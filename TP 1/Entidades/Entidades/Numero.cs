using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
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
            if (!string.IsNullOrEmpty(strNumero) && !strNumero.Contains("."))
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
        public string BinarioDecimal(string valor)
        {
            int acumuladorEntero = 0;
            bool esNegativo = valor.StartsWith("-");
            double acumuladorFraccional = 0;
            int nro;
            int factorProducto;
            int j;

            string[] enteroFraccional = valor.Split(',');
            j = enteroFraccional[0].Length - 1;

            // Parte entera.
            for (int i = 0; i < enteroFraccional[0].Length; i++, j--)
            {
                // voy de derecha a izquierda. El factor arranca en 1 con i = 0
                factorProducto = (int)Math.Pow(2, i);

                // La toma de dígitos es de derecha a izquierda. con j igual al último índice del string.
                if (int.TryParse((enteroFraccional[0][j]).ToString(), out nro))
                {
                    acumuladorEntero += nro * factorProducto;
                }
            }

            // Parte Fraccional.
            if (enteroFraccional.GetLength(0) == 2) //Chequeo que exista el índice 1.
            {
                for (int i = 0; i < enteroFraccional[1].Length; i++)
                {
                    factorProducto = (int)Math.Pow(2, i + 1);

                    if (int.TryParse(enteroFraccional[1][i].ToString(), out nro))
                    {
                        acumuladorFraccional += (double)nro / factorProducto;
                    }
                    else
                    {
                        acumuladorFraccional = 0;
                        break;
                    }
                }
            }

            double resultado = esNegativo ? (acumuladorEntero + acumuladorFraccional) * (-1) : 
                acumuladorEntero + acumuladorFraccional;
            return resultado.ToString();
        }

        /// <summary>
        ///  Convierte un número de decimal a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Valor en formato string. Si no es posible la conversión retorna "Valor inválido".</returns>
        public string DecimalBinario(string numero)
        {
            double nro;
            string retorno;

            if (double.TryParse(numero, out nro))            
                retorno = this.DecimalBinario(nro);           
            else retorno = ("Valor inválido");

            return retorno;
        }

        /// <summary>
        ///  Convierte un número de decimal a binario.
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>Valor en formato string. Si no es posible la conversión retorna "Valor inválido".</returns>
        public string DecimalBinario(double valor)
        {
            string nroBinario = string.Empty;
            bool esNegativo = valor < 0;
            if (esNegativo) valor *= -1;
            double nroAux;
            int enteroAux;
            int valEntero = (int)valor;
            double valFrac = valor - valEntero;

            // Parte entera.  
            if (valEntero == 0) nroBinario = "0";
            else
            {
                while (valEntero > 0)
                {
                    if (valEntero % 2 == 0) nroBinario = "0" + nroBinario; //ingreso los nros como pila.
                    else nroBinario = "1" + nroBinario;
                    valEntero = (int)(valEntero / 2); // tomo la parte entera                
                }
            }

            // Parte fraccional            
            if (valFrac != 0)
            {
                nroBinario += ","; // ingreso como cola

                for (int i = 0; i < 10; i++)
                {
                    nroAux = valFrac * 2;
                    enteroAux = (int)nroAux;
                    valFrac = nroAux - enteroAux;

                    nroBinario += enteroAux.ToString();
                }
                nroBinario = nroBinario.TrimEnd('0'); //quito los ceros sobrantes
            }

            if (esNegativo) nroBinario = "-" + nroBinario;
            return nroBinario;            
        }

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
