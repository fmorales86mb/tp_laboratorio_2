using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Clase Persona:
// Abstracta, con los atributos Nombre, Apellido, Nacionalidad y DNI.
// Se deberá validar que el DNI sea correcto, teniendo en cuenta su nacionalidad.
//      Argentino entre 1 y 89999999 y Extranjero entre 90000000 y 99999999. 
//      Caso contrario, se lanzará la excepción NacionalidadInvalidaException.
// Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanzará DniInvalidoException.
// Sólo se realizarán las validaciones dentro de las propiedades.
// Validará que los nombres sean cadenas con caracteres válidos para nombres.Caso contrario, no se cargará.
// ToString retornará los datos de la Persona.

namespace ClasesAbstractas
{
    public abstract class Persona
    {
        // Atributos
        private string apellido;
        private int dni;
        private ENacionalidad nacionalidad;
        private string nombre;

        // Propiedades
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                this.apellido = this.ValidarNombreApellido(value);
            }
        }

        public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }

        public ENacionalidad Nacionalidad
        {
            get
            {
                return this.nacionalidad;
            }
            set
            {
                this.nacionalidad = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = this.ValidarNombreApellido(value);
            }
        }

        public string StringToDNI
        {
            set
            {
                this.Dni = this.ValidarDni(this.Nacionalidad, value);
            }
        }

        // Constructores
        public Persona() { }

        public Persona(string nombre, string apellido, ENacionalidad nacionalidad)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Nacionalidad = nacionalidad;
        }

        public Persona(string nombre, string apellido, int dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)
        {
            this.Dni = dni;
        }

        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            :this(nombre, apellido, nacionalidad)
        {
            this.StringToDNI = dni;
        }

        // Métodos
        /// <summary>
        /// Retorna los datos de la Persona.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("NOMBRE COMPLETO: {0}, {1}", this.Apellido, this.Nombre);
            sb.AppendLine();
            sb.AppendFormat("NACIONALIDAD: {0}", this.Nacionalidad.ToString());
            
            return sb.ToString();
        }

        /// <summary>
        /// Se valida que el DNI sea correcto, teniendo en cuenta su nacionalidad. 
        /// Argentino entre 1 y 89999999 y Extranjero entre 90000000 y 99999999. 
        /// Caso contrario, se lanzará la excepción NacionalidadInvalidaException.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato">DNI a validar</param>
        /// <returns>Dni validado</returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int valorRetorno = 0;

            switch(nacionalidad)
            {
                case ENacionalidad.Argentino:
                    if (dato >= 1 && dato <= 89999999)
                    {
                        valorRetorno = dato;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    break;
                case ENacionalidad.Extranjero:
                    if (dato >= 90000000 && dato <= 99999999)
                    {
                        valorRetorno = dato;
                    }
                    else
                    {
                        throw new Exception();
                    }
                    break;
                default:
                    break;
            }

            return valorRetorno;
        }

        /// <summary>
        /// Se valida que el DNI sea correcto, teniendo en cuenta su nacionalidad.
        /// Si el DNI presenta un error de formato (más caracteres de los permitidos, letras, etc.) se lanza DniInvalidoException.
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns>Dni validado.</returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            string patternDniArgentino = @"^\d{1,8}$";
            string patternDniExtranjero = @"^\d{8}$";
            Regex rg;
            int valorRetorno = 0;

            switch (nacionalidad)
            {
                // Se repite código. Ver.
                case ENacionalidad.Argentino:
                    rg = new Regex(patternDniArgentino);
                    if (rg.IsMatch(dato))
                    {
                        valorRetorno = int.Parse(dato);
                    }
                    else
                    {
                        throw new Exception();
                    }
                    break;
                case ENacionalidad.Extranjero:
                    rg = new Regex(patternDniExtranjero);
                    if (rg.IsMatch(dato))
                    {
                        valorRetorno = int.Parse(dato);
                    }
                    else
                    {
                        throw new Exception();
                    }
                    break;
                default:
                    break;
            }
 
            return valorRetorno;
        }

        /// <summary>
        /// Valida que el nombre o apellido ingresado sea de sólo caracteres entre a-z y tenga al menos dos, 
        /// permitiendo mayúscula en el primer caracter.
        /// </summary>
        /// <param name="dato">Nombre o apellido a validar</param>
        /// <returns>Si el dato es válido lo retorna. Caso contrario retorna string.Empty</returns>
        private string ValidarNombreApellido(string dato)
        {
            string valorRetorno = string.Empty;
            string patternName = @"^[A-Za-z][a-z]+$";
            Regex rg = new Regex(patternName);

            if(rg.IsMatch(dato))
            {
                valorRetorno = dato;
            }

            return valorRetorno;
        }

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
    }
}
