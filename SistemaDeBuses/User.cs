using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.VisualBasic;
using SistemaDeBuses.Contexto;
using Microsoft.VisualBasic;
using System.Diagnostics.Eventing.Reader;

namespace SistemaDeBuses
{
    public partial class User : Form
    {
        GestorVentaBoletosContext Contexto = new GestorVentaBoletosContext();
        private Form formularioPrincipal;
        private sesionActual datosUsuario;

        public User(Form formularioPrincipal, sesionActual datosUsuario)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
            this.datosUsuario = datosUsuario;
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

        private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void MostrarComprasUsuario(int usuarioID)
        {
            // metodo para atualizar las compras hechas por el usuario
            // hacemos una consulta LINQ para obtener los datos de la tabla compras y usando la llave foranea UsuarioID obtener 
            // los registros de las rutas que el ha comprado
            // c en compras donde usuarioid sea igual que el id del usuario que inicio sesion
            // creamos nuevas columnas donde se ingresaran los datos que cumplan con la consulta y 
            // lo convertimos en una lista para luego mostrarlo en el datagridview
            var comprasUsuario = (from c in Contexto.Compras
                                  where c.UsuarioId == usuarioID
                                  select new
                                  {
                                      NombreUsuario = c.Usuario.NombreUsuario,
                                      NombreRuta = c.Ruta.NombreRuta,
                                      AsientosComprados = c.AsientosComprados,
                                      TotalCompra = c.TotalCompra,
                                      Origen = c.Ruta.Origen,
                                      Destino = c.Ruta.Destino
                                  }).ToList();
            DataUser.Columns.Add(new DataGridViewTextBoxColumn() // creamos una nueva columna
            {
                DataPropertyName = "NombreUsuario", // nombre de la columna de la cual recibira los datos
                HeaderText = "Cliente", // nombre visual sobre la coolumna
                Name = "NombreUsuario"
            });
            DataUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "NombreRuta",
                HeaderText = "Ruta",
                Name = "NombreRuta"
            });
            DataUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "AsientosComprados",
                HeaderText = "Asientos comprados",
                Name = "AsientosComprados"
            });

            DataUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "TotalCompra",
                HeaderText = "Total de la compra",
                Name = "TotalCompra"
            });
            DataUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Origen",
                HeaderText = "Lugar de salida",
                Name = "Origen"
            });
            DataUser.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Destino",
                HeaderText = "Destino",
                Name = "Destino"
            });
            DataUser.DataSource = comprasUsuario;

        }
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creamos un interaction inputbox propio de visual basic para hacer mas interactivo el cambio de contraseña 
            // la variable checkpass seria igual a lo que digite el usuario
            string checkpass = Interaction.InputBox("Ingresa tu contraseña actual :", "Verifica tu identidad", "Ingresa aqui tu actual contraseña", -1, -1);
            if (checkpass == datosUsuario.Pass) // si la contraseña digitada coincide con la contraseña actual entonces se mostrara otro interaction
                                                // inputbox donde el usuario digitara su nueva contraseña
            {
                string nuevoPassword = Interaction.InputBox("Ingresa tu nueva contraseña :", "Cambiar contraseña", "Ingresa aqui tu nueva contraseña", -1, -1);
                if (nuevoPassword != "")
                {
                    // obtenemos el registro del usuario y modificamos el registro de contraseña con la que digito 
                    // el usuario que seria su nueva contraseña
                    var changepass = Contexto.Usuarios.FirstOrDefault(x => x.UsuarioId == datosUsuario.idUsuario);
                    changepass.Contraseña = nuevoPassword;
                    Contexto.Usuarios.Update(changepass);
                    if (Contexto.SaveChanges() == 1)
                    {
                        MessageBox.Show("Contraseña modificada con exito");

                    }


                    else
                    {
                        MessageBox.Show("La contraseña ingresada es incorrecta");
                    }
                }
                else
                {
                    MessageBox.Show("La nueva contraseña es invalida");
                }
            }


        }

        private void User_Load(object sender, EventArgs e)
        {
            // mostramos los datos del usuario en los label
            txtnombreUsuario.Text = datosUsuario.Usuario;
            txtnombreCompleto.Text = datosUsuario.NombreUsuario;
            txtcorreo.Text = datosUsuario.Email;
            int usuarioID = datosUsuario.idUsuario;
            DataUser.Columns.Clear();
            DataUser.DataSource = null;
            MostrarComprasUsuario(usuarioID);
        }



        private void btnActCompras_Click(object sender, EventArgs e)
        {
            // refrescar el datagridviwe con las ultimas compras hechas por el usuario
            int usuarioID = datosUsuario.idUsuario;
            DataUser.Columns.Clear();
            DataUser.DataSource = null;
            MostrarComprasUsuario(usuarioID);
        }

        private void comprarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // creamos abrimos un nuevo form de tipo compras y escondemos el actual
            Compras compras = new Compras(this, datosUsuario);
            compras.Show();
            this.Hide();
        }
    }

}