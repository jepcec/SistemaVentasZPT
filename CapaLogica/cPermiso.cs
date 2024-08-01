using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class cPermiso
    {
        public string IdPermiso { get; set; }
        public string IdRol { get; set; }
        public string NombreMenu { get; set; }
        public DateTime FechaRegistro { get; set; }

        private cDatos odatos = new cDatosSQL();
        public string Mensaje;

        public DataTable Listar() => odatos.TraerDataTable("uspListarPermiso");
        public bool Insertar()
        {
            DataRow ofila = odatos.TraerDataRow("uspInsertarPermiso", IdRol, NombreMenu);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Modificar()
        {
            DataRow ofila = odatos.TraerDataRow("uspModificarPermiso", IdPermiso, IdRol, NombreMenu);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
        public bool Eliminar()
        {
            DataRow ofila = odatos.TraerDataRow("uspEliminarPermiso", IdPermiso);
            Mensaje = ofila[1].ToString();
            byte CodigoError = Convert.ToByte(ofila[0]);
            return CodigoError == 0;
        }
    }
}
