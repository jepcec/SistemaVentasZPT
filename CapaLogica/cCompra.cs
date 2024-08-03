using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class cCompra
    {
        public string IdCompra { get; set; }
        public string IdEmpleado { get; set; }
        public string IdProveedor { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado {  get; set; }   

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarCompra");
        public DataTable Buscar(string campo, string contenido) => odatos.TraerDataTable("uspBuscarCompra", campo, contenido);
        public DataTable BuscarComprobante(string Tipo, string campo, string contenido) => odatos.TraerDataTable("uspBuscarComprobanteCompra", Tipo, campo, contenido);
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarCompra", IdEmpleado, IdProveedor, TipoDocumento, NumeroDocumento, MontoTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarCompra", IdCompra, IdEmpleado, IdProveedor, MontoTotal);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarCompra", IdCompra);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool AnularCompra()
        {
            DataRow ofila = odatos.TraerDataRow("uspAnularCompra", IdCompra);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public string SiguienteID() => odatos.TraerValor("uspGenerarCodigo", "COMPRA");
        public string GenerarNroDocumento() => odatos.TraerValor("uspGenerarNumeroComprobante", TipoDocumento);
        public void CargarInformacion()
        {
            DataRow ofila = odatos.TraerDataRow("uspBuscarCompra", "IdCompra", IdCompra);
            if (ofila != null)
            {
                try
                {
                    IdCompra = ofila["IdCompra"].ToString();
                    IdEmpleado = ofila["IdEmpleado"].ToString();
                    IdProveedor = ofila["IdProveedor"].ToString();
                    NumeroDocumento = ofila["NumeroDocumento"].ToString();
                    TipoDocumento = ofila["TipoDocumento"].ToString();
                    NumeroDocumento = ofila["NumeroDocumento"].ToString();
                    

                }
                catch (Exception ex)
                {
                    Mensaje = ex.Message;
                }
            }
        }
    }
}
