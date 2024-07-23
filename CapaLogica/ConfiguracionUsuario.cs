using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaLogica;
public static class ConfiguracionUsuario
{
    public static cEmpleado Usuario { get; set; }
    public static string IdEmpleado { get; set; }
    public static string Documento { get; set; }
    public static string NombreCompleto { get; set; }
    public static string Correo { get; set; }
    public static string Clave { get; set; }
    public static string IdRol { get; set; }
    public static string Estado { get; set; }
    public static DateTime FechaRegistro { get; set; }
    public static byte[] Imagen { get; set; }

    public static Rol RolUsuario = Rol.None;
    public static cDatos oDatos = new cDatosSQL();
    public enum Rol { None, Administrado, Vendedor, Almacenero }
    public static void CargarInformacion(cEmpleado usuario)
    {
        Usuario = usuario;
        IdEmpleado = usuario.IdEmpleado;
        Documento = usuario.Documento;
        NombreCompleto = usuario.NombreCompleto;
        Correo = usuario.Correo;
        Clave = usuario.Clave;
        IdRol = usuario.IdRol;
        AsignarCargo();
        Estado = usuario.Estado;
        FechaRegistro = usuario.FechaRegistro;
        Imagen = usuario.Imagen;
    }
    static void AsignarCargo()
    {
        string cargo = oDatos.TraerValor("uspDevolverCargo", Correo);
        switch (cargo)
        {
            case "Administrador":
                RolUsuario = Rol.Administrado;
                break;
            case "Vendedor":
                RolUsuario = Rol.Vendedor;
                break;
            case "Almacenero":
                RolUsuario = Rol.Almacenero;
                break;
        }
    }
}
