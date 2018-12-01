using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parcial1Laboratorio3_ZapataCeleste
{
    class Program
    {

        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado();
            Empleado emp2 = new Empleado();
            Sector sector1 = new Sector();

            emp1.setNombre("Celeste");
            emp1.setApellido("Zapata");
            emp1.setDni(34068414L);
            
            emp2.setNombre("Florencia");
            emp2.setApellido("Dolcemascolo");
            emp2.setDni(34068418L);

            List<Empleado> empleados = new List<Empleado>();
            empleados.Add(emp1);
            empleados.Add(emp2);

            sector1.setEmpleados(empleados);
            sector1.verificarDNIEmpleados();
        }
    }
}
