using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class SinProfesorExeption : Exception
    {
        public SinProfesorExeption()
            :base("Sin Profesor.")
        {            
        }
    }
}
