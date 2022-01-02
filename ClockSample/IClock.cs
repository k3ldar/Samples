using System;
using System.Collections.Generic;

namespace ClockSample
{
    public interface IClock
    {
        ClockInterval Interval { get; set; }

        List<IAlarm> Alarms { get; }

        bool AddAlarm(string alarmName, int hour, int minute, int second);

        void RemoveAlarm(string alarmName);

        event TimeChangedDelegate OnTimeChanged;

        event AlarmRaisedDelegate OnAlarmRaised;

        event EventHandler OnAlarmChanged;
    }
}
