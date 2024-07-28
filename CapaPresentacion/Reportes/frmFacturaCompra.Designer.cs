﻿namespace CapaPresentacion.Reportes
{
    partial class frmFacturaCompra
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
            this.grbProductos = new System.Windows.Forms.GroupBox();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbCliente = new System.Windows.Forms.GroupBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.grbBoleta = new System.Windows.Forms.GroupBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.txtIdCompra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new System.Windows.Forms.TextBox();
            this.grbEmpleado = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbPago = new System.Windows.Forms.GroupBox();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelfProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grbProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.grbCliente.SuspendLayout();
            this.grbBoleta.SuspendLayout();
            this.grbEmpleado.SuspendLayout();
            this.grbPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbProductos
            // 
            this.grbProductos.Controls.Add(this.txtContenido);
            this.grbProductos.Controls.Add(this.label8);
            this.grbProductos.Controls.Add(this.dgvProductos);
            this.grbProductos.Controls.Add(this.cbCampo);
            this.grbProductos.Controls.Add(this.label7);
            this.grbProductos.Location = new System.Drawing.Point(16, 255);
            this.grbProductos.Margin = new System.Windows.Forms.Padding(4);
            this.grbProductos.Name = "grbProductos";
            this.grbProductos.Padding = new System.Windows.Forms.Padding(4);
            this.grbProductos.Size = new System.Drawing.Size(913, 205);
            this.grbProductos.TabIndex = 28;
            this.grbProductos.TabStop = false;
            this.grbProductos.Text = "Productos";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(545, 31);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(185, 22);
            this.txtContenido.TabIndex = 16;
            this.txtContenido.TextChanged += new System.EventHandler(this.txtContenido_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Contenido";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(33, 60);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(814, 133);
            this.dgvProductos.TabIndex = 0;
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "NombreProducto",
            "Cantidad",
            "Precio Unitario",
            "Sub Total"});
            this.cbCampo.Location = new System.Drawing.Point(208, 31);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(153, 24);
            this.cbCampo.TabIndex = 17;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(150, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Campo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(817, 467);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 39);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(47, 26);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(167, 22);
            this.txtDocumentoCliente.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "RUC";
            // 
            // grbCliente
            // 
            this.grbCliente.Controls.Add(this.txtTelfProveedor);
            this.grbCliente.Controls.Add(this.label4);
            this.grbCliente.Controls.Add(this.txtNombreCliente);
            this.grbCliente.Controls.Add(this.label9);
            this.grbCliente.Controls.Add(this.txtDocumentoCliente);
            this.grbCliente.Controls.Add(this.label3);
            this.grbCliente.Location = new System.Drawing.Point(472, 157);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Size = new System.Drawing.Size(458, 91);
            this.grbCliente.TabIndex = 30;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Proveedor";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(106, 59);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(341, 22);
            this.txtNombreCliente.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Rason Social";
            // 
            // grbBoleta
            // 
            this.grbBoleta.Controls.Add(this.dtpFecha);
            this.grbBoleta.Controls.Add(this.label10);
            this.grbBoleta.Controls.Add(this.btnBuscar);
            this.grbBoleta.Controls.Add(this.txtNroDocumento);
            this.grbBoleta.Controls.Add(this.txtIdCompra);
            this.grbBoleta.Controls.Add(this.label1);
            this.grbBoleta.Controls.Add(this.label2);
            this.grbBoleta.Location = new System.Drawing.Point(13, 7);
            this.grbBoleta.Name = "grbBoleta";
            this.grbBoleta.Size = new System.Drawing.Size(504, 144);
            this.grbBoleta.TabIndex = 31;
            this.grbBoleta.TabStop = false;
            this.grbBoleta.Text = "Datos Factura";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(146, 97);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(293, 22);
            this.dtpFecha.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(60, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(385, 21);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 27);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(185, 65);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(254, 22);
            this.txtNroDocumento.TabIndex = 16;
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(136, 29);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(194, 22);
            this.txtIdCompra.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "IdCompra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nro Documento";
            // 
            // sfdGuardar
            // 
            this.sfdGuardar.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            this.sfdGuardar.InitialDirectory = "D:\\Informática\\2024-1\\Desarrollo de Software";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(119, 60);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(227, 22);
            this.txtNombreEmpleado.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(44, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nombre";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(119, 29);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(148, 22);
            this.txtIdEmpleado.TabIndex = 19;
            // 
            // grbEmpleado
            // 
            this.grbEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.grbEmpleado.Controls.Add(this.label12);
            this.grbEmpleado.Controls.Add(this.txtIdEmpleado);
            this.grbEmpleado.Controls.Add(this.label11);
            this.grbEmpleado.Location = new System.Drawing.Point(16, 157);
            this.grbEmpleado.Name = "grbEmpleado";
            this.grbEmpleado.Size = new System.Drawing.Size(450, 91);
            this.grbEmpleado.TabIndex = 33;
            this.grbEmpleado.TabStop = false;
            this.grbEmpleado.Text = "Empleado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(44, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "ID";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(140, 34);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(144, 22);
            this.txtSubTotal.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "SubTotal";
            // 
            // grbPago
            // 
            this.grbPago.Controls.Add(this.txtIGV);
            this.grbPago.Controls.Add(this.label14);
            this.grbPago.Controls.Add(this.txtMontoTotal);
            this.grbPago.Controls.Add(this.label13);
            this.grbPago.Controls.Add(this.txtSubTotal);
            this.grbPago.Controls.Add(this.label6);
            this.grbPago.Location = new System.Drawing.Point(523, 7);
            this.grbPago.Name = "grbPago";
            this.grbPago.Size = new System.Drawing.Size(407, 144);
            this.grbPago.TabIndex = 32;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Forma de Pago";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(140, 67);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(144, 22);
            this.txtIGV.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(69, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "IGV";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(141, 100);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(136, 22);
            this.txtMontoTotal.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(69, 103);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total";
            // 
            // txtTelfProveedor
            // 
            this.txtTelfProveedor.Location = new System.Drawing.Point(288, 26);
            this.txtTelfProveedor.Name = "txtTelfProveedor";
            this.txtTelfProveedor.Size = new System.Drawing.Size(159, 22);
            this.txtTelfProveedor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "TELF.";
            // 
            // frmFacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 513);
            this.Controls.Add(this.grbProductos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbBoleta);
            this.Controls.Add(this.grbEmpleado);
            this.Controls.Add(this.grbPago);
            this.Name = "frmFacturaCompra";
            this.Text = "frmFacturaCompra";
            this.grbProductos.ResumeLayout(false);
            this.grbProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.grbCliente.ResumeLayout(false);
            this.grbCliente.PerformLayout();
            this.grbBoleta.ResumeLayout(false);
            this.grbBoleta.PerformLayout();
            this.grbEmpleado.ResumeLayout(false);
            this.grbEmpleado.PerformLayout();
            this.grbPago.ResumeLayout(false);
            this.grbPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbProductos;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbCliente;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbBoleta;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.TextBox txtIdCompra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIdEmpleado;
        private System.Windows.Forms.GroupBox grbEmpleado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbPago;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelfProveedor;
        private System.Windows.Forms.Label label4;
    }
}