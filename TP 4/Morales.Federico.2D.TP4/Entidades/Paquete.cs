using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//Paquete
//1. Implementar la interfaz IMostrar, siendo su tipo genérico Paquete. 
//2. MostrarDatos utilizará 
//  string.Format con el siguiente formato "{0} para {1}", p.trackingID, p.direccionEntrega.
//3. MockCicloDeVida hará que el paquete cambie de estado de la siguiente forma:
//a.Colocar una demora de 10 segundos.
//b.Pasar al siguiente estado.
//c.Informar el estado a través de InformarEstado.EventArgs no tendrá ningún dato extra.
//d.Repetir las acciones desde el punto A hasta que el estado sea Entregado.
//e.Finalmente guardar los datos del paquete en la base de datos.

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        // Propiedades
        public string DireccionEntrega
        {
            get;
            set;
        }
        public EEstado Estado
        {
            get;
            set;
        }
        public string trackingId
        {
            get;
            set;
        }
        
        // Constructores
        public Paquete(string direccionEntrega, string trackingID)
        {

        }

        // Métodos
        public void MockCicloDeVida()
        {
            Thread.Sleep(10000);
            this.Estado += 1;
        }        

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).trackingId,
                ((Paquete)elemento).DireccionEntrega);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return true;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return false;
        }

        // Evento


        // Enmerable
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
