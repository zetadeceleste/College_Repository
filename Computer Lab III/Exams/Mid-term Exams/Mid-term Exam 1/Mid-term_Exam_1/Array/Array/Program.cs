using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int filas, columnas, suma;
            string aux;

            Console.WriteLine("Ingrese el número de filas: ");
            aux = Console.ReadLine();
            filas = Int32.Parse(aux);
            Console.WriteLine("Ingrese el número de columnas: ");
            aux = Console.ReadLine();
            columnas = Int32.Parse(aux);

            int valorFmasC = (filas + columnas);
            string[,] matriz = new string[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    suma = (i + 1) + (j + 1);

                    if (valorFmasC == suma)
                    {
                        matriz[i, j] = "X";
                    }
                    else
                    {
                        matriz[i, j] = "O";
                    }
                }
            }
            Console.WriteLine("Matriz: \n");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
