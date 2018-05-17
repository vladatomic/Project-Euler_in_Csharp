using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallestMultiple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<bool> list=new List<bool>();
            bool check = false;
            int count = 20;
            while (!check)
            {
                for (int i = 11; i <21; i++)
                {
                    if (count%i==0)
                    {
                        list.Add(true);
                        if (list.Count==10)
                        {
                            check = true;
                        }
                    }
                    else
                    {
                        check = false;
                        count++;
                        list.Clear();
                    }
                }
            }
            Console.WriteLine("Number is :"+count);
            Console.ReadKey();

        }
    }
}
