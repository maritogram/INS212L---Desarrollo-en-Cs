using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            int d;
            int e;
            float f;

            Console.WriteLine("Inserte cinco numeros: ");
            a = Convert.ToInt32(Console.ReadLine());    
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());

            f = (a + b + c + d + e) / (float)5;

            Console.WriteLine($"El promedio de esos cinco numeros es {f}");
        }
    }
}
