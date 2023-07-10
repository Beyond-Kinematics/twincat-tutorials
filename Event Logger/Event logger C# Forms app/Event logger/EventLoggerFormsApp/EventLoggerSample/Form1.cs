using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TcEventLoggerAdsProxyLib;

namespace EventLoggerSample
{
    public partial class Form1 : Form
    {
        static TcEventLogger eventLogger;


        int LangID = 1033; // Selected langue 1033 = English

        #region FormInit

        public Form1()
        {
            eventLogger = new TcEventLogger();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            eventLogger.Connect("127.0.0.1.1.1"); //Local TwinCAT runtime (AMS Net ID)
            eventLogger.AlarmRaised += OnAlarmRaised;
            eventLogger.ActiveAlarmListChanged += OnActiveAlarmListChange;
            eventLogger.AlarmCleared += OnAlarmCleared;
            eventLogger.AlarmConfirmed += OnAlarmConfirmed;
            eventLogger.MessageSent += OnMessageSent;
            

            UpdateUIActiveAlarms();
            UpdateUILoggedEvents();
        }

    

        #endregion


        #region Buttons

             private void btnClearAlarms_Click(object sender, EventArgs e)
             {
                 eventLogger.ClearAllAlarms();
             }

             private void btnConfirmAlarms_Click(object sender, EventArgs e)
             {
                 eventLogger.ConfirmAllAlarms();
             }

             private void btnGetLoggedEvents_Click(object sender, EventArgs e)
             {
                 UpdateUILoggedEvents();
             }

             private void btnClearLogged_Click(object sender, EventArgs e)
             {
                 eventLogger.ClearLoggedEvents();
                 SetTextBoxLoggedEvents("");
                 AppendTextBoxLoggedEvents(DateTime.Now.ToString() + " | Clear Logged Events\r\n");
             }

             private void btnClearMessages_Click(object sender, EventArgs e)
             {
                 SetTextBoxMessages("");
             }

        #endregion


        #region EventLogger_Events
            private void OnMessageSent(TcMessage evtObj)
            {
                AppendTextBoxMessages(evtObj.TimeRaised.ToString() + " | Message Sent | " + evtObj.GetText(LangID) + "\r\n");
            }

            private void OnAlarmRaised(TcAlarm evtObj)
            {
                UpdateUIActiveAlarms();
            }

            private void OnAlarmConfirmed(TcAlarm evtObj, bool bRemove)
            {
                UpdateUIActiveAlarms();
            }

            private void OnAlarmCleared(TcAlarm evtObj, bool bRemove)
            {
                UpdateUIActiveAlarms();
            }

            private void OnActiveAlarmListChange() //What triggers this? It doesnt seem to work. 
            {
                UpdateUIActiveAlarms();
            }

        #endregion


        #region UI Methods

             #region Active alarms
                 #region Helper methods
                     public void AppendTextBoxActiveAlarms(string value) //requried to pass string across threads
                         {
                             if (InvokeRequired)
                             {
                                 this.BeginInvoke(new Action<string>(AppendTextBoxActiveAlarms), new object[] {value});
                                 return;
                             }
                             tbOutputWindowAlarms.Text += value;
                         }

                     public void SetTextBoxActiveAlarms(string value) //requried to pass string across threads
                     {
                         if (InvokeRequired)
                         {
                             this.BeginInvoke(new Action<string>(SetTextBoxActiveAlarms), new object[] { value });
                             return;
                         }
                         tbOutputWindowAlarms.Text = value; 
                     }
                 #endregion

                 #region Gets a list of active alarms from the event logger and outputs it to a text box
                     delegate void UpdateUIActiveAlarmsVoidDelegate();

