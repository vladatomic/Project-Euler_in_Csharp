using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primeNums=new List<int>();
            long end = 600851475143;
            long temp = end;
            long sum = 1;
            int count = 2;
            bool startLoop = true;
            int primeCount = 2;
            while (startLoop)
            {
                if (count==2 || count==3 )
                {
                  primeCount = count;
                }
                else if (count%2!=0 || count%3!=0)
                {
                    primeCount = count;
                }

                if(temp%primeCount==0)
                {
                    temp /= primeCount;
                    primeNums.Add(count);
                    sum *= primeCount;
                }
                else
                {
                    count++;
                }

                if (sum==end)
                {
                    startLoop = false;
                }

            }
            Console.WriteLine("Largest prime factor is :"+primeNums.Max());
            Console.ReadKey();
        }
    }
}
