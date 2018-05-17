using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _10001st_prime
{
   class Program
   {
      static void Main(string[] args)
      {
         List<double> primes = new List<double>();
         double i = 1;
         double result = 0;
         Console.WriteLine("Calculating..........");
         while (true)
         {
            i++;
            if (IsPrimeNumber(i) == true) {
               primes.Add(i);
               if (primes.Count == 10001)
               {
                  result = primes.ElementAt(10000);
                  break;
               }
            }
         }
         Console.WriteLine("Result is" + result);
         Console.ReadLine();
      }
      static bool IsPrimeNumber(double num)
      {
         bool bPrime = true;
         double factor = num / 2;
         for (double i = 2; i <= factor; i++)
         {
            if ((num % i) == 0)
               bPrime = false;
         }
         return bPrime;
      }
   }
}
