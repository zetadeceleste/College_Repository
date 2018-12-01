using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionACSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int a, b, c, d;
                string aux;
                Console.WriteLine("Ingrese 4 números enteros: ");
                Console.WriteLine("Número a: ");
                aux = Console.ReadLine();
                a = Int32.Parse(aux);
                Console.WriteLine("Número b: ");
                aux = Console.ReadLine();
                b = Int32.Parse(aux);
                Console.WriteLine("Número c: ");
                aux = Console.ReadLine();
                c = Int32.Parse(aux);
                Console.WriteLine("Número d: ");
                aux = Console.ReadLine();
                d = Int32.Parse(aux);

                int formula = (((a * a) + (b * b)) / c) - d;

                if (formula < 0)
                {
                    Console.WriteLine("El resultado de la formula no puede ser negativo. Inténtelo nuevamente.");
                    continue;
                }
                else if (formula > 10000)
                {
                    Console.WriteLine("“El resultado de la formula supera el máximo esperado. Inténtelo nuevamente.");
                    continue;
                }
                else
                {
                    Console.WriteLine("Resultado de la fórmula: {0}", formula);
                    break;
                }
            }
        }
    }
}
