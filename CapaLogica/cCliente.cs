﻿using CapaDatos;
using capaLogica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static ConfiguracionUsuario;

namespace CapaLogica
{
    public class cCliente
    {
        public string IdCliente { get; set; }
        public string Documento { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarCliente");
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarCliente", Documento, NombreCompleto, Correo, Telefono);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarCliente", IdCliente, Documento, NombreCompleto, Correo, Telefono);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarCliente", IdCliente);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public string SiguienteID() => odatos.TraerValor("uspGenerarCodigo", "CLIENTE");
        public void CargarInformacion()
        {
            DataRow ofila = odatos.TraerDataRow("uspBuscarCliente", "Correo", Correo);
            if (ofila != null)
            {
                try
                {
                    IdCliente = ofila["IdCliente"].ToString();
                    Documento = ofila["Documento"].ToString();
                    NombreCompleto = ofila["NombreCompleto"].ToString();
                    Correo = ofila["Correo"].ToString();
                    Telefono = ofila["Telefono"].ToString();
                    Estado = ofila["Estado"].ToString();

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
        }
    }
}