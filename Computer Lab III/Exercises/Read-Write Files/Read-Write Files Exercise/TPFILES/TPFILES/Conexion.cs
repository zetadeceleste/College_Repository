using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFILES
{
    public class Conexion
    {
        protected SqlConnection con = null;

        public SqlConnection conectar()
        {
            try
            {   //Data Source=localhost;Initial Catalog=Northwind;Integrated Security=True
                //con = new SqlConnection("Data Source=localhost\\SQLExpress;Initial Catalog=Northwind;Persist Security Info=True;User ID=SALA/electro;Password=");
                con = new SqlConnection("Data Source = localhost; Initial Catalog = Northwind; Integrated Security = True");
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return null;
            }

        }

        public bool desconectar()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
                return false;
            }

        }


    }
}
