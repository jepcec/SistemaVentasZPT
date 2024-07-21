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

namespace CapaPresentacion
{
    public partial class frmIniciarSesion : Form
    {
        cEmpleado oEmpleado = new cEmpleado();

        int _tSesion = 60;
        int _tMensaje = 10;
        int _intentos = 3;
        int _tRetraso = 10;
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
            string mensaje = "Numero de intentos disponibles ";
            if(_intentos == 0)
            {
                mensaje = "Numero de intentos maximo cerrando sesion!";
                Application.Exit();
                
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
                    ConfiguracionUsuario.CargarInformacion(oEmpleado);
                    if(ConfiguracionUsuario.RolUsuario == ConfiguracionUsuario.Rol.Administrado)
                    {
                        ReniciarTiempos();
                        tCloseFrm.Start();

                    }
                }
                else
                {
                    mensaje = oEmpleado.Mensaje;
                }

            }
            InciarTickMensaje(mensaje);

            
        }
        private void ReniciarTiempos()
        {
            _tMensaje = 10;
        }

        
        private void tCuentaRegresiva_Tick(object sender, EventArgs e)
        {
            _tSesion--;
            lblTime.Text = _tSesion.ToString();
            if(_tSesion == 0)
            {
                Application.Exit();
            }

        }

        private void tMensaje_Tick(object sender, EventArgs e)
        {
            _tMensaje--;
            if (_tMensaje  == 0)
            {
                lblMensaje.Text = "";
                lblMensaje.Visible = false;
                _tMensaje = 10;
            }
        }
        private void InciarTickMensaje(string Mensaje)
        {
            _tMensaje = 10;
            lblMensaje.Text = Mensaje;
            tMensaje.Start();
        }

        private void tCloseFrm_Tick(object sender, EventArgs e)
        {
            _tRetraso--;
            if (_tRetraso == 0)
            {
                ((frmPrincipal)MdiParent).tssRol.Text = ConfiguracionUsuario.RolUsuario.ToString();
                ((frmPrincipal)MdiParent).msPrincipal.Enabled = true;
                Close();
            }
        }
    }
}
