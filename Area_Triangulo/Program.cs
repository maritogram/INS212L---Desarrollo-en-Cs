using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vBase;
            double vHeight;
            double vArea;

            Console.WriteLine("Porfavor inserte la longitud (en cm) de la base: ");
            vBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Porfavor inserte la longitud (en cm) de la altura: ");
            vHeight = Convert.ToDouble(Console.ReadLine());

            vArea = (vBase * vHeight) / (double)2;
            Console.WriteLine($"El area del triangulo es {vArea}cm.");         
  
        }
    }
}
