using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaExeption : Exception
    {
        public NacionalidadInvalidaExeption()
            : base("Nacionalidad inválida.")
        {
        }

        public NacionalidadInvalidaExeption(string message) : base(message)
        {
        }
    }
}
