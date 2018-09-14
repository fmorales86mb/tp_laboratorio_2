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

namespace MiCalculadora
{
    /* Consultas:
     
     * Uso de atributos de la clase o creo objetos en los métodos. Atributos de clase. 
     * Limpiar en el Constructor ok
     * El combo como dropdownlist, es decir que no permite ingresar valores distintos a los items cargados. No es necesario. 
    */
    public partial class LaCalculadora: Form
    {
        private Calculadora Calc;
        private Numero Nro1;
        private Numero Nro2;
        private bool EsDecimal;
        private Numero NumeroObj = new Numero();

        public LaCalculadora()
        {
            InitializeComponent();
            Limpiar();
            Calc = new Calculadora();            
        }
        
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            if (EsDecimal)
            {
                lblResultado.Text = NumeroObj.DecimalBinario(lblResultado.Text);
                EsDecimal = false;
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            if (!EsDecimal)
            {
                lblResultado.Text = NumeroObj.BinarioDecimal(lblResultado.Text);
                EsDecimal = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {            
            string resultado = (Operar(txtNumero1.Text, txtNumero2.Text, cmbOperador.SelectedItem.ToString())).ToString();
            lblResultado.Text = resultado;
            EsDecimal = true;
        }

        private void frmCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (MessageBox.Show("¿Confirma el cierre de la aplicación?",
                "Confirmación", MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) 
                == DialogResult.Cancel) e.Cancel=true;
        }

        /// <summary>
        /// Inicializa los valores de los controles del form.
        /// </summary>
        private void Limpiar()
        {
            txtNumero1.Text = "0";
            txtNumero2.Text = "0";
            lblResultado.Text = "0";
            cmbOperador.SelectedIndex = 0;
            EsDecimal = true;
        }

        /// <summary>
        /// Realiza la operación y devuelve el resultado.
        /// </summary>
        /// <param name="numero1">Valor del txtNumero1</param>
        /// <param name="numero2">Valor del txtNumero2</param>
        /// <param name="operador">Item seleccionado en el ComboBox</param>
        /// <returns>Resultado de la operación</returns>
        private double Operar (string numero1, string numero2, string operador)
        {
            Nro1 = new Numero(numero1);
            Nro2 = new Numero(numero2);
            return Calc.Operar(Nro1, Nro2, operador);
        }
    }
}
