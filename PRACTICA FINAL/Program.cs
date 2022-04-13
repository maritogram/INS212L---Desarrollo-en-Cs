namespace PRACTICA_FINAL
{
    internal class Program
    {



        //CALCULAR SFS
        static void cSFS(int i, double[] SFS, double[] salarios)
        {

            SFS[i] = salarios[i] * 0.0304;

            if (SFS[i] > 4742.40)
            {
                SFS[i] = 4742.40;
            }

        }



        //CALCULAR AFP
        static void cAFP(int i, double[] AFP, double[] salarios)
        {

            AFP[i] = salarios[i] * 0.0287;

            if (AFP[i] > 8954.40)
            {
                AFP[i] = 8954.40;
            }

        }



        //IN PROGRESS PRIMERO AFP Y SFS
        static void cISR(int i, double[] ISR, double[] salarios, double[] SFS, double[] AFP)
        {


            double anualSB = (salarios[i] - AFP[i] - SFS[i]) * 12;

            switch (anualSB)
            {
                case (<= 416220):
                    ISR[i] = 0;

                    break;
                case (<= 624329):
                    double restante = anualSB - 416220;
                    ISR[i] = (restante * 0.15) / 12;

                    break;
                case (<= 867123):
                    restante = anualSB - 624329;
                    ISR[i] = ((restante * 0.20) + 31216) / 12;

                    break;
                case (> 867123):
                    restante = anualSB - 867123;
                    ISR[i] = ((restante * 0.25) + 79776) / 12;

                    break;
            }
        }




        //PROGRAMA PRINCIPAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAALLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLll
        static void Main(string[] args)
        {

            string[] empleados = new string[15];
            double[] salarios = new double[15];


            double[] ISR = new double[15];
            double[] AFP = new double[15];
            double[] SFS = new double[15];
            double[] neto = new double[15];

            string[] ISRstring = new string[15];
            string[] AFPstring = new string[15];
            string[] SFSstring = new string[15];
            string[] salariosstring = new string[15];
            string[] netostring = new string[15];


            Console.WriteLine("Cuantos salarios desea calcular?    (Máximo 12 salarios)");
            int cantidadSalarios = int.Parse(Console.ReadLine());
            Console.Clear();

            //primer tipo de bucle

            for (int i = 0; i < cantidadSalarios; i++)
            {
                Console.WriteLine("Cual es el nombre del empleado #" + (i + 1) + "?");
                empleados[i] = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Cual es el sueldo bruto de " + empleados[i] + "?    (Mensual)     [Puede utilizar comas para cantidades grandes]");
                string unconvertedSalarios = Console.ReadLine();
                string convertedSalarios = unconvertedSalarios.Replace(",", "");
                salarios[i] = double.Parse(convertedSalarios);
                Console.Clear();

                cSFS(i, SFS, salarios);
                cAFP(i, AFP, salarios);
                cISR(i, ISR, salarios, SFS, AFP);

                neto[i] = salarios[i] - (SFS[i] + AFP[i] + ISR[i]);

                //añadir comas a los numeros NEW

                SFSstring[i] = SFS[i].ToString("#,##0");
                AFPstring[i] = AFP[i].ToString("#,##0");
                ISRstring[i] = ISR[i].ToString("#,##0");
                salariosstring[i] = salarios[i].ToString("#,##0");
                netostring[i] = neto[i].ToString("#,##0");


            }

            Console.WriteLine("|       {0}       |  {1}  |     {2}     |     {3}     |     {4}     |  {5}  |", "Nombre", "Sueldo Bruto", "SFS", "AFP", "IRS", "Sueldo Neto");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            //segundo tipo de bucle

            int whileContador = 0;

            while (whileContador < cantidadSalarios)
            {
                Console.Write("|{0,-20}|", empleados[whileContador]);
                Console.Write("RD${0,-13}|", $"{salariosstring[whileContador]:.##}");
                Console.Write("RD${0,-10}|", $"{SFSstring[whileContador]:.##}");
                Console.Write("RD${0,-10}|", $"{AFPstring[whileContador]:.##}");
                Console.Write("RD${0,-10}|", $"{ISRstring[whileContador]:.##}");
                Console.WriteLine("RD${0,-12}|", $"{netostring[whileContador]:.##}");

                whileContador++;
            }
        }
    }
}