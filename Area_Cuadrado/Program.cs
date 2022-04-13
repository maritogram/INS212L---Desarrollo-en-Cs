using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Cuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            Console.WriteLine("Porfavor inserte la longitud (en cm) de un lado del cuadrado: ");
            a = Convert.ToDouble(Console.ReadLine());

            b = Math.Pow(a, 2);

            Console.WriteLine($"El area del cuadrado es {b}cm.");

        }
    }
}
