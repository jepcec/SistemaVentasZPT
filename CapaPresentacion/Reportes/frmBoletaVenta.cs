using CapaLogica;
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
    public partial class frmBoletaVenta : Form
    {
        cVenta oVenta = new cVenta();
        cDetalleVenta oDetalleVenta = new cDetalleVenta();

        public frmBoletaVenta()
        {
            InitializeComponent();
        }

        void actualizarLista()
        {
            string IdVenta = txtIdVenta.Text;
            string Campo = cbCampo.Text;
            string Contenido = txtContenido.Text;
            dgvProductos.DataSource = oDetalleVenta.BuscarProductos(IdVenta, Campo, Contenido);
        }

        public void actualizarMuestra(string idVenta)
        {
            // Recuperando Valores
            DataTable Venta = oVenta.Buscar("IdVenta", idVenta);
            DataRow VentaValores = Venta.Rows[0];
            // Mostrando Valores
            txtIdVenta.Text = VentaValores["IdVenta"].ToString();
            txtNroDocumento.Text = VentaValores["NumeroDocumento"].ToString();
            dtpFecha.Value = (DateTime)VentaValores["FechaRegistro"];
            txtIdEmpleado.Text = VentaValores["IdEmpleado"].ToString();
            txtNombreEmpleado.Text = VentaValores["NombreEmpleado"].ToString();
            txtMontoTotal.Text = VentaValores["MontoTotal"].ToString();
            txtMontoRecibido.Text = VentaValores["MontoPago"].ToString();
            txtMontoCambio.Text = VentaValores["MontoCambio"].ToString();
            txtDocumentoCliente.Text = VentaValores["DocumentoCliente"].ToString();
            txtNombreCliente.Text = VentaValores["NombreCliente"].ToString();
            // Mostrar Productos
            dgvProductos.DataSource = oDetalleVenta.ListarProductos(txtIdVenta.Text);
            cbCampo.Text = "NombreProducto";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sfrmBuscarVenta hijo = new sfrmBuscarVenta(this, "Boleta");
            hijo.Show();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }
    }
}
