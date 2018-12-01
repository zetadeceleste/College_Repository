using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP___XML
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorXML gestorXML = new GestorXML();
            gestorXML.CrearDocumentoXML(@"C:\Users\Celes\Desktop\miXML.xml");
            gestorXML.CrearDocumentoXMLTextWriter(@"C:\Users\Celes\Desktop\miXMLTextWriter.xml");
            gestorXML.LeerDocumentoXML(@"C:\Users\Celes\Desktop\miXML.xml");
            gestorXML.LeerDocumentoXMLTextReader(@"C:\Users\Celes\Desktop\miXMLTextWriter.xml");
        }   
    }
}
