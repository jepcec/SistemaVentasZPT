using CapaLogica;
using CapaPresentacion.Mantenimiento;
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
    public partial class frmCompra : Form
    {
        cCompra oCompra = new cCompra();
        cDetalleCompra oDetalleCompra = new cDetalleCompra();
        public frmCompra()
        {
            InitializeComponent();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oCompra.IdEmpleado = txtIDEmpleado.Text;
            oCompra.IdProveedor = txtIdProveedor.Text;
            if (rbBoleta.Checked) oCompra.TipoDocumento = "BOLETA";
            else oCompra.TipoDocumento = "FACTURA";
            oCompra.NumeroDocumento = txtNroDocumento.Text;
            oCompra.MontoTotal = decimal.Parse(txtMontoTotal.Text);
            oCompra.FechaRegistro = dtpFechaRegistro.Value;
            oCompra.Insertar();

            //int maxIdVenta = oCompra.RecureparMaxID();
            //ocular IDProdcuto
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                oDetalleCompra.IdCompra = oCompra.IdCompra;
                oDetalleCompra.IdProducto = dgvProductos.Rows[i].Cells["coIdProducto"].ToString();
                oDetalleCompra.PrecioCompra = decimal.Parse(dgvProductos.Rows[i].Cells["PrecioCompra"].ToString());
                oDetalleCompra.PrecioVenta = decimal.Parse(dgvProductos.Rows[i].Cells["PrecioVenta"].ToString());
                oDetalleCompra.Cantidad = int.Parse(dgvProductos.Rows[i].Cells["Cantidad"].ToString());
                oDetalleCompra.MontoTotal = decimal.Parse(dgvProductos.Rows[i].Cells["MontoTotal"].ToString());
                oDetalleCompra.FechaRegistro = DateTime.Now;
                oDetalleCompra.Insertar();
            }
            lblMensaje.Text = oCompra.Mensaje;
            tMensaje.Start();
            CargarFormularioCombrobante();
            LimpiarTextbox();
        }
        private void LimpiarTextbox()
        {
            dgvProductos.Rows.Clear();
            txtIdProveedor.Text = "";
            txtDocumentoProveedor.Text = "";
            txtRazonSocial.Text = "";
            txtCorreoProveedor.Text = "";
            txtTelefonoProveedor.Text = "";
            txtEstadoProveedor.Text = "";

            txtNroDocumento.Text = "";
        }
        private void CargarFormularioCombrobante()
        {

        }
        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            string TipoDocumento = rbBoleta.Checked ? "BOLETA" : "FACTURA";
            oCompra.TipoDocumento = TipoDocumento;
            txtNroDocumento.Text = oCompra.GenerarNroDocumento();
        }

        public string IdProveedorDialog {  get; set; }
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            using (var formBuscarProducto = new sfrmBuscarProveedor(this))
            {
                DialogResult resultado = formBuscarProducto.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    cProveedor auxProveedor = new cProveedor();
                    auxProveedor.IdProveedor = IdProveedorDialog;
                    auxProveedor.CargarInformacion();
                }
            }
        }
        int tiempoMensaje = 10;
        private void tMensaje_Tick(object sender, EventArgs e)
        {
            tiempoMensaje--;
            if (tiempoMensaje == 0)
            {
                tiempoMensaje = 10;
                lblMensaje.Visible = false;
            }
        }
    }
}
