namespace sorts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] aOrdenar = { 505,423,6786,679,9083,123,4,56,7780, 0, -1, 0.5};

            Sort(aOrdenar);

            for (int i = 0; i < aOrdenar.Length ; i++)
            {
                Console.Write(aOrdenar[i] + " ");
            }
            
        }


        static void Sort(double[] aOrdenar)
        {
            
            
            bool swap;

            do
            {
                swap = false;

                for (int i = 0; i < aOrdenar.Length - 1; i++)
                {

                    if (aOrdenar[i] > aOrdenar[i + 1])
                    {

                        var guardar = aOrdenar[i+1];
                        aOrdenar[i+1] = aOrdenar[i];
                        aOrdenar[i] = guardar;

                        swap = true;
                    }
                }
            } while (swap);
        }

        static void Sort2(double[] aOrdenar)
        {

            
                for (int i = 0; i < aOrdenar.Length; i++)
                {
                    var chequeando = aOrdenar[i];
                    var numeroLista = i;

                    while (numeroLista > 0 && aOrdenar[numeroLista - 1] > chequeando)
                    {
                    aOrdenar[numeroLista] = aOrdenar[numeroLista - 1];
                        numeroLista--;
                    }
                    
                     aOrdenar[numeroLista] = chequeando;
                }

        }

    }
}