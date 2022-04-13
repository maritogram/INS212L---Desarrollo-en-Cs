namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Menu(); 
        }


        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Mini calculadora");
            Console.WriteLine("");
            Console.WriteLine("Opcion 1. Area de un cuadrado");
            Console.WriteLine("Opcion 2. Area de un rectangulo.");
            Console.WriteLine("Opcion 3. Area de un triangulo.");
            Console.WriteLine("Opcion 4. Area de un circulo.");
            Console.WriteLine("Opcion 5. Area de un cono.");
            Console.WriteLine("Opcion 6. Calcular la hipotenusa.");
            Console.WriteLine("");
            Console.WriteLine("Por favor escribe el numero de la opcion que desea utilizar: ");
            string vOp = Console.ReadLine();

            switch (vOp)
            {
                case ("1"):
                    Cuadrado();
                    break;
                case ("2"):
                    Rectangulo();
                    break;
                case ("3"):
                    Triangulo();    
                    break;
                case ("4"):
                    Circulo();
                    break;
                case ("5"):
                    Cono();
                    break;
                case ("6"):
                    Hipotenusa();
                    break;
            }


            Menu(); 
        }

        static void Cuadrado()
        {
            double a;
            double b;

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) de un lado del cuadrado: ");
            a = Convert.ToDouble(Console.ReadLine());

            b = Math.Pow(a, 2); //Formula del area del cuadrado.

            Console.WriteLine("");
            Console.WriteLine($"El area del cuadrado es de {b}cm^2.");

            Console.WriteLine("");
            Console.WriteLine("Dele a enter para volver al menu");

            Console.ReadLine();
        }

        static void Rectangulo()
        {
            double a;
            double b;
            double c;

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) del largo del cuadrado: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte el largo (en cm) del ancho del cuadrado: ");
            b = Convert.ToDouble(Console.ReadLine());

            c = a * b; //Formula del area del rectangulo

            Console.WriteLine("");
            Console.WriteLine($"El area del rectangulo es de {c}cm^2.");

            Console.WriteLine("");
            Console.WriteLine("Dele a enter para volver al menu");

            Console.ReadLine();

        }

        static void Triangulo()
        {
            double vBase;
            double vHeight;
            double vArea;

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) de la base: ");
            vBase = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) de la altura: ");
            vHeight = Convert.ToDouble(Console.ReadLine());


            vArea = (vBase * vHeight) / (double)2; //Formula del area del triangulo

            Console.WriteLine("");
            Console.WriteLine($"El area del triangulo es de {vArea}cm^2.");

            Console.WriteLine("");
            Console.WriteLine("Dele a enter para volver al menu");

            Console.ReadLine();
        }

        static void Circulo()
        {

            double vRad;
            double vArea;

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) del radio del circulo. ");
            vRad = Convert.ToDouble(Console.ReadLine());

            vArea = Math.PI * Math.Pow(vRad, 2); //Formula del area del circulo.

            Console.WriteLine("");
            Console.WriteLine($"El area del circulo es de {vArea}cm^2.");



            Console.WriteLine("");
            Console.WriteLine("Dele a enter para volver al menu");

            Console.ReadLine();

        }

        static void Cono()
        {
            double vHeight;
            double vRad;
            double vArea;

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) del radio del cono. ");
            vRad = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) de la altura del cono. ");
            vHeight = Convert.ToDouble(Console.ReadLine());

            vArea = Math.PI * vRad * (vRad + Math.Sqrt(Math.Pow(vHeight, 2) + Math.Pow(vRad, 2)));

            Console.WriteLine("");
            Console.WriteLine($"El area total del cono es de {vArea}cm^2. ");

            Console.WriteLine("");
            Console.WriteLine("Dele a enter para volver al menu");

            Console.ReadLine();

        }

        static void Hipotenusa()
        {
            double vCat1;
            double vCat2;
            double vHip;


            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) del primer cateto del triangulo rectangulo. ");
            vCat1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Por favor inserte la longitud (en cm) del segundo cateto del triangulo rectangulo. ");
            vCat2 = Convert.ToDouble(Console.ReadLine());

            vHip = Math.Sqrt(Math.Pow(vCat1, 2) + Math.Pow(vCat2, 2));

            Console.WriteLine("");
            Console.WriteLine($"La longitud de la hipotenusa del triangulo rectangulo es de {vHip}cm.");

            Console.WriteLine("");
            Console.WriteLine("Dele a enter para volver al menu");

            Console.ReadLine();
        }

    }
}


