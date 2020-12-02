using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dano: y(x)= Ln(d)/|B^2-a^2|Sin(c)");

            float d, b, a, c;

            Console.Write("a = ");
            a = float.Parse(Console.ReadLine());

            Console.Write("b = ");
            b = float.Parse(Console.ReadLine());

            Console.Write("d = ");
            d = float.Parse(Console.ReadLine());

            Console.Write("c = ");
            c = float.Parse(Console.ReadLine());
            
            

            if (b == 0 && a == 0 || c == 0 || c == 180 || d < 0)
            {
                Console.WriteLine("Function no exist");

            }
            else
            {
                Console.WriteLine("Function exist");

            }
        }
    }
}
