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
    public partial class frmProveedor : Form
    {
        private cProveedor oProveedor = new cProveedor();

        public frmProveedor()
        {
            InitializeComponent();
        }

        private void frmProveedor_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = oProveedor.SiguienteID();
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            oProveedor.Documento = txtDocumento.Text;
            oProveedor.RazonSocial = txtRazonSocial.Text;
            oProveedor.Correo = txtCorreo.Text;
            oProveedor.Telefono = txtTelefono.Text;
            oProveedor.Estado = txtEstado.Text;
            oProveedor.FechaRegistro = dtpFechaRegistro.Value;
            oProveedor.Insertar();
            lblMensaje.Text = oProveedor.Mensaje;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oProveedor.Documento = txtDocumento.Text;
            oProveedor.RazonSocial = txtRazonSocial.Text;
            oProveedor.Correo = txtCorreo.Text;
            oProveedor.Telefono = txtTelefono.Text;
            oProveedor.Estado = txtEstado.Text;
            oProveedor.FechaRegistro = dtpFechaRegistro.Value;
            oProveedor.Modificar();
            lblMensaje.Text = oProveedor.Mensaje;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                lblMensaje.Text = "Sin ID";
                return;
            }
            oProveedor.IdProveedor = txtID.Text;
            oProveedor.Eliminar();
            lblMensaje.Text = oProveedor.Mensaje;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            dgvProveedor.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvProveedor_ClickRellenar(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                string idProveedor = dgvProveedor.SelectedRows[0].Cells[0].Value.ToString();
                string documento = dgvProveedor.SelectedRows[0].Cells[1].Value.ToString();
                string razonSocial = dgvProveedor.SelectedRows[0].Cells[2].Value.ToString();
                string correo = dgvProveedor.SelectedRows[0].Cells[3].Value.ToString();
                string telefono = dgvProveedor.SelectedRows[0].Cells[4].Value.ToString();
                string estado = dgvProveedor.SelectedRows[0].Cells[5].Value.ToString();
                var fechaRegistro = dgvProveedor.SelectedRows[0].Cells[6].Value.ToString();
                txtID.Text = idProveedor;
                txtDocumento.Text = documento;
                txtRazonSocial.Text = razonSocial;
                txtCorreo.Text = correo;
                txtTelefono.Text = telefono;
                txtEstado.Text = estado;
                DateTime fechaRegistroAux = DateTime.Now;
                if (DateTime.TryParse(fechaRegistro, out fechaRegistroAux)) dtpFechaRegistro.Value = fechaRegistroAux;
            }
        }

        private void dgvProveedor_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProveedor.SelectedRows.Count > 0)
            {
                string idProveedor = dgvProveedor.SelectedRows[0].Cells[0].Value.ToString();
                oProveedor.IdProveedor = idProveedor;
                oProveedor.Eliminar();
                lblMensaje.Text = oProveedor.Mensaje;
            }
        }

        private void Listar()
        {
            dgvProveedor.DataSource = oProveedor.Listar();
        }
    }
}
