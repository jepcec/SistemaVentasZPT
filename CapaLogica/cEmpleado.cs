﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class cEmpleado
    {
        public string IdEmpleado { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string IdRol { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public byte[] Imagen { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarEmpleado");
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarEmpleado", IdEmpleado, Documento, NombreCompleto, Correo, Clave, IdRol, Estado, Imagen);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarEmpleado", IdEmpleado, Documento, NombreCompleto, Correo, Clave, IdRol, Estado, Imagen);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarEmpleado", IdEmpleado);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool VerificarUsuario()
        {
            DataRow ofila = odatos.TraerDataRow("uspVerificarUsuario", Correo,Clave);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public string DevolverCargo() => odatos.TraerValor("uspDevolverCargo", Correo);
        public void CargarInformacion()
        {
            DataRow ofila = odatos.TraerDataRow("uspBuscarEmpleado", "Correo", Correo);
            if (ofila != null)
            {
                try
                {
                    IdEmpleado = ofila["IdEmpleado"].ToString();
                    Documento = ofila["Documento"].ToString();
                    NombreCompleto = ofila["NombreCompleto"].ToString();
                    Correo = ofila["Correo"].ToString();
                    Clave = ofila["Clave"].ToString();
                    IdRol = ofila["IdRol"].ToString();
                    Estado = ofila["Estado"].ToString();
                    FechaRegistro = Convert.ToDateTime(ofila["FechaRegistro"]);
                    Imagen = (byte[])ofila["Imagen"];

                   
                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                   
                }
            }
        }
        public string SiguienteID() => odatos.TraerValor("uspGenerarCodigo", "EMPLEADO");
    }
}