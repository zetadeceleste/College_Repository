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
            CuentaBancaria cuenta1 = new CuentaBancaria();
            cuenta1.setTitularCta("Juan Alonso");
            cuenta1.setCuit("20-26987456-7");
            cuenta1.setSaldo(1258.75);
            cuenta1.setNumeroCBU(1236547896554);

            CuentaBancaria cuenta2 = new CuentaBancaria();
            cuenta2.setTitularCta("Alberto Lopez");
            cuenta2.setCuit("23-15654321-9");
            cuenta2.setSaldo(25698.78);
            cuenta2.setNumeroCBU(9876546546557);
        }
    }
}
