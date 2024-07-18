namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmIniciarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.ssInformacion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msPrincipal.SuspendLayout();
            this.ssInformacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmIniciarSesion,
            this.tsmMantenimiento,
            this.tsmProcesos,
            this.tsmInformes});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(776, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmIniciarSesion
            // 
            this.tsmIniciarSesion.Name = "tsmIniciarSesion";
            this.tsmIniciarSesion.Size = new System.Drawing.Size(88, 20);
            this.tsmIniciarSesion.Text = "Iniciar Sesion";
            this.tsmIniciarSesion.Click += new System.EventHandler(this.tsmIniciarSesion_Click);
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.tsmMantenimiento.Text = "Mantenimiento";
            // 
            // tsmProcesos
            // 
            this.tsmProcesos.Name = "tsmProcesos";
            this.tsmProcesos.Size = new System.Drawing.Size(66, 20);
            this.tsmProcesos.Text = "Procesos";
            // 
            // tsmInformes
            // 
            this.tsmInformes.Name = "tsmInformes";
            this.tsmInformes.Size = new System.Drawing.Size(66, 20);
            this.tsmInformes.Text = "Informes";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(749, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 23);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ssInformacion
            // 
            this.ssInformacion.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssInformacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.ssInformacion.Location = new System.Drawing.Point(0, 465);
            this.ssInformacion.Name = "ssInformacion";
            this.ssInformacion.Size = new System.Drawing.Size(776, 26);
            this.ssInformacion.TabIndex = 4;
            this.ssInformacion.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 21);
            this.toolStripStatusLabel1.Text = "pc";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(151, 21);
            this.toolStripStatusLabel2.Text = "pc";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.AutoSize = false;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(151, 21);
            this.toolStripStatusLabel3.Text = "hora";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(151, 21);
            this.toolStripStatusLabel4.Text = "fecha";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(151, 21);
            this.toolStripStatusLabel5.Text = "usuario";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(776, 491);
            this.Controls.Add(this.ssInformacion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.msPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.FC_StartFormPrincipal);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ssInformacion.ResumeLayout(false);
            this.ssInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmIniciarSesion;
        private System.Windows.Forms.ToolStripMenuItem tsmMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem tsmProcesos;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ToolStripMenuItem tsmInformes;
        private System.Windows.Forms.StatusStrip ssInformacion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}