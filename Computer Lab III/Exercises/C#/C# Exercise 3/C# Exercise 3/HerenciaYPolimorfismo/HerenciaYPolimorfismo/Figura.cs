using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaYPolimorfismo
{
    class Figura
    {
        public virtual void Dibujar()
        {
            Console.WriteLine("Dibuja Figura");
        }
    }
}
