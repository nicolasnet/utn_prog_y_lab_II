using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;

namespace Ejercicio60
{
    public static class DAO
    {
        #region Atributos

        private static SqlConnection conexion;
        private static SqlCommand comando;

        #endregion

        #region Constructores

        static DAO()
        {
            // CREO UN OBJETO SQLCONECTION
            DAO.conexion = new SqlConnection("Data Source=LAB3PC05\\SQLEXPRESS;Initial Catalog=AdventureWorks2012;Integrated Security=True");
            
            // CREO UN OBJETO SQLCOMMAND
            DAO.comando = new SqlCommand();
            
            // INDICO EL TIPO DE COMANDO
            DAO.comando.CommandType = System.Data.CommandType.Text;
            
            // ESTABLEZCO LA CONEXION
            DAO.comando.Connection = DAO.conexion;

            // ABRO LA CONEXION
            DAO.conexion.Open();
        }

        #endregion


        #region Leer

        public static SqlDataReader ObtieneObjeto(string comandoTexto)
        {            
            try
            {
                // LE PASO LA INSTRUCCION SQL
                DAO.comando.CommandText = comandoTexto;

                // EJECUTO EL COMMAND                 
                SqlDataReader oDr = DAO.comando.ExecuteReader();

                /*
                // MIENTRAS TENGA REGISTROS...
                if (oDr.Read())
                {
                    // ACCEDO POR NOMBRE O POR INDICE
                    obj = new Object(int.Parse(oDr["id"].ToString()), oDr["nombre"].ToString(), oDr["apellido"].ToString(), int.Parse(oDr["dni"].ToString()));
                }

                //CIERRO EL DATAREADER
                oDr.Close();
                */               

                return oDr;
            }

            catch (Exception ex)
            {
                throw ex;
            }                      
        }

        #endregion



        #region Insertar

        public static bool InsertaObjeto(string comandoInsert)
        {
            return EjecutarNonQuery(comandoInsert);
        }

        #endregion


        #region Modificar

        public static bool ModificarObjeto(string comandoUpdate)
        {
            return EjecutarNonQuery(comandoUpdate);
        }

        #endregion


        #region Eliminar

        public static bool EliminarObjeto(string comandoDelete)
        {
            return EjecutarNonQuery(comandoDelete);
        }

        #endregion




        private static bool EjecutarNonQuery(string sql)
        { 
            try
            {
                // LE PASO LA INSTRUCCION SQL
                DAO.comando.CommandText = sql;
                
                // EJECUTO EL COMMAND
                DAO.comando.ExecuteNonQuery();

             return true;
            }
            catch (Exception e)
            {
                throw e;
            }           
        }
    }
}
