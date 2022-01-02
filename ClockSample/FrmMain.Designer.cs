using System.Windows.Forms;

namespace ClockSample
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtCurrentTime = new System.Windows.Forms.TextBox();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.grpActiveAlarms = new System.Windows.Forms.GroupBox();
            this.lstActiveAlarms = new System.Windows.Forms.ListView();
            this.colAlarmName = new System.Windows.Forms.ColumnHeader();
            this.colAlarmTime = new System.Windows.Forms.ColumnHeader();
            this.colAlarmDate = new System.Windows.Forms.ColumnHeader();
            this.grpRaisedAlarms = new System.Windows.Forms.GroupBox();
            this.lstAlarmsRaised = new System.Windows.Forms.ListBox();
            this.grpAddAlarm = new System.Windows.Forms.GroupBox();
            this.btnAddAlarmNowPlus30 = new System.Windows.Forms.Button();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.txtAddAlarmName = new System.Windows.Forms.TextBox();
            this.lblAddAlarmName = new System.Windows.Forms.Label();
            this.lblAddAlarmSecond = new System.Windows.Forms.Label();
            this.udSecond = new System.Windows.Forms.NumericUpDown();
            this.lblAddAlarmMinute = new System.Windows.Forms.Label();
            this.udMinute = new System.Windows.Forms.NumericUpDown();
            this.lblAddAlarmHour = new System.Windows.Forms.Label();
            this.udHour = new System.Windows.Forms.NumericUpDown();
            this.grpActiveAlarms.SuspendLayout();
            this.grpRaisedAlarms.SuspendLayout();
            this.grpAddAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHour)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCurrentTime
            // 
            this.txtCurrentTime.Location = new System.Drawing.Point(12, 27);
            this.txtCurrentTime.Name = "txtCurrentTime";
            this.txtCurrentTime.ReadOnly = true;
            this.txtCurrentTime.Size = new System.Drawing.Size(100, 23);
            this.txtCurrentTime.TabIndex = 1;
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(76, 15);
            this.lblCurrentTime.TabIndex = 0;
            this.lblCurrentTime.Text = "Current Time";
            // 
            // grpActiveAlarms
            // 
            this.grpActiveAlarms.Controls.Add(this.lstActiveAlarms);
            this.grpActiveAlarms.Location = new System.Drawing.Point(12, 66);
            this.grpActiveAlarms.Name = "grpActiveAlarms";
            this.grpActiveAlarms.Size = new System.Drawing.Size(418, 168);
            this.grpActiveAlarms.TabIndex = 2;
            this.grpActiveAlarms.TabStop = false;
            this.grpActiveAlarms.Text = "Active Alarms";
            // 
            // lstActiveAlarms
            // 
            this.lstActiveAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActiveAlarms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colAlarmName,
            this.colAlarmTime,
            this.colAlarmDate});
            this.lstActiveAlarms.Location = new System.Drawing.Point(6, 22);
            this.lstActiveAlarms.Name = "lstActiveAlarms";
            this.lstActiveAlarms.Size = new System.Drawing.Size(406, 140);
            this.lstActiveAlarms.TabIndex = 3;
            this.lstActiveAlarms.UseCompatibleStateImageBehavior = false;
            this.lstActiveAlarms.View = System.Windows.Forms.View.Details;
            // 
            // colAlarmName
            // 
            this.colAlarmName.Text = "Alarm Name";
            this.colAlarmName.Width = 180;
            // 
            // colAlarmTime
            // 
            this.colAlarmTime.Text = "Alarm Time";
            this.colAlarmTime.Width = 100;
            // 
            // colAlarmDate
            // 
            this.colAlarmDate.Text = "Alarm Date";
            this.colAlarmDate.Width = 120;
            // 
            // grpRaisedAlarms
            // 
            this.grpRaisedAlarms.Controls.Add(this.lstAlarmsRaised);
            this.grpRaisedAlarms.Location = new System.Drawing.Point(12, 414);
            this.grpRaisedAlarms.Name = "grpRaisedAlarms";
            this.grpRaisedAlarms.Size = new System.Drawing.Size(418, 108);
            this.grpRaisedAlarms.TabIndex = 15;
            this.grpRaisedAlarms.TabStop = false;
            this.grpRaisedAlarms.Text = "Raised Alarms";
            // 
            // lstAlarmsRaised
            // 
            this.lstAlarmsRaised.FormattingEnabled = true;
            this.lstAlarmsRaised.ItemHeight = 15;
            this.lstAlarmsRaised.Location = new System.Drawing.Point(6, 22);
            this.lstAlarmsRaised.Name = "lstAlarmsRaised";
            this.lstAlarmsRaised.Size = new System.Drawing.Size(406, 79);
            this.lstAlarmsRaised.TabIndex = 16;
            // 
            // grpAddAlarm
            // 
            this.grpAddAlarm.Controls.Add(this.btnAddAlarmNowPlus30);
            this.grpAddAlarm.Controls.Add(this.btnAddAlarm);
            this.grpAddAlarm.Controls.Add(this.txtAddAlarmName);
            this.grpAddAlarm.Controls.Add(this.lblAddAlarmName);
            this.grpAddAlarm.Controls.Add(this.lblAddAlarmSecond);
            this.grpAddAlarm.Controls.Add(this.udSecond);
            this.grpAddAlarm.Controls.Add(this.lblAddAlarmMinute);
            this.grpAddAlarm.Controls.Add(this.udMinute);
            this.grpAddAlarm.Controls.Add(this.lblAddAlarmHour);
            this.grpAddAlarm.Controls.Add(this.udHour);
            this.grpAddAlarm.Location = new System.Drawing.Point(12, 240);
            this.grpAddAlarm.Name = "grpAddAlarm";
            this.grpAddAlarm.Size = new System.Drawing.Size(418, 168);
            this.grpAddAlarm.TabIndex = 4;
            this.grpAddAlarm.TabStop = false;
            this.grpAddAlarm.Text = "Add Alarm";
            // 
            // btnAddAlarmNowPlus30
            // 
            this.btnAddAlarmNowPlus30.Location = new System.Drawing.Point(252, 40);
            this.btnAddAlarmNowPlus30.Name = "btnAddAlarmNowPlus30";
            this.btnAddAlarmNowPlus30.Size = new System.Drawing.Size(120, 23);
            this.btnAddAlarmNowPlus30.TabIndex = 13;
            this.btnAddAlarmNowPlus30.Text = "Now + 30 Seconds";
            this.btnAddAlarmNowPlus30.UseVisualStyleBackColor = true;
            this.btnAddAlarmNowPlus30.Click += new System.EventHandler(this.btnAddAlarmNowPlus30_Click);
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.Location = new System.Drawing.Point(8, 130);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlarm.TabIndex = 14;
            this.btnAddAlarm.Text = "Add";
            this.btnAddAlarm.UseVisualStyleBackColor = true;
            this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
            // 
            // txtAddAlarmName
            // 
            this.txtAddAlarmName.Location = new System.Drawing.Point(6, 91);
            this.txtAddAlarmName.MaxLength = 150;
            this.txtAddAlarmName.Name = "txtAddAlarmName";
            this.txtAddAlarmName.Size = new System.Drawing.Size(174, 23);
            this.txtAddAlarmName.TabIndex = 12;
            // 
            // lblAddAlarmName
            // 
            this.lblAddAlarmName.AutoSize = true;
            this.lblAddAlarmName.Location = new System.Drawing.Point(6, 73);
            this.lblAddAlarmName.Name = "lblAddAlarmName";
            this.lblAddAlarmName.Size = new System.Drawing.Size(39, 15);
            this.lblAddAlarmName.TabIndex = 11;
            this.lblAddAlarmName.Text = "Name";
            // 
            // lblAddAlarmSecond
            // 
            this.lblAddAlarmSecond.AutoSize = true;
            this.lblAddAlarmSecond.Location = new System.Drawing.Point(126, 22);
            this.lblAddAlarmSecond.Name = "lblAddAlarmSecond";
            this.lblAddAlarmSecond.Size = new System.Drawing.Size(46, 15);
            this.lblAddAlarmSecond.TabIndex = 9;
            this.lblAddAlarmSecond.Text = "Second";
            // 
            // udSecond
            // 
            this.udSecond.Location = new System.Drawing.Point(126, 40);
            this.udSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udSecond.Name = "udSecond";
            this.udSecond.Size = new System.Drawing.Size(54, 23);
            this.udSecond.TabIndex = 10;
            // 
            // lblAddAlarmMinute
            // 
            this.lblAddAlarmMinute.AutoSize = true;
            this.lblAddAlarmMinute.Location = new System.Drawing.Point(66, 22);
            this.lblAddAlarmMinute.Name = "lblAddAlarmMinute";
            this.lblAddAlarmMinute.Size = new System.Drawing.Size(45, 15);
            this.lblAddAlarmMinute.TabIndex = 7;
            this.lblAddAlarmMinute.Text = "Minute";
            // 
            // udMinute
            // 
            this.udMinute.Location = new System.Drawing.Point(66, 40);
            this.udMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.udMinute.Name = "udMinute";
            this.udMinute.Size = new System.Drawing.Size(54, 23);
            this.udMinute.TabIndex = 8;
            // 
            // lblAddAlarmHour
            // 
            this.lblAddAlarmHour.AutoSize = true;
            this.lblAddAlarmHour.Location = new System.Drawing.Point(6, 22);
            this.lblAddAlarmHour.Name = "lblAddAlarmHour";
            this.lblAddAlarmHour.Size = new System.Drawing.Size(34, 15);
            this.lblAddAlarmHour.TabIndex = 5;
            this.lblAddAlarmHour.Text = "Hour";
            // 
            // udHour
            // 
            this.udHour.Location = new System.Drawing.Point(6, 40);
            this.udHour.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.udHour.Name = "udHour";
            this.udHour.Size = new System.Drawing.Size(54, 23);
            this.udHour.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 532);
            this.Controls.Add(this.grpAddAlarm);
            this.Controls.Add(this.grpRaisedAlarms);
            this.Controls.Add(this.grpActiveAlarms);
            this.Controls.Add(this.lblCurrentTime);
            this.Controls.Add(this.txtCurrentTime);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.Text = "Clock Example with Alarms";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.grpActiveAlarms.ResumeLayout(false);
            this.grpRaisedAlarms.ResumeLayout(false);
            this.grpAddAlarm.ResumeLayout(false);
            this.grpAddAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.udSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udHour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolTip toolTip1;
        private TextBox txtCurrentTime;
        private Label lblCurrentTime;
        private GroupBox grpActiveAlarms;
        private ListView lstActiveAlarms;
        private ColumnHeader colAlarmName;
        private ColumnHeader colAlarmTime;
        private ColumnHeader colAlarmDate;
        private GroupBox grpRaisedAlarms;
        private ListBox lstAlarmsRaised;
        private GroupBox grpAddAlarm;
        private Button btnAddAlarmNowPlus30;
        private Button btnAddAlarm;
        private TextBox txtAddAlarmName;
        private Label lblAddAlarmName;
        private Label lblAddAlarmSecond;
        private NumericUpDown udSecond;
        private Label lblAddAlarmMinute;
        private NumericUpDown udMinute;
        private Label lblAddAlarmHour;
        private NumericUpDown udHour;
    }
}