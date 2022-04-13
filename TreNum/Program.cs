using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            float d;

            Console.WriteLine("Inserte tres numeros enteros: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            d = (a+c)/(float)b;

            Console.WriteLine($"El resultado es {d}");
        }
    }
}
