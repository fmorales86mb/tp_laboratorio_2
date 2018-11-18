namespace MainCorreo
{
    partial class FrmPpal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxEstadosPaquetes = new System.Windows.Forms.GroupBox();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.rtbMostrar = new System.Windows.Forms.RichTextBox();
            this.groupBoxPaquete = new System.Windows.Forms.GroupBox();
            this.mtxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.lblTrackingID = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.groupBoxEstadosPaquetes.SuspendLayout();
            this.groupBoxPaquete.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEstadosPaquetes
            // 
            this.groupBoxEstadosPaquetes.Controls.Add(this.lstEstadoEntregado);
            this.groupBoxEstadosPaquetes.Controls.Add(this.lblEstadoEntregado);
            this.groupBoxEstadosPaquetes.Controls.Add(this.lstEstadoEnViaje);
            this.groupBoxEstadosPaquetes.Controls.Add(this.lblEstadoEnViaje);
            this.groupBoxEstadosPaquetes.Controls.Add(this.lstEstadoIngresado);
            this.groupBoxEstadosPaquetes.Controls.Add(this.lblEstadoIngresado);
            this.groupBoxEstadosPaquetes.Location = new System.Drawing.Point(21, 18);
            this.groupBoxEstadosPaquetes.Name = "groupBoxEstadosPaquetes";
            this.groupBoxEstadosPaquetes.Size = new System.Drawing.Size(726, 273);
            this.groupBoxEstadosPaquetes.TabIndex = 0;
            this.groupBoxEstadosPaquetes.TabStop = false;
            this.groupBoxEstadosPaquetes.Text = "Estados Paquetes";
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(33, 28);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 0;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(15, 44);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(204, 212);
            this.lstEstadoIngresado.TabIndex = 1;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(257, 46);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(204, 212);
            this.lstEstadoEnViaje.TabIndex = 3;
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(275, 30);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 2;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(505, 46);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(204, 212);
            this.lstEstadoEntregado.TabIndex = 5;
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(519, 30);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEstadoEntregado.TabIndex = 4;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // rtbMostrar
            // 
            this.rtbMostrar.Location = new System.Drawing.Point(24, 310);
            this.rtbMostrar.Name = "rtbMostrar";
            this.rtbMostrar.ReadOnly = true;
            this.rtbMostrar.Size = new System.Drawing.Size(437, 125);
            this.rtbMostrar.TabIndex = 1;
            this.rtbMostrar.Text = "";
            // 
            // groupBoxPaquete
            // 
            this.groupBoxPaquete.Controls.Add(this.btnMostrarTodos);
            this.groupBoxPaquete.Controls.Add(this.btnAgregar);
            this.groupBoxPaquete.Controls.Add(this.lblDireccion);
            this.groupBoxPaquete.Controls.Add(this.txtDireccion);
            this.groupBoxPaquete.Controls.Add(this.lblTrackingID);
            this.groupBoxPaquete.Controls.Add(this.mtxtTrackingID);
            this.groupBoxPaquete.Location = new System.Drawing.Point(467, 309);
            this.groupBoxPaquete.Name = "groupBoxPaquete";
            this.groupBoxPaquete.Size = new System.Drawing.Size(279, 126);
            this.groupBoxPaquete.TabIndex = 2;
            this.groupBoxPaquete.TabStop = false;
            this.groupBoxPaquete.Text = "Paquete";
            // 
            // mtxtTrackingID
            // 
            this.mtxtTrackingID.Location = new System.Drawing.Point(6, 48);
            this.mtxtTrackingID.Mask = "aaa-aaa-aaaa";
            this.mtxtTrackingID.Name = "mtxtTrackingID";
            this.mtxtTrackingID.Size = new System.Drawing.Size(154, 20);
            this.mtxtTrackingID.TabIndex = 0;
            // 
            // lblTrackingID
            // 
            this.lblTrackingID.AutoSize = true;
            this.lblTrackingID.Location = new System.Drawing.Point(17, 32);
            this.lblTrackingID.Name = "lblTrackingID";
            this.lblTrackingID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackingID.TabIndex = 1;
            this.lblTrackingID.Text = "Tracking ID";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 96);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(154, 20);
            this.txtDireccion.TabIndex = 2;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(17, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Dirección";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(166, 32);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 36);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(166, 80);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(97, 36);
            this.btnMostrarTodos.TabIndex = 5;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // FrmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 452);
            this.Controls.Add(this.groupBoxPaquete);
            this.Controls.Add(this.rtbMostrar);
            this.Controls.Add(this.groupBoxEstadosPaquetes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo UTN por Federico.Morales.2D";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPpal_FormClosed);
            this.groupBoxEstadosPaquetes.ResumeLayout(false);
            this.groupBoxEstadosPaquetes.PerformLayout();
            this.groupBoxPaquete.ResumeLayout(false);
            this.groupBoxPaquete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEstadosPaquetes;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.RichTextBox rtbMostrar;
        private System.Windows.Forms.GroupBox groupBoxPaquete;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTrackingID;
        private System.Windows.Forms.MaskedTextBox mtxtTrackingID;
    }
}

