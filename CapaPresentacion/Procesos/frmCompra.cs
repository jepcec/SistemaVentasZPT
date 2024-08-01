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

        cEmpleado oEmpleado = new cEmpleado();
        public frmCompra(string correoEmpleado)
        {
            InitializeComponent();
            oEmpleado.Correo = correoEmpleado;
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            oEmpleado.CargarInformacion();
            txtIDEmpleado.Text = oEmpleado.IdEmpleado;
            txtNombreEmpleado.Text = oEmpleado.NombreCompleto;
            unableControls();
        }

        private void unableControls()
        {
            txtIdProveedor.Enabled = false;
            txtDocumentoProveedor.Enabled = false;
            txtRazonSocial.Enabled = false;
            txtCorreoProveedor.Enabled = false;
            txtTelefonoProveedor.Enabled = false;
            txtEstadoProveedor.Enabled = false;
            txtNroDocumento.Enabled = false;
            dtpFechaRegistro.Enabled = false;
            txtIDEmpleado.Enabled = false;
            txtNombreEmpleado.Enabled = false;

            txtSubTotal.Enabled = false;
            txtIGV.Enabled = false;
            txtMontoTotal.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            oCompra.IdCompra = oCompra.SiguienteID();
            MessageBox.Show(oCompra.IdCompra);
            oCompra.IdEmpleado = txtIDEmpleado.Text;
            oCompra.IdProveedor = txtIdProveedor.Text;
            oCompra.TipoDocumento = "FACTURA";
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
                oDetalleCompra.PrecioCompra = decimal.Parse(dgvProductos.Rows[i].Cells["coPrecioCompra"].Value.ToString());
                oDetalleCompra.PrecioVenta = decimal.Parse(dgvProductos.Rows[i].Cells["coPrecioVenta"].Value.ToString());
                oDetalleCompra.Cantidad = int.Parse(dgvProductos.Rows[i].Cells["coCantidad"].Value.ToString());
                oDetalleCompra.MontoTotal = decimal.Parse(dgvProductos.Rows[i].Cells["coMontoTotal"].Value.ToString());
                oDetalleCompra.Insertar();
            }
            tiempoMensaje = 10;
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
            string TipoDocumento = "FACTURA";
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
                    if(auxProveedor.Estado == "True")
                    {
                        txtIdProveedor.Text = auxProveedor.IdProveedor;
                        txtDocumentoProveedor.Text = auxProveedor.Documento;
                        txtRazonSocial.Text = auxProveedor.RazonSocial;
                        txtCorreoProveedor.Text = auxProveedor.Correo;
                        txtTelefonoProveedor.Text = auxProveedor.Telefono;
                        txtEstadoProveedor.Text = auxProveedor.Estado;
                    }
                    
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
        private void ReiniciarTiempoMensaje(int t = 10)
        {
            tiempoMensaje = t;
        }

        public string IdProductoDialog {  get; set; }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using (var formBuscarProducto = new sfrmBuscarProductoCompra(this))
            {
                DialogResult resultado = formBuscarProducto.ShowDialog();
                if (resultado == DialogResult.OK)
                {
                    cProducto auxProducto = new cProducto();
                    auxProducto.IdProducto = IdProductoDialog;
                    auxProducto.CargarInformacion();
                    RellenarProductos(dgvProductos, auxProducto);
                }
                else if (resultado == DialogResult.Cancel)
                {
                    string mensaje = "Sin stock";
                    lblMensaje.Text = mensaje;
                }
            }
        }
        private void RellenarProductos(DataGridView pdgvProductos, cProducto producto)
        {
            pdgvProductos.Rows.Add(producto.IdProducto, producto.Nombre, producto.PrecioCompra, producto.PrecioVenta,  1, producto.PrecioCompra);
            CalcularTotal();
            //pdgvProductos.Rows.Add(producto.IdProducto, producto.Codigo, producto.Nombre, producto.Descripcion, 
            //                       producto.IdCategoria, producto.Stock, producto.PrecioCompra, producto.PrecioVenta, 
            //                       producto.Estado, producto.FechaRegistro, producto.Imagen);

        }
        private void FC_ActualizarMontos(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow Fila = dgvProductos.CurrentRow;
            if (Fila != null && dgvProductos.Rows.Count > 0)
            {
                Fila.Cells["coMontoTotal"].Value = decimal.Parse(Fila.Cells["coPrecioCompra"].Value.ToString()) * decimal.Parse(Fila.Cells["coCantidad"].Value.ToString());
            }
            CalcularTotal();
        }
        private void dgvProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            decimal Subtotal = 0;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                Subtotal += Convert.ToDecimal(row.Cells["coMontoTotal"].Value.ToString());
            }
            txtSubTotal.Text = Subtotal.ToString("0.00");
            txtIGV.Text = (Subtotal * 18 / 100).ToString("0.00");
            txtMontoTotal.Text = (Subtotal + Subtotal * 18 / 100).ToString("0.00");
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
