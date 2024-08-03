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
    public partial class frmCambiarContraseña : Form
    {
        cEmpleado oEmpleado = new cEmpleado();
        int _intentos = 3;

        public frmCambiarContraseña()
        {
            InitializeComponent();
            DesabilidarCambio();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string mensaje = "Numero de intentos disponibles ";
            if (_intentos == 0)
            {
                mensaje = "Numero de intentos maximo cerrando sesion!";
                Close();

            }
            else
            {
                _intentos--;
                lblMensaje.Visible = true;

                oEmpleado.Correo = txtUsuario.Text;
                oEmpleado.Clave = txtContraseña.Text;

                if (oEmpleado.VerificarUsuario())
                {
                    mensaje = oEmpleado.Mensaje;
                    oEmpleado.CargarInformacion();

                    // Habil para cambiar
                    AbilitarCambio();
                    DesabilitarIngreso();
                }
                else
                {
                    mensaje = oEmpleado.Mensaje;
                }

            }
        }

        private void AbilitarCambio()
        {
            label1.Visible = true;
            label4.Visible = true;
            txtNuevaContrasenia.Visible = true;
            txtRepetirContrasenia.Visible = true;
            lblCambio.Visible = true;
            btnAceptar.Visible = true;
            btnRegresar.Visible = true;
        }

        private void DesabilidarCambio()
        {
            label1.Visible = false;
            label4.Visible = false;
            txtNuevaContrasenia.Visible = false;
            txtRepetirContrasenia.Visible = false;
            lblCambio.Visible = false;
            btnAceptar.Visible = false;
            btnRegresar.Visible = false;
        }

        private void AbilitarIngreso()
        {
            label2.Visible = true;
            txtUsuario.Visible = true;
            label3.Visible = true;
            txtContraseña.Visible = true;
            btnIniciarSesion.Visible = true;
            lblMensaje.Visible = true;
        }

        private void DesabilitarIngreso()
        {
            label2.Visible = false;
            txtUsuario.Visible = false;
            label3.Visible = false;
            txtContraseña.Visible = false;
            btnIniciarSesion.Visible = false;
            lblMensaje.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DesabilidarCambio();
            AbilitarIngreso();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string Clave1 = txtNuevaContrasenia.Text;
            string Clave2 = txtRepetirContrasenia.Text;
            if (Clave1 == Clave2)
            {
                oEmpleado.Correo = txtUsuario.Text;
                oEmpleado.Clave = Clave1;
                oEmpleado.CambiarClave();
                lblCambio.Text = oEmpleado.Mensaje;
                tMensaje.Start();
            }
        }
        int tiempoMensajeFinal = 5;
        private void tMensaje_Tick(object sender, EventArgs e)
        {
            tiempoMensajeFinal--;
            if(tiempoMensajeFinal == 0)
            {
                tiempoMensajeFinal = 10;
                Close();

            }
        }
    }
}
