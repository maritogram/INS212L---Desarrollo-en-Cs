using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double c;

            Console.WriteLine("Por favor inserte la longitud (en cm) del largo del cuadrado: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Por favor inserte el largo (en cm) del ancho del cuadrado: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a * b;

            Console.WriteLine($"El area del rectangulo es {c}cm.");

        }
    }
}
