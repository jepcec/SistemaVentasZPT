using CapaLogica;
using CapaPresentacion.Procesos;
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
    public partial class sfrmBuscarCliente : Form
    {
        cCliente oCliente = new cCliente();
        frmVenta formPadre { get; set; }
        public sfrmBuscarCliente(Form padre)
        {
            InitializeComponent();
            formPadre = (frmVenta)padre;
        }
        private void sfrmBuscarCliente_Load(object sender, EventArgs e)
        {
            dgvCliente.DataSource = oCliente.Listar();
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvCliente.CurrentRow;
            if (Fila != null)
            {
                formPadre.CorreoDialog = Fila.Cells["Correo"].Value.ToString();
                DialogResult = DialogResult.OK;
            } 
            else DialogResult = DialogResult.Cancel;
            
        }
        public void FC_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvCliente.CurrentRow;
            if (Fila != null) formPadre.CorreoDialog = Fila.Cells["Correo"].Value.ToString();
            else DialogResult = DialogResult.Cancel;
            DialogResult = DialogResult.OK;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        
    }
}
