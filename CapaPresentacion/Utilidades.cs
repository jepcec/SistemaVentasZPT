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
            nuevoFormulario.Show();

        }
    }
    public static void AbrirFormulario<T>() where T : Form, new() 
    {
        T nuevoFormulario = new T();
        nuevoFormulario.Show();
    }

}
