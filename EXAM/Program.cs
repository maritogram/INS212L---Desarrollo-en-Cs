using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Int32 vN1, vN2, vResultado;

            Console.Write("Favor indicar el 1er. valor:");
            vN1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Favor indicar el 2do. valor:");
            vN2 = Int32.Parse(Console.ReadLine());

            vResultado = vN1 / vN2;

            Console.Write("El resultado es:" + vResultado);





        }
    }
}
