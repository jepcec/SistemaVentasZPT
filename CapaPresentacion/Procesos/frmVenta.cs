using capaLogica;
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
using static System.Resources.ResXFileRef;

namespace CapaPresentacion.Procesos
{
    public partial class frmVenta : Form
    {
        public string usuario;
        cEmpleado oEmpleado = new cEmpleado();
        cUtilitarios oUtilitarioas = new cUtilitarios();


        cVenta oVenta = new cVenta();
        cDetalleVenta oDetalleVenta = new cDetalleVenta();

        //

        public frmVenta(string pUser)
        {
            InitializeComponent();
            usuario = pUser;
            MessageBox.Show("Usuario correcto" + pUser);
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            oEmpleado.Correo = usuario;
            oEmpleado.CargarInformacion();
            txtIDEmpleado.Text = oEmpleado.IdEmpleado;
            txtNombreEmpleado.Text = oEmpleado.NombreCompleto;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            oVenta.IdEmpleado = oEmpleado.IdEmpleado;
            if (rbBoleta.Checked) oVenta.TipoDocumento = "Boleta";
            else oVenta.TipoDocumento = "Factura";
            oVenta.NumeroDocumento = txtNroComprobante.Text;
            oVenta.DocumentoCliente = txtDocumento.Text;
            oVenta.NombreCliente = txtNombre.Text;
            //MontoPago
            //MontoCambio
            oVenta.MontoTotal = decimal.Parse(txtMontoTotal.Text);
            oVenta.FechaRegistro = dtpComprobante.Value;
            oVenta.Insertar();

            var maxIdVenta = oVenta.RecuperarIDMax();
            //ocular IDProdcuto
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                oDetalleVenta.Cantidad = int.Parse(dgvProductos.Rows[i].Cells[0].Value.ToString());
                oDetalleVenta.PrecioUnitario = int.Parse(dgvProductos.Rows[i].Cells[0].Value.ToString());
                oDetalleVenta.IdProducto = dgvProductos.Rows[i].Cells[0].Value.ToString();
                oDetalleVenta.IdVenta = maxIdVenta;
                oDetalleVenta.Insertar();
            }
            lblMensaje.Text = oVenta.Mensaje;
            //Timer.Start(); --mensaje 
            CargarFormularioReporteComprobante();
            //LimpiarTextbox();

            // -------- Cadavez que se ejecute un detalle venta ejecuta un trigger actualiza un stock del producto (SQL)
        }
        private void CargarFormularioReporteComprobante()
        {

        }

        
    }
}
