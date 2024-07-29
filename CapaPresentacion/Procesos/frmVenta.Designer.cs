namespace CapaPresentacion.Procesos
{
    partial class frmVenta
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCorreoCliente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDocumentoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdCliente = new System.Windows.Forms.TextBox();
            this.lblI = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNroDocumento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            this.rbBoleta = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnQuitarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtIDEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIGV = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.tMensaje = new System.Windows.Forms.Timer(this.components);
            this.coIdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.txtTelefonoCliente);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtCorreoCliente);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtNombreCliente);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDocumentoCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtIdCliente);
            this.groupBox1.Controls.Add(this.lblI);
            this.groupBox1.Location = new System.Drawing.Point(16, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(441, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(304, 27);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(112, 25);
            this.btnBuscarCliente.TabIndex = 10;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtTelefonoCliente
            // 
            this.txtTelefonoCliente.Location = new System.Drawing.Point(120, 154);
            this.txtTelefonoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefonoCliente.Name = "txtTelefonoCliente";
            this.txtTelefonoCliente.Size = new System.Drawing.Size(271, 22);
            this.txtTelefonoCliente.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 162);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Telefono";
            // 
            // txtCorreoCliente
            // 
            this.txtCorreoCliente.Location = new System.Drawing.Point(120, 122);
            this.txtCorreoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCorreoCliente.Name = "txtCorreoCliente";
            this.txtCorreoCliente.Size = new System.Drawing.Size(271, 22);
            this.txtCorreoCliente.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 130);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 16);
            this.label8.TabIndex = 6;
            this.label8.Text = "Correo";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(120, 90);
            this.txtNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(271, 22);
            this.txtNombreCliente.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Nombre";
            // 
            // txtDocumentoCliente
            // 
            this.txtDocumentoCliente.Location = new System.Drawing.Point(120, 58);
            this.txtDocumentoCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtDocumentoCliente.Name = "txtDocumentoCliente";
            this.txtDocumentoCliente.Size = new System.Drawing.Size(271, 22);
            this.txtDocumentoCliente.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Documento";
            // 
            // txtIdCliente
            // 
            this.txtIdCliente.Location = new System.Drawing.Point(120, 27);
            this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdCliente.Name = "txtIdCliente";
            this.txtIdCliente.Size = new System.Drawing.Size(175, 22);
            this.txtIdCliente.TabIndex = 1;
            // 
            // lblI
            // 
            this.lblI.AutoSize = true;
            this.lblI.Location = new System.Drawing.Point(35, 36);
            this.lblI.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblI.Name = "lblI";
            this.lblI.Size = new System.Drawing.Size(20, 16);
            this.lblI.TabIndex = 0;
            this.lblI.Text = "ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFechaRegistro);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNroDocumento);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(465, 28);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(559, 207);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Comprobante";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(116, 143);
            this.dtpFechaRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaRegistro.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha";
            // 
            // txtNroDocumento
            // 
            this.txtNroDocumento.Location = new System.Drawing.Point(96, 108);
            this.txtNroDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.txtNroDocumento.Name = "txtNroDocumento";
            this.txtNroDocumento.Size = new System.Drawing.Size(393, 22);
            this.txtNroDocumento.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nro";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbFactura);
            this.groupBox3.Controls.Add(this.rbBoleta);
            this.groupBox3.Location = new System.Drawing.Point(49, 36);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(441, 63);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo";
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Location = new System.Drawing.Point(303, 23);
            this.rbFactura.Margin = new System.Windows.Forms.Padding(4);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(73, 20);
            this.rbFactura.TabIndex = 3;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            // 
            // rbBoleta
            // 
            this.rbBoleta.AutoSize = true;
            this.rbBoleta.Location = new System.Drawing.Point(47, 23);
            this.rbBoleta.Margin = new System.Windows.Forms.Padding(4);
            this.rbBoleta.Name = "rbBoleta";
            this.rbBoleta.Size = new System.Drawing.Size(67, 20);
            this.rbBoleta.TabIndex = 2;
            this.rbBoleta.TabStop = true;
            this.rbBoleta.Text = "Boleta";
            this.rbBoleta.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnQuitarProducto);
            this.groupBox4.Controls.Add(this.btnAgregarProducto);
            this.groupBox4.Location = new System.Drawing.Point(16, 242);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(200, 102);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Producto";
            // 
            // btnQuitarProducto
            // 
            this.btnQuitarProducto.Location = new System.Drawing.Point(21, 59);
            this.btnQuitarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnQuitarProducto.Name = "btnQuitarProducto";
            this.btnQuitarProducto.Size = new System.Drawing.Size(132, 28);
            this.btnQuitarProducto.TabIndex = 4;
            this.btnQuitarProducto.Text = "Quitar producto";
            this.btnQuitarProducto.UseVisualStyleBackColor = true;
            this.btnQuitarProducto.Click += new System.EventHandler(this.btnQuitarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(21, 23);
            this.btnAgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(132, 28);
            this.btnAgregarProducto.TabIndex = 3;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtNombreEmpleado);
            this.groupBox5.Controls.Add(this.txtIDEmpleado);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(465, 242);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(559, 102);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Empleado";
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(133, 57);
            this.txtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(416, 22);
            this.txtNombreEmpleado.TabIndex = 7;
            // 
            // txtIDEmpleado
            // 
            this.txtIDEmpleado.Location = new System.Drawing.Point(133, 26);
            this.txtIDEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDEmpleado.Name = "txtIDEmpleado";
            this.txtIDEmpleado.Size = new System.Drawing.Size(180, 22);
            this.txtIDEmpleado.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvProductos);
            this.groupBox6.Location = new System.Drawing.Point(16, 352);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(1008, 185);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Productos";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coIdProducto,
            this.coProducto,
            this.coPrecio,
            this.coStock,
            this.coCantidad,
            this.coSubTotal});
            this.dgvProductos.Location = new System.Drawing.Point(8, 23);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(971, 140);
            this.dgvProductos.TabIndex = 0;
            this.dgvProductos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.FC_ActualizarMontos);
            this.dgvProductos.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgvProductos_RowsRemoved);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(55, 566);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(105, 39);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(401, 581);
            this.textBox9.Margin = new System.Windows.Forms.Padding(4);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(167, 22);
            this.textBox9.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(316, 587);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "label10";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Location = new System.Drawing.Point(775, 544);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(167, 22);
            this.txtSubTotal.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(689, 551);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 9;
            this.label11.Text = "SubTotal";
            // 
            // txtIGV
            // 
            this.txtIGV.Location = new System.Drawing.Point(775, 576);
            this.txtIGV.Margin = new System.Windows.Forms.Padding(4);
            this.txtIGV.Name = "txtIGV";
            this.txtIGV.Size = new System.Drawing.Size(167, 22);
            this.txtIGV.TabIndex = 12;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(689, 583);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 16);
            this.label12.TabIndex = 11;
            this.label12.Text = "IGV";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(775, 608);
            this.txtMontoTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(167, 22);
            this.txtMontoTotal.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(689, 615);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 16);
            this.label13.TabIndex = 13;
            this.label13.Text = "Total";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Location = new System.Drawing.Point(124, 543);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(0, 16);
            this.lblMensaje.TabIndex = 15;
            // 
            // tMensaje
            // 
            this.tMensaje.Tick += new System.EventHandler(this.tMensaje_Tick);
            // 
            // coIdProducto
            // 
            this.coIdProducto.HeaderText = "IdProducto";
            this.coIdProducto.MinimumWidth = 6;
            this.coIdProducto.Name = "coIdProducto";
            this.coIdProducto.Width = 125;
            // 
            // coProducto
            // 
            this.coProducto.HeaderText = "Producto";
            this.coProducto.MinimumWidth = 6;
            this.coProducto.Name = "coProducto";
            this.coProducto.Width = 125;
            // 
            // coPrecio
            // 
            this.coPrecio.HeaderText = "Precio";
            this.coPrecio.MinimumWidth = 6;
            this.coPrecio.Name = "coPrecio";
            this.coPrecio.Width = 125;
            // 
            // coStock
            // 
            this.coStock.HeaderText = "Stock";
            this.coStock.MinimumWidth = 6;
            this.coStock.Name = "coStock";
            this.coStock.Width = 125;
            // 
            // coCantidad
            // 
            this.coCantidad.HeaderText = "Cantidad";
            this.coCantidad.MinimumWidth = 6;
            this.coCantidad.Name = "coCantidad";
            this.coCantidad.Width = 125;
            // 
            // coSubTotal
            // 
            this.coSubTotal.HeaderText = "Sub Total";
            this.coSubTotal.MinimumWidth = 6;
            this.coSubTotal.Name = "coSubTotal";
            this.coSubTotal.Width = 125;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 640);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtIGV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmVenta";
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbFactura;
        private System.Windows.Forms.RadioButton rbBoleta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNroDocumento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnQuitarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtIDEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtTelefonoCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCorreoCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDocumentoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdCliente;
        private System.Windows.Forms.Label lblI;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtIGV;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.Timer tMensaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn coIdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn coProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn coPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn coStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn coCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn coSubTotal;
    }
}