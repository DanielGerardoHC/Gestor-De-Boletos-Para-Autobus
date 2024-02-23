using SistemaDeBuses.Contexto;
using System.Globalization;

namespace SistemaDeBuses.Admin_form
{
    public partial class RutaNueva : Form
    {

        GestorVentaBoletosContext contexto = new GestorVentaBoletosContext();
        private Form Admin;


        public RutaNueva(Form Admin)
        {
            InitializeComponent();
            this.Admin = Admin;
        }
        private void GridViewLoad()
        {
            var consulta = from ruta in contexto.Rutas
                           join compra in contexto.Compras on ruta.RutaId equals compra.RutaId into comprasRuta
                           select new
                           {
                               ruta.RutaId,
                               ruta.NombreRuta,
                               ruta.Origen,
                               ruta.Destino,
                               ruta.Precio,
                               ruta.AsientosDisponibles,
                               BoletosComprados = comprasRuta.Sum(c => c.CantidadAsientos)
                           };

            dgvRutas.DataSource = null;
            dgvRutas.DataSource = consulta.ToList();
        }
        private void Limpiar()
        {
            txtRutaAdm.Text = string.Empty;
            txtOrigenAdm.Text = string.Empty;
            txtDestinoAdm.Text = string.Empty;
            txtPrecioAdm.Text = string.Empty;
            cbAsientosAdm.SelectedIndex = -1;
            txtID.Text = string.Empty;
        }


        private void RutaNueva_Load(object sender, EventArgs e)
        {
            GridViewLoad();
        }

        private void btnVolverRutaNv_Click(object sender, EventArgs e)
        {
            this.Close();
            Admin.Show();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos estén completos
            if (string.IsNullOrWhiteSpace(txtRutaAdm.Text) || string.IsNullOrWhiteSpace(txtOrigenAdm.Text) ||
                string.IsNullOrWhiteSpace(txtDestinoAdm.Text) || string.IsNullOrWhiteSpace(txtPrecioAdm.Text) ||
                string.IsNullOrWhiteSpace(cbAsientosAdm.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el formato del precio
            if (!decimal.TryParse(txtPrecioAdm.Text, out decimal precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número decimal positivo.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el formato de los asientos disponibles
            if (!int.TryParse(cbAsientosAdm.Text, out int asientosDisponibles) || asientosDisponibles <= 0)
            {
                MessageBox.Show("La cantidad de asientos disponibles debe ser un número entero positivo.", "Formato Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar si la ruta ya existe
            var rutaexistente = contexto.Rutas.FirstOrDefault(x => x.NombreRuta == txtRutaAdm.Text);
            if (rutaexistente == null)
            {
                Ruta nr = new Ruta();

                nr.NombreRuta = txtRutaAdm.Text;
                nr.Origen = txtOrigenAdm.Text;
                nr.Destino = txtDestinoAdm.Text;
                nr.Precio = decimal.Parse(txtPrecioAdm.Text);
                nr.AsientosDisponibles = int.Parse(cbAsientosAdm.Text);


                // Agregar la nueva ruta a la base de datos
                contexto.Rutas.Add(nr);
                contexto.SaveChanges();

                // Notifica y limpia el campo
                MessageBox.Show("Ruta agregada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();

                // Actualizar el DataGridView con las rutas
                GridViewLoad();
            }
            else
            {
                MessageBox.Show("Esta ruta ya existe en el sistema");
            }
        }

        private void dgvRutas_Click(object sender, EventArgs e)
        {
            if (dgvRutas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRutas.SelectedRows[0];
                var rutaSeleccionada = (dynamic)selectedRow.DataBoundItem; // Cambiado a dynamic

                txtID.Text = rutaSeleccionada.RutaId.ToString();
                txtRutaAdm.Text = rutaSeleccionada.NombreRuta;
                txtOrigenAdm.Text = rutaSeleccionada.Origen;
                txtDestinoAdm.Text = rutaSeleccionada.Destino;
                txtPrecioAdm.Text = rutaSeleccionada.Precio.ToString();
                cbAsientosAdm.Text = rutaSeleccionada.AsientosDisponibles.ToString();
            }
        }

        private void btnModificarRuta_Click(object sender, EventArgs e)
        {
            if (dgvRutas.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRutas.SelectedRows[0];
                var rutaSeleccionada = (dynamic)selectedRow.DataBoundItem;

                // Obtener la ruta seleccionada desde el DataGridView
                int rutaId = rutaSeleccionada.RutaId;
                Ruta rutaActualizar = contexto.Rutas.FirstOrDefault(r => r.RutaId == rutaId);

                if (rutaActualizar != null)
                {
                    // Actualiza los valores de la ruta con los datos del formulario
                    rutaActualizar.NombreRuta = txtRutaAdm.Text;
                    rutaActualizar.Origen = txtOrigenAdm.Text;
                    rutaActualizar.Destino = txtDestinoAdm.Text;
                    rutaActualizar.Precio = decimal.Parse(txtPrecioAdm.Text);
                    rutaActualizar.AsientosDisponibles = int.Parse(cbAsientosAdm.Text);

                    // Guarda los cambios en la base de datos
                    contexto.SaveChanges();

                    // Actualiza el DataGridView con las rutas y boletos comprados
                    GridViewLoad();
                }
            }
            else
            {
                MessageBox.Show("Seleccione una ruta para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Notifica y limpia el campo
            MessageBox.Show("Ruta modificada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();

        }

        private void btnEliminarRuta_Click(object sender, EventArgs e)
        {
            if (dgvRutas.SelectedRows.Count > 0)
            {
                var rutaId = int.Parse(txtID.Text);

                // Eliminar las compras relacionadas con la ruta
                var comprasAEliminar = contexto.Compras.Where(c => c.RutaId == rutaId);
                foreach (var compra in comprasAEliminar)
                {
                    contexto.Compras.Remove(compra);
                }
                contexto.SaveChanges();

                // Obtener y eliminar la ruta de la base de datos
                var rutaEliminar = contexto.Rutas.FirstOrDefault(x => x.RutaId == rutaId);
                if (rutaEliminar != null)
                {
                    contexto.Rutas.Remove(rutaEliminar);
                    contexto.SaveChanges();
                }

                // Actualizar el DataGridView con las rutas y boletos comprados
                GridViewLoad();

            }
            else
            {
                MessageBox.Show("Seleccione una ruta para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Notifica y limpia el campo
            MessageBox.Show("Ruta eliminada correctamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpiar();
        }

        private void txtID_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
