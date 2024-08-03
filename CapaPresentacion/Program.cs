﻿using CapaPresentacion.Mantenimiento;
using CapaPresentacion.Procesos;
using CapaPresentacion.Reportes;
using CapaPresentacion.Seguridad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmCambiarContraseña());
            //Application.Run(new frmCliente());
            //Application.Run(new frmEmpleado());

        }
        
    }
}
