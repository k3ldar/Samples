using System;

namespace ClockSample
{
    public interface IAlarm
    {
        string Name { get; }

        DateTime AlarmDate { get; }
    }
}
