using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            notas();
        }

        static void notas()
        {
            Console.Write("Porfavor ingrese su nota (0-100): ");
            double a = Convert.ToDouble(Console.ReadLine());

            if (a >= 90 && a <= 100)
                Console.WriteLine("Sacaste una A.");
            else if (a >= 80 && a <= 89)
                Console.WriteLine("Sacaste una B.");
            else if (a >= 70 && a <= 79)
                Console.WriteLine("Sacaste una C.");
            else if (a >= 60 && a <= 69)
                Console.WriteLine("Sacaste una D.");
            else if (a <= 59 && a>= 0)
                Console.WriteLine("Sacaste una F.");
            else
                Console.WriteLine("No es un dato valido");

            notas();
        }


    }
}
