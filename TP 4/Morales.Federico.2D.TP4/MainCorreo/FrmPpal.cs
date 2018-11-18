using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MainCorreo
{
    public partial class FrmPpal : Form
    {
        Correo correo;

        public FrmPpal()
        {
            InitializeComponent();
            correo = new Correo();
        }
// El evento click del botón btnAgregar realizará las siguientes acciones en el siguiente orden:
// a.Creará un nuevo paquete y asociará al evento InformaEstado el método paq_InformaEstado.
// b.Agregará el paquete al correo, controlando las excepciones que puedan derivar de dicha acción.
// c.Llamará al método ActualizarEstados.
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Paquete p = new Paquete(txtDireccion.Text, mtxtTrackingID.Text);
            p.InformarEstado += this.paq_InformaEstado;

            try
            {
                correo += p;
                this.ActualizarEstados();
            }
            catch(TrackingIdRepetidoExeption ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {

        }

        private void paq_InformaEstado(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                Paquete.DelegadoEstado d = new Paquete.DelegadoEstado(paq_InformaEstado);
                this.Invoke(d, new object[] { sender, e });
            }
            else
            { // Llamar al método 
                this.ActualizarEstados();
            }
        }

        private void ActualizarEstados()
        {

        }

        private void FrmPpal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.correo.FinEntregas();
        }
    }
}
