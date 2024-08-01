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
    public partial class frmAnularCompra : Form
    {
        public frmAnularCompra()
        {
            InitializeComponent();
        }

        public string IdCompraDialog { get; set; }
        cCompra oCompra = new cCompra();
        private void btnBuscarCompra_Click(object sender, EventArgs e)
        {
            string tipoComprobante = rbBoleta.Checked ? "BOLETA" : "FACTURA";
            using (sfrmBuscarCompra venta = new sfrmBuscarCompra(this, tipoComprobante))
            {
                DialogResult resultado = venta.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    oCompra.IdCompra = IdCompraDialog;
                    oCompra.CargarInformacion();
                    txtNroDocumento.Text = oCompra.NumeroDocumento;
                }
            }
        }

        private void txtAnular_Click(object sender, EventArgs e)
        {
            oCompra.Estado = false;
            oCompra.Modificar();
           
        }
    }
}
