using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Clase Universitario:
// Abstracta, con el atributo Legajo.
// Método protegido y virtual MostrarDatos retornará todos los datos del Universitario.
// Método protegido y abstracto ParticiparEnClase.
// Dos Universitario serán iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.

// Ver Equals    

namespace ClasesAbstractas
{
    public abstract class Universitario : Persona
    {
        private int legajo;

        public Universitario()
        {
        }
        public Universitario(int legajo, string nombre, string apellido, int dni, ENacionalidad nacionalidad) 
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        /// <summary>
        /// Retorna todos los datos del Universitario.
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.ToString());

            sb.AppendLine("LEGAJO NÚMERO: " + this.legajo.ToString());

            return sb.ToString();
        }
        protected abstract string ParticiparEnClase();

        /// <summary>
        /// Dos Universitario son iguales si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            bool valorRetorno = false;

            if (pg1.legajo == pg2.legajo || pg1.Dni == pg2.Dni)
            {
                valorRetorno = pg1.Equals(pg2);
            }

            return valorRetorno;
        }
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return this.Equals(obj);
            //return base.Equals(obj);
        }
    }
}
