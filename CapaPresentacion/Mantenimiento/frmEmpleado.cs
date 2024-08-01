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
    public partial class frmEmpleado : Form
    {
        cEmpleado oEmpleado = new cEmpleado();
        cUtilitarios oUtilitarios = new cUtilitarios();
        public frmEmpleado()
        {
            InitializeComponent();
        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {
            Listar();
            CargarFotoDefault();
            txtID.Enabled = false;
            dtpFechaRegistro.Enabled = false;
            txtEstado.Enabled = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = oEmpleado.SiguienteID();
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtIdRol.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            CargarFotoDefault();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            oEmpleado.Documento = txtDocumento.Text;
            oEmpleado.NombreCompleto = txtNombre.Text;
            oEmpleado.Correo = txtCorreo.Text;
            oEmpleado.Clave = txtClave.Text;
            oEmpleado.IdRol = txtIdRol.Text;
            oEmpleado.Estado = txtEstado.Text;
            oEmpleado.FechaRegistro = dtpFechaRegistro.Value;
            oEmpleado.Imagen = oUtilitarios.Image2Bytes(pbFoto.Image);
            oEmpleado.Insertar();
            lblMensaje.Text = oEmpleado.Mensaje;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oEmpleado.IdEmpleado = txtID.Text;
            oEmpleado.Documento = txtDocumento.Text;
            oEmpleado.NombreCompleto = txtNombre.Text;
            oEmpleado.Correo = txtCorreo.Text;
            oEmpleado.Clave = txtClave.Text;
            oEmpleado.IdRol = txtIdRol.Text;
            oEmpleado.Estado = txtEstado.Text;
            oEmpleado.FechaRegistro = dtpFechaRegistro.Value;
            oEmpleado.Imagen = oUtilitarios.Image2Bytes(pbFoto.Image);
            oEmpleado.Modificar();
            lblMensaje.Text = oEmpleado.Mensaje;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                lblMensaje.Text = "Sin ID";
                return;
            }
            oEmpleado.IdEmpleado = txtID.Text;
            oEmpleado.Eliminar();
            lblMensaje.Text = oEmpleado.Mensaje;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtClave.Text = "";
            txtIdRol.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            CargarFotoDefault();
            dgvEmpleado.ClearSelection();
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
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                string idEmpleado = dgvEmpleado.SelectedRows[0].Cells["IdEmpleado"].Value.ToString();
                string documento = dgvEmpleado.SelectedRows[0].Cells["Documento"].Value.ToString();
                string nombreEmpleado = dgvEmpleado.SelectedRows[0].Cells["NombreCompleto"].Value.ToString();
                string correo = dgvEmpleado.SelectedRows[0].Cells["Correo"].Value.ToString();
                string Clave = dgvEmpleado.SelectedRows[0].Cells["Clave"].Value.ToString();
                string idRol = dgvEmpleado.SelectedRows[0].Cells["IdRol"].Value.ToString();
                string estado = dgvEmpleado.SelectedRows[0].Cells["Estado"].Value.ToString();
                var fechaRegistro = dgvEmpleado.SelectedRows[0].Cells["FechaRegistro"].Value.ToString();
                var foto = dgvEmpleado.SelectedRows[0].Cells["Imagen"].Value as byte[];
                txtID.Text = idEmpleado;
                txtDocumento.Text = documento;
                txtNombre.Text = nombreEmpleado;
                txtCorreo.Text = correo;
                txtClave.Text = Clave;
                txtIdRol.Text = idRol;
                txtEstado.Text = estado;
                DateTime fechaRegistroAux = DateTime.Now;
                if (DateTime.TryParse(fechaRegistro, out fechaRegistroAux)) dtpFechaRegistro.Value = fechaRegistroAux;
                if (foto != null) pbFoto.Image = oUtilitarios.Bytes2Image(foto);
                else CargarFotoDefault();

            }
        }
        private void FC_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleado.SelectedRows.Count > 0)
            {
                string idEmpleado= dgvEmpleado.SelectedRows[0].Cells[0].Value.ToString();
                oEmpleado.IdEmpleado = idEmpleado;
                oEmpleado.Eliminar();
                lblMensaje.Text = oEmpleado.Mensaje;
            }
        }
        private void Listar()
        {
            dgvEmpleado.DataSource = oEmpleado.Listar();
        }
        private void CargarFotoDefault()
        {
            
        }
    }
}