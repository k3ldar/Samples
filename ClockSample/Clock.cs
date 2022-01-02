using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ClockSample
{
    /// <summary>
    /// Internal implementation of IClock
    /// 
    /// Issues: if the consumers of events takes perform a lot of processing, consider raising 
    /// events via a seperate thread to prevent any delays
    /// </summary>
    internal sealed class Clock : IClock
    {
        #region Private Members

        private const int ThreadSleepTime = 15;
        private const int OneSecond = 1000;
        private const int OneMinute = 60000;
        private const string DefaultThreadName = "Clock Timer Thread";

        private readonly object _lockObject = new object();

        private readonly Dictionary<string, InternalAlarm> _alarms;

        #endregion Private Members

        #region Constructors

        internal Clock()
        {
            Interval = ClockInterval.Seconds;
            _alarms = new Dictionary<string, InternalAlarm>();

            Thread threadTimer = new Thread(ThreadTimer);
            threadTimer.IsBackground = true;
            threadTimer.Name = DefaultThreadName;
            threadTimer.Start();
        }

        #endregion Constructors

        #region Properties

        public ClockInterval Interval { get; set; }

        public List<IAlarm> Alarms
        {
            get
            {
                List<IAlarm> alarms = new List<IAlarm>();

                lock (_lockObject)
                {
                    foreach (InternalAlarm alarm in _alarms.Values)
                    {
                        alarms.Add(alarm.Clone());
                    }
                }

                return alarms;
            }
        }

        #endregion Properties

        #region Events

        public event TimeChangedDelegate OnTimeChanged;

        public event AlarmRaisedDelegate OnAlarmRaised;

        public event EventHandler OnAlarmChanged;

        #endregion Events

        #region Public Methods

        public bool AddAlarm(string alarmName, int hour, int minute, int second)
        {
            if (String.IsNullOrEmpty(alarmName))
                throw new ArgumentNullException(nameof(alarmName));

            if (hour < 0 || hour > 23)
                throw new ArgumentOutOfRangeException(nameof(hour));

            if (minute < 0 || minute > 59)
                throw new ArgumentOutOfRangeException(nameof(minute));

            if (second < 0 || second > 59)
                throw new ArgumentOutOfRangeException(nameof(second));

            lock (_lockObject)
            {
                if (_alarms.ContainsKey(alarmName))
                    return false;

                _alarms.Add(alarmName, new InternalAlarm(alarmName, hour, minute, second));
                RaiseOnAlarmChanged();

                return true;
            }
        }

        public void RemoveAlarm(string alarmName)
        {
            if (String.IsNullOrEmpty(alarmName))
                throw new ArgumentNullException(nameof(alarmName));

            lock (_lockObject)
            {
                if (_alarms.ContainsKey(alarmName))
                {
                    _alarms.Remove(alarmName);
                    RaiseOnAlarmChanged();
                }
            }
        }

        #endregion Public Methods

        #region Private Methods

        private void ThreadTimer()
        {
            DateTime lastTimeTriggered = CreateTimeWithZeroSeconds(DateTime.Now.AddDays(-1));

            while (true)
            {
                TriggerTimeChangeIfRequired(ref lastTimeTriggered);

                RaiseAlarmsIfRequired();

                Thread.Sleep(ThreadSleepTime);
            }
        }

        private void RaiseAlarmsIfRequired()
        {
            if (OnAlarmRaised != null)
            {
                List<InternalAlarm> alarmsToRaise = new List<InternalAlarm>();

                lock (_lockObject)
                {
                    foreach (InternalAlarm alarm in _alarms.Values)
                    {
                        if (alarm.AlarmCanBeTriggered())
                            alarmsToRaise.Add(alarm.Clone());
                    }
                }

                if (alarmsToRaise.Count > 0)
                {
                    foreach (InternalAlarm alarm in alarmsToRaise)
                    {
                        OnAlarmRaised.Invoke(this, new AlarmRaisedEventArgs(alarm.Name));
                    }

                    RaiseOnAlarmChanged();
                }
            }
        }

        private void TriggerTimeChangeIfRequired(ref DateTime lastTimeTriggered)
        {
            if (OnTimeChanged != null)
            {
                DateTime timeCheck = DateTime.Now;
                TimeSpan span = timeCheck - lastTimeTriggered;
                bool timeElapsed = false;

                switch (Interval)
                {
                    case ClockInterval.Seconds:
                        timeElapsed = span.TotalMilliseconds >= OneSecond;

                        break;

                    case ClockInterval.Minutes:
                        timeElapsed = span.TotalMilliseconds >= OneMinute;

                        break;
                }

                if (timeElapsed)
                {
                    lastTimeTriggered = CreateTimeWithZeroSeconds(timeCheck);

                    RaiseOnTimeChanged(timeCheck);
                }
            }
        }

        private void RaiseOnTimeChanged(DateTime timeCheck)
        {
            OnTimeChanged?.Invoke(this, new TimeChangedEventArgs(timeCheck));
        }

        private void RaiseOnAlarmChanged()
        {
            OnAlarmChanged?.Invoke(this, EventArgs.Empty);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private DateTime CreateTimeWithZeroSeconds(DateTime timestamp)
        {
            return new DateTime(timestamp.Year, timestamp.Month, timestamp.Day, timestamp.Hour, timestamp.Minute, 0);
        }

        #endregion Private Methods
    }
}
