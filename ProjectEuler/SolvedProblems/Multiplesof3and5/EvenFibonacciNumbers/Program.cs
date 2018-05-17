using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenFibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibb=new List<int>();
            int num1 = 1;
            int num2 = 2;
            int temp = 0;
            int sum = 0;
            fibb.Add(num1);
            fibb.Add(num2);
            
            while (temp<4000000)
            {
                temp = num1 + num2;
                num1 = num2;
                num2 = temp;
                fibb.Add(temp);
            }
            foreach (int number in fibb)
            {
                if (number%2==0)
                    sum += number;
            }
            Console.WriteLine("Sum :"+sum);
            Console.ReadKey();
        }
    }
}
