using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_LINQ_ABM
{
    class GestorSupplier
    {
        private static SuppliersBDDataContext dataSource = new SuppliersBDDataContext();
        public static void insertar(Suppliers supplier)
        {

            dataSource.Suppliers.InsertOnSubmit(supplier);
            dataSource.SubmitChanges();
        }

        public static void actualizar(Suppliers supplier, int id)
        {
            var supplierQRY = (from sup in dataSource.Suppliers
                               where sup.SupplierID == id
                               select sup).Single();

            supplierQRY.CompanyName = supplier.CompanyName;
            supplierQRY.ContactName = supplier.ContactName;
            supplierQRY.ContactTitle = supplier.ContactTitle;
            supplierQRY.Address = supplier.Address;
            supplierQRY.City = supplier.City;
            supplierQRY.Region = supplier.Region;
            supplierQRY.PostalCode = supplier.PostalCode;
            supplierQRY.Country = supplier.Country;
            supplierQRY.Phone = supplier.Phone;
            supplierQRY.Fax = supplier.Fax;
            supplierQRY.HomePage = supplier.HomePage;
            dataSource.SubmitChanges();

        }

        public static void eliminar(Suppliers supplier)
        {
            var supplierQRY = (from sup in dataSource.Suppliers
                               where sup.SupplierID == supplier.SupplierID
                               select sup).Single();
            ;
            dataSource.Suppliers.DeleteOnSubmit(supplierQRY);
            dataSource.SubmitChanges();
        }

        public static IQueryable<Suppliers> filtrarXNombreCompañia(String companie)
        {
            //List<String> companies = filtrarCompanies();
            //List<Object> objetos = new List<Object>();

            //foreach (var i in companies)
            //{
            //   var qry = from sup in dataSource.Suppliers
            //            where sup.CompanyName == i
            //           select sup;
            // objetos.Add(qry);
            // }

            var qry = from sup in dataSource.Suppliers
                      where sup.CompanyName == companie
                      select sup
                ;


            return qry;
        }

        public static List<String> filtrarCompanies()
        {
            List<String> array = new List<String>();
            var qry = from sup in dataSource.Suppliers
                      group sup by sup.CompanyName into newGroup
                      select newGroup
                      ;

            foreach (var g in qry)
            {
                foreach (var c in g)
                {
                    if (!array.Contains(c.CompanyName))
                    {
                        array.Add(c.CompanyName);
                        //MessageBox.Show("Se ha agregado la ciudad: " + c.City);
                    }

                }
            }

            return array;
        }


    }
}
