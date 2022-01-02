using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClockSample
{
    internal sealed class InternalAlarm : IAlarm
    {
        private DateTime _nextAlarmTime;

        public InternalAlarm(string name, int hour, int minute, int second)
        {
            if (String.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (hour < 0 || hour > 23)
                throw new ArgumentOutOfRangeException(nameof(hour));

            if (minute < 0 || minute > 59)
                throw new ArgumentOutOfRangeException(nameof(minute));

            if (second < 0 || second > 59)
                throw new ArgumentOutOfRangeException(nameof(second));

            Name = name;
            Hour = hour;
            Minute = minute;
            Second = second;

            RescheduleAlarm(DateTime.Now);
        }

        public string Name { get; }

        public int Hour { get; }

        public int Minute { get; }

        public int Second { get; }

        public DateTime AlarmDate => _nextAlarmTime;

        public InternalAlarm Clone()
        {
            return new InternalAlarm(Name, Hour, Minute, Second);
        }

        public bool AlarmCanBeTriggered()
        {
            if (_nextAlarmTime.Date > DateTime.Now.Date || _nextAlarmTime > DateTime.Now)
                return false;

            RescheduleAlarm(_nextAlarmTime.AddDays(1));

            return true;
        }

        private void RescheduleAlarm(DateTime currentTime)
        {
            _nextAlarmTime = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, Hour, Minute, Second);

            if (_nextAlarmTime < currentTime)
                _nextAlarmTime = _nextAlarmTime.AddDays(1);
        }
    }
}
