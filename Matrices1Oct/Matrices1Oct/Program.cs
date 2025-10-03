using System;
namespace Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[20,20];
            int[] sumacolumnas = new int[20];
            for (int i = 0; i < numeros.GetLength(0); i++)
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"{numeros[1,1]} |");
                }
                Console.WriteLine();
            }
            //Recorrer la matriz
            for (int i = 0; i < sumacolumnas.GetLength(0); i++)
            {
                for (int j = 0; j < sumacolumnas.GetLength(1); j++)
                {
                    sumacolumnas[i] += numeros[j, i];
                }
            }

        }
    }
}