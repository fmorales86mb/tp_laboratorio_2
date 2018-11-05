using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosExeption : Exception
    {
        public ArchivosExeption(Exception innerException) 
            : base("Error en la gestión del Archivo.", innerException)
        {
        }
    }
}