                     public void UpdateUIActiveAlarms()
                     {
                         if(InvokeRequired)
                         {
                             UpdateUIActiveAlarmsVoidDelegate d = new UpdateUIActiveAlarmsVoidDelegate(UpdateUIActiveAlarms);
                             this.BeginInvoke(d);
                         }
                         else
                         {
                             string DisplayText = "";
                             TcAlarmCollection ActiveAlarms = eventLogger.ActiveAlarms;
                             foreach (TcAlarm Alarm in ActiveAlarms)
                             {
                                 if (Alarm.ConfirmationState == ConfirmationStateEnum.Confirmed)
                                 {
                                     DisplayText += Alarm.TimeConfirmed.ToString() + " | Alarm Confirmed | " + Alarm.GetText(LangID) + "\r\n";
                                     continue; //goto next alarm
                                 }
                                 if (Alarm.IsRaised)
                                 {
                                     DisplayText += Alarm.TimeRaised.ToString() + " | Alarm Raised | " + Alarm.GetText(LangID) + "\r\n";
                                     continue; //goto next alarm
                                 }

                                 //else spit out all
                                 DisplayText += "Confirmation state:" + Alarm.ConfirmationState + "|" + Alarm.GetText(LangID) + "|" + "Time raised:" + Alarm.TimeRaised + "|" + "Time confirmed:" + Alarm.TimeConfirmed + "|" + "Time cleared:" + Alarm.TimeCleared + "\r\n";

                             }
                             SetTextBoxActiveAlarms(DisplayText);
                         }

                     }
                #endregion


            #endregion

             #region Messages
                     #region Helper methods
                     public void AppendTextBoxMessages(string value) //requried to pass string across threads
                     {
                         if (InvokeRequired)
                         {
                             this.BeginInvoke(new Action<string>(AppendTextBoxMessages), new object[] { value });
                             return;
                         }
                         tbOutputWindowMsg.Text += value;
                     }
             
                     public void SetTextBoxMessages(string value) //requried to pass string across threads
                     {
                         if (InvokeRequired)
                         {
                             this.BeginInvoke(new Action<string>(SetTextBoxMessages), new object[] { value });
                             return;
                         }
                         tbOutputWindowMsg.Text = value;
                     }

                    #endregion

        #endregion

             #region Logged Events
                #region Helper methods
                public void AppendTextBoxLoggedEvents(string value) //requried to pass string across threads
                {
                    if (InvokeRequired)
                    {
                        this.BeginInvoke(new Action<string>(AppendTextBoxLoggedEvents), new object[] { value });
                        return;
                    }
                    tbOutputWindowLoggedEvents.Text += value;
                }

                public void SetTextBoxLoggedEvents(string value) //requried to pass string across threads
                {
                    if (InvokeRequired)
                    {
                        this.BeginInvoke(new Action<string>(SetTextBoxLoggedEvents), new object[] { value });
                        return;
                    }
                    tbOutputWindowLoggedEvents.Text = value;
                }

                 #region Gets a list of logged events from the event logger and outputs it to a text box
                 delegate void UpdateUILoggedEventsVoidDelegate();

                 public void UpdateUILoggedEvents()
                 {
                     if (InvokeRequired)
                     {
                        UpdateUILoggedEventsVoidDelegate d = new UpdateUILoggedEventsVoidDelegate(UpdateUILoggedEvents);
                         this.BeginInvoke(d);
                     }
                     else
                     {
                         string DisplayText = "";
                
                         TcLoggedEventCollection LoggedEvents = eventLogger.GetLoggedEvents(Convert.ToUInt32(tbNumLoggedEventsToGet.Text)); //Would be nice to have a property to know how many logged events there are. 
                         foreach (TcLoggedEvent Event in LoggedEvents)
                         {

                             if(Event.EventType==EventTypeEnum.Message)
                             {
                                DisplayText += "| Message | " + Event.GetText(LangID) + " | Time Raised | " + Event.TimeRaised.ToString() + " | " + "\r\n";
                             }
                             if(Event.EventType==EventTypeEnum.Alarm) //Would be nice to have a property to see if the event is that requires a confirmation or not.
                             {
                                
                                DisplayText += "| Alarm | " + Event.GetText(LangID) + " | Time Raised | " + Event.TimeRaised.ToString() +" | " + " | Time Confirmed | " + Event.TimeConfirmed.ToString() + " | " + " | Time Cleared | " + Event.TimeCleared.ToString() + " | " + "\r\n";
                             }

                         }
                        SetTextBoxLoggedEvents(DisplayText);
                     }

                 }

        #endregion

        #endregion

        #endregion

        #endregion
    }
}
