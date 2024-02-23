using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaDeBuses.Contexto;
using SistemaDeBuses.Admin_form;
using System.Xml.Schema;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System.Diagnostics;
using iText.Kernel.Geom;


namespace SistemaDeBuses
{
    public partial class Admin : Form
    {

        private Form formularioPrincipal;
        public Admin(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }



        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que desea cerrar sesión?", "Confirmar Cierre de Sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cierra el formulario actual (Usuario o Administrador)
                formularioPrincipal.Show(); // Muestra el formulario de inicio de sesión
            }
            // Si el usuario selecciona "No", no se realizará ninguna acción.
        }

        private void rutasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RutaNueva formNR = new RutaNueva(this);
            formNR.Show();
            this.Hide();

        }


        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfil_admin formPe = new Perfil_admin(this);
            formPe.Show();
            this.Hide();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            var Fecha_hora = DateTime.Today;
            GestorVentaBoletosContext contexto = new GestorVentaBoletosContext();
            //rutq del pdf

            string rutaPDF = "Reporte_Ventas.pdf";
            // Definir el tamaño de página horizontal

            //var pageSize = PageSize.A4.Rotate();
            PdfWriter writer = new PdfWriter(rutaPDF);
            PdfDocument pdfDoc = new PdfDocument(writer);
            Document doc = new Document(pdfDoc/*, pageSize*/);
            try
            {

                //generar una tabla con datos de la BD
                Table tabla = new Table(7);
                tabla.AddCell(new Cell().Add(new Paragraph("Cliente")).SetBackgroundColor(ColorConstants.CYAN));
                tabla.AddCell(new Cell().Add(new Paragraph("Nombre completo")).SetBackgroundColor(ColorConstants.CYAN));
                tabla.AddCell(new Cell().Add(new Paragraph("Total")).SetBackgroundColor(ColorConstants.CYAN));
                tabla.AddCell(new Cell().Add(new Paragraph("Ruta")).SetBackgroundColor(ColorConstants.CYAN));
                tabla.AddCell(new Cell().Add(new Paragraph("Cantidad")).SetBackgroundColor(ColorConstants.CYAN));
                tabla.AddCell(new Cell().Add(new Paragraph("Codigos de asiento")).SetBackgroundColor(ColorConstants.CYAN));
                tabla.AddCell(new Cell().Add(new Paragraph("Fecha de la compra")).SetBackgroundColor(ColorConstants.CYAN));
                // realizamos una consulta LINQ para poder unir las tablas mediante las llaves foraneas en una lista llamada tabla
                var data = (from compra in contexto.Compras
                            join usuario in contexto.Usuarios on compra.UsuarioId equals usuario.UsuarioId
                            join ruta in contexto.Rutas on compra.RutaId equals ruta.RutaId
                            select new
                            {
                                Usuario = usuario.NombreUsuario,
                                NombreCompleto = usuario.NombreCompleto,
                                TotalCompra = compra.TotalCompra,
                                NombreRuta = ruta.NombreRuta,
                                CantidadAsientos = compra.CantidadAsientos,
                                AsientosComprados = compra.AsientosComprados,
                                FechaCompra = compra.FechaCompra
                            }).ToList();

                foreach (var item in data)
                {
                    tabla.AddCell(new Cell().Add(new Paragraph(item.Usuario)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                    tabla.AddCell(new Cell().Add(new Paragraph(item.NombreCompleto)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                    tabla.AddCell(new Cell().Add(new Paragraph(item.TotalCompra.ToString())).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                    tabla.AddCell(new Cell().Add(new Paragraph(item.NombreRuta)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                    tabla.AddCell(new Cell().Add(new Paragraph(item.CantidadAsientos.ToString())).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                    tabla.AddCell(new Cell().Add(new Paragraph(item.AsientosComprados)).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                    tabla.AddCell(new Cell().Add(new Paragraph(item.FechaCompra.ToString())).SetBackgroundColor(ColorConstants.LIGHT_GRAY));
                }
                //Generar tittulo
                var titulo = new Paragraph("TRANSMOVE EXPRESS");
                titulo.SetTextAlignment(TextAlignment.CENTER);
                titulo.SetFontSize(17);
                titulo.SetBold();



                //Generar un logo
                string ruta_imagen = "../../../img/Icono.png";
                var img = new iText.Layout.Element.Image(ImageDataFactory.Create(ruta_imagen));
                img.ScaleToFit(200, 100);
                img.SetFixedPosition(35, 730);
                //Armado Del Documento
                doc.Add(titulo);
                // agrar imagen al documento
                doc.Add(img);
                var salto_doble = new Paragraph("\n\n");
                var salto_simple = new Paragraph("\n");
                doc.Add(salto_doble);
                var info_reporte = new Paragraph("Reporte de ventas de Transmove Express, hasta la fecha: " + Fecha_hora);
                doc.Add(info_reporte);
                doc.Add(salto_simple);
                doc.Add(tabla);
                //se cierra el documento
                doc.Close();
                pdfDoc.Close();
                //para que muestre el documento hay que usar la misma logica

                try
                {
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo
                    {
                        UseShellExecute = true,
                        FileName = rutaPDF,
                        Verb = "open"

                    };
                    System.Diagnostics.Process.Start(startInfo);
                }
                catch (Exception ex)
                {
                    // Manejar excepciones
                    MessageBox.Show("Ocurrió un error al intentar abrir el archivo: " + ex.Message);
                }

            }
            catch (Exception ex)
            {

            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            GestorVentaBoletosContext contexto = new GestorVentaBoletosContext();
            decimal TotalVentas = 0;
            int TotalUsuarios = 0;
            int TotalAsientos = 0;
            foreach (var X in contexto.Usuarios)
            {
                TotalUsuarios++;
            }
            foreach (var x in contexto.Compras)
            {
                TotalAsientos += x.CantidadAsientos;
                TotalVentas += x.TotalCompra;
            }
            txtUsuarios.Text = TotalUsuarios.ToString();
            txtvAsientos.Text = TotalAsientos.ToString();
            txtVentas.Text = "$ " + TotalVentas.ToString();
        }
    }
}
