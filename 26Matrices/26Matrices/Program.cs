using System;
namespace E26Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numeros = new int[2, 2];
            string[,] nombres = new string[2, 3]; //Rango=6 posiciones
            char[,] caracteres = new char[3, 2]; //Rango=6 posiciones
            //Asignación de datos
            numeros[0, 0] = 25;
            numeros[0, 1] = 46;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;
            //Otra forma de declarar e inicializar matrices
            string[,] apellidos =
            {
                {"Chica","Álvarez" },
                {"Carolina", "Rios" },
                {"López", "Mejía" }
            };
            //Recuperar datos
            Console.WriteLine(apellidos[1,1]);
            //Recorrer matrices - Almacenar Datos
            for (int i = 0; i < 2; i++) //Recorrer filas
            {
                for (int j = 0; j < 2; j++) //Recorrer las columnas 
                {
                    Console.WriteLine($"Ingrese el caracter para la posición{i},{j}");
                    caracteres[i,j] =char.Parse(Console.ReadLine());
                }
            }
            //Recorrer Matrices - Recuperar Datos
            for (int i = 0;i < caracteres.GetLength(0); i++) //.GetLength con cero devuelve el número de filas
            {
                for (int j = 0; j < caracteres.GetLength(1); j++)
                {
                    Console.WriteLine($"Caracter posicion {i},{j} {caracteres[i, j]}");
                }
                Console.WriteLine();
            }
            //Rango de la matriz
            Console.WriteLine(caracteres.Length );
        }
    }
}