using System;

namespace Entidades
{
    public class TrackingIdRepetidoExeption : Exception
    {
        public TrackingIdRepetidoExeption(string message) 
            : base(message)
        {
        }

        public TrackingIdRepetidoExeption(string message, Exception innerException) 
            : base(message, innerException)
        {
        }
    }
}
