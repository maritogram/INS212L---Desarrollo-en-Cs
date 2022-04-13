using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeInt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte un numero: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte otro numero: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte otro numero: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double suma = a + b + c;
            double promedio = suma / 3;

            if (a > b && a > c)
                Console.WriteLine($"El numero mas grande es el {a}");
            else if (b > a && b > c)
                Console.WriteLine($"El numero mas grande es el {a}");
            else if (c > a && c > b)
                Console.WriteLine($"El numero mas grande es el {c}");
            else
                Console.WriteLine("Es el mismo numero.");

            Console.WriteLine($"La suma de todos los numeros es {suma}, y el promedio de los numeros es {promedio}");


        }
    }
}
