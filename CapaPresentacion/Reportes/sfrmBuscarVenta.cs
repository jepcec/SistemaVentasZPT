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
using CapaPresentacion.Procesos;

namespace CapaPresentacion.Reportes
{
    public partial class sfrmBuscarVenta : Form
    {
        string Comprobante;
        Form frmPadre;
        cVenta oVenta = new cVenta();
        
        public sfrmBuscarVenta(Form Padre, string Tipo)
        {
            InitializeComponent();
            Comprobante = Tipo;
            frmPadre = Padre;
            lblTipo.Text = Tipo;
            actualizarLista();
        }

        void actualizarLista()
        {
            btnAceptar.Enabled = false;
            string Campo = cmbCampo.Text;
            string Contenido = txtContenido.Text;
            dgvComprobantes.DataSource = oVenta.BuscarComprobante(Comprobante, Campo, Contenido);
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void dgvComprobantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Fila = dgvComprobantes.CurrentRow;
            if (Fila != null) btnAceptar.Enabled = true;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // ----------------------by esau : para formulario anularVenta-----------------------
            if (frmPadre is frmAnularVenta anularVenta) 
            {
                DataGridViewRow Fila = dgvComprobantes.CurrentRow;
                string Codigo = Fila.Cells["IdVenta"].Value.ToString();
                anularVenta.IdVentaDialog = Codigo;
                DialogResult = DialogResult.OK;
            } 
            // ----------------------------------------------------------------------------------
            else
            {
                DataGridViewRow Fila = dgvComprobantes.CurrentRow;
                string Codigo = Fila.Cells["IdVenta"].Value.ToString();
                if (frmPadre is frmBoletaVenta frmPadre1) frmPadre1.actualizarMuestra(Codigo);
                else if (frmPadre is frmFacturaVenta frmPadre2) frmPadre2.actualizarMuestra(Codigo);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
