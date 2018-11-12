using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
