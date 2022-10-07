using Clock1.Event;
using System;

namespace Clock1.View
{
    class DisplayClock
    {
        public void Subcribe(Clock clock)
        {
            clock.clockTick += new Clock.clockTickHandler(showClock);
        }

        public void showClock(object clock, ClockEventArgs clockEventArgs)
        {
            Console.WriteLine($"{clockEventArgs.hour} : {clockEventArgs.minute} : {clockEventArgs.second}");
        }
    }
}
