using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Laboratorio3_ZapataCeleste
{
    class Sector
    {
        private string denominacion;
        private List<Empleado> empleados;

        public string getDenominacion()
        {
            return this.denominacion;
        }

        public void setDenominacion(string denominacion)
        {
            this.denominacion = denominacion;
        }

        public List<Empleado> getEmpleados()
        {
            return this.empleados;
        }

        public void setEmpleados(List<Empleado> empleados)
        {
            this.empleados = empleados;
        }
    
        public void verificarDNIEmpleados()
        {
            if(empleados != null)
            {
                foreach(Empleado empleado1 in empleados)
                {
                    foreach (Empleado empleado2 in empleados)
                    {
                        if (empleado2.getDni() == empleado1.getDni())
                        {
                            if (empleado2.getApellido() != empleado1.getApellido())
                            {
                                Console.WriteLine("Los Empleados {0} {1} y {2} {3} poseen el mismo DNI.", empleado1.getNombre(), empleado1.getApellido(), empleado2.getNombre(), empleado2.getApellido());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Los Empleados están correctamente cargados");
                        }
                    }
                } 
            }
            
        }
    }
}
