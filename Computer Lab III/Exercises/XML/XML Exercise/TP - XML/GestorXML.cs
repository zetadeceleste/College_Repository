using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace TP___XML
{
    class GestorXML
    {
        public void CrearDocumentoXML(string ubicacion)
        {
            XDocument miXML = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XElement("empleados",
                    new XElement("listado",
                        new XElement("empleado",
                            new XElement("id", "4884"),
                            new XElement("nombreCompleto", "Rodriguez, Victor"),
                            new XElement("cuil", "20103180326"),
                            new XElement("sector",
                                new XAttribute("denominacion", "Gerencia Recursos Humanos"),
                                new XAttribute("id", "137"),
                                new XAttribute("valorSemaforo", "130.13"),
                                new XAttribute("colorSemaforo", "VERDE")),
                            new XElement("cupoAsignado", "1837.15"),
                            new XElement("cupoConsumido", "658.02")),
                        new XElement("empleado",
                            new XElement("id", "1225"),
                            new XElement("nombreCompleto", "Sanchez, Juan Ignacio"),
                            new XElement("cuil", "20271265817"),
                            new XElement("sector",
                                new XAttribute("denominacion", "Gerencia Operativa"),
                                new XAttribute("id", "44"),
                                new XAttribute("valorSemaforo", "130.13"),
                                new XAttribute("colorSemaforo", "ROJO")),
                            new XElement("cupoAsignado", "750.87"),
                            new XElement("cupoConsumido", "625.46"))),
                    new XElement("subsectores", "5"),
                    new XElement("totalCupoAsignadoSector", "4217.21"),
                    new XElement("totalCupoConsumidoSector", "1405.88"),
                    new XElement("valorDial", "33.34"))
            );
            miXML.Save(ubicacion);
        }        

        public void CrearDocumentoXMLTextWriter(string ubicacion)
        {
            XmlTextWriter writer;
            writer = new XmlTextWriter(ubicacion,Encoding.UTF8);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();

            writer.WriteStartElement("empleados");

                writer.WriteStartElement("listado");

                    writer.WriteStartElement("empleado");
                    writer.WriteElementString("id", "4884");
                    writer.WriteElementString("nombreCompleto", "Rodriguez, Victor");
                    writer.WriteElementString("cuil", "20103180326");
                    writer.WriteStartElement("sector");
                    writer.WriteAttributeString("denominacion", "Gerencia Recursos Humanos");
                    writer.WriteAttributeString("id", "137");
                    writer.WriteAttributeString("valorSemaforo", "130.13");
                    writer.WriteAttributeString("colorSemaforo", "VERDE");
                    writer.WriteEndElement();
                    writer.WriteElementString("cupoAsignado", "1837.15");
                    writer.WriteElementString("cupoConsumido", "658.02");
                    writer.WriteEndElement();

                    writer.WriteStartElement("empleado");
                    writer.WriteElementString("id", "1225");
                    writer.WriteElementString("nombreCompleto", "Sanchez, Juan Ignacio");
                    writer.WriteElementString("cuil", "20271265817");
                    writer.WriteStartElement("sector");
                    writer.WriteAttributeString("denominacion", "Gerencia Operativa");
                    writer.WriteAttributeString("id", "44");
                    writer.WriteAttributeString("valorSemaforo", "130.13");
                    writer.WriteAttributeString("colorSemaforo", "ROJO");
                    writer.WriteEndElement();
                    writer.WriteElementString("cupoAsignado", "750.87");
                    writer.WriteElementString("cupoConsumido", "625.46");
                    writer.WriteEndElement();
            
                writer.WriteEndElement();
                writer.WriteElementString("subsectores", "5");
                writer.WriteElementString("totalCupoAsignadoSector", "4217.21");
                writer.WriteElementString("totalCupoConsumidoSector", "1405.88");
                writer.WriteElementString("valorDial", "33.34");

            writer.WriteEndElement();

            writer.WriteEndDocument();
            writer.Close();
        }

        public void LeerDocumentoXML(string ubicacion)
        {
            XmlDocument docXML = new XmlDocument();
            docXML.Load(ubicacion);

            XmlNodeList empleados = docXML.GetElementsByTagName("empleados");
            XmlNodeList lista = ((XmlElement)empleados[0]).GetElementsByTagName("empleado");

            foreach (XmlElement nodo in lista)
            {                
                XmlNodeList id = nodo.GetElementsByTagName("id");
                XmlNodeList nombreCompleto = nodo.GetElementsByTagName("nombreCompleto");
                XmlNodeList cuil = nodo.GetElementsByTagName("cuil");                
                XmlNodeList sector = nodo.GetElementsByTagName("sector");
                XmlNodeList cupoAsignado = nodo.GetElementsByTagName("cupoAsignado");
                XmlNodeList cupoConsumido = nodo.GetElementsByTagName("cupoConsumido");

                Console.WriteLine("ID: " + id[0].InnerText +
                                "\nNombreCompleto: " + nombreCompleto[0].InnerText +
                                "\nCuil: " + cuil[0].InnerText +
                                "\nSector: " + ((XmlElement)sector[0]).GetAttribute("denominacion") + 
                                "\n\tID: " + ((XmlElement)sector[0]).GetAttribute("id") + 
                                "\n\tValor Semaforo: " + ((XmlElement)sector[0]).GetAttribute("valorSemaforo") +
                                "\n\tColor Semaforo: " + ((XmlElement)sector[0]).GetAttribute("colorSemaforo") + 
                                "\nCupo Asignado: " + cupoAsignado[0].InnerText + 
                                "\nCupo Consumido: " + cupoConsumido[0].InnerText + "\n");
            }

            XmlNodeList subsectores = ((XmlElement)empleados[0]).GetElementsByTagName("subsectores");
            XmlNodeList totalCupoAsignadoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoAsignadoSector");
            XmlNodeList totalCupoConsumidoSector = ((XmlElement)empleados[0]).GetElementsByTagName("totalCupoConsumidoSector");
            XmlNodeList valorDial = ((XmlElement)empleados[0]).GetElementsByTagName("valorDial");

            Console.WriteLine("Subsectores: " + subsectores[0].InnerText + 
                            "\nTotal Cupo Asignado por Sector:" + totalCupoAsignadoSector[0].InnerText + 
                            "\nTotal Cupo Consumido por Sector: " + totalCupoConsumidoSector[0].InnerText + 
                            "\nValor Dial: " + valorDial[0].InnerText + "\n\n\n\n\n");
        }

        public void LeerDocumentoXMLTextReader(string ubicacion)
        {
            XmlReader reader = XmlReader.Create(ubicacion);
            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    switch (reader.Name)
                    {                   
                        case "id":                            
                            if (reader.Read())
                            {
                                Console.WriteLine("ID: " + reader.Value.Trim());
                            }
                                break;
                        case "nombreCompleto":
                            if (reader.Read())
                            {
                                Console.WriteLine("Nombre Completo: " + reader.Value.Trim());
                            }
                            break;
                        case "cuil":
                            if (reader.Read())
                            {
                                Console.WriteLine("Cuil: " + reader.Value.Trim());
                            }
                            break;
                        case "sector":
                            string denominacion = reader["denominacion"];
                            string id = reader["id"];
                            string valorSemaforo = reader["valorSemaforo"];
                            string colorSemaforo = reader["colorSemaforo"];

                            Console.WriteLine("\nSector: " + denominacion +
                                              "\n\tID: " + id +
                                              "\n\tValor Semaforo: " + valorSemaforo +
                                              "\n\tColor Semaforo: " + colorSemaforo);
                            

                                break;
                        case "cupoAsignado":
                            if (reader.Read())
                            {
                                Console.WriteLine("Cupo Asignado: " + reader.Value.Trim());
                            }
                            break;
                        case "cupoConsumido":
                            if (reader.Read())
                            {
                                Console.WriteLine("Cupo Consumido: " + reader.Value.Trim() + "\n");
                            }
                            break;
                        case "subsectores":
                            if (reader.Read())
                            {
                                Console.WriteLine("Subsectores " + reader.Value.Trim());
                            }
                            break;
                        case "totalCupoAsignadoSector":
                            if (reader.Read())
                            {
                                Console.WriteLine("Total Cupo Asignado por Sector: " + reader.Value.Trim());
                            }
                            break;
                        case "totalCupoConsumidoSector":
                            if (reader.Read())
                            {
                                Console.WriteLine("Total Cupo Consumido por Sector: " + reader.Value.Trim());
                            }
                            break;
                        case "valorDial":
                            if (reader.Read())
                            {
                                Console.WriteLine("Valor Dial: " + reader.Value.Trim());
                            }
                            break;
                    }
                }
            }
        }
    }
}
