using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilo
{
    class Program
    {
        static void ejecutarHilo()
        {
            Thread.Sleep(5000);
            Console.WriteLine("HILO EJECUTADO");
        }

        static void Main(string[] args)
        {
            while (true)
            {
                ejecutarHilo();
            }
        }
    }
}
