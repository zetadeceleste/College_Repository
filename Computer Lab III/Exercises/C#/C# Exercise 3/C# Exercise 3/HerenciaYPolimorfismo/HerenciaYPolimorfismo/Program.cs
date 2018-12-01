using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaYPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();
            Circulo circulo = new Circulo();
            Triangulo triangulo = new Triangulo();
            Rectangulo rectangulo = new Rectangulo();

            figuras.Add(circulo);
            figuras.Add(triangulo);
            figuras.Add(rectangulo);

            foreach(Figura figura in figuras)
            {
                figura.Dibujar();
            }
        }
    }
}
