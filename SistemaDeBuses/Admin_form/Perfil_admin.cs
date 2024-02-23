
using SistemaDeBuses.Contexto;
namespace SistemaDeBuses.Admin_form
{
    public partial class Perfil_admin : Form
    {

        GestorVentaBoletosContext contexto = new GestorVentaBoletosContext();
        private Form Admin;
        public Perfil_admin(Form Admin)
        {
            InitializeComponent();
            this.Admin = Admin;
        }
        private void GridViewLoad()
        {
            dgvPerfiles.DataSource = null;
            dgvPerfiles.DataSource = contexto.Usuarios.ToList();
        }

        private void Limpiar()
        {
            txtNomComAdm.Text = string.Empty;
            txtCorreoAdm.Text = string.Empty;
            txtUsuarioAdm.Text = string.Empty;
            txtContraAdm.Text = string.Empty;
            nudEdadAdm.Text = string.Empty;
            cbNivelAdm.SelectedIndex = -1;
        }
        private void Perfil_admin_Load(object sender, EventArgs e)
        {
            dgvPerfiles.DataSource = contexto.Usuarios.ToList();

        }

        private void btnVolverPerfil_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin.Show();
        }

        private void btnAgregarPerfil_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtNomComAdm.Text) || string.IsNullOrWhiteSpace(txtCorreoAdm.Text) ||
                string.IsNullOrWhiteSpace(txtUsuarioAdm.Text) || string.IsNullOrWhiteSpace(txtContraAdm.Text) ||
                string.IsNullOrWhiteSpace(nudEdadAdm.Text) || cbNivelAdm.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el formato de la edad
            if (!int.TryParse(nudEdadAdm.Text, out int edad) || edad <= 0)
            {
                MessageBox.Show("La edad debe ser un número entero positivo.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si el usuario ya existe
            bool existe = contexto.Usuarios.Any(u => u.NombreUsuario == txtUsuarioAdm.Text);
            if (existe)
            {
                MessageBox.Show("Este nombre de usuario ya está en uso.", "Usuario Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Agregar el nuevo usuario a la base de datos
            Usuario us = new Usuario();

            us.NombreCompleto = txtNomComAdm.Text;
            us.Correo = txtCorreoAdm.Text;
            us.NombreUsuario = txtUsuarioAdm.Text;
            us.Contraseña = txtContraAdm.Text;
            us.Edad = int.Parse(nudEdadAdm.Text);
            us.NivelUsuario = int.Parse(cbNivelAdm.Text);


            // Agregar la nueva usuario a la base de datos
            contexto.Usuarios.Add(us);
            contexto.SaveChanges();

            // Notifica y limpia el campo
            MessageBox.Show("Usuario agregado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();

            // Actualizar el DataGridView con las usuario
            GridViewLoad();
        }

        private void btnModificarPerfil_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                // Obtén la usuario seleccionada desde el DataGridView

                Usuario UsuarioSelecionado = contexto.Usuarios.FirstOrDefault(u => u.UsuarioId == int.Parse(txtID.Text));

                if (UsuarioSelecionado != null)
                {
                    // Actualiza los valores de la usuario con los datos del formulario
                    UsuarioSelecionado.NombreCompleto = txtNomComAdm.Text;
                    UsuarioSelecionado.Correo = txtCorreoAdm.Text;
                    UsuarioSelecionado.Edad = int.Parse(nudEdadAdm.Text);
                    UsuarioSelecionado.NombreUsuario = txtUsuarioAdm.Text;
                    UsuarioSelecionado.Contraseña = txtContraAdm.Text;
                    UsuarioSelecionado.NivelUsuario = int.Parse(cbNivelAdm.Text);

                    // Guarda los cambios en la base de datos
                    contexto.SaveChanges();

                    // Actualiza el DataGridView con las usuario
                    dgvPerfiles.DataSource = null;
                    dgvPerfiles.DataSource = contexto.Usuarios.ToList();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            // Notifica y limpia el campo
            MessageBox.Show("Usuario modificado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            GridViewLoad();
        }

        private void btnEliminarPerfil_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                // Obtén la usuario seleccionada desde el DataGridView
                int UsuarioId = (int)dgvPerfiles.SelectedRows[0].Cells["UsuarioID"].Value;
                Usuario UsuarioSelecionado = contexto.Usuarios.FirstOrDefault(u => u.UsuarioId == UsuarioId);
                var comprasEliminar = contexto.Compras.Where(x => x.UsuarioId == UsuarioId);

                foreach (var compras in comprasEliminar)
                {
                    contexto.Compras.Remove(compras);

                }
                contexto.SaveChanges();
                if (UsuarioSelecionado != null)
                {
                    contexto.Usuarios.Remove(UsuarioSelecionado);
                    contexto.SaveChanges();
                }
                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Notifica y limpia el campo
            MessageBox.Show("Usuario eliminado correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
            GridViewLoad();
        }

        private void dgvPerfiles_Click(object sender, EventArgs e)
        {
            if (dgvPerfiles.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvPerfiles.SelectedRows[0];
                Usuario UsuarioSeleccinado = (Usuario)selectedRow.DataBoundItem;
                txtID.Text = UsuarioSeleccinado.UsuarioId.ToString();
                txtNomComAdm.Text = UsuarioSeleccinado.NombreCompleto;
                txtCorreoAdm.Text = UsuarioSeleccinado.Correo;
                nudEdadAdm.Text = UsuarioSeleccinado.Edad.ToString();
                txtUsuarioAdm.Text = UsuarioSeleccinado.NombreUsuario;
                txtContraAdm.Text = UsuarioSeleccinado.Contraseña;
                cbNivelAdm.Text = UsuarioSeleccinado.NivelUsuario.ToString();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
