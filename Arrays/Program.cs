namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            int[,] bi = new int[2, 2] { { 1, 2 }, { 3, 4 } };
            int[,] bi2 = new int[2, 2] { { 5, 6 }, { 7, 8 } };
            int[,] solucion = new int[2, 2];

            for (int i = 0; i < solucion.GetLength(0); i++)
            {
                for (int j = 0; j < solucion.GetLength(1); j++)
                {
                    solucion[i, j] = bi[i, j] + bi2[i, j];
                }
            }

            for (int i = 0; i < solucion.GetLength(0); i++)
            {
                for (int j = 0; j < solucion.GetLength(1); j++)
                {
                    Console.Write(solucion[i,j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}