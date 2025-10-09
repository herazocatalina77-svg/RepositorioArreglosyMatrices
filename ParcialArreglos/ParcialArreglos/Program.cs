using System;
namespace ParcialArreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int[] pisoshotel = new int[6];
            char[] habitaciones = new char[4];
            int[,] ocupacion = new int[6, 4];
            int[,] facturacion = new int[6, 4];
            int tiempocupado = 0;
            int habitacionactual = 0;
            int pisoactual = 0;
            double monto = 0;
            //Llenando el arreglo de las habitaciones
            habitaciones[0] = 'A';
            habitaciones[1] = 'B';
            habitaciones[2] = 'C';
            habitaciones[3] = 'D';
            //Arreglo de los pisos del hotel
            pisoshotel[0] = 1;
            pisoshotel[1] = 2;
            pisoshotel[2] = 3;
            pisoshotel[3] = 4;
            pisoshotel[4] = 5;
            pisoshotel[5] = 6;
            Console.WriteLine("Ingrese el piso de la habitación en la que se piensa quedar");
            pisoactual = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el piso de la habitación en la que se piensa quedar");
            habitacionactual = char.Parse(Console.ReadLine());
            //Leer la coordenada de la matriz

            //Recorrer matriz ocupacion - Almacenar Datos
            for (int i = 0; i < ocupacion.GetLength(0); i++) //.GetLength con cero devuelve el número de filas
            {
                for (int j = 0; j < ocupacion.GetLength(1); j++)
                {
                    Console.WriteLine($"");
                }

            }
            //Pedirle al usuario la ocupación
            Console.WriteLine("Ingrese la cantidad de noches que se piensa quedar");
            tiempocupado = Int32.Parse(Console.ReadLine());
            //Recorrer matriz facturacion
            for (int i = 0; i < facturacion.GetLength(0); i++) //.GetLength con cero devuelve el número de filas
            {
                for (int j = 0; j < facturacion.GetLength(1); j++)
                {
                    Console.WriteLine("Ingresar el monto cobrado");
                    monto = Int32.Parse(Console.ReadLine());
                }

            }
        }
    }
}