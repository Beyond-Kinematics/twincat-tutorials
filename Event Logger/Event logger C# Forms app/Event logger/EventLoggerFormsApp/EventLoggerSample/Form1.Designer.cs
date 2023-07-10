namespace EventLoggerSample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClearAlarms = new System.Windows.Forms.Button();
            this.btnConfirmAlarms = new System.Windows.Forms.Button();
            this.tbOutputWindowAlarms = new System.Windows.Forms.TextBox();
            this.btnClearLogged = new System.Windows.Forms.Button();
            this.tabControlEvents = new System.Windows.Forms.TabControl();
            this.tabPageAlarms = new System.Windows.Forms.TabPage();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.btnClearMessages = new System.Windows.Forms.Button();
            this.tbOutputWindowMsg = new System.Windows.Forms.TextBox();
            this.tabPageLoggedEvents = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNumLoggedEventsToGet = new System.Windows.Forms.TextBox();
            this.btnGetLoggedEvents = new System.Windows.Forms.Button();
            this.tbOutputWindowLoggedEvents = new System.Windows.Forms.TextBox();
            this.tabControlEvents.SuspendLayout();
            this.tabPageAlarms.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            this.tabPageLoggedEvents.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClearAlarms
            // 
            this.btnClearAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearAlarms.Location = new System.Drawing.Point(105, 329);
            this.btnClearAlarms.Name = "btnClearAlarms";
            this.btnClearAlarms.Size = new System.Drawing.Size(93, 32);
            this.btnClearAlarms.TabIndex = 0;
            this.btnClearAlarms.Text = "Clear Alarms";
            this.btnClearAlarms.UseVisualStyleBackColor = true;
            this.btnClearAlarms.Click += new System.EventHandler(this.btnClearAlarms_Click);
            // 
            // btnConfirmAlarms
            // 
            this.btnConfirmAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirmAlarms.Location = new System.Drawing.Point(3, 329);
            this.btnConfirmAlarms.Name = "btnConfirmAlarms";
            this.btnConfirmAlarms.Size = new System.Drawing.Size(93, 32);
            this.btnConfirmAlarms.TabIndex = 1;
            this.btnConfirmAlarms.Text = "Confirm Alarms";
            this.btnConfirmAlarms.UseVisualStyleBackColor = true;
            this.btnConfirmAlarms.Click += new System.EventHandler(this.btnConfirmAlarms_Click);
            // 
            // tbOutputWindowAlarms
            // 
            this.tbOutputWindowAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputWindowAlarms.Location = new System.Drawing.Point(6, 6);
            this.tbOutputWindowAlarms.Multiline = true;
            this.tbOutputWindowAlarms.Name = "tbOutputWindowAlarms";
            this.tbOutputWindowAlarms.ReadOnly = true;
            this.tbOutputWindowAlarms.Size = new System.Drawing.Size(716, 317);
            this.tbOutputWindowAlarms.TabIndex = 4;
            // 
            // btnClearLogged
            // 
            this.btnClearLogged.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearLogged.Location = new System.Drawing.Point(131, 316);
            this.btnClearLogged.Name = "btnClearLogged";
            this.btnClearLogged.Size = new System.Drawing.Size(121, 32);
            this.btnClearLogged.TabIndex = 2;
            this.btnClearLogged.Text = "Clear Logged Events";
            this.btnClearLogged.UseVisualStyleBackColor = true;
            this.btnClearLogged.Click += new System.EventHandler(this.btnClearLogged_Click);
            // 
            // tabControlEvents
            // 
            this.tabControlEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlEvents.Controls.Add(this.tabPageAlarms);
            this.tabControlEvents.Controls.Add(this.tabPageMessages);
            this.tabControlEvents.Controls.Add(this.tabPageLoggedEvents);
            this.tabControlEvents.Location = new System.Drawing.Point(3, 12);
            this.tabControlEvents.Name = "tabControlEvents";
            this.tabControlEvents.SelectedIndex = 0;
            this.tabControlEvents.Size = new System.Drawing.Size(738, 394);
            this.tabControlEvents.TabIndex = 6;
            // 
            // tabPageAlarms
            // 
            this.tabPageAlarms.Controls.Add(this.tbOutputWindowAlarms);
            this.tabPageAlarms.Controls.Add(this.btnConfirmAlarms);
            this.tabPageAlarms.Controls.Add(this.btnClearAlarms);
            this.tabPageAlarms.Location = new System.Drawing.Point(4, 22);
            this.tabPageAlarms.Name = "tabPageAlarms";
            this.tabPageAlarms.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAlarms.Size = new System.Drawing.Size(730, 368);
            this.tabPageAlarms.TabIndex = 0;
            this.tabPageAlarms.Text = "Alarms";
            this.tabPageAlarms.UseVisualStyleBackColor = true;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.btnClearMessages);
            this.tabPageMessages.Controls.Add(this.tbOutputWindowMsg);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 22);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(730, 368);
            this.tabPageMessages.TabIndex = 1;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // btnClearMessages
            // 
            this.btnClearMessages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClearMessages.Location = new System.Drawing.Point(5, 336);
            this.btnClearMessages.Name = "btnClearMessages";
            this.btnClearMessages.Size = new System.Drawing.Size(156, 32);
            this.btnClearMessages.TabIndex = 6;
            this.btnClearMessages.Text = "Clear Message Window";
            this.btnClearMessages.UseVisualStyleBackColor = true;
            this.btnClearMessages.Click += new System.EventHandler(this.btnClearMessages_Click);
            // 
            // tbOutputWindowMsg
            // 
            this.tbOutputWindowMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputWindowMsg.Location = new System.Drawing.Point(6, 6);
            this.tbOutputWindowMsg.Multiline = true;
            this.tbOutputWindowMsg.Name = "tbOutputWindowMsg";
            this.tbOutputWindowMsg.ReadOnly = true;
            this.tbOutputWindowMsg.Size = new System.Drawing.Size(716, 327);
            this.tbOutputWindowMsg.TabIndex = 5;
            // 
            // tabPageLoggedEvents
            // 
            this.tabPageLoggedEvents.Controls.Add(this.label1);
            this.tabPageLoggedEvents.Controls.Add(this.tbNumLoggedEventsToGet);
            this.tabPageLoggedEvents.Controls.Add(this.btnGetLoggedEvents);
            this.tabPageLoggedEvents.Controls.Add(this.tbOutputWindowLoggedEvents);
            this.tabPageLoggedEvents.Controls.Add(this.btnClearLogged);
            this.tabPageLoggedEvents.Location = new System.Drawing.Point(4, 22);
            this.tabPageLoggedEvents.Name = "tabPageLoggedEvents";
            this.tabPageLoggedEvents.Size = new System.Drawing.Size(730, 368);
            this.tabPageLoggedEvents.TabIndex = 2;
            this.tabPageLoggedEvents.Text = "Logged Events";
            this.tabPageLoggedEvents.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Number of logged events to get:";
            // 
            // tbNumLoggedEventsToGet
            // 
            this.tbNumLoggedEventsToGet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNumLoggedEventsToGet.Location = new System.Drawing.Point(622, 323);
            this.tbNumLoggedEventsToGet.Name = "tbNumLoggedEventsToGet";
            this.tbNumLoggedEventsToGet.Size = new System.Drawing.Size(100, 20);
            this.tbNumLoggedEventsToGet.TabIndex = 8;
            this.tbNumLoggedEventsToGet.Text = "100";
            this.tbNumLoggedEventsToGet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGetLoggedEvents
            // 
            this.btnGetLoggedEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnGetLoggedEvents.Location = new System.Drawing.Point(5, 316);
            this.btnGetLoggedEvents.Name = "btnGetLoggedEvents";
            this.btnGetLoggedEvents.Size = new System.Drawing.Size(121, 32);
            this.btnGetLoggedEvents.TabIndex = 7;
            this.btnGetLoggedEvents.Text = "Get Logged Events";
            this.btnGetLoggedEvents.UseVisualStyleBackColor = true;
            this.btnGetLoggedEvents.Click += new System.EventHandler(this.btnGetLoggedEvents_Click);
            // 
            // tbOutputWindowLoggedEvents
            // 
            this.tbOutputWindowLoggedEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbOutputWindowLoggedEvents.Location = new System.Drawing.Point(5, 3);
            this.tbOutputWindowLoggedEvents.Multiline = true;
            this.tbOutputWindowLoggedEvents.Name = "tbOutputWindowLoggedEvents";
            this.tbOutputWindowLoggedEvents.ReadOnly = true;
            this.tbOutputWindowLoggedEvents.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbOutputWindowLoggedEvents.Size = new System.Drawing.Size(717, 307);
            this.tbOutputWindowLoggedEvents.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 407);
            this.Controls.Add(this.tabControlEvents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlEvents.ResumeLayout(false);
            this.tabPageAlarms.ResumeLayout(false);
            this.tabPageAlarms.PerformLayout();
            this.tabPageMessages.ResumeLayout(false);
            this.tabPageMessages.PerformLayout();
            this.tabPageLoggedEvents.ResumeLayout(false);
            this.tabPageLoggedEvents.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClearAlarms;
        private System.Windows.Forms.Button btnConfirmAlarms;
        private System.Windows.Forms.TextBox tbOutputWindowAlarms;
        private System.Windows.Forms.Button btnClearLogged;
        private System.Windows.Forms.TabControl tabControlEvents;
        private System.Windows.Forms.TabPage tabPageAlarms;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.TabPage tabPageLoggedEvents;
        private System.Windows.Forms.TextBox tbOutputWindowMsg;
        private System.Windows.Forms.Button btnClearMessages;
        private System.Windows.Forms.TextBox tbOutputWindowLoggedEvents;
        private System.Windows.Forms.Button btnGetLoggedEvents;
        private System.Windows.Forms.TextBox tbNumLoggedEventsToGet;
        private System.Windows.Forms.Label label1;
    }
}

