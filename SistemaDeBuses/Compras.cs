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

namespace SistemaDeBuses
{
    public partial class Compras : Form
    {
        GestorVentaBoletosContext Contexto = new GestorVentaBoletosContext();
        private sesionActual datosUsuario;
        private Form User;

        public Compras(Form User, sesionActual datosUsuario)
        {
            InitializeComponent();
            this.User = User;
            this.datosUsuario = datosUsuario;
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            //creamos un objeto de tipo compra donde registraremos los datos de la nueva compra
            Compra Ncompra = new Compra();
            if (int.Parse(txtcantidadAsientos.Text) < 4 && int.Parse(txtcantidadAsientos.Text) > 0)
            {
                //hacemos una consulta LINQ para obtner el registro de la ruta que el usuario desea comprar
                var compraRuta = Contexto.Rutas.FirstOrDefault(x => x.NombreRuta == txtCompra.Text);
                if (compraRuta != null && compraRuta.AsientosDisponibles > 0)
                {
                    Ncompra.RutaId = compraRuta.RutaId;
                    Ncompra.CantidadAsientos = int.Parse(txtcantidadAsientos.Text);
                    Ncompra.FechaCompra = DateTime.Now;
                    Ncompra.TotalCompra = compraRuta.Precio * txtcantidadAsientos.Value;
                    Ncompra.UsuarioId = datosUsuario.idUsuario;
                    compraRuta.AsientosDisponibles = compraRuta.AsientosDisponibles - int.Parse(txtcantidadAsientos.Text);
                    //adjuntamos 3 numeros aleatorios seguidos de la letra A para simular la generacion de un codigo de asiento
                    // y lo repetimos segun la cantidad de asientos que compre el usuario
                    for (int i = 0; i < txtcantidadAsientos.Value; i++)
                    {
                        Random random = new Random();
                        int num1 = random.Next(0, 10);
                        int num2 = random.Next(0, 10);
                        int num3 = random.Next(0, 10);
                        Ncompra.AsientosComprados += ("A" + num1 + num2 + num3 + ", ");
                    }
                    Contexto.Compras.Add(Ncompra);
                    Contexto.Rutas.Update(compraRuta);
                    Contexto.SaveChanges();
                    MessageBox.Show("Compra realizada con exito");

                }
                else
                {
                    MessageBox.Show("La ruta que has elegido no existe, revisa nuevamente");
                }

                CargarRutas();

            }
            else if (int.Parse(txtcantidadAsientos.Text) > 3)
            {
                MessageBox.Show("El limite de compra de asientos por usuario es 3");
            }
            else if (int.Parse(txtcantidadAsientos.Text) <= 0)
            {
                MessageBox.Show("No puede comprar 0 voletos");
            }
        }
        private void Compras_Load(object sender, EventArgs e)
        {
            CargarRutas();
        }
        private void CargarRutas() // metodo para cargar los registros de las rutas 
        {
            DataCompras.Columns.Clear();
            DataCompras.DataSource = null;
            var listaRutas = Contexto.Rutas.ToList();
            DataCompras.AutoGenerateColumns = false;// colocamos la autogeneracion de columnas para asi 
                                                    // crearlas paso a paso para mejorar la estetica
            DataCompras.Columns.Add(new DataGridViewTextBoxColumn() // cfeamos una nueva columna
            {
                DataPropertyName = "NombreRuta", // nombre de la columna 
                HeaderText = "Ruta", // nombre visual sobre el datagridview
                Name = "NombreRuta"
            });
            DataCompras.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AsientosDisponibles",
                HeaderText = "Asientos Disponibles",
                Name = "AsientosDisponibles"
            });
            DataCompras.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Precio",
                HeaderText = "Precio",
                Name = "Precio"
            });
            DataCompras.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Origen",
                HeaderText = "Origen",
                Name = "Origen"
            });

            DataCompras.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Destino",
                HeaderText = "Destino",
                Name = "Destino"
            });

            DataCompras.DataSource = listaRutas;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //cerramos este form y mostramos el de usuario
            this.Close();
            User.Show();
        }

        private void DataCompras_Click(object sender, EventArgs e)
        {
            txtCompra.Text = DataCompras.SelectedCells[0].Value.ToString();
            // evento click del gridview para auto rellenar el txtcompra con la fila 
            // a la cual el usuario le haya dado click
        }
    }
}
