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
    public partial class Login : Form
    {       
        GestorVentaBoletosContext context = new GestorVentaBoletosContext();

        private Form formularioPrincipal; // Esta variable almacenará una referencia al formulario principal
        public Login(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;

            // Suscribir el método al evento TextChanged para convertir a minúsculas
            txtUser.TextChanged += txtUser_TextChanged;
        }
       
        private void LimpiarLogin()
        {
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Verificar si los campos de usuario y contraseña están vacíos
            if (string.IsNullOrWhiteSpace(txtUser.Text) || string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Por favor, ingrese nombre de usuario y contraseña.");
                return; // Salir del método si los campos están vacíos
            }

            string user = txtUser.Text;
            string pass = txtPass.Text;

            // Se comprueba la conexion a la base de datos
            if (context.Database.CanConnect())
            {
                //Verificar las credenciales del usuario en la base de datos
                var usuario = context.Usuarios.SingleOrDefault(u => u.NombreUsuario == user && u.Contraseña == pass);
                if (usuario != null)
                {
                    //Verificar el nivel de usuario y mostrar mensajes o realizar acciones según el nivel
                    if (usuario.NivelUsuario == 1)
                    {
                        MessageBox.Show("Inicio de sesión exitoso para usuario normal, Bienvenido: " + usuario.NombreCompleto);
                        sesionActual datosUsuario = new sesionActual();
                        datosUsuario.Pass = pass;
                        datosUsuario.NombreUsuario = usuario.NombreCompleto;
                        datosUsuario.Usuario = user;
                        datosUsuario.Email = usuario.Correo;
                        datosUsuario.idUsuario = usuario.UsuarioId;

                        User mainForm = new User(this, datosUsuario); // Pasa una referencia a este formulario
                        mainForm.Show();
                        this.Hide();
                    }
                    else if (usuario.NivelUsuario == 2)
                    {
                        MessageBox.Show("Inicio de sesión exitoso para administrador, Bienvenido: " + usuario.NombreCompleto);
                        Admin mainForm = new Admin(this); // Pasa una referencia a este formulario
                        mainForm.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas. Por favor, inténtalo de nuevo.");
                    LimpiarLogin();
                }
            }
            else
            {
                MessageBox.Show("Error en la conexion a la base de datos comunicarse con un administrador");
            }
             
 

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Registro MainForm = new Registro(this);
            MainForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            txtUser.Text = txtUser.Text.ToLower();
            txtUser.SelectionStart = txtUser.Text.Length; // Pone el cursor al final del texto
        }

        private bool mostrarContraseña = false;
        // Variable para almacenar la contraseña original
        private string contraseñaOriginal;

        private void btnVisContra_Click(object sender, EventArgs e)
        {
            if (mostrarContraseña)
            {
                // Si la contraseña se está mostrando, ocultarla
                txtPass.Text = contraseñaOriginal; // Restaura la contraseña original
                txtPass.PasswordChar = '*'; // Restaura el PasswordChar original
                btnVisContra.Text = "Mostrar";
            }
            else
            {
                // Si la contraseña está oculta, mostrarla
                contraseñaOriginal = txtPass.Text; // Guarda la contraseña original
                txtPass.Text = contraseñaOriginal; // Asegura que el texto se muestra correctamente
                txtPass.PasswordChar = '\0'; // Muestra el texto original
                btnVisContra.Text = "Ocultar";
            }

            // Invertir el valor
            mostrarContraseña = !mostrarContraseña;
        }
    }
}
