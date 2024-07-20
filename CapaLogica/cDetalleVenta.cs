using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class cDetalleVenta
    {
        public string IdDetalleVenta { get; set; }
        public string IdVenta { get; set; }
        public string IdProducto { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public DateTime FechaRegistro { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarDetalleVenta");
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarDetalleVenta", IdDetalleVenta, IdVenta, IdProducto, PrecioUnitario, Cantidad, SubTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarDetalleVenta", IdDetalleVenta, IdVenta, IdProducto, PrecioUnitario, Cantidad, SubTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarDetalleVenta", IdDetalleVenta);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
    }
}
