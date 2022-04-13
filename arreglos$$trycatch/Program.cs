
namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {



            int dig = 13;


            Console.WriteLine("0");
            Console.WriteLine("1");

            int display = 0;
            int uno = 1;
            int zero = 0;
            do
            {

                display = uno + zero;
                Console.WriteLine(display);
                zero = uno;
                uno = display;

                dig--;

            } while (dig > 2);
        }
    }
}

/*

namespace paridad
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Inserte un numero");
            double x = double.Parse(Console.ReadLine());
            Console.Clear();

            if (x % 2 == 0)
                Console.WriteLine(x + " es un número par.");
            else
                Console.WriteLine(x + " es un número impar.");

        }
    }
}

namespace primo
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Por favor inserte un numero:");
            int num = int.Parse(Console.ReadLine());
            Console.Clear();

            int factores = 0;

            for (int i = 1; i <= num; i++)
            {

                if (num % i == 0)
                    factores++;

            }

            if (factores == 2)
                Console.WriteLine("El numero es primo.");
            else
                Console.WriteLine("El numero es compuesto.");


        }
    }
}



namespace sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double restante, Porciento, sueldoNeto, deduccionesTotalesISR, sueldoSFS, sueldoAFP, deducciones, sueldoBase, sueldoBaseMensual;


            Console.WriteLine("Por favor inserte su sueldo bruto:");
            double sueldo = double.Parse(Console.ReadLine());
            Console.Clear();

            sueldoSFS = sueldo * 0.0304;

            sueldoAFP = sueldo * 0.0287;

            deducciones = sueldoAFP + sueldoSFS;

            Console.WriteLine("Deducciones mensuales (SFS y AFP) : RD${0:.##}", deducciones);
            Console.WriteLine("");

            sueldoBase = (sueldo - deducciones) * 12;
            sueldoBaseMensual = (sueldo - deducciones);

            Console.WriteLine("Base anual para la deduccion del ISR : RD${0:.##}", sueldoBase);
            Console.WriteLine("");


            switch (sueldoBase)
            {

                case (<= 416220):
                    Console.WriteLine("Está exento de la deducción del ISR, su sueldo neto mensual es de RD${0:.##}.", sueldoBaseMensual);
                    Console.ReadLine();
                    break;
                case (<= 624329):
                    restante = sueldoBase - 416220;
                    Porciento = (restante * 0.15) / 12;

                    deduccionesTotalesISR = deducciones + Porciento;

                    Console.WriteLine("Deducciones mensuales totales (SFS, AFP, y ISR) : RD${0:.##}", deduccionesTotalesISR);
                    Console.WriteLine("");

                    sueldoNeto = sueldo - (deduccionesTotalesISR);
                    Console.WriteLine("Su sueldo neto mensual es de RD${0:.##}.", sueldoNeto);
                    Console.ReadLine();
                    break;

                case (<= 867123):
                    restante = sueldoBase - 624329;
                    Porciento = ((restante * 0.20) + 31216) / 12;

                    deduccionesTotalesISR = deducciones + Porciento;

                    Console.WriteLine("Deducciones mensuales totales (SFS, AFP, y ISR) : RD${0:.##}", deduccionesTotalesISR);
                    Console.WriteLine("");

                    sueldoNeto = sueldo - (deduccionesTotalesISR);
                    Console.WriteLine("Su sueldo neto mensual es de RD${0:.##}.", sueldoNeto);
                    Console.ReadLine();

                    break;

                case (> 867123):
                    restante = sueldoBase - 867123;
                    Porciento = ((restante * 0.25) + 79776) / 12;

                    deduccionesTotalesISR = deducciones + Porciento;

                    Console.WriteLine("Deducciones mensuales totales (SFS, AFP, y ISR) : RD${0:.##}", deduccionesTotalesISR);
                    Console.WriteLine("");

                    sueldoNeto = sueldo - (deduccionesTotalesISR);
                    Console.WriteLine("Su sueldo neto mensual es de RD${0:.##}.", sueldoNeto);
                    Console.ReadLine();
                    break;

            } 

        }
    }
}




namespace sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int u = 9;
            int[] moneda = { 1, 5, 10, 25, 50, 100, 200, 500, 1000, 2000 };
            int[] monedb = new int[10];
            
            Console.WriteLine("Cuanto dinero desea sacar?");
            int dinero = int.Parse(Console.ReadLine());


            while (u >= 0)
            {

                monedb[i] = dinero/moneda[u];
                Console.WriteLine("Billete de " + moneda[u] + " " + monedb[i]);
                dinero = dinero % moneda[u];

                i++;
                u--;
            }
        }
    }
}

*/

