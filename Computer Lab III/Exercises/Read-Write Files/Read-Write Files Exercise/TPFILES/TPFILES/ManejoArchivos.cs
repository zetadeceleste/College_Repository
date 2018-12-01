using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFILES
{
    class ManejoArchivos
    {
        private Conexion conexion = new Conexion();

        public Conexion Conexion { get => conexion; set => conexion = value; }

        char[] caracteres = { '\t', '\n' };

        public void LeerArchivo()
        {
            StreamReader sr = new StreamReader("Customers.txt");
            try
            {
                string linea = sr.ReadLine();//leo hasta el salto de linea

                int clavePrimaria = 0;
                String[] palabras;
                while (linea != null)// Lee líneas mientras haya lineas (mientras sean !=null)
                {
                    String stmt = "INSERT INTO Customers (CustomerID, CompanyName, ContactName, ContactTitle, Address, City, Region, PostalCode, Country, Phone, Fax)"
                                         + " VALUES (@id, @compania, @contacto,@titulo,@direccion,@ciudad,@region,@codpostal,@pais,@telefono,@fax)";
                    SqlCommand cmd = new SqlCommand(stmt, Conexion.conectar());
                    
                    palabras = linea.Split(caracteres);
                    
                    for (int i = 0; i < palabras.Length; i++)
                    {

                        if (i == 0)
                        {
                            palabras[0] = "" + clavePrimaria++;
                        }
                        Console.WriteLine(palabras[i]);
                    }
                    Console.WriteLine(palabras.Length);

                    cmd.Parameters.AddWithValue("@id", palabras[0]);
                    cmd.Parameters.AddWithValue("@compania", palabras[1]);
                    cmd.Parameters.AddWithValue("@contacto", palabras[2]);
                    cmd.Parameters.AddWithValue("@titulo", palabras[3]);
                    cmd.Parameters.AddWithValue("@direccion", palabras[4]);
                    cmd.Parameters.AddWithValue("@ciudad", palabras[5]);
                    cmd.Parameters.AddWithValue("@region", palabras[6]);
                    cmd.Parameters.AddWithValue("@codpostal", palabras[7]);
                    cmd.Parameters.AddWithValue("@pais", palabras[8]);
                    cmd.Parameters.AddWithValue("@telefono", palabras[9]);
                    cmd.Parameters.AddWithValue("@fax", palabras[10]);
                    Console.WriteLine("-------------------");
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    cmd = null;
                    Conexion.desconectar();
                    linea = sr.ReadLine();//leo siguiente linea si existe
                }

                Console.ReadLine();
            }
            catch (SqlException e)
            {

                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally
            {
                Conexion.desconectar();
                sr.Close();
            }

        }

        public void EscribirArchivo()
        {
            StreamWriter sw = new StreamWriter("Customers.txt");
            Conexion = new Conexion();
            SqlConnection conexion = Conexion.conectar();
            try
            {

                SqlCommand qry = new SqlCommand("SELECT * FROM Customers", conexion);
                SqlDataReader reader = qry.ExecuteReader();

                while (reader.Read())
                {
                    sw.Write(String.Format($"{reader["CustomerID"]}\t"));
                    sw.Write(String.Format($"{reader["CompanyName"]}\t"));
                    sw.Write(String.Format($"{reader["ContactName"]}\t"));
                    sw.Write(String.Format($"{reader["ContactTitle"]}\t"));
                    sw.Write(String.Format($"{reader["Address"]}\t"));
                    sw.Write(String.Format($"{reader["City"]}\t"));
                    sw.Write(String.Format($"{reader["Region"]}\t"));
                    sw.Write(String.Format($"{reader["PostalCode"]}\t"));
                    sw.Write(String.Format($"{reader["Country"]}\t"));
                    sw.Write(String.Format($"{reader["Phone"]}\t"));
                    sw.Write(String.Format($"{reader["Fax"]}"));
                    sw.WriteLine();
                }



                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                Console.Read();
            }
            finally
            {
                Conexion.desconectar();
                sw.Close();
            }


        }
    }
}
