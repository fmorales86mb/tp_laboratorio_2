using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//PaqueteDAO
//Clase estática que se encargará de guardar los datos de un paquete en la base de datos provista.
//A.De surgir cualquier error con la carga de datos, se deberá lanzar una excepción y controlarla en el método 
//  que la haya llamado, sin realizar ninguna acción con esta.
//B.El campo alumno de la base de datos deberá contener el nombre del alumno que está realizando el examen.

namespace Entidades
{
    public static class PaqueteDAO
    {
        private static string StrConection;          
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

            SqlCommand command = new SqlCommand(query, Con);
            
            try
            {
                Con.Open();
                if (command.ExecuteNonQuery() > 0)
                    insertado = true;                
            }
            catch
            {                
                insertado = false;
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
            StrConection = @"Data Source=.\SQLEXPRESS;Initial Catalog=correo-sp-2017;Integrated Security=True";
            Con = new SqlConnection(StrConection);
        }
    }
}
