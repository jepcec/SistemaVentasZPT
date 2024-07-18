using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmIniciarSesion : Form
    {
        int _tCuentaRegresiva = 60;
        int _tMensaje = 10;
        public frmIniciarSesion()
        {
            InitializeComponent();
            
        }
        public void FC_StartFormIniciarSesion(object sender, EventArgs e)
        {
            tCuentaRegresiva.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            
        }

        
        private void tCuentaRegresiva_Tick(object sender, EventArgs e)
        {
            _tCuentaRegresiva--;
            lblTime.Text = _tCuentaRegresiva.ToString();
            if(_tCuentaRegresiva == 0)
            {
                Application.Exit();
            }

        }
    }
}
