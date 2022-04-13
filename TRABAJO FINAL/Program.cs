using System.Collections;

namespace PRACTICA_FINAL
{
    internal class Program
    {







        //METODO PARA ENSENAR LOS ESTUDIANTES ACTVIOS & ANADIDOS
        static void BaseDeDatos(int[] numero_de_estudiante, List<string> estudiantes_nuevos, List<int> ID)
        {
            Console.WriteLine("|   {0}   |               {1}               |    {2}    |              {3}              |  {4}  |", "ID", "Nombre", "Cedula", "Email", "Telefono");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine("|{0,-8}|{1,-36}|{2,-14}|{3,-33}|{4,-12}|", "1105582", "Mario José Estrella Santos", "402-*******-0", "estrellamariosantos@gmail.com", "809-***-1600");


            if (numero_de_estudiante[0]>0)
            {

                int repeater = 0;
                int adder=0;

                while ( repeater < numero_de_estudiante[0])
                {

                    if (ID[repeater] != 0)
                    { 
                    Console.WriteLine("|{0,-8}|{1,-36}|{2,-14}|{3,-33}|{4,-12}|", ID[repeater], estudiantes_nuevos[0+adder], estudiantes_nuevos[1+adder], estudiantes_nuevos[2+adder], estudiantes_nuevos[3+adder]);
                    repeater++;
                    adder += 4;
                    }
                    else
                    { 
                    repeater++;
                    }


                }

            }
            Console.ReadLine();

        }







        //METODO PARA ANADIR ESTUDIANTES
        static void Declaracion(int[] numero_de_estudiante, List<string> estudiantes_nuevos, List<int> ID)
        {
    
            ref int estudiantex = ref numero_de_estudiante[0];
            int adder = 0+4*(numero_de_estudiante[0]);
            

            Console.Clear();

            Console.WriteLine("Cual es el nombre completo del estudiante?");
            estudiantes_nuevos.Add(Console.ReadLine()); 
            Console.Clear();

            Console.WriteLine("Cual es la cedula del estudiante?");
            estudiantes_nuevos.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Cual es el email del estudiante?");
            estudiantes_nuevos.Add(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Cual es el telefono del estudiante?");
            estudiantes_nuevos.Add(Console.ReadLine());
            Console.Clear();

            estudiantex += 1;
            ID.Add(estudiantex);

        }



        static void Eliminar(int[] numero_de_estudiante, List<string> estudiantes_nuevos, List<int> ID)
        {
            ref int estudiantex = ref numero_de_estudiante[0];

            Console.WriteLine("A cual estudiante desea eliminar? Por favor inserte su ID:");
            int eliminacion = int.Parse(Console.ReadLine());

            int eliminacionCuatro = eliminacion * 4;
            
            while (eliminacionCuatro-1 >= ((eliminacion*4)-4))
            {
                estudiantes_nuevos.RemoveAt(eliminacionCuatro-1);

                eliminacionCuatro -= 1;
                
            }

            ID[eliminacion-1]=0;

        }







        //MAAAAINNNN PROGRAMMMMMMmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmmaaaaaaaaaaa
        static void Main(string[] args)
        {




            bool seguir = true;

            int[] numero_de_estudiante = {0};

            List<int> ID = new List<int>();
            List<string> estudiantes_nuevos = new List<string>();





            do
            {

             // try
                {
                    Console.Clear();
                    Console.WriteLine("Que desea hacer:");
                    Console.WriteLine("");
                    Console.WriteLine("1) Visualizar estudiantes activos.");
                    Console.WriteLine("2) Inscribir estudiantes en cursos.");
                    Console.WriteLine("3) Declarar un nuevo estudiante.");
                    Console.WriteLine("4) Eliminar.");
                    int opcion = int.Parse(Console.ReadLine());

                    switch(opcion)
                    {
                        case 1:
                            Console.Clear();
                            BaseDeDatos(numero_de_estudiante, estudiantes_nuevos, ID);
                        break;

                        case 2:
                            Console.Clear();
                            //Inscripcion();
                        break;
                        case 3:
                            Console.Clear();
                            Declaracion(numero_de_estudiante, estudiantes_nuevos, ID);
                        break;
                        case 4:
                            Console.Clear();
                            Eliminar(numero_de_estudiante, estudiantes_nuevos, ID);
                        break;

                        default:
                            Console.Clear();
                            Console.WriteLine("Por favor seleccione una opcion valida.");
                            Console.ReadLine();
                        break;
                    }

                }
            // catch (Exception)
             //   {
               //     Console.Clear();
                 //   Console.WriteLine("Por favor seleccione una opcion valida.");
                   // Console.ReadLine();

                //}

            } while (seguir);










        }
    }
}