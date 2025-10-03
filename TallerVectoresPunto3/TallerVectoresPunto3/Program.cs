using System;
namespace TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //Vector con condicional rango de 1 a 50
            //Inicializando vector
            int[] numero = new int[20];
            int numerousuario = 0;
            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = random.Next(1, 51);
                //Console.WriteLine($"La posición para {i} es {numero[i]}");
            }
            Console.WriteLine("Ingrese un numero del 1 al 50");
            numerousuario = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < numero.Length; i++)
            {
                if (numerousuario == numero[i])
                {
                    Console.WriteLine($"El numero ingresado está en la posición {i}");
                    Console.WriteLine(numerousuario);
                    break;
                }
                else if (i == numero.Length-1)
                {
                    Console.WriteLine("Pailas brother -1");
                }
            }
        }
    }
}