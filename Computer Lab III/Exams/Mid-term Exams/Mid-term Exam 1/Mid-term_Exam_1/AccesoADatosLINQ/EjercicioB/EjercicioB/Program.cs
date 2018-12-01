using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioB
{
    class Program
    {
        static void Main(string[] args)
        {
            PubsStoresDataContext data = new PubsStoresDataContext();

            var queryMax = (from s in data.GetTable<stores>()
                            select s.zip).Max();

            var queryMin = (from s in data.GetTable<stores>()
                            select s.zip).Min();

            Console.WriteLine("Máximo valor ZIP: {0}\nMínimo valor ZIP: {1}", queryMax, queryMin);
            Console.ReadKey();
        }
    }
}
