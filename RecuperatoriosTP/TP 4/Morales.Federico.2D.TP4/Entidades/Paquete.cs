using System;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {        
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

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
        
        public Paquete(string direccionEntrega, string trackingID)
        {
            this.Estado = EEstado.Ingresado;
            this.DireccionEntrega = direccionEntrega;
            this.TrackingId = trackingID;
        }

        /// <summary>
        /// Cambia el estado del paquete hasta que su estado sea Entregado. Luego lo guarda en la DB.
        /// </summary>
        public void MockCicloDeVida()
        {            
            while (this.Estado != EEstado.Entregado)
            {                
                Thread.Sleep(4000);                
                if (this.Estado < EEstado.Entregado)
                    this.Estado += 1;                
                this.InformarEstado.Invoke(this.Estado, null);
            }

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
        /// Compara la igualdad de dos Paquetes por su TrackingId.
        /// </summary>
        /// <param name="p1"></param>
        /// <param name="p2"></param>
        /// <returns></returns>
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            return (p1.TrackingId == p2.TrackingId);
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        
        public event DelegadoEstado InformarEstado;
        public event DelegadoDaoException InformarExcepcion;
        
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public delegate void DelegadoDaoException(Exception e);
        
        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}
