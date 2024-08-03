using CapaLogica;
using CapaPresentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Procesos
{
    public partial class frmAnularVenta : Form
    {
        
        public frmAnularVenta()
        {
            InitializeComponent();
        }
        cVenta oventa = new cVenta();

        public string IdVentaDialog { get; set; }
        private void btnBuscarVenta_Click(object sender, EventArgs e)
        {
            string tipoComprobante = rbBoleta.Checked ? "BOLETA" : "FACTURA";
            using(sfrmBuscarVenta venta = new sfrmBuscarVenta(this,tipoComprobante))
            {
                DialogResult resultado = venta.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                    oventa.IdVenta = IdVentaDialog;
                    oventa.CargarInformacion();
                    txtNroDocumento.Text = oventa.NumeroDocumento;
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            oventa.AnularVenta();
            lblMensaje.Text = oventa.Mensaje;
            tMensaje.Start();
            
        }
        int tiempoMensaje = 5;
        private void tMensaje_Tick(object sender, EventArgs e)
        {
            tiempoMensaje--;
            if(tiempoMensaje == 0)
            {
                tiempoMensaje = 5;
                lblMensaje.Text = "";
                txtNroDocumento.Text = "";
            }
        }
    }
}
