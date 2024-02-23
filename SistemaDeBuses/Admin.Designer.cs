namespace SistemaDeBuses
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            rutasToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            panelAdm = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            txtUsuarios = new Label();
            txtvAsientos = new Label();
            txtVentas = new Label();
            btnReporte = new Button();
            menuStrip1.SuspendLayout();
            panelAdm.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(341, 29);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido admin";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { rutasToolStripMenuItem, perfilToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // rutasToolStripMenuItem
            // 
            rutasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            rutasToolStripMenuItem.Size = new Size(51, 20);
            rutasToolStripMenuItem.Text = "Rutas";
            rutasToolStripMenuItem.Click += rutasToolStripMenuItem_Click;
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(60, 20);
            perfilToolStripMenuItem.Text = "Perfiles";
            perfilToolStripMenuItem.Click += perfilToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(94, 20);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // panelAdm
            // 
            panelAdm.Controls.Add(label4);
            panelAdm.Controls.Add(label3);
            panelAdm.Controls.Add(label2);
            panelAdm.Controls.Add(panel1);
            panelAdm.Controls.Add(txtUsuarios);
            panelAdm.Controls.Add(txtvAsientos);
            panelAdm.Controls.Add(txtVentas);
            panelAdm.Controls.Add(btnReporte);
            panelAdm.Dock = DockStyle.Fill;
            panelAdm.ForeColor = SystemColors.Window;
            panelAdm.Location = new Point(0, 24);
            panelAdm.Name = "panelAdm";
            panelAdm.Size = new Size(800, 426);
            panelAdm.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(428, 238);
            label4.Name = "label4";
            label4.Size = new Size(210, 17);
            label4.TabIndex = 10;
            label4.Text = "TOTAL DE ASIENTOS VENDIDOS:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(472, 157);
            label3.Name = "label3";
            label3.Size = new Size(166, 17);
            label3.TabIndex = 9;
            label3.Text = "USUARIOS REGISTRADOS:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(512, 70);
            label2.Name = "label2";
            label2.Size = new Size(126, 17);
            label2.TabIndex = 8;
            label2.Text = "TOTAL DE VENTAS:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(394, 426);
            panel1.TabIndex = 7;
            // 
            // txtUsuarios
            // 
            txtUsuarios.AutoSize = true;
            txtUsuarios.BackColor = Color.Transparent;
            txtUsuarios.FlatStyle = FlatStyle.Flat;
            txtUsuarios.Location = new Point(662, 161);
            txtUsuarios.Name = "txtUsuarios";
            txtUsuarios.Size = new Size(52, 15);
            txtUsuarios.TabIndex = 6;
            txtUsuarios.Text = "Usuarios";
            // 
            // txtvAsientos
            // 
            txtvAsientos.AutoSize = true;
            txtvAsientos.BackColor = Color.Transparent;
            txtvAsientos.FlatStyle = FlatStyle.Flat;
            txtvAsientos.Location = new Point(662, 240);
            txtvAsientos.Name = "txtvAsientos";
            txtvAsientos.Size = new Size(94, 15);
            txtvAsientos.TabIndex = 5;
            txtvAsientos.Text = "Total de asientos";
            // 
            // txtVentas
            // 
            txtVentas.AutoSize = true;
            txtVentas.BackColor = Color.Transparent;
            txtVentas.FlatStyle = FlatStyle.Flat;
            txtVentas.Location = new Point(662, 74);
            txtVentas.Name = "txtVentas";
            txtVentas.Size = new Size(69, 15);
            txtVentas.TabIndex = 4;
            txtVentas.Text = "Total ventas";
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(31, 10, 100);
            btnReporte.FlatAppearance.BorderColor = Color.White;
            btnReporte.FlatAppearance.BorderSize = 2;
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnReporte.ForeColor = Color.White;
            btnReporte.Location = new Point(512, 307);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(205, 52);
            btnReporte.TabIndex = 0;
            btnReporte.Text = "Crear Reporte de Ventas";
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 10, 100);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(panelAdm);
            Controls.Add(menuStrip1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            Text = "Pagina principal";
            Load += Admin_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelAdm.ResumeLayout(false);
            panelAdm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private ToolStripMenuItem rutasToolStripMenuItem;
        private Panel panelAdm;
        private Label txtUsuarios;
        private Label txtvAsientos;
        private Label txtVentas;
        private Button btnReporte;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}