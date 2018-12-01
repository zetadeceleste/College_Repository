using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta1 = new CuentaBancaria
            {
                titularCta = "Juan Alonso",
                cuit = "20-26987456-7",
                saldo = 1258.75,
                numeroCBU = 1236547896554
            };

            CuentaBancaria cuenta2 = new CuentaBancaria
            {
                titularCta = "Alberto Lopez",
                cuit = "23-15654321-9",
                saldo = 25698.78,
                numeroCBU = 9876546546557
            };
        }
    }
}
