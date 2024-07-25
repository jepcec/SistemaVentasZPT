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

namespace CapaPresentacion.Mantenimiento
{
    public partial class frmProducto : Form
    {
        cProducto oProducto = new cProducto();
        cUtilitarios oUtilitarios = new cUtilitarios();
        public frmProducto()
        {
            InitializeComponent();
        }

        private void frmProducto_Load(object sender, EventArgs e)
        {
            Listar();
            CargarFotoDefault();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = oProducto.SiguienteID();
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtIdCategoria.Text = "";
            txtStock.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            CargarFotoDefault();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            oProducto.Codigo = txtCodigo.Text;
            oProducto.Nombre = txtNombre.Text;
            oProducto.Descripcion = txtDescripcion.Text;
            oProducto.IdCategoria = txtIdCategoria.Text;
            oProducto.Stock = int.Parse(txtStock.Text);
            oProducto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            oProducto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            oProducto.Estado = txtEstado.Text;
            oProducto.FechaRegistro = dtpFechaRegistro.Value;
            oProducto.Imagen = oUtilitarios.Image2Bytes(pbFoto.Image);
            oProducto.Insertar();
            lblMensaje.Text = oProducto.Mensaje;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oProducto.Codigo = txtCodigo.Text;
            oProducto.Nombre = txtNombre.Text;
            oProducto.Descripcion = txtDescripcion.Text;
            oProducto.IdCategoria = txtIdCategoria.Text;
            oProducto.Stock = int.Parse(txtStock.Text);
            oProducto.PrecioCompra = decimal.Parse(txtPrecioCompra.Text);
            oProducto.PrecioVenta = decimal.Parse(txtPrecioVenta.Text);
            oProducto.Estado = txtEstado.Text;
            oProducto.FechaRegistro = dtpFechaRegistro.Value;
            oProducto.Imagen = oUtilitarios.Image2Bytes(pbFoto.Image);
            oProducto.Modificar();
            lblMensaje.Text = oProducto.Mensaje;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                lblMensaje.Text = "Sin ID";
                return;
            }
            oProducto.IdProducto = txtID.Text;
            oProducto.Eliminar();
            lblMensaje.Text = oProducto.Mensaje;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtIdCategoria.Text = "";
            txtStock.Text = "";
            txtPrecioCompra.Text = "";
            txtPrecioVenta.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            CargarFotoDefault();
            dgvProducto.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            
            if (ofdFoto.ShowDialog() == DialogResult.OK) pbFoto.Image = Image.FromFile(ofdFoto.FileName);
            else CargarFotoDefault();
        }

        private void FC_ClickRellenar(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                string idProducto = dgvProducto.SelectedRows[0].Cells[0].Value.ToString();
                string codigo = dgvProducto.SelectedRows[0].Cells[1].Value.ToString();
                string nombre = dgvProducto.SelectedRows[0].Cells[2].Value.ToString();
                string descripcion = dgvProducto.SelectedRows[0].Cells[3].Value.ToString();
                string idCategoria = dgvProducto.SelectedRows[0].Cells[4].Value.ToString();
                string stock = dgvProducto.SelectedRows[0].Cells[5].Value.ToString();
                string precioCompra = dgvProducto.SelectedRows[0].Cells[6].Value.ToString();
                string precioVenta = dgvProducto.SelectedRows[0].Cells[7].Value.ToString();
                string estado = dgvProducto.SelectedRows[0].Cells[8].Value.ToString();
                var fechaRegistro = dgvProducto.SelectedRows[0].Cells[9].Value.ToString();
                var foto = dgvProducto.SelectedRows[0].Cells[10].Value as byte[];

                txtCodigo.Text = codigo;
                txtNombre.Text = nombre;
                txtDescripcion.Text = descripcion;
                txtIdCategoria.Text = idCategoria;
                txtStock.Text = stock;
                txtPrecioCompra.Text = precioCompra;
                txtPrecioVenta.Text = precioVenta;
                txtEstado.Text = estado;
                DateTime fechaRegistroAux = DateTime.Now;
                if (DateTime.TryParse(fechaRegistro, out fechaRegistroAux)) dtpFechaRegistro.Value = fechaRegistroAux;
                if (foto != null) pbFoto.Image = oUtilitarios.Bytes2Image(foto);
                else CargarFotoDefault();
            }
        }

        private void FC_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                string idProducto = dgvProducto.SelectedRows[0].Cells[0].Value.ToString();
                oProducto.IdProducto = idProducto;
                oProducto.Eliminar();
                lblMensaje.Text = oProducto.Mensaje;
            }
        }

        private void Listar()
        {
            dgvProducto.DataSource = oProducto.Listar();
        }

        private void CargarFotoDefault()
        {
            // Implementa el método para cargar una foto predeterminada
        }
    }
}
