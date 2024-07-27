using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;
using System.IO;

namespace CapaPresentacion.Reportes
{
    public partial class frmBoletaVenta : Form
    {
        cVenta oVenta = new cVenta();
        cDetalleVenta oDetalleVenta = new cDetalleVenta();

        public frmBoletaVenta()
        {
            InitializeComponent();
        }

        void actualizarLista()
        {
            string IdVenta = txtIdVenta.Text;
            string Campo = cbCampo.Text;
            string Contenido = txtContenido.Text;
            dgvProductos.DataSource = oDetalleVenta.BuscarProductos(IdVenta, Campo, Contenido);
        }

        public void actualizarMuestra(string idVenta)
        {
            // Recuperando Valores
            DataTable Venta = oVenta.Buscar("IdVenta", idVenta);
            DataRow VentaValores = Venta.Rows[0];
            // Mostrando Valores
            txtIdVenta.Text = VentaValores["IdVenta"].ToString();
            txtNroDocumento.Text = VentaValores["NumeroDocumento"].ToString();
            dtpFecha.Value = (DateTime)VentaValores["FechaRegistro"];
            txtIdEmpleado.Text = VentaValores["IdEmpleado"].ToString();
            txtNombreEmpleado.Text = VentaValores["NombreEmpleado"].ToString();
            txtMontoTotal.Text = VentaValores["MontoTotal"].ToString();
            txtMontoRecibido.Text = VentaValores["MontoPago"].ToString();
            txtMontoCambio.Text = VentaValores["MontoCambio"].ToString();
            txtDocumentoCliente.Text = VentaValores["DocumentoCliente"].ToString();
            txtNombreCliente.Text = VentaValores["NombreCliente"].ToString();
            // Mostrar Productos
            dgvProductos.DataSource = oDetalleVenta.ListarProductos(txtIdVenta.Text);
            cbCampo.Text = "NombreProducto";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            sfrmBuscarVenta hijo = new sfrmBuscarVenta(this, "Boleta");
            hijo.Show();
        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            sfdGuardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss");

            // Construir la ruta relativa al archivo HTML
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string htmlFilePath = Path.Combine(projectDirectory, "Recursos", "BoletaVenta.html");
            string imagePath = Path.Combine(projectDirectory, "Recursos", "Logo.png");

            // Leer el contenido del archivo HTML
            string paginahtml_texto = File.ReadAllText(htmlFilePath);

            // Reemplazar valores plantilla
            paginahtml_texto = paginahtml_texto.Replace("@CLIENTE", txtNombreCliente.Text);
            paginahtml_texto = paginahtml_texto.Replace("@DOCUMENTO", txtDocumentoCliente.Text);
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", dtpFecha.Value.ToShortDateString());
            paginahtml_texto = paginahtml_texto.Replace("@EMPLEADO", txtNombreEmpleado.Text);
            paginahtml_texto = paginahtml_texto.Replace("@ID_ EMPLEADO", txtIdEmpleado.Text);
            paginahtml_texto = paginahtml_texto.Replace("@TOTAL", txtMontoTotal.Text);
            paginahtml_texto = paginahtml_texto.Replace("@RECIBIDO", txtMontoRecibido.Text);
            paginahtml_texto = paginahtml_texto.Replace("@CAMBIO", txtMontoCambio.Text);
            paginahtml_texto = paginahtml_texto.Replace("@ID_BOLETA", txtIdVenta.Text);

            // Insertar Datos de la compra
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvProductos.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Cantidad"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["NombreProducto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value.ToString() + "</td>";
                filas += "</tr>";
            }
            paginahtml_texto = paginahtml_texto.Replace("@FILAS", filas);

            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(sfdGuardar.FileName, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);

                    pdfDoc.Open();

                    pdfDoc.Add(new Phrase(""));

                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePath);
                    img.ScaleToFit(90, 70);
                    img.Alignment = iTextSharp.text.Image.UNDERLYING;
                    img.SetAbsolutePosition(pdfDoc.LeftMargin + 20, pdfDoc.Top - 70);
                    pdfDoc.Add(img);

                    using (StringReader sr = new StringReader(paginahtml_texto))
                    {
                        XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                    }

                    pdfDoc.Close();

                    stream.Close();
                }
            }
        }
    }
}
