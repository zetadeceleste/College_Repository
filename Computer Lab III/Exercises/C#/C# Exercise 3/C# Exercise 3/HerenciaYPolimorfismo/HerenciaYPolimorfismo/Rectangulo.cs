using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaYPolimorfismo
{
    class Rectangulo : Figura
    {
        public override void Dibujar()
        {
            Console.WriteLine("Dibuja Rectángulo");
        }
    }
}
