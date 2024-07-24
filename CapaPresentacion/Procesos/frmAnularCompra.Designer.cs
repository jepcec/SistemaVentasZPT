namespace CapaPresentacion.Procesos
{
    partial class frmAnularCompra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbFactura = new System.Windows.Forms.RadioButton();
            this.rbBoleta = new System.Windows.Forms.RadioButton();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtAnular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFactura);
            this.groupBox1.Controls.Add(this.rbBoleta);
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(291, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Comprobante";
            // 
            // rbFactura
            // 
            this.rbFactura.AutoSize = true;
            this.rbFactura.Location = new System.Drawing.Point(189, 28);
            this.rbFactura.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFactura.Name = "rbFactura";
            this.rbFactura.Size = new System.Drawing.Size(69, 19);
            this.rbFactura.TabIndex = 1;
            this.rbFactura.TabStop = true;
            this.rbFactura.Text = "Factura";
            this.rbFactura.UseVisualStyleBackColor = true;
            // 
            // rbBoleta
            // 
            this.rbBoleta.AutoSize = true;
            this.rbBoleta.Location = new System.Drawing.Point(22, 28);
            this.rbBoleta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbBoleta.Name = "rbBoleta";
            this.rbBoleta.Size = new System.Drawing.Size(63, 19);
            this.rbBoleta.TabIndex = 1;
            this.rbBoleta.TabStop = true;
            this.rbBoleta.Text = "Boleta";
            this.rbBoleta.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(208, 226);
            this.lblResultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(72, 15);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado...";
            // 
            // txtAnular
            // 
            this.txtAnular.Location = new System.Drawing.Point(84, 168);
            this.txtAnular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAnular.Name = "txtAnular";
            this.txtAnular.Size = new System.Drawing.Size(69, 28);
            this.txtAnular.TabIndex = 8;
            this.txtAnular.Text = "Anular";
            this.txtAnular.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nro Documento";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(136, 106);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 20);
            this.textBox1.TabIndex = 6;
            // 
            // frmAnularCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 265);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtAnular);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmAnularCompra";
            this.Text = "frmAnularCompra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFactura;
        private System.Windows.Forms.RadioButton rbBoleta;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button txtAnular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}