using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos
{
    class Program
    {
        static void ejecutarHilo()
        {
            //Hacer que se tarde 30000 milisegundos (30 segundos) 
            Thread.Sleep(30000);
            Console.WriteLine("HILO EJECUTADO");
        }
        static void Main(string[] args)
        {
            while(true)
            {
                ejecutarHilo();
            }
        }
    }
}
