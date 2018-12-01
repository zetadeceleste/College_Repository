using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFILES
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos archivo = new ManejoArchivos();
            //archivo.EscribirArchivo();
            archivo.LeerArchivo();
        }
    }
}
