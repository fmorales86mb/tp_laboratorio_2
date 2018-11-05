using EntidadesAbstractas;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        // Atributos
        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        // Constructores         
        static Profesor()
        {
            random = new Random();
        }

        private Profesor()
        {
            
        }

        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        // Métodos
        /// <summary>
        /// Asigna dos clases al azar al Profesor.
        /// </summary>
        private void _randomClases()
        {
            int nroClase = -1;
            for(int i =0; i<2; i++)
            {
                nroClase = random.Next(0, 2);
                this.clasesDelDia.Enqueue((Universidad.EClases)nroClase);
            }                        
        }

        /// <summary>
        /// Devuelve los datos del Profesor, sus clases del día.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Devuelve todos los datos del Profesor.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Retorna la cadena "CLASES DEL DÍA" junto al nombre de las clases que da.
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DÍA:");
            foreach (Universidad.EClases c in this.clasesDelDia)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Un Profesor es igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="p"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static bool operator==(Profesor p, Universidad.EClases c)
        {
            bool valRetorno = false;

            foreach(Universidad.EClases clase in p.clasesDelDia)
            {
                if (clase == c)
                {
                    valRetorno = true;
                    break;
                }
            }

            return valRetorno;
        }

        public static bool operator !=(Profesor p, Universidad.EClases c)
        {
            return !(p == c);
        }

    }
}
