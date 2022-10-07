using Clock1.Event;
using Clock1.View;

namespace Clock1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            DisplayClock displayClock = new DisplayClock();
            displayClock.Subcribe(clock);
            clock.Run();
        }
    }
}
