using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_square_difference
{
   class Program
   {
      static void Main(string[] args)
      {
         double sumOfSquares=0;
         double squareOfSum=0;
         for (double i = 1; i < 101; i++)
         {
            sumOfSquares += Math.Pow(i, 2);
            squareOfSum += i;
         }
         double squareOfSumFinal = Math.Pow(squareOfSum, 2);
         Console.WriteLine("sumOfSquares :"+ sumOfSquares);
         Console.WriteLine("squareOfSum :"+ squareOfSumFinal);
         Console.WriteLine("Diff :" + (squareOfSumFinal - sumOfSquares));

      }
   }
}
