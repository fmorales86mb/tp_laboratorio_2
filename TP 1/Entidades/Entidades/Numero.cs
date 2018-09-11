using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /* Consultas:
     
     * Casteo implícito de Numero a double. 
    */
    public class Numero
    {
        private double numero;

        public Numero() : this(0) { }        

        public Numero(double numero)
        {
            this.numero = numero;
        }

        public Numero(string strNumero)
        {
            SetNumero(strNumero);
        }

        /// <summary>
        /// Asigna un valor al atributo numero, previa validación.
        /// </summary>
        /// <param name="strNumero"></param>
        public void SetNumero(string strNumero)
        {
            this.numero = ValidarNumero(strNumero);
        }

        /// <summary>
        ///  Comprueba que el valor recibido sea numérico.
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Valor en formato double. Si el parámetro pasado es inválido retorna cero.</returns>
        private double ValidarNumero (string strNumero)
        {
            double valor = 0;
            if (!string.IsNullOrEmpty(strNumero))
            {
                double.TryParse(strNumero, out valor);
            } 
            return valor;
        }

        /// <summary>
        /// Convierte un número binario a decimal.
        /// </summary>
        /// <param name="binario"></param>
        /// <returns>Si es posible retorna el valor en decimal con formato string. En caso contrario retorna "Valor inválido". </returns>
        public string BinarioDecimal(string binario)
        {
            return "";
        }

        /// <summary>
        ///  Convierte un número de decimal a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Valor en formato string. Si no es posible la conversión retorna "Valor inválido".</returns>
        public string DecimalBinario(string numero)
        {
            return "";
        }

        /// <summary>
        ///  Convierte un número de decimal a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Valor en formato string. Si no es posible la conversión retorna "Valor inválido".</returns>
        public string DecimalBinario(double numero)
        {
            return "";
        }

        // ver si corresponde 
        //public static implicit operator double(Numero nro)
        //{
        //    return nro.numero;
        //}

        public static double operator -(Numero nro1, Numero nro2)
        {
            return nro1.numero - nro2.numero;
        }

        public static double operator +(Numero nro1, Numero nro2)
        {
            return nro1.numero + nro2.numero;
        }

        public static double operator *(Numero nro1, Numero nro2)
        {
            return nro1.numero * nro2.numero;
        }

        public static double operator /(Numero nro1, Numero nro2)
        {
            double resultado = 0;
            if (nro2.numero != 0) resultado = nro1.numero / nro2.numero;
            return resultado;
        }
    }
}
