using System;

namespace ClockSample
{
    public sealed class AlarmRaisedEventArgs : EventArgs
    {
        public AlarmRaisedEventArgs(string alarmName)
        {
            if (String.IsNullOrEmpty(alarmName))
                throw new ArgumentNullException(nameof(alarmName));

            AlarmName = alarmName;
        }

        public string AlarmName { get; }
    }
}
