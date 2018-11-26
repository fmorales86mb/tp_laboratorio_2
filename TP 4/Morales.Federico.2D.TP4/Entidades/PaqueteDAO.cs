using System;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static SqlCommand comando;     
        private static SqlConnection Con;

        /// <summary>
        /// Se encarga de guardar los datos de un Paquete en la base de datos.
        /// </summary>
        /// <param name="p"></param>
        /// <returns>True si guardó correctamente, caso contrario retorna False.</returns>
        public static bool Insertar(Paquete p)
        {
            bool insertado = false;
            string query = string.Format("insert into dbo.Paquetes values('{0}', '{1}', 'MoralesFederico')",
                p.DireccionEntrega, p.TrackingId);

            comando = new SqlCommand(query, Con);
            
            try
            {
                Con.Open();
                if (comando.ExecuteNonQuery() > 0)
                    insertado = true;                
            }
            catch (Exception e)
            {
                throw e;                
            }
            finally
            {
                if (Con.State != System.Data.ConnectionState.Closed)
                    Con.Close();
            }
           
            return insertado;
        }

        static PaqueteDAO()
        {
            string StrConection = @"Data Source=.\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True";
            Con = new SqlConnection(StrConection);
            comando = null;
        }
    }
}
