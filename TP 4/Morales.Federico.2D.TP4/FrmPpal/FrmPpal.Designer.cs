namespace FrmPpal
{
    partial class FrmPpal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEstados = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // groupBoxEstados
            // 
            this.groupBoxEstados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxEstados.Name = "groupBoxEstados";
            this.groupBoxEstados.Size = new System.Drawing.Size(538, 122);
            this.groupBoxEstados.TabIndex = 0;
            this.groupBoxEstados.TabStop = false;
            this.groupBoxEstados.Text = "Estados Paquetes";
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 282);
            this.Controls.Add(this.groupBoxEstados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.Text = "Correo UTN por Federico.Morales.2D";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEstados;
    }
}

