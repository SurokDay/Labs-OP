using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Labs_C_Sharp_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double x, sum = 0;
            Console.WriteLine("i : ");
            i = int.Parse(Console.ReadLine());

            Console.WriteLine("x : ");
            x = int.Parse(Console.ReadLine());


            for (int j = 1; j < i; j++)
            {
                sum += 1 / Math.Pow(j, 2) * Math.Sin(x);
            }
            Console.WriteLine("Answer the question : {0}",1/sum);
        }
    }
}
