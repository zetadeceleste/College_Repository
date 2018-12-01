using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioC
{
    class Program
    {
        static void Main(string[] args)
        {
            PubsTitlesDataContext data = new PubsTitlesDataContext();

            var query = (from t in data.GetTable<titles>()
                         select t.price).Average();
            
            Console.WriteLine("Promedio de Precio en Tabla Title: {0}", query);
            Console.ReadKey();
        }
    }
}
