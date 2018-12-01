using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_WriteFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Celes\Desktop\archivo.txt"))
            {
                sw.Write("Carlos,Lopez,29118614,Salta#Jose,Sanchez,11045855,Cordoba#Luis,Perez,08654789,Misiones#Alberto,Tobares,15654258,Mendoza");
            }
            using (StreamReader sr = new StreamReader(@"C:\Users\Celes\Desktop\archivo.txt"))
            {
                string line;
                string cadena;
                while ((line = sr.ReadLine()) != null)
                {
                    cadena = line.Replace("#", "\n").Replace(",", "  ");
                    Console.WriteLine(cadena);
                }
            }
        }
    }
}
