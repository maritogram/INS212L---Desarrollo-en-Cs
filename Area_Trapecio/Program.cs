using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Trapecio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vBase1;
            double vBase2;
            double vHeight;
            double vArea;

            Console.WriteLine("Inserte las longitudes (en cm) de las bases paralelas: ");
            vBase1 = Convert.ToDouble(Console.ReadLine());
            vBase2 = Convert.ToDouble(Console.ReadLine());      

            Console.WriteLine("Inserte la longitud (en cm) de la altura: ");
            vHeight = Convert.ToDouble(Console.ReadLine());

            vArea = ((vBase1 + vBase2)*(vHeight))/2;  // La formula del area del trapecio.

            Console.WriteLine($"El area del trapecio es {vArea}cm.");

        
            
        }
    }
}
