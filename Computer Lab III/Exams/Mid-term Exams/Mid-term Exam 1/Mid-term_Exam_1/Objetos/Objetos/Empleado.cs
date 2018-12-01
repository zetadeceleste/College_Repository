using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1Laboratorio3_ZapataCeleste
{
    class Empleado
    {
        private string nombre;
        private string apellido;
        private double dni;
        private Sector sector;

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }

        public void setApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public double getDni()
        {
            return this.dni;
        }

        public void setDni(double dni)
        {
            this.dni = dni;
        }

        public Sector getSector()
        {
            return this.sector;
        }

        public void setSector(Sector sector)
        {
            this.sector = sector;
        }
    }
}
