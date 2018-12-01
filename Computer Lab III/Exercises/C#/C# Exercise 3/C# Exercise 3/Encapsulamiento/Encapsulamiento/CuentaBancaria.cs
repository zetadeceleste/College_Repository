using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class CuentaBancaria
    {
        private string titularCta;
        private string cuit;
        private double saldo;
        private long numeroCBU;

        public string getTitularCta()
        {
            return this.titularCta;
        }

        public void setTitularCta(string titularCta)
        {
            this.titularCta = titularCta;
        }

        public string getCuit()
        {
            return this.cuit;
        }

        public void setCuit(string cuit)
        {
            this.cuit = cuit;
        }

        public double getSaldo()
        {
            return this.saldo;
        }

        public void setSaldo(double saldo)
        {
            this.saldo = saldo;
        }

        public long getNumeroCBU()
        {
            return this.numeroCBU;
        }

        public void setNumeroCBU(long numeroCBU)
        {
            this.numeroCBU = numeroCBU;
        }
    }
}
