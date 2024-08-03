using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public static class Utilidades
{
    public static int CalcularEdad(DateTime fechaNacimiento)
    {
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;
        if (fechaNacimiento.Date > fechaActual.AddYears(-edad)) edad--;
        return Math.Abs(edad);
    }
    public static void VerificarFormulacionExistente<T>(Form formulariosPadre) where T : Form, new()
    {
        // Cerrar todos los formularios hijos existentes
        foreach (Form childForm in formulariosPadre.MdiChildren)
        {
            childForm.Close();
        }

        T t = Application.OpenForms.OfType<T>().FirstOrDefault();
        if (t != null)
        {
            // enfocar ventina existentes
            t.Focus();
        }
        else
        {
            // crear nuevo formulario de tipo T
            T nuevoFormulario = new T();
            nuevoFormulario.MdiParent = formulariosPadre;
            nuevoFormulario.WindowState = FormWindowState.Maximized;
            nuevoFormulario.Show();
            nuevoFormulario.Focus();

        }
    }
    public static void AbrirFormulario<T>() where T : Form, new() 
    {
        T nuevoFormulario = new T();
        nuevoFormulario.Show();
    }
    public static void VerificarFormulacionExistente<T>(Form formularioPadre, params object[] args) where T : Form
    {
        // Cerrar todos los formularios hijos existentes
        foreach (Form childForm in formularioPadre.MdiChildren)
        {
            childForm.Close();
        }

        // Crear nuevo formulario de tipo T con parámetros
        T nuevoFormulario = (args == null || args.Length == 0)
            ? (T)Activator.CreateInstance(typeof(T))
            : (T)Activator.CreateInstance(typeof(T), args);

        nuevoFormulario.MdiParent = formularioPadre;
        nuevoFormulario.WindowState = FormWindowState.Maximized;
        nuevoFormulario.Show();
        nuevoFormulario.Focus();
    }
}
