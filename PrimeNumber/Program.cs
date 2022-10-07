using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var primes = GetPrimeNumbers(0, 100).Result;

            if (primes.Any())
            {
                foreach (var prime in primes)
                {
                    Console.WriteLine(prime);
                }
            }
            Console.WriteLine("Total prime numbers: " + primes.Count);
        }

        static async Task<List<int>> GetPrimeNumbers(int minimum, int maximum)
        {
            var list = new List<int>();

            var result = await Task.Run(() =>
            {
                for (int i = minimum; i <= maximum; i++)
                {
                    if (isPrimeNumber(i))
                    {
                        list.Add(i);
                    }
                }
                return list;
            });

            return result;
        }

     

        public static bool isPrimeNumber(int n)
        {
            
            if (n < 2)
            {
                return false;
            }
            int squareRoot = (int)Math.Sqrt(n);
            int i;
            for (i = 2; i <= squareRoot; i++)
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
