using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio60
{
    public class ProductoDAO
    {
        public static bool Guardar(Producto p)
        {
            //StringBuilder texto = new StringBuilder();

            //texto.AppendFormat("INSERT INTO Production.Location (Name, CostRate, Availability, ModifiedDate) VALUES('{0}',{1},1,'{2}')",p.Nombre, p.CostRate, DateTime.Now);

            //return DAO.InsertaObjeto(texto.ToString());
            return DAO.InsertaObjeto(string.Format("INSERT INTO Production.Location (Name, CostRate, Availability, ModifiedDate) VALUES('{0}',{1},1,'{2}')", p.Nombre, p.CostRate, DateTime.Now));
        }


        public static Producto Leer()
        {
            Producto prod = null;
            SqlDataReader oDr;

            oDr = DAO.ObtieneObjeto(string.Format("SELECT TOP  Name,CostRate,Availability,ModifiedDate FROM Production.Location"));

            oDr.Read();

            prod = new Producto(oDr["Name"].ToString(), float.Parse(oDr["CostRate"].ToString()));

            oDr.Close();

            return prod;
        }
    }
}
