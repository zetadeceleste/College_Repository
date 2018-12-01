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
            List<int> numeros = new List<int>();
            string temp;
            int cant, num, sumaNum = 0;

            Console.WriteLine("Introduzca la cantidad de números a sumar:");
            temp = Console.ReadLine();
            cant = Int32.Parse(temp);

            for(int i = 0; i < cant; i++)
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

            foreach(int numero in numeros)
            {
                sumaNum += numero;
            }

            Console.WriteLine("La suma de los números enteros ingresados da: {0}" , sumaNum);
        }
    }
}
