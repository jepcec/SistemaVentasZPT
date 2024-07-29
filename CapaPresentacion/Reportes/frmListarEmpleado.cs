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
    public partial class frmListarEmpleado : Form
    {
        cEmpleado oEmpleado = new cEmpleado();

        public frmListarEmpleado()
        {
            InitializeComponent();
            cmbCampo.Text = "IdEmpleado";
            Listar();
        }

        public void Listar()
        {
            string Campo = cmbCampo.Text;
            string Contenido = txtContenido.Text;
            dgvEmpleado.DataSource = oEmpleado.BusquedaDinamica(Campo, Contenido);
        }

        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void txtContenido_TextChanged(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            sfdGuardar.FileName = DateTime.Now.ToString("ddMMyyyyHHmmss");

            // Construir la ruta relativa al archivo HTML
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string htmlFilePath = Path.Combine(projectDirectory, "Recursos", "Empleados.html");
            string imagePath = Path.Combine(projectDirectory, "Recursos", "Logo.png");

            // Leer el contenido del archivo HTML
            string paginahtml_texto = File.ReadAllText(htmlFilePath);

            // Reemplazar valores plantilla
            paginahtml_texto = paginahtml_texto.Replace("@FECHA", DateTime.Now.ToString("dd/MM/yyyy"));

            // Insertar Datos de los empleados
            string filas = string.Empty;
            foreach (DataGridViewRow row in dgvEmpleado.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Documento"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["NombreCompleto"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Correo"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["Estado"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["FechaRegistro"].Value.ToString() + "</td>";
                filas += "<td>" + row.Cells["NombreRol"].Value.ToString() + "</td>";
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
