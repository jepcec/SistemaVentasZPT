using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class cVenta
    {
        public string IdVenta { get; set; }
        public string IdEmpleado { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public decimal MontoPago { get; set; }
        public decimal MontoCambio { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarVenta");
        public DataTable Buscar(string campo, string contenido) => odatos.TraerDataTable("uspBuscarVenta", campo, contenido);
        public DataTable BuscarComprobante(string Tipo, string campo, string contenido) => odatos.TraerDataTable("uspBuscarComprobanteVenta", Tipo, campo, contenido);
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarVenta", IdVenta, IdEmpleado, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        // generar mro comprobante
        // esto no
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarVenta", IdVenta, IdEmpleado, TipoDocumento, NumeroDocumento, DocumentoCliente, NombreCliente, MontoPago, MontoCambio, MontoTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarVenta", IdVenta);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        // esto no
        // Agregar Anular
        public string RecuperarIDMax()
        {
            string idMaximo = "0000";
            return idMaximo;
        }
    }
}
