using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    /* Consultas:
     
     * Esta podría ser estática. Hacer lo que dice el enunciado. No es estático pero debería serlo.
     * Método ValidarOperador. Ver si hace falta el if o si el swich ejecuta defout si el string es null o empty
     * 
    */

    public class Calculadora    
    {
        /// <summary>
        /// Valida y realiza la operación pedida entre ambos Numeros.
        /// </summary>
        /// <param name="nro1">Primer Numero.</param>
        /// <param name="nro2">Segundo Numero.</param>
        /// <param name="operador">Parámetro que indica la operación a realizar. En caso de invalidez se asigna "+".</param>
        /// <returns>Retorna el valor del resultado de la operación.</returns>
        public double Operar (Numero nro1, Numero nro2, string operador)
        {
            double resultado;
            string operadorValidado = ValidarOperador(operador);

            switch (operadorValidado)
            {
                case "+":
                    resultado = nro1 + nro2;
                    break;
                case "-":
                    resultado = nro1 - nro2;
                    break;
                case "*":
                    resultado = nro1 * nro2;
                    break;
                case "/":
                    resultado = nro1 / nro2;
                    break;
                default:
                    resultado = 0;
                    break;
            }
            return resultado;
        }

        /// <summary>
        /// Valida que el parámetro operador sea "+", "-", "/" o "*".
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Si el parámetro es válido lo retorna, Caso contrario retornará "+".</returns>
        private static string ValidarOperador(string operador)
        {
            string operadorValidado = "+";
            if (!string.IsNullOrEmpty(operador))
            {
                switch (operador)
                {
                    case "+":
                        operadorValidado = "+";
                        break;
                    case "-":
                        operadorValidado = "-";
                        break;
                    case "*":
                        operadorValidado = "*";
                        break;
                    case "/":
                        operadorValidado = "/";
                        break;
                    default:
                        operadorValidado = "+";
                        break;
                }
            }
            return operadorValidado;
        }
    }
}
