using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase Persona:
// Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
// Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad.Argentino entre 1 y 89999999 y Extranjero entre 90000000 y 99999999. Caso contrario, se lanzará la excepción NacionalidadInvalidaException.
// Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanzará DniInvalidoException.
// Sólo se realizarán las validaciones dentro de las propiedades.
// Validará que los nombres sean cadenas con caracteres válidos para nombres.Caso contrario, no se cargará.
// ToString retornará los datos de la Persona.

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
