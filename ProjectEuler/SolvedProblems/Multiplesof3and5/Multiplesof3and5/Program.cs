using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplesof3and5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = 1000;
            int sum=0;
            for (int i = 1; i < numbers; i++)
            {
                if (i%3==0 || i%5==0)
                    sum+=i;
            }
            Console.WriteLine("SumTotal is :"+sum);
          
        }
    }
}
