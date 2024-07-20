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

namespace CapaPresentacion
{
    public partial class FormTest : Form
    {
        cEmpleado empleado = new cEmpleado();       
        public FormTest()
        {
            InitializeComponent();
            dataGridView1.DataSource = empleado.Listar();
            empleado.IdEmpleado = "E0001";
            empleado.Clave = "password123";
            if (empleado.VerificarUsuario())
            {
                MessageBox.Show("El usuario esta correcto");
                empleado.CargarInformacion();
                ConfiguracionUsuario.CargarInformacion(empleado);
                MessageBox.Show(ConfiguracionUsuario.RolUsuario.ToString());
            }
            else
            {
                MessageBox.Show(empleado.Mensaje);
            }
        }
    }
}
