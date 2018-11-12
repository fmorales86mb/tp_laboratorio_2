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
        public static bool Insertar(Paquete p)
        {
            return true;
        }

        static PaqueteDAO()
        { }

    }
}
