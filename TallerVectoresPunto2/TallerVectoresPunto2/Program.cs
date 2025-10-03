using System;
namespace Punto2Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ingresar los caracteres de un vector
            //Declarando el vector
            char[] caracteres = new char[6];
            for (int i = 0; i < caracteres.Length;  i++)
            {
                Console.WriteLine($"Ingrese el caracter para la posición {i}");
                caracteres[i]=Convert.ToChar(Console.ReadLine());
            }
            for (int j = 0; j < caracteres.Length; j++)
            {
               Console.WriteLine($"Los números ingresados por posición son: {caracteres[j]}");

            }
            for (int j = caracteres.Length-1; j >= 0; j--)
            {
                Console.WriteLine($"Los números ingresados por posición en sentido contrario son: {caracteres[j]}");

            }
        }
    }
}