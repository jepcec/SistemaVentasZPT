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
using System.Xml.Linq;

namespace CapaPresentacion.Mantenimiento
{
    public partial class frmCliente : Form
    {
        cCliente oCliente = new cCliente();
        public frmCliente()
        {
            InitializeComponent();
        }
        private void frmCliente_Load(object sender, EventArgs e)
        {
            Listar();
            dtpFechaRegistro.Enabled = false;
            txtEstado.Enabled = false;
            txtID.Enabled = false;
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = oCliente.SiguienteID();
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            oCliente.Documento = txtDocumento.Text;
            oCliente.NombreCompleto = txtNombre.Text;
            oCliente.Correo = txtCorreo.Text;
            oCliente.Telefono = txtTelefono.Text;
            oCliente.Estado = txtEstado.Text;
            oCliente.FechaRegistro = dtpFechaRegistro.Value;
            oCliente.Insertar();
            lblMensaje.Text = oCliente.Mensaje;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oCliente.IdCliente = txtID.Text;
            oCliente.Documento = txtDocumento.Text;
            oCliente.NombreCompleto = txtNombre.Text;
            oCliente.Correo = txtCorreo.Text;
            oCliente.Telefono = txtTelefono.Text;
            oCliente.Estado = txtEstado.Text;
            oCliente.FechaRegistro = dtpFechaRegistro.Value;
            oCliente.Modificar();
            lblMensaje.Text = oCliente.Mensaje;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                lblMensaje.Text = "Sin ID";
                return;
            }
            oCliente.IdCliente = txtID.Text;
            oCliente.Eliminar();
            lblMensaje.Text = oCliente.Mensaje;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtEstado.Text = "";
            dtpFechaRegistro.Value = DateTime.Now;
            dgvCliente.ClearSelection();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void FC_ClickRellenar(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                string idCliente = dgvCliente.SelectedRows[0].Cells[0].Value.ToString();
                string documento = dgvCliente.SelectedRows[0].Cells[1].Value.ToString();
                string nombreCliente = dgvCliente.SelectedRows[0].Cells[2].Value.ToString();
                string correo = dgvCliente.SelectedRows[0].Cells[3].Value.ToString();
                string telefono = dgvCliente.SelectedRows[0].Cells[4].Value.ToString();
                string estado = dgvCliente.SelectedRows[0].Cells[5].Value.ToString();
                var fechaRegistro = dgvCliente.SelectedRows[0].Cells[6].Value.ToString();
                txtID.Text = idCliente;
                txtDocumento.Text = documento;
                txtNombre.Text = nombreCliente;
                txtCorreo.Text = correo;
                txtTelefono.Text = telefono;
                txtEstado.Text = estado;
                DateTime fechaRegistroAux = DateTime.Now;
                if(DateTime.TryParse(fechaRegistro, out fechaRegistroAux)) dtpFechaRegistro.Value = fechaRegistroAux;

            }
        }
        private void FC_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCliente.SelectedRows.Count > 0)
            {
                string idCliente = dgvCliente.SelectedRows[0].Cells[0].Value.ToString();
                oCliente.IdCliente = idCliente;
                oCliente.Eliminar();
                lblMensaje.Text = oCliente.Mensaje;
            }
        }
        private void Listar()
        {
            dgvCliente.DataSource = oCliente.Listar();
        }

        
    }
}