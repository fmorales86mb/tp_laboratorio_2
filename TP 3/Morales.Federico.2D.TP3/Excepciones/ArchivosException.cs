using System;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        public ArchivosException(Exception innerException) 
            : base("Error en la gestión del Archivo.", innerException)
        {
        }
    }
}
