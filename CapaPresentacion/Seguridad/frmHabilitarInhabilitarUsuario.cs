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

namespace CapaPresentacion.Seguridad
{
    public partial class frmHabilitarInhabilitarUsuario : Form
    {
        cEmpleado oEmpleado = new cEmpleado();

        public frmHabilitarInhabilitarUsuario()
        {
            InitializeComponent();
            oEmpleado.Listar();
            btnImprimir.Enabled = false;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvEmpleado.CurrentRow;
            oEmpleado.IdEmpleado = Fila.Cells["IdEmpleado"].Value.ToString();
            oEmpleado.Estado = Fila.Cells["Estado"].Value.ToString();
            oEmpleado.ActualizarEstado();
            lblMensaje.Text = oEmpleado.Mensaje;
        }

        private void dgvEmpleado_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow Fila = dgvEmpleado.CurrentRow;
            if (Fila != null) btnImprimir.Enabled = true;
            else btnImprimir.Enabled = false;
        }
    }
}
