using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{
    public class Correo : IMostrar<List<Paquete>>
    {        
        private List<Thread> mockPaquetes;
        private List<Paquete> paquetes;
     
        public List<Paquete> Paquetes
        {
            get
            {
                return this.paquetes;
            }
            set
            {
                this.paquetes = value;
            }
        }

        public Correo()
        {
            this.Paquetes = new List<Paquete>();
            this.mockPaquetes = new List<Thread>();
        }

        // Métodos
        /// <summary>
        /// Cierra todos los hilos activos.
        /// </summary>
        public void FinEntregas()
        {
            foreach(Thread t in this.mockPaquetes)
            {
                if(t.ThreadState == ThreadState.Running)                
                    t.Abort();                
            }
        }

        /// <summary>
        /// Retorna un String con los datos de la lista de Paquetes.
        /// </summary>
        /// <param name="elementos"></param>
        /// <returns>Lista de paquetes.</returns>
        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            List<Paquete> lista = (List<Paquete>)((Correo)elementos).Paquetes;

            StringBuilder sb = new StringBuilder();
            
            foreach(Paquete p in lista)
            {
                sb.AppendLine();
                sb.AppendFormat("{0} ({1})", p.ToString(), p.Estado.ToString());                
            }

            return sb.ToString();
        }

        /// <summary>
        /// Agrega el paquete al correo. En caso de que el paquete ya se encuentre en la lista, lanza una TrackingIdRepetidoExeption.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Correo operator +(Correo c, Paquete p)
        {
            bool repetido = false;
            
            foreach (Paquete paquete in c.Paquetes)
            {
                if (paquete == p)
                {
                    repetido = true;
                    throw new TrackingIdRepetidoExeption("El Paquete ya se encuentra en la lista.");
                }
            }

            if (!repetido)
            {                
                c.Paquetes.Add(p);                
                Thread hilo = null;

                try
                {
                    hilo = new Thread(p.MockCicloDeVida);
                }
                catch (Exception e)
                {
                    throw e;
                }

                c.mockPaquetes.Add(hilo);                
                hilo.Start();
            }

            return c;
        }
    }
}
