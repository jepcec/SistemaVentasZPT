namespace CapaPresentacion.Reportes
{
    partial class frmListarEmpleado
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
            this.Empleados = new System.Windows.Forms.GroupBox();
            this.dgvEmpleado = new System.Windows.Forms.DataGridView();
            this.txtContenido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbCampo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.sfdGuardar = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.Empleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).BeginInit();
            this.SuspendLayout();
            // 
            // Empleados
            // 
            this.Empleados.Controls.Add(this.dgvEmpleado);
            this.Empleados.Controls.Add(this.txtContenido);
            this.Empleados.Controls.Add(this.label8);
            this.Empleados.Controls.Add(this.cmbCampo);
            this.Empleados.Controls.Add(this.label7);
            this.Empleados.Location = new System.Drawing.Point(11, 67);
            this.Empleados.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Empleados.Name = "Empleados";
            this.Empleados.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Empleados.Size = new System.Drawing.Size(790, 298);
            this.Empleados.TabIndex = 36;
            this.Empleados.TabStop = false;
            this.Empleados.Text = "Empleados";
            // 
            // dgvEmpleado
            // 
            this.dgvEmpleado.AllowUserToAddRows = false;
            this.dgvEmpleado.AllowUserToDeleteRows = false;
            this.dgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleado.Location = new System.Drawing.Point(4, 48);
            this.dgvEmpleado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvEmpleado.Name = "dgvEmpleado";
            this.dgvEmpleado.ReadOnly = true;
            this.dgvEmpleado.RowTemplate.Height = 24;
            this.dgvEmpleado.Size = new System.Drawing.Size(781, 245);
            this.dgvEmpleado.TabIndex = 14;
            // 
            // txtContenido
            // 
            this.txtContenido.Location = new System.Drawing.Point(501, 24);
            this.txtContenido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContenido.Name = "txtContenido";
            this.txtContenido.Size = new System.Drawing.Size(158, 20);
            this.txtContenido.TabIndex = 13;
            this.txtContenido.TextChanged += new System.EventHandler(this.txtContenido_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Contenido";
            // 
            // cmbCampo
            // 
            this.cmbCampo.FormattingEnabled = true;
            this.cmbCampo.Items.AddRange(new object[] {
            "IdEmpleado",
            "Documento",
            "NombreCompleto",
            "Correo",
            "Estado",
            "FechaRegistro",
            "NombreRol"});
            this.cmbCampo.Location = new System.Drawing.Point(192, 24);
            this.cmbCampo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCampo.Name = "cmbCampo";
            this.cmbCampo.Size = new System.Drawing.Size(138, 21);
            this.cmbCampo.TabIndex = 13;
            this.cmbCampo.SelectedIndexChanged += new System.EventHandler(this.cmbCampo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(148, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Campo";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(716, 370);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 32);
            this.btnImprimir.TabIndex = 37;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // sfdGuardar
            // 
            this.sfdGuardar.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(13, 21);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Listar Empleados";
            // 
            // frmListarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.Empleados);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListarEmpleado";
            this.Text = "frmListarEmpleado";
            this.Empleados.ResumeLayout(false);
            this.Empleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox Empleados;
        private System.Windows.Forms.DataGridView dgvEmpleado;
        private System.Windows.Forms.TextBox txtContenido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbCampo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.SaveFileDialog sfdGuardar;
        private System.Windows.Forms.Label label5;
    }
}