using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo rectangulo = new Rectangulo()
            {
                ancho = 5,
                alto = 10
            };

            rectangulo.RetornarSuperficie();
            rectangulo.RetornarPerimetro();
        }
    }
}
