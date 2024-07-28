using capaLogica;
using CapaLogica;
using CapaPresentacion.Mantenimiento;
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

        public frmVenta(string pUser)
        {
            InitializeComponent();
            usuario = pUser;
            
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

            if (rbBoleta.Checked)
            {
                oVenta.TipoDocumento = "Boleta";
            }
            else
            {
                oVenta.TipoDocumento = "Factura";
            }
            // --------------- asignar oVenta --------------------------
            //oVenta.NumeroDocumento = txtNrodocumento;
            //oVenta.emision = dtpFechaemision.value
            //oVenta.MontoTotal = decimal.Parse(txtMontoTotal);
            //oVenta.IdTipoComprovante = rbTipoBoleta
            //oVenta.Insertar();

            //int maxIdVenta = oVenta.RecureparMaxID();
            //ocular IDProdcuto
            for (int i = 0; i < dgvProductos.Rows.Count; i++)
            {
                //oDetalleVenta.Cantidad = dgvProductos.Rows[i][0].ToString(); comvertir a entero
                //oDetalleVenta.PrecioUnitario = dgvProductos.Rows[i][0].ToString(); comvertir a entero;
                //oDetalleVenta.IdProducto = AsignarProducto
                //oDetalleVenta.IdVenta = maxIdVenta;
                //oDetalleVenta.Insertar();
            }
            //lblMensaje.Text = oVenta.Mensaje;
            //Timer.Start(); --mensaje 
            //CargarFormularioReporteComprobante();
            //LimpiarTextbox();

            // -------- Cadavez que se ejecute un detalle venta ejecuta un trigger actualiza un stock del producto (SQL)
        }

        public string CorreoDialog {  get; set; }
        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            using(var formBuscarCliente = new sfrmBuscarCliente(this))
            {
                DialogResult resultado = formBuscarCliente.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                    cCliente clienteAux = new cCliente();
                    clienteAux.Correo = CorreoDialog;
                    clienteAux.CargarInformacion();

                    txtIdCliente.Text = clienteAux.IdCliente;
                    txtDocumentoCliente.Text = clienteAux.Documento;
                    txtNombreCliente.Text = clienteAux.NombreCompleto;
                    txtCorreoCliente.Text = clienteAux.Correo;
                    txtTelefonoCliente.Text = clienteAux.Telefono;                    
                }
            }
        }


        public string IdProductoDialog {  get; set; }
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            using(var formBuscarProducto = new sfrmBuscarProducto(this))
            {
                DialogResult resultado = formBuscarProducto.ShowDialog();
                if(resultado == DialogResult.OK)
                {
                    cProducto auxProducto = new cProducto();
                    auxProducto.IdProducto = IdProductoDialog;
                    auxProducto.CargarInformacion();
                    RellenarProductos(dgvProductos, auxProducto);

                }
            }
        }
        private void RellenarProductos(DataGridView pdgvProductos, cProducto producto)
        {
            pdgvProductos.Rows.Add(producto.IdProducto, producto.Codigo, producto.Nombre, producto.Descripcion, 
                                   producto.IdCategoria, producto.Stock, producto.PrecioCompra, producto.PrecioVenta, 
                                   producto.Estado, producto.FechaRegistro, producto.Imagen);

        }
    }
}