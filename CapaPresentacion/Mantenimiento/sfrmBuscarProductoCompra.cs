﻿using CapaLogica;
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
    public partial class sfrmBuscarProductoCompra : Form
    {
        frmCompra formPadre { get; set; }
        cProducto oProducto = new cProducto();
        public sfrmBuscarProductoCompra(frmCompra padre)
        {
            InitializeComponent();
            formPadre = padre;
            dgvProducto.DataSource = oProducto.Listar();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvProducto.CurrentRow;
            if (Fila != null)
            {
                formPadre.IdProductoDialog = Fila.Cells["IdProducto"].Value.ToString();
                DialogResult = DialogResult.OK;
            }
            else DialogResult = DialogResult.Cancel;
        }
        public void FC_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow Fila = dgvProducto.CurrentRow;
            if (Fila != null) formPadre.IdProductoDialog = Fila.Cells["IdProducto"].Value.ToString();
            else DialogResult = DialogResult.Cancel;
            DialogResult = DialogResult.OK;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void sfrmBuscarProductoCompra_Load(object sender, EventArgs e)
        {

        }
    }
}
