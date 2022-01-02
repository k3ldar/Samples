using System;

namespace ClockSample
{
    public sealed class TimeChangedEventArgs : EventArgs
    {
        public TimeChangedEventArgs(DateTime newTime)
        {
            Time = newTime;
        }

        public DateTime Time { get; }
    }
}
