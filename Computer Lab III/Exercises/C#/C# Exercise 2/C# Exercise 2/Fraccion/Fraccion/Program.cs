using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraccion
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Fraccion> fracciones = new List<Fraccion>();
            string temp;
            int num, den;

            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("Escriba el numeral (entero) de la {0}º fracción", (i + 1));
                temp = Console.ReadLine();
                num = Int32.Parse(temp);
                Console.WriteLine("Escriba el denominador (entero) de la {0}º fracción", (i + 1));
                temp = Console.ReadLine();
                den = Int32.Parse(temp);

                while (den == 0)
                {
                    Console.WriteLine("El número 0 no es permitido como denominador.");
                    Console.WriteLine("Escriba el denominador (entero) de la fracción");
                    temp = Console.ReadLine();
                    den = Int32.Parse(temp);
                }

                Fraccion fraccion = new Fraccion();
                fraccion.setNum(num);
                fraccion.setDen(den);
                fracciones.Add(fraccion);
            }
            
            try
            {
                Fraccion fraccionSuma = new Fraccion();
                fraccionSuma = fracciones[0].sumaFracciones(fracciones[1]);
                Console.WriteLine("El resultado de sumar la 1º Fraccion {0}/{1} por la 2º Fraccion {2}/{3} es {4}/{5}", fracciones[0].getNum(), fracciones[0].getDen(), fracciones[1].getNum(), fracciones[1].getDen(), fraccionSuma.getNum(), fraccionSuma.getDen());

                Fraccion fraccionResta = new Fraccion();
                fraccionResta = fracciones[0].restaFracciones(fracciones[1]);
                Console.WriteLine("El resultado de restar la 1º Fraccion {0}/{1} por la 2º Fraccion {2}/{3} es {4}/{5}", fracciones[0].getNum(), fracciones[0].getDen(), fracciones[1].getNum(), fracciones[1].getDen(), fraccionResta.getNum(), fraccionResta.getDen());

                Fraccion fraccionMultiplicar = new Fraccion();
                fraccionMultiplicar = fracciones[0].multiplicacionFracciones(fracciones[1]);
                Console.WriteLine("El resultado de restar la 1º Fraccion {0}/{1} por la 2º Fraccion {2}/{3} es {4}/{5}", fracciones[0].getNum(), fracciones[0].getDen(), fracciones[1].getNum(), fracciones[1].getDen(), fraccionMultiplicar.getNum(), fraccionMultiplicar.getDen());

                Fraccion fraccionDividir = new Fraccion();
                fraccionDividir = fracciones[0].divisionFracciones(fracciones[1]);
                Console.WriteLine("El resultado de restar la 1º Fraccion {0}/{1} por la 2º Fraccion {2}/{3} es {4}/{5}", fracciones[0].getNum(), fracciones[0].getDen(), fracciones[1].getNum(), fracciones[1].getDen(), fraccionDividir.getNum(), fraccionDividir.getDen());
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
        }
    }
}
