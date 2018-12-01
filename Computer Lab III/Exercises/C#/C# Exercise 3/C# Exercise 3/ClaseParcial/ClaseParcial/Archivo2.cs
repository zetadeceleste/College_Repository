using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseParcial
{
    partial class Rectangulo
    {
        public double RetornarSuperficie()
        {
            double superficie;

            superficie = (this.ancho * this.alto);

            return superficie;
        }

        public double RetornarPerimetro()
        {
            double perimetro;

            perimetro = (this.ancho * 2) + (this.alto * 2);

            return perimetro;
        }
    }
}
