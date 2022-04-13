using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Inserte un numero:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Inserte otro numero:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
                Console.WriteLine($"{a} es mayor que {b}.");
            else if (a < b)
                Console.WriteLine($"{b} es mayor que {a}.");
            else
                Console.WriteLine($"Son el mismo numero.");

        }
    }
}
