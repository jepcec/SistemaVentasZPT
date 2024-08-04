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
            this.txtTelfProveedor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
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
            this.label5 = new System.Windows.Forms.Label();
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
            this.grbProductos.Location = new System.Drawing.Point(10, 269);
            this.grbProductos.Name = "grbProductos";
            this.grbProductos.Size = new System.Drawing.Size(685, 167);
            this.grbProductos.TabIndex = 28;
            this.grbProductos.TabStop = false;
            this.grbProductos.Text = "Productos";
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(409, 25);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(140, 20);
            this.txtContenido.TabIndex = 16;
            this.txtContenido.TextChanged += new System.EventHandler(this.txtContenido_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(350, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
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
            this.dgvProductos.Location = new System.Drawing.Point(25, 49);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(610, 108);
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
            this.cbCampo.Location = new System.Drawing.Point(156, 25);
            this.cbCampo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(116, 21);
            this.cbCampo.TabIndex = 17;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Campo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(611, 441);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 32);
            this.btnImprimir.TabIndex = 29;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(35, 21);
            this.txtDocumentoCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(126, 20);
            this.txtDocumentoCliente.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
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
            this.grbCliente.Location = new System.Drawing.Point(352, 190);
            this.grbCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCliente.Name = "grbCliente";
            this.grbCliente.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbCliente.Size = new System.Drawing.Size(344, 74);
            this.grbCliente.TabIndex = 30;
            this.grbCliente.TabStop = false;
            this.grbCliente.Text = "Proveedor";
            // 
            // txtTelfProveedor
            // 
            this.txtTelfProveedor.Location = new System.Drawing.Point(216, 21);
            this.txtTelfProveedor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTelfProveedor.Name = "txtTelfProveedor";
            this.txtTelfProveedor.Size = new System.Drawing.Size(120, 20);
            this.txtTelfProveedor.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 24);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "TELF.";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(80, 48);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(257, 20);
            this.txtNombreCliente.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 50);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
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
            this.grbBoleta.Location = new System.Drawing.Point(8, 68);
            this.grbBoleta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbBoleta.Name = "grbBoleta";
            this.grbBoleta.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbBoleta.Size = new System.Drawing.Size(378, 117);
            this.grbBoleta.TabIndex = 31;
            this.grbBoleta.TabStop = false;
            this.grbBoleta.Text = "Datos Factura";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(110, 79);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(221, 20);
            this.dtpFecha.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 83);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(289, 17);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(72, 22);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(139, 53);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(192, 20);
            this.txtNroDocumento.TabIndex = 16;
            // 
            // txtIdCompra
            // 
            this.txtIdCompra.Location = new System.Drawing.Point(102, 24);
            this.txtIdCompra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdCompra.Name = "txtIdCompra";
            this.txtIdCompra.Size = new System.Drawing.Size(146, 20);
            this.txtIdCompra.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "IdCompra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
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
            this.txtNombreEmpleado.Location = new System.Drawing.Point(89, 49);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(171, 20);
            this.txtNombreEmpleado.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(33, 51);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Nombre";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.Location = new System.Drawing.Point(89, 24);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.Size = new System.Drawing.Size(112, 20);
            this.txtIdEmpleado.TabIndex = 19;
            // 
            // grbEmpleado
            // 
            this.grbEmpleado.Controls.Add(this.txtNombreEmpleado);
            this.grbEmpleado.Controls.Add(this.label12);
            this.grbEmpleado.Controls.Add(this.txtIdEmpleado);
            this.grbEmpleado.Controls.Add(this.label11);
            this.grbEmpleado.Location = new System.Drawing.Point(10, 190);
            this.grbEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmpleado.Name = "grbEmpleado";
            this.grbEmpleado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbEmpleado.Size = new System.Drawing.Size(338, 74);
            this.grbEmpleado.TabIndex = 33;
            this.grbEmpleado.TabStop = false;
            this.grbEmpleado.Text = "Empleado";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 26);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "ID";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(105, 28);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(109, 20);
            this.txtSubTotal.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
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
            this.grbPago.Location = new System.Drawing.Point(390, 68);
            this.grbPago.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPago.Name = "grbPago";
            this.grbPago.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbPago.Size = new System.Drawing.Size(305, 117);
            this.grbPago.TabIndex = 32;
            this.grbPago.TabStop = false;
            this.grbPago.Text = "Forma de Pago";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(105, 54);
            this.txtIGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(109, 20);
            this.txtIGV.TabIndex = 26;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 57);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(25, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "IGV";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(106, 81);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(103, 20);
            this.txtMontoTotal.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 84);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(13, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Factura Compra";
            // 
            // frmFacturaCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 502);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbProductos);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.grbCliente);
            this.Controls.Add(this.grbBoleta);
            this.Controls.Add(this.grbEmpleado);
            this.Controls.Add(this.grbPago);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
    }
}