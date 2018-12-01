using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumaEnteros
{
    class Program
    {
        static void Main(string[] args)
        {

            //El bloque Finally se ejecuta siempre
            //NO se puede poner un bloque Finally sin un try
            //SI se puede poner un bloque Finally sin un catch

            try
            {
                List<int> numeros = new List<int>();
                string temp;
                int cant, num, sumaNum = 0;

                Console.WriteLine("Introduzca la cantidad de números a sumar:");
                temp = Console.ReadLine();
                cant = Int32.Parse(temp);

                for (int i = 0; i < cant; i++)
                {
                    try
                    {
                        Console.WriteLine("Introduzca el {0}º número entero: ", (i + 1));
                        temp = Console.ReadLine();
                        num = Int32.Parse(temp);
                        numeros.Add(num);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: {0}", e.Message);
                    }
                }

                foreach (int numero in numeros)
                {
                    sumaNum += numero;
                }

                Console.WriteLine("La suma de los números enteros ingresados da: {0}", sumaNum);
            }
            finally
            {
                Console.WriteLine("FIN DEL PROGRAMA.");
            }
        }
    }
}
