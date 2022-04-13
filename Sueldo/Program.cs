using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Inserte un sueldo:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte otro sueldo:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine($"El sueldo mayor es el de {a} pesos.");
                Console.WriteLine($"El sueldo menor es el de {b} pesos.");
            }
            else if (a < b)
            {
                Console.WriteLine($"El sueldo mayor es el de {b} pesos.");
                Console.WriteLine($"El sueldo menor es el de {a} pesos.");
            }
            else
                Console.WriteLine($"Son el mismo sueldo.");
        }
    }
}
