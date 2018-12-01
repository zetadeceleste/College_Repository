using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludos
{
  class Program
  {
    static void Main(string[] args)
    {
      String miNombre;
      Console.WriteLine("Por favor, escriba su nombre");
      miNombre = Console.ReadLine();
      Console.WriteLine("Hola {0}", miNombre);
      Console.ReadKey(); // Para que no se cierre la aplicación de golpe
    }
  }
}
