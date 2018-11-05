using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

//Clase Jornada:
// Atributos Profesor, Clase y Alumnos que toman dicha clase.
// Se inicializará la lista de alumnos en el constructor por defecto.
// Una Jornada será igual a un Alumno si el mismo participa de la clase.
// Agregar Alumnos a la clase por medio del operador +, validando que no estén previamente cargados.
// ToString mostrará todos los datos de la Jornada.
// Guardar de clase guardará los datos de la Jornada en un archivo de texto.
// Leer de clase retornará los datos de la Jornada como texto.

namespace ClasesInstanciables
{
    [Serializable]
    public class Jornada
    {
        // Atributos    
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        // Propiedades
        public List<Alumno> Alumnos
        {
            get
            {
                return this.alumnos;
            }
            set
            {
                this.alumnos = value;
            }
        }

        public Universidad.EClases Clase
        {
            get
            {
                return this.clase;
            }
            set
            {
                this.clase = value;
            }
        }

        public Profesor Instructor
        {
            get
            {
                return this.instructor;
            }
            set
            {
                this.instructor = value;
            }
        }

        // Constructores
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor)
            : this()
        {
            this.Clase = clase;
            this.Instructor = instructor;
        }

        // Métodos
        /// <summary>
        /// Guarda los datos de la Jornada en un archivo de texto.        
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto writer = new Texto();
            return writer.Guardar("Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Retorna los datos de la Jornada como texto.
        /// </summary>
        /// <returns></returns>
        public static string Leer()
        {
            string datos;
            Texto writer = new Texto();
            writer.Leer("archivoJornada.txt", out datos);
            return datos;
        }

        /// <summary>
        /// Muestra todos los datos de la Jornada.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("JORNADA:");
            sb.AppendFormat("CLASE DE {0} POR {1}", this.Clase.ToString(), this.Instructor.ToString());
            sb.AppendLine("ALUMNOS:");
            foreach (Alumno a in this.Alumnos)
            {
                sb.AppendLine(a.ToString());
            }
            sb.AppendLine("<----------------------------------------------->");

            return sb.ToString();
        }

        /// <summary>
        /// Una Jornada será igual a un Alumno si el mismo participa de la clase.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator == (Jornada j, Alumno a)
        {
            bool valorRetorno = false;

            foreach(Alumno alumno in j.Alumnos)
            {
                if (alumno == a)
                {
                    valorRetorno = true;
                    break;
                }
            }

            return valorRetorno;
        }

        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega Alumnos a la clase por medio del operador +, validando que no estén previamente cargados.
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.Alumnos.Add(a);
            else
                throw new AlumnoRepetidoException();

            return j;
        }
    }
}
