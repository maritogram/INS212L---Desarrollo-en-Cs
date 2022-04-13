
namespace jesu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int e = 0;
            int cP = 1;
            int pOpt, dOpt;

            do
            {
                do
                {

                    Console.WriteLine("Seleccione el numero de la operación que desea realizar.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Opcion 1. Que muestre los números descendentes del 1 al 100 de dos en dos.");
                    Console.WriteLine("Opcion 2. Que pida un número y muestre la tabla del 1 al 12 de dicho número.");
                    Console.WriteLine("Opcion 3. Que pregunte la cantidad de montos, pida dichos montos y calcule la sumatorio y el promedio.");
                    Console.WriteLine("Opcion 4. Que pida un nombre y se repita mientras no sea \" jose \" o la cantidad de nombres ingresados sea menor a 7.");
                    Console.WriteLine(" ");
                    pOpt = int.Parse(Console.ReadLine());

                    if (pOpt < 1 || pOpt > 4)
                    {
                        Console.WriteLine(" ");
                        Console.WriteLine("Inserte una opción válida. ENTER para volver.");
                        Console.ReadLine();
                    }

                    Console.Clear();

                } while (pOpt < 1 || pOpt > 4);

                do
                {

                    Console.WriteLine("Seleccione el tipo de bucle que quiere usar.");
                    Console.WriteLine(" ");
                    Console.WriteLine("Opcion 1. While.");
                    Console.WriteLine("Opcion 2. Do/While.");
                    Console.WriteLine("Opcion 3. For.");
                    Console.WriteLine(" ");
                    dOpt = int.Parse(Console.ReadLine());

                    if (dOpt < 1 || dOpt > 3)
                    {
                        Console.WriteLine(" ");
                        Console.Write("Inserte una opción válida. ENTER para volver.");
                        Console.ReadLine();
                    }

                    Console.Clear();


                } while (dOpt < 1 || dOpt > 3);




                switch (pOpt, dOpt)
                {
                    case (1, 1):
                        int wX = 100;
                        while (wX > 0)
                        {

                            Console.WriteLine(wX + " - 2 = " + (wX - 2));

                            wX -= 2;
                        }

                        break;

                    case (1, 2):
                        int wY = 100;
                        do
                        {
                            Console.WriteLine(wY + " - 2 = " + (wY - 2));
                            wY -= 2;

                        } while (wY != 0);

                        break;

                    case (1, 3):
                        for (int i = 100; i != 0; i -= 2)
                        {
                            Console.WriteLine(i + " - 2 = " + (i - 2));
                        }
                        break;

                    case (2, 1):
                        int dX = 1;
                        Console.WriteLine("Por favor inserte un numero");
                        int dT = int.Parse(Console.ReadLine());

                        Console.Clear();

                        while (dX <= 12)
                        {
                            Console.WriteLine(dT + " por " + dX + " es = " + dT * dX);

                            dX++;
                        }
                        break;

                    case (2, 2):

                        int dY = 1;
                        Console.WriteLine("Por favor inserte un numero");
                        int dU = int.Parse(Console.ReadLine());

                        Console.Clear();

                        do
                        {
                            Console.WriteLine(dU + " por " + dY + " es = " + dU * dY);

                            dY++;

                        } while (dY != 13);
                        break;

                    case (2, 3):
                        Console.WriteLine("Por favor inserte un numero");
                        int dZ = int.Parse(Console.ReadLine());

                        Console.Clear();

                        for (int i = 1; i <= 12; i++)
                        {

                            Console.WriteLine(i + " por " + dZ + " es = " + i * dZ);

                        }
                        break;

                    case (3, 1):

                        Console.WriteLine("Cual es la cantidad de montos?");
                        int xM = int.Parse(Console.ReadLine());


                        float add = 0;

                        while (xM != cP - 1)
                        {
                            Console.WriteLine("Cual es el valor del monto #" + cP);
                            int mF = int.Parse(Console.ReadLine());

                            add += mF;

                            cP++;

                        }

                        Console.WriteLine("La sumatoria de los montos es = " + add);
                        Console.WriteLine(" ");
                        Console.WriteLine("El promedio de los montos es = " + (add / (float)xM));

                        break;

                    case (3, 2):
                        Console.WriteLine("Cual es la cantidad de montos?");
                        int xK = int.Parse(Console.ReadLine());

                        float addD = 0;
                        do
                        {
                            Console.WriteLine("Cual es el valor del monto #" + cP);
                            int mF = int.Parse(Console.ReadLine());

                            addD += mF;

                            cP++;


                        } while (cP - 1 != xK);

                        Console.WriteLine("La sumatoria de los montos es = " + addD);
                        Console.WriteLine(" ");
                        Console.WriteLine("El promedio de los montos es = " + (addD / (float)xK));


                        break;

                    case (3, 3):

                        Console.WriteLine("Cual es la cantidad de montos?");
                        int zG = int.Parse(Console.ReadLine());

                        float addZ = 0;


                        for (int i = zG; i > 0; i--)
                        {
                            Console.WriteLine("Cual es el valor del monto #" + cP);
                            int mF = int.Parse(Console.ReadLine());

                            addZ += mF;

                            cP++;
                        }

                        Console.WriteLine("La sumatoria de los montos es = " + addZ);
                        Console.WriteLine(" ");
                        Console.WriteLine("El promedio de los montos es = " + (addZ / (float)zG));
                        break;

                    case (4, 1):

                        Console.WriteLine("Por favor ingrese un nombre:");
                        string vNom = Console.ReadLine();



                        while (vNom != "jose" && cP < 7)
                        {
                            Console.WriteLine("Nombre incorrecto, intento #" + (cP + 1) + ". Por favor ingrese otro:");
                            vNom = Console.ReadLine();

                            cP++;
                        }

                        Console.WriteLine("QUEDAS BAJO ARRESTO!");
                        break;

                    case (4, 2):
                        string xNom;
                        do
                        {

                            Console.WriteLine("Intento #" + cP + ". Por favor ingrese un nombre:");
                            xNom = Console.ReadLine();

                            cP++;


                        } while (xNom != "jose" && cP <= 7);

                        Console.WriteLine("QUEDAS BAJO ARRESTO!");
                        break;

                    case (4, 3):

                        Console.WriteLine("Por favor ingrese un nombre:");
                        string gNom = Console.ReadLine();


                        for (int i = 2; i <= 7 && gNom != "jose"; i++)
                        {
                            Console.WriteLine("Nombre incorrecto, intento #" + (i) + ". Por favor ingrese otro:");
                            gNom = Console.ReadLine();
                        }

                        Console.WriteLine("QUEDAS BAJO ARRESTO!");
                        break;

                }


                Console.WriteLine(" ");
                Console.WriteLine("Dele a ENTER para borrar todo.");

                Console.ReadLine();
                Console.Clear();

                Console.WriteLine("Desea continuar? (si o no)");
                string rE = Console.ReadLine();

                if (rE == "no" || rE == "nO" || rE == "NO")
                    e++;

                cP = 1;
                Console.Clear();

            } while (e == 0);
        }
    }
}

