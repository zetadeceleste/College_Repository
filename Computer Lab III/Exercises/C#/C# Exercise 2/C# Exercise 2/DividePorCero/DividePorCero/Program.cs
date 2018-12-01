using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DividePorCero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba el primer entero");
                string temp = Console.ReadLine();
                int i = Int32.Parse(temp);
                Console.WriteLine("Escriba el segundo entero");
                temp = Console.ReadLine();
                int j = Int32.Parse(temp);
                int k = i / j;
                Console.WriteLine("El resultado de dividir {0} por {1} es {2}", i, j, k);
}
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}
