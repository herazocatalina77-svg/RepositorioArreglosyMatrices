using System;
namespace Tallervectorespunto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declarando el arreglo para que el usuario ingrese un número que quede en la mitad del array
            int[] array = new int [5];
            //Declarando contadores, creo
            int contadorsuma = 0;
            int contadorresta = 0;
            int numero = 0;
            Console.WriteLine("Ingrese un número");
            numero = Int32.Parse(Console.ReadLine());
            array[array.Length-1 / 2] = numero;
            int iniciocontadorresta = numero - 2;
            int iniciocontadorsuma = numero + 1;
            //Ciclo que pone las posiciones antes del numero ingresado
            // 0 1 2(mitad) 3 4 
            contadorsuma = iniciocontadorsuma;
            contadorresta = iniciocontadorresta;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"El número para la posición {i} es {contadorresta}");
                contadorresta++;
            }
            //Ciclo que pone las posiciones después del numero ingresado
            Console.WriteLine($"El número para la posición 2 es {numero}");
            for (int i = 3; i < array.Length; i++)
            {
                Console.WriteLine($"El número para la posición {i} es {contadorsuma}");
                contadorsuma++;
            }
        }
    }
}
