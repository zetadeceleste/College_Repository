using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            String temp;
            int valor, dimX = 0, dimY = 0;

            Console.WriteLine("Ingrese la cantidad de las filas de la Matriz: ");
            temp = Console.ReadLine();
            dimX = Int32.Parse(temp);
            Console.WriteLine("Ingrese la cantidad de las columnas de la Matriz: ");
            temp = Console.ReadLine();
            dimY = Int32.Parse(temp);
            int[,] matriz = new int[dimX, dimY];

            for (int i = 0; i < dimX; i++)
            {
                for(int j = 0; j < dimY; j++)
                {
                    valor = ((i + 1) + (j + 1));
                    matriz[i, j] = valor;
                }
            }

            for (int i = 0; i < dimX; i++)
            {
                for (int j = 0; j < dimY; j++)
                {
                    Console.WriteLine("Valor ({0}, {1}): {2}", (i + 1), (j + 1), matriz[i, j]);
                }
            }
        }
    }
}
