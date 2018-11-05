using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;

//Clase Universidad:
// Atributos Alumnos(lista de inscriptos), Profesores(lista de quienes pueden dar clases) y Jornadas.
// Se accederá a una Jornada específica a través de un indexador.
// Un Universidad será igual a un Alumno si el mismo está inscripto en él.
// Un Universidad será igual a un Profesor si el mismo está dando clases en él.
// Al agregar una clase a un Universidad se deberá generar y agregar una nueva Jornada 
    // indicando la clase, un Profesor que pueda darla (según su atributo ClasesDelDia) 
    // y la lista de alumnos que la toman(todos los que coincidan en su campo ClaseQueToma).
// Se agregarán Alumnos y Profesores mediante el operador +, validando que no estén previamente cargados.
// La igualación entre un Universidad y una Clase retornará el primer Profesor capaz de dar esa clase.
    //Sino, lanzará la Excepción SinProfesorException.El distinto retornará el primer Profesor que no pueda dar la clase.
// MostrarDatos será privado y de clase. Los datos del Universidad se harán públicos mediante ToString.
// Guardar de clase serializará los datos del Universidad en un XML, incluyendo todos los datos de sus Profesores, Alumnos y Jornadas.
// Leer de clase retornará un Universidad con todos los datos previamente serializados.

namespace ClasesInstanciables
{
    [Serializable]
    public class Universidad
    {
        // Atributos
        private List<Alumno> alumnos;
        private List<Jornada> jornada;
        private List<Profesor> profesores;

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

        public List<Jornada> Jornadas
        {
            get
            {
                return this.jornada;
            }
            set
            {
                this.jornada = value;
            }
        }

        public List<Profesor> Profesores
        {
            get
            {
                return this.profesores;
            }
            set
            {
                this.profesores = value;
            }
        }

        /// <summary>
        /// Se accede a una Jornada específica a través de un indexador.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Jornada this[int i]
        {
            get
            {
                return this.Jornadas[i];
            }
            set
            {
                this.Jornadas[i] = value;
            }

        }

        // Constructores
        public Universidad ()
        {
            this.alumnos = new List<Alumno>();
            this.jornada = new List<Jornada>();
            this.profesores = new List<Profesor>();
        }

        // Métodos
        /// <summary>
        /// Serializa los datos del Universidad en un XML, incluyendo todos los datos de sus Profesores, Alumnos y Jornadas.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns>True si se serializó correctamente.</returns>
        public static bool Guardar (Universidad uni)
        {
            Xml<Universidad> serializador = new Xml<Universidad>();
            return serializador.Guardar("archivoUni", uni);
        }

        /// <summary>
        /// Retorna un Universidad con todos los datos previamente serializados.
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        public static Universidad Leer ()
        {
            Xml<Universidad> serializador = new Xml<Universidad>();
            serializador.Leer("archivoUni", out Universidad uni);
            return uni;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uni"></param>
        /// <returns></returns>
        private static string MostrarDatos(Universidad uni)
        {
            StringBuilder sb = new StringBuilder();

            foreach(Profesor p in uni.Profesores)
            {
                sb.AppendLine(p.ToString());
            }
            foreach(Alumno a in uni.Alumnos)
            {
                sb.AppendLine(a.ToString());
            }
            foreach(Jornada j in uni.Jornadas)
            {
                sb.AppendLine(j.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Se muestran los datos de la Universidad.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return MostrarDatos(this);
        }

        /// <summary>
        /// Una Universidad es igual a un Alumno si el mismo está inscripto en él.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator == (Universidad u, Alumno a)
        {
            bool valorRetorno = false;

            foreach(Alumno alumno in u.Alumnos)
            {
                if (alumno == a)
                {
                    valorRetorno = true;
                    break;
                }
            }

            return valorRetorno;
        }

        public static bool operator !=(Universidad u, Alumno a)
        {
            return !(u == a);
        }

        /// <summary>
        /// Agrega al Alumno validando que no esté previamente cargado.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Alumno a)
        {
            if (u != a)
                u.Alumnos.Add(a);

            return u;
        }

        /// <summary>
        /// Una Universidad es igual a un Profesor si el mismo está dando clases en él.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Universidad u, Profesor p)
        {
            bool valorRetorno = false;

            foreach (Profesor profe in u.Profesores)
            {
                if (profe == p)
                {
                    valorRetorno = true;
                    break;
                }
            }

            return valorRetorno;
        }

        public static bool operator !=(Universidad u, Profesor p)
        {
            return !(u == p);
        }

        /// <summary>
        /// Agrega al Profesor validando que no esté previamente cargado.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, Profesor p)
        {
            if (u != p)
                u.Profesores.Add(p);

            return u;
        }

        /// <summary>
        /// Retorna el primer Profesor capaz de dar la clase pasada como parámetro. 
        /// Sino, lanzará la Excepción SinProfesorException.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Profesor operator ==(Universidad u, EClases c)
        {
            foreach(Profesor p  in u.Profesores)
            {
                if(p == c)
                {
                    return p;
                }
            }

            throw new SinProfesorExeption();
        }

        /// <summary>
        /// Retorna el primer Profesor que no pueda dar la clase.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Profesor operator !=(Universidad u, EClases c)
        {
            foreach (Profesor p in u.Profesores)
            {
                if (p != c)
                {
                    return p;
                }
            }

            throw new SinProfesorExeption();
        }

        /// <summary>
        /// Al agregar una clase a un Universidad se genera y agrega una nueva Jornada 
        /// indicando la clase, un Profesor que pueda darla y la lista de alumnos que la toman.
        /// </summary>
        /// <param name="u"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static Universidad operator +(Universidad u, EClases c)
        {
            Profesor p = u == c;
            Jornada j = new Jornada(c, p);

            foreach(Alumno a in u.Alumnos)
            {
                if (a == c)
                    j += a;
            }

            u.Jornadas.Add(j);

            return u;
        }

        // Enumerable
        public enum EClases
        {
            Programacion,
            Laboratorio,
            Legislacion,
            SPD
        }
    }
}
