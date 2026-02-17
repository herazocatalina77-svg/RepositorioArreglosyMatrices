using System;
namespace TallerVectoresPuntos5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Datos ingresados por el usuario
            int rangovector1 = 0;
            int rangovector2 = 0;
            int numeroingresadoV1 = 0;
            int numeroingresadoV2 = 0;
            //Vectores
            int[] vector1 = new int[5];
            int[] vector2 = new int[5];
            //Pedirle al usuario el rango de los números que pueden ser usados en el  vector 1
            Console.WriteLine("Ingrese el rango de numero para el primer array:");
            rangovector1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el rango de numero para el segundo array:");
            rangovector2 = Int32.Parse(Console.ReadLine());
            //Ciclo para recorrer el primer array
            for  (int i = 0; i < vector1.Length; i++)
            {
                if (numeroingresadoV1 < 0 || numeroingresadoV2 > rangovector1 + 1)
                {
                    Console.WriteLine("");
                }
            }

        }
    }
}