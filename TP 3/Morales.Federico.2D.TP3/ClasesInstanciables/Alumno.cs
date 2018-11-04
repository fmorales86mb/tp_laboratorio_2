using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesAbstractas;
using ClasesInstanciables;

//Clase Alumno:
// Atributos ClaseQueToma del tipo EClase y EstadoCuenta del tipo EEstadoCuenta.
// Sobreescribirá el método MostrarDatos con todos los datos del alumno.
// ParticiparEnClase retornará la cadena "TOMA CLASE DE " junto al nombre de la clase que toma.
// ToString hará públicos los datos del Alumno.
// Un Alumno será igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
// Un Alumno será distinto a un EClase sólo si no toma esa clase.

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        public Alumno()
        {            
        }
        public Alumno(int id, string nombre, string apellido, int dni, ENacionalidad nacionalidad, 
            Universidad.EClases claseQueToma) 
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }
        public Alumno(int id, string nombre, string apellido, int dni, ENacionalidad nacionalidad, 
            Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta) 
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }


        /// <summary>
        /// Devuelve todos los datos del Alumno.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendLine(this.ToString());

            return sb.ToString();
        }
        /// <summary>
        /// Retorna la cadena "TOMA CLASE DE: " junto al nombre de la clase que toma.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return ("TOMA CLASES DE: " + this.claseQueToma.ToString());
        }
        /// <summary>
        /// Un Alumno es igual a un EClase si toma esa clase y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator == (Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor);
        }
        /// <summary>
        /// Un Alumno es distinto a un EClase sólo si no toma esa clase.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma != clase);
        }
        /// <summary>
        /// Retorna los datos del Alumno.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ESTADO DE CUENTA: " + this.estadoCuenta.ToString());
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }

        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }
    }
}
