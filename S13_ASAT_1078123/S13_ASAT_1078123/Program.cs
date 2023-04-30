using System;
using System.Globalization;

class Ejercicio2
{   
    static void Main()
    {
        Console.Write("\nIngrese el tamaño de la matriz para hacer la multiplicación: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] mult = new int[n, n];

        for (int i = 1; i <= n; i++)
        {
            for (int x = 1; x <= n; x++)
            {
                mult[i - 1, x - 1] = i * x;
            }
        }

        Console.WriteLine("\nEl resultado es: \n");

        for (int i = 0; i < n; i++)
        {
            for (int x = 0; x < n; x++)
            {
                Console.Write(mult[i, x] + "\t");
            }
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}
