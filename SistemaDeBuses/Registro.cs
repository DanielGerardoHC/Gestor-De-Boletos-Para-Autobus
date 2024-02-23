using System;
using SistemaDeBuses.Contexto;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query;

namespace SistemaDeBuses
{

    public partial class Registro : Form
    {
        private Form formularioPrincipal;
        GestorVentaBoletosContext contexto = new GestorVentaBoletosContext();
        public Registro(Form formularioPrincipal)
        {
            InitializeComponent();
            this.formularioPrincipal = formularioPrincipal;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Se comprueba la conexion a la base de datos
            if (contexto.Database.CanConnect())
            {
                // Validar que los campos requeridos estén completos
                if (string.IsNullOrWhiteSpace(txtUsuario.Text) ||
                    string.IsNullOrWhiteSpace(txtContra.Text) ||
                    string.IsNullOrWhiteSpace(txtnombreCompleto.Text) ||
                    string.IsNullOrWhiteSpace(txtEdad.Text) ||
                    string.IsNullOrWhiteSpace(txtCorreo.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios. Por favor, complete la información.");
                    return;
                }

                // Validar la edad (debe ser un número entero)
                if (!int.TryParse(txtEdad.Text, out _))
                {
                    MessageBox.Show("Ingrese una edad válida.");
                    return;
                }

                // Verificar si el nombre de usuario ya existe en la base de datos
                bool existe = contexto.Usuarios.Any(p => p.NombreUsuario == (txtUsuario.Text));
                if (existe)
                {
                    MessageBox.Show("Usuario ya existente");
                }
                else
                {
                    // llenar el objeto con los datos ingresados por el usuario
                    Usuario Nusuario = new Usuario();
                    Nusuario.NivelUsuario = 1;
                    Nusuario.NombreUsuario = txtUsuario.Text;
                    Nusuario.Contraseña = txtContra.Text;
                    Nusuario.NombreCompleto = txtnombreCompleto.Text;
                    Nusuario.Edad = int.Parse(txtEdad.Text);
                    Nusuario.Correo = txtCorreo.Text;
                    contexto.Usuarios.Add(Nusuario);
                }
                if (contexto.SaveChanges() == 1)
                {
                    MessageBox.Show("Nuevo Usuario registrado con exito");
                    LimpiarCampos();

                }
            }
            else
            {
                MessageBox.Show("Error en la conexion a la base de datos comunicarse con un administrador");
            }
        }

        private void LimpiarCampos()
        {
            // Limpiar los campos después de un registro exitoso
            txtUsuario.Text = string.Empty;
            txtContra.Text = string.Empty;
            txtnombreCompleto.Text = string.Empty;
            txtEdad.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de que deses volver atras?", "Volver atras", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close(); // Cierra el formulario actual (Usuario o Administrador)
                formularioPrincipal.Show(); // Muestra el formulario de inicio de sesión
            }
        }
        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
