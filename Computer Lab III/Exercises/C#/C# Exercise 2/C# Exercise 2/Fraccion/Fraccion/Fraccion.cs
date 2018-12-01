using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraccion
{
    class Fraccion
    {
        private int num;
        private int den;

        public int getNum()
        {
            return this.num;
        }

        public void setNum(int num)
        {
            this.num = num;
        }

        public int getDen()
        {
            return this.den;
        }

        public void setDen(int den)
        {
            this.den = den;
        }

        public Fraccion sumaFracciones(Fraccion f)
        {
            Fraccion fresultado = new Fraccion();

            fresultado.setNum((this.num * f.getDen()) + (f.getNum() * this.den));
            fresultado.setDen((this.den * f.getDen()));

            return fresultado;
        }

        public Fraccion restaFracciones(Fraccion f)
        {
            Fraccion fresultado = new Fraccion();

            fresultado.setNum((this.num * f.getDen()) - (f.getNum() * this.den));
            fresultado.setDen((this.den * f.getDen()));

            return fresultado;
        }

        public Fraccion multiplicacionFracciones(Fraccion f)
        {
            Fraccion fresultado = new Fraccion();

            fresultado.setNum((this.num * f.getNum()));
            fresultado.setDen((this.den * f.getDen()));

            return fresultado;
        }

        public Fraccion divisionFracciones(Fraccion f)
        {
            Fraccion fresultado = new Fraccion();

            fresultado.setNum((this.num * f.getDen()));
            fresultado.setDen((this.den * f.getNum()));

            return fresultado;
        }
    }
}
