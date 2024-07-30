using CapaLogica;
using CapaPresentacion.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Mantenimiento
{
    public partial class sfrmBuscarProveedor : Form
    {
        frmCompra frmCompra {  get; set; }
        cProveedor oProveedor = new cProveedor();
        public sfrmBuscarProveedor(frmCompra padre)
        {
            InitializeComponent();
            this.frmCompra = padre;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvProveedor.CurrentRow;
            if (Fila != null)
            {
                frmCompra.IdProveedorDialog = Fila.Cells["IdProducto"].Value.ToString();
                DialogResult = DialogResult.OK;
            }
            else DialogResult = DialogResult.Cancel;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        public void FC_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvProveedor.CurrentRow;
            if (Fila != null) frmCompra.IdProveedorDialog = Fila.Cells["IdProducto"].Value.ToString();
            else DialogResult = DialogResult.Cancel;
            DialogResult = DialogResult.OK;
        }
    }
}
