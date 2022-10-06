using System;

namespace ClockAssign
{
    delegate void UpdateClockHandlers(DateTime clockTime);

    class Clock
    {
        public event UpdateClockHandlers ClockChanged;

        private DateTime clockTime;

        public DateTime ClockTime
        {
            get => clockTime;

            set
            {
                clockTime = value;
                if (ClockChanged != null)
                {
                    ClockChanged(ClockTime);
                }
            }
        }
    }
}