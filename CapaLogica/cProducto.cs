﻿using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using static ConfiguracionUsuario;
using System.Xml.Linq;

namespace CapaLogica
{
    public class cProducto
    {
        public string IdProducto { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string IdCategoria { get; set; }
        public int Stock { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public string Estado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public byte[] Imagen { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarProducto");
        public DataTable BusquedaPersonalizada(string comando) => odatos.TraerDataTable_Consulta(comando);
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarProducto", IdProducto, Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, Imagen);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarProducto", IdProducto, Codigo, Nombre, Descripcion, IdCategoria, Stock, PrecioCompra, PrecioVenta, Estado, Imagen);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarProducto", IdProducto);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public string SiguienteID() => odatos.TraerValor("uspGenerarCodigo", "PRODUCTO");
        public void CargarInformacion()
        {
            DataRow ofila = odatos.TraerDataRow("uspBuscarProducto", "IdProducto", IdProducto);
            if (ofila != null)
            {
                try
                {
                    IdProducto = ofila["IdProducto"].ToString();
                    Codigo = ofila["Codigo"].ToString();
                    Nombre = ofila["Nombre"].ToString();
                    Descripcion = ofila["Descripcion"].ToString();
                    IdCategoria = ofila["IdCategoria"].ToString();
                    Stock = int.Parse(ofila["Stock"].ToString());
                    PrecioCompra = decimal.Parse(ofila["PrecioCompra"].ToString());
                    PrecioVenta = decimal.Parse(ofila["PrecioVenta"].ToString());
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
    }
}