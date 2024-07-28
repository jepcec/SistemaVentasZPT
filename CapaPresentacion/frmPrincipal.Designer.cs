﻿namespace CapaPresentacion
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
            this.tsmCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmpleado = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProducto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProveedor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProcesos = new System.Windows.Forms.ToolStripMenuItem();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anularVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInformes = new System.Windows.Forms.ToolStripMenuItem();
            this.boletaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturaDeVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habilitarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.ssInformacion = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssRol = new System.Windows.Forms.ToolStripStatusLabel();
            this.facturaDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmInformes,
            this.seguridadToolStripMenuItem});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msPrincipal.Size = new System.Drawing.Size(1036, 28);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmIniciarSesion
            // 
            this.tsmIniciarSesion.Name = "tsmIniciarSesion";
            this.tsmIniciarSesion.Size = new System.Drawing.Size(108, 24);
            this.tsmIniciarSesion.Text = "Iniciar Sesion";
            this.tsmIniciarSesion.Click += new System.EventHandler(this.tsmIniciarSesion_Click);
            // 
            // tsmMantenimiento
            // 
            this.tsmMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCliente,
            this.tsmEmpleado,
            this.tsmProducto,
            this.tsmProveedor});
            this.tsmMantenimiento.Name = "tsmMantenimiento";
            this.tsmMantenimiento.Size = new System.Drawing.Size(122, 24);
            this.tsmMantenimiento.Text = "Mantenimiento";
            // 
            // tsmCliente
            // 
            this.tsmCliente.Name = "tsmCliente";
            this.tsmCliente.Size = new System.Drawing.Size(152, 26);
            this.tsmCliente.Text = "Cliente";
            this.tsmCliente.Click += new System.EventHandler(this.tsmCliente_Click);
            // 
            // tsmEmpleado
            // 
            this.tsmEmpleado.Name = "tsmEmpleado";
            this.tsmEmpleado.Size = new System.Drawing.Size(152, 26);
            this.tsmEmpleado.Text = "Empleado";
            this.tsmEmpleado.Click += new System.EventHandler(this.tsmEmpleado_Click);
            // 
            // tsmProducto
            // 
            this.tsmProducto.Name = "tsmProducto";
            this.tsmProducto.Size = new System.Drawing.Size(152, 26);
            this.tsmProducto.Text = "Producto";
            this.tsmProducto.Click += new System.EventHandler(this.tsmProducto_Click);
            // 
            // tsmProveedor
            // 
            this.tsmProveedor.Name = "tsmProveedor";
            this.tsmProveedor.Size = new System.Drawing.Size(152, 26);
            this.tsmProveedor.Text = "Proveedor";
            this.tsmProveedor.Click += new System.EventHandler(this.tsmProveedor_Click);
            // 
            // tsmProcesos
            // 
            this.tsmProcesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.compraToolStripMenuItem,
            this.ventaToolStripMenuItem,
            this.anularCompraToolStripMenuItem,
            this.anularVentaToolStripMenuItem});
            this.tsmProcesos.Name = "tsmProcesos";
            this.tsmProcesos.Size = new System.Drawing.Size(79, 24);
            this.tsmProcesos.Text = "Procesos";
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.compraToolStripMenuItem.Text = "Compra";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.ventaToolStripMenuItem.Text = "Venta";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // anularCompraToolStripMenuItem
            // 
            this.anularCompraToolStripMenuItem.Name = "anularCompraToolStripMenuItem";
            this.anularCompraToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.anularCompraToolStripMenuItem.Text = "Anular compra";
            // 
            // anularVentaToolStripMenuItem
            // 
            this.anularVentaToolStripMenuItem.Name = "anularVentaToolStripMenuItem";
            this.anularVentaToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.anularVentaToolStripMenuItem.Text = "Anular venta";
            // 
            // tsmInformes
            // 
            this.tsmInformes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletaDeVentasToolStripMenuItem,
            this.facturaDeVentasToolStripMenuItem,
            this.facturaDeComprasToolStripMenuItem});
            this.tsmInformes.Name = "tsmInformes";
            this.tsmInformes.Size = new System.Drawing.Size(79, 24);
            this.tsmInformes.Text = "Informes";
            // 
            // boletaDeVentasToolStripMenuItem
            // 
            this.boletaDeVentasToolStripMenuItem.Name = "boletaDeVentasToolStripMenuItem";
            this.boletaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.boletaDeVentasToolStripMenuItem.Text = "Boleta de Ventas";
            this.boletaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.boletaDeVentasToolStripMenuItem_Click);
            // 
            // facturaDeVentasToolStripMenuItem
            // 
            this.facturaDeVentasToolStripMenuItem.Name = "facturaDeVentasToolStripMenuItem";
            this.facturaDeVentasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.facturaDeVentasToolStripMenuItem.Text = "Factura de Ventas";
            this.facturaDeVentasToolStripMenuItem.Click += new System.EventHandler(this.facturaDeVentasToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarContraseñaToolStripMenuItem,
            this.habilitarToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar contraseña";
            // 
            // habilitarToolStripMenuItem
            // 
            this.habilitarToolStripMenuItem.Name = "habilitarToolStripMenuItem";
            this.habilitarToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.habilitarToolStripMenuItem.Text = "Habilitar Inhabilitar Usuario";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(1012, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(24, 24);
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
            this.tssRol});
            this.ssInformacion.Location = new System.Drawing.Point(0, 578);
            this.ssInformacion.Name = "ssInformacion";
            this.ssInformacion.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssInformacion.Size = new System.Drawing.Size(1036, 26);
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
            // tssRol
            // 
            this.tssRol.AutoSize = false;
            this.tssRol.Name = "tssRol";
            this.tssRol.Size = new System.Drawing.Size(151, 21);
            this.tssRol.Text = "usuario";
            // 
            // facturaDeComprasToolStripMenuItem
            // 
            this.facturaDeComprasToolStripMenuItem.Name = "facturaDeComprasToolStripMenuItem";
            this.facturaDeComprasToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.facturaDeComprasToolStripMenuItem.Text = "Factura de Compras";
            this.facturaDeComprasToolStripMenuItem.Click += new System.EventHandler(this.facturaDeComprasToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1036, 604);
            this.Controls.Add(this.ssInformacion);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.msPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FC_StartFormPrincipal);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.ssInformacion.ResumeLayout(false);
            this.ssInformacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        public System.Windows.Forms.ToolStripStatusLabel tssRol;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habilitarToolStripMenuItem;
        public System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmCliente;
        private System.Windows.Forms.ToolStripMenuItem tsmEmpleado;
        private System.Windows.Forms.ToolStripMenuItem tsmProducto;
        private System.Windows.Forms.ToolStripMenuItem tsmProveedor;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anularVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaDeVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturaDeComprasToolStripMenuItem;
    }
}