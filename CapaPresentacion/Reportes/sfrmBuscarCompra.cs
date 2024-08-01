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

namespace CapaPresentacion.Reportes
{
    public partial class sfrmBuscarCompra : Form
    {
        string Comprobante;
        frmFacturaCompra frmPadre;
        cCompra oCompra = new cCompra();

        Form padre2;
        public sfrmBuscarCompra(Form Padre, string Tipo)
        {
            InitializeComponent();
            Comprobante = Tipo;
            lblTipo.Text = Tipo;
            padre2 = Padre;
            frmPadre = padre2 is frmFacturaCompra ? (frmFacturaCompra)Padre : null;
            actualizarLista();
        }

        void actualizarLista()
        {
            btnAceptar.Enabled = false;
            string Campo = cmbCampo.Text;
            string Contenido = txtContenido.Text;
            dgvComprobantes.DataSource = oCompra.BuscarComprobante(Comprobante, Campo, Contenido);
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void dgvComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAceptar.Enabled = true;
        }

        private void dgvComprobantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Fila = dgvComprobantes.CurrentRow;
            if (Fila != null) btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(frmPadre != null)
            {
                DataGridViewRow Fila = dgvComprobantes.CurrentRow;
                string Codigo = Fila.Cells["IdCompra"].Value.ToString();
                frmPadre.actualizarMuestra(Codigo);
                Close();
            }
            if(padre2 is frmAnularCompra anularCompra)
            {
                DataGridViewRow Fila = dgvComprobantes.CurrentRow;
                string Codigo = Fila.Cells["IdCompra"].Value.ToString();
                anularCompra.IdCompraDialog = Codigo;
                DialogResult = DialogResult.OK;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
