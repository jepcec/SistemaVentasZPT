using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaPresentacion.Mantenimiento;
using CapaPresentacion.Procesos;


namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FC_StartFormPrincipal(object sender, EventArgs e)
        {
            CargarBarraEstado();
            TimerHoraSTM();
            msPrincipal.Enabled = false;
            Utilidades.VerificarFormulacionExistente<frmIniciarSesion>(this);
        }
        private void CargarBarraEstado()
        {
            toolStripStatusLabel1.Text = Environment.UserName;
            toolStripStatusLabel2.Text = Environment.MachineName;
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
            toolStripStatusLabel4.Text = DateTime.Now.ToLongDateString();
        }
        #region Otros
        private void HoraSTM(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = DateTime.Now.ToLongTimeString();
        }
        private Timer _horaSTM;
        private void TimerHoraSTM()
        {
            _horaSTM = new Timer();
            _horaSTM.Interval = 1000;
            _horaSTM.Tick += HoraSTM;
            _horaSTM.Start();

        }
        #endregion Otros
        #region ToolMenuStrip
        private void tsmIniciarSesion_Click(object sender, EventArgs e)
        {
            Utilidades.VerificarFormulacionExistente<frmIniciarSesion>(this);
        }
        private void tsmCliente_Click(object sender, EventArgs e)
        {
            Utilidades.VerificarFormulacionExistente<frmCliente>(this);
        }
        private void tsmEmpleado_Click(object sender, EventArgs e)
        {
            Utilidades.VerificarFormulacionExistente<frmEmpleado>(this);
        }

        private void tsmProducto_Click(object sender, EventArgs e)
        {
            Utilidades.VerificarFormulacionExistente<frmProducto>(this);
        }

        private void tsmProveedor_Click(object sender, EventArgs e)
        {
            Utilidades.VerificarFormulacionExistente<frmProveedor>(this);
        }


        #endregion ToolMenuStrip

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVenta venta = new frmVenta(ConfiguracionUsuario.Correo);
            venta.MdiParent = this;
            venta.Focus();
            venta.Show();
        }
    }
}
