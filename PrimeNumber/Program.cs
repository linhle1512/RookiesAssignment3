using System;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.WhenAny(
            GetPrimeNumbers(0, 100),
            GetPrimeNumbers(100, 200)
            );

            Console.WriteLine("Task done.");
            Console.ReadKey();
        }

        static async Task GetPrimeNumbers(int minimum, int maximum)
        {
            await Task.Run(() =>
            {
                for (int i = minimum; i <= maximum; i++)
                {
                    if (isPrimeNumber(i))
                    {
                        Console.WriteLine(" " + i);
                    }
                }
            });
        }

        public static bool isPrimeNumber(int n)
        {
            if (n < 2)
            {
                return false;
            }
            int square = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= square; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
