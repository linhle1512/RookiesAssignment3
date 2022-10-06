using System;
using System.Threading;

namespace ClockAssign
{
    class Program
    {
        private static void GetClockTimeChanged(DateTime clockTime)
        {
            Console.WriteLine("New Clock: " + clockTime);

            Thread.Sleep(1000);
        }

        static void Main(string[] args)
        {
            Clock time = new Clock();
            time.ClockChanged += GetClockTimeChanged;

            while (true)
            {
                time.ClockTime = DateTime.Now;
            }
        }
    }   
}
