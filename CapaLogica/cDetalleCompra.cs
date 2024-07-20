using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class cDetalleCompra
    {
        public string IdDetalleCompra { get; set; }
        public string IdCompra { get; set; }
        public string IdProducto { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarDetalleCompra");
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarDetalleCompra", IdDetalleCompra, IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarDetalleCompra", IdDetalleCompra, IdCompra, IdProducto, PrecioCompra, PrecioVenta, Cantidad, MontoTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarDetalleCompra", IdDetalleCompra);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
    }
}
