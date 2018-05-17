using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestPalindromeProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 1;
            List<int> palindromArray=new List<int>();
            for (int i = 999; i > 100; i--)
            {
                for (int j = 999; j > 100 ; j--)
                {
                    sum = j * i;
                    string polindrom = sum.ToString();
                    string reverse = new string(polindrom.Reverse().ToArray());
                    
                    if (polindrom.Equals(reverse))
                              palindromArray.Add(sum);
                    
                }
            }
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("Largest polindrom is: " + palindromArray.Max());
            Console.ReadKey();
        }
    }
}
