using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Pythagorean_triplet
{
   class Program
   {
      static void Main(string[] args)
      {
         for (int a = 1; a < 1001; a++)
         {
            for (int b = 1; b < 1001; b++)
            {
               double c=1000-a-b;
               double c1 = Math.Sqrt((a * a) + (b * b));
               if (c==c1)
               {
                  Console.WriteLine($"a {a}  b {b}  c {c}");
                  double z = a * b * c;
                  Console.WriteLine("prod "+z);
               }
            }
         }
         Console.ReadLine();
      }
   }
}
