using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class cRol
    {
        public string IdRol { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarRol");
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarRol", Descripcion);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarRol", IdRol, Descripcion);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarRol", IdRol);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
    }
}
