using ClasesAbstractas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

//Clase Profesor:
// Atributos ClasesDelDia del tipo Cola y random del tipo Random y estático.
// Sobrescribir el método MostrarDatos con todos los datos del profesor.
// ParticiparEnClase retornará la cadena "CLASES DEL DÍA" junto al nombre de la clases que da.
// ToString hará públicos los datos del Profesor.
// Se inicializará a Random sólo en un constructor.
// En el constructor de instancia se inicializará ClasesDelDia y se asignarán dos clases al azar al Profesor mediante el método randomClases.Las dos clases pueden o no ser la misma.
// Un Profesor será igual a un EClase si da esa clase.

// ver constructores.

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

        public Profesor(int id, string nombre, string apellido, int dni, ENacionalidad nacionalidad)
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
            StringBuilder sb = new StringBuilder();
            
            foreach(Universidad.EClases c in this.clasesDelDia)
            {
                sb.AppendLine(c.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve todos los datos del Profesor.
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder(base.MostrarDatos());

            sb.AppendLine(this.ToString());

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
            sb.AppendLine(this.ToString());

            return sb.ToString();
        }
    }
}
