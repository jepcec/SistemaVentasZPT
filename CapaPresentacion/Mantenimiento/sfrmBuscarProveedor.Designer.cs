namespace CapaPresentacion.Mantenimiento
{
    partial class sfrmBuscarProveedor
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
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.Productos = new System.Windows.Forms.GroupBox();
            this.dgvProveedor = new System.Windows.Forms.DataGridView();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Productos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(132, 339);
            this.btnEnviar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(56, 19);
            this.btnEnviar.TabIndex = 56;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(394, 340);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(56, 19);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.dgvProveedor);
            this.Productos.Controls.Add(this.txtContenido);
            this.Productos.Controls.Add(this.label8);
            this.Productos.Controls.Add(this.cbCampo);
            this.Productos.Controls.Add(this.label7);
            this.Productos.Location = new System.Drawing.Point(11, 11);
            this.Productos.Margin = new System.Windows.Forms.Padding(2);
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(2);
            this.Productos.Size = new System.Drawing.Size(580, 317);
            this.Productos.TabIndex = 54;
            this.Productos.TabStop = false;
            this.Productos.Text = "Productos";
            // 
            // dgvProveedor
            // 
            this.dgvProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProveedor.Location = new System.Drawing.Point(4, 48);
            this.dgvProveedor.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProveedor.Name = "dgvProveedor";
            this.dgvProveedor.RowHeadersWidth = 51;
            this.dgvProveedor.RowTemplate.Height = 24;
            this.dgvProveedor.Size = new System.Drawing.Size(571, 266);
            this.dgvProveedor.TabIndex = 14;
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(436, 24);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(2);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(76, 20);
            this.txtContenido.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contenido";
            // 
            // cbCampo
            // 
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Items.AddRange(new object[] {
            "All",
            "ID",
            "Nombre",
            "DNI",
            "Direccion",
            "Fecha Nacimiento",
            "Edad",
            "FechaIngreso",
            "AñosEstudio"});
            this.cbCampo.Location = new System.Drawing.Point(86, 24);
            this.cbCampo.Margin = new System.Windows.Forms.Padding(2);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(92, 21);
            this.cbCampo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Campo";
            // 
            // sfrmBuscarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 373);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.Productos);
            this.Name = "sfrmBuscarProveedor";
            this.Text = "sfrmBuscarProveedor";
            this.Productos.ResumeLayout(false);
            this.Productos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox Productos;
        private System.Windows.Forms.DataGridView dgvProveedor;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.Label label7;
    }
}