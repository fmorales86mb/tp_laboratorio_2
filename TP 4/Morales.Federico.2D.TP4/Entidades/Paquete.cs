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
        // Atributos
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        // Propiedades
        public string DireccionEntrega
        {
            get
            {
                return this.direccionEntrega;
            }
            set
            {
                this.direccionEntrega = value;
            }
        }
        public EEstado Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }
        public string TrackingId
        {
            get
            {
                return this.trackingID;
            }
            set
            {
                this.trackingID = value;
            }
        }
        
        // Constructores
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.Estado = EEstado.Ingresado;
            this.DireccionEntrega = direccionEntrega;
            this.TrackingId = trackingID;
        }

        // Métodos
        /// <summary>
        /// Cambia el estado del paquete hasta que su estado sea Entregado. Luego lo guarda en la DB.
        /// </summary>
        public void MockCicloDeVida()
        {
            //d.Repetir las acciones desde el punto A hasta que el estado sea Entregado.
            while (this.Estado != EEstado.Entregado)
            {
                //a.Colocar una demora de 10 segundos.
                Thread.Sleep(4000);
                //b.Pasar al siguiente estado.
                if (this.Estado < EEstado.Entregado)
                    this.Estado += 1;
                //c.Informar el estado a través de InformarEstado.EventArgs no tendrá ningún dato extra.
                this.InformarEstado.Invoke(this.Estado, null);
            }

            //e.Finalmente guardar los datos del paquete en la base de datos.
            //PaqueteDAO.Insertar(this);
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                this.InformarExcepcion.Invoke(e);
            }
        }        

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).TrackingId,
                ((Paquete)elemento).DireccionEntrega);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Retorna un string con el TrackingId y la Dirección de Entrega del Paquete.</returns>
        public override string ToString()
        {
            return this.MostrarDatos(this);
        }

        /// <summary>
        /// Compara la igualdad de dos Paquetes por sus Propiedades.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.Estado == p2.Estado && 
                p1.DireccionEntrega == p1.DireccionEntrega && 
                p1.TrackingId == p2.TrackingId);
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        // Evento
        public event DelegadoEstado InformarEstado;
        public event DelegadoDaoException InformarExcepcion;

        // Delegado
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public delegate void DelegadoDaoException(Exception e);

        // Enumerable
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
