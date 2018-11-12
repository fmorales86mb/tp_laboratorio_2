using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Correo
//1. Implementará la interfaz IMostrar<List<Paquete>>.
//2. En el operador +:
// a.Controlar si el paquete ya está en la lista.En el caso de que esté, se lanzará la excepción 
//  TrackingIdRepetidoException.
//b.Agregar el paquete a la lista de paquetes.
//c.Crear un hilo para el método MockCicloDeVida del paquete, y agregar dicho hilo a mockPaquetes.
//d.Ejecutar el hilo. 
//3. MostrarDatos utilizará string.Format con el siguiente formato "{0} para {1} ({2})",
//  p.TrackingID, p.DireccionEntrega, p.Estado.ToString() para retornar los datos de todos los paquetes de su 
//  lista.
//4. FinEntregas cerrará todos los hilos activos.

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {
        // Propiedades
        public List<Paquete> Paquetes
        {
            get;
            set;
        }

        // Constructores
        public Correo()
        {
        }

        // Métodos
        public void FinEntregas()
        {

        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            return "";
        }

        // Sobreescritos
        public static Correo operator +(Correo c, Paquete p)
        {
            return c;
        }
    }
}
