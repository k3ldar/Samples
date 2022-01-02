using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ClockSample
{
    public partial class FrmMain : Form
    {
        #region Private Members

        private const int AddAlarmDefaultOffset = 30;

        private readonly IClock _clock;

        #endregion Private Members

        #region Constructors

        public FrmMain()
            : this(new Clock())
        {

        }

        public FrmMain(IClock clock)
        {
            _clock = clock ?? throw new ArgumentNullException(nameof(clock));

            InitializeComponent();

            if (LicenseManager.UsageMode != LicenseUsageMode.Designtime)
            {
                _clock.OnTimeChanged += Clock_OnTimeChanged;
                _clock.OnAlarmRaised += Clock_OnAlarmRaised;
                _clock.OnAlarmChanged += Clock_OnAlarmChanged;

                UpdateAddAlarmTimes(AddAlarmDefaultOffset);
            }
        }

        #endregion Constructors

        #region IClock Events

        private void Clock_OnTimeChanged(object sender, TimeChangedEventArgs e)
        {
            if (txtCurrentTime.InvokeRequired)
            {
                txtCurrentTime.Invoke(new TimeChangedDelegate(Clock_OnTimeChanged), new object[] { sender, e });
            }
            else
            {
                txtCurrentTime.Text = _clock.Interval == ClockInterval.Seconds ?
                    e.Time.ToLongTimeString() :
                    e.Time.ToShortTimeString();
            }
        }

        private void Clock_OnAlarmRaised(object sender, AlarmRaisedEventArgs e)
        {
            if (lstAlarmsRaised.InvokeRequired)
            {
                lstAlarmsRaised.Invoke(new AlarmRaisedDelegate(Clock_OnAlarmRaised), new object[] { sender, e });
            }
            else
            {
                lstAlarmsRaised.SelectedIndex = lstAlarmsRaised.Items.Add(
                    $"Alarm \"{e.AlarmName}\" Raised at {DateTime.Now.ToLongTimeString()} ");
            }
        }

        private void Clock_OnAlarmChanged(object sender, EventArgs e)
        {
            if (lstActiveAlarms.InvokeRequired)
            {
                lstActiveAlarms.Invoke(new EventHandler(Clock_OnAlarmChanged), new object[] { sender, e });
            }
            else
            {
                RebuildAlarmList();
            }
        }

        #endregion IClock Events

        #region Private Methods

        private void RebuildAlarmList()
        {
            lstActiveAlarms.BeginUpdate();
            try
            {
                lstActiveAlarms.Items.Clear();

                foreach (IAlarm alarm in _clock.Alarms)
                {
                    ListViewItem newItem = new ListViewItem(alarm.Name);
                    newItem.SubItems.Add(alarm.AlarmDate.ToLongTimeString());
                    newItem.SubItems.Add(alarm.AlarmDate.ToLongDateString());
                    lstActiveAlarms.Items.Add(newItem);
                }
            }
            finally
            {
                lstActiveAlarms.EndUpdate();
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _clock.OnTimeChanged -= Clock_OnTimeChanged;
            _clock.OnAlarmRaised -= Clock_OnAlarmRaised;
            _clock.OnAlarmChanged -= Clock_OnAlarmChanged;
        }

        private void btnAddAlarmNowPlus30_Click(object sender, EventArgs e)
        {
            UpdateAddAlarmTimes(AddAlarmDefaultOffset);
        }

        private void UpdateAddAlarmTimes(int offset)
        {
            DateTime now = DateTime.Now.AddSeconds(offset);
            udHour.Value = now.Hour;
            udMinute.Value = now.Minute;
            udSecond.Value = now.Second;
        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtAddAlarmName.Text))
            {
                MessageBox.Show("Please enter a unique alarm name", "Alarm Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_clock.AddAlarm(txtAddAlarmName.Text, (int)udHour.Value, (int)udMinute.Value, (int)udSecond.Value))
            {
                MessageBox.Show("Failed to create the alarm, ensure name is unique", "Alarm Add Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtAddAlarmName.Text = String.Empty;
            UpdateAddAlarmTimes(AddAlarmDefaultOffset);
        }

        #endregion Private Methods
    }
}