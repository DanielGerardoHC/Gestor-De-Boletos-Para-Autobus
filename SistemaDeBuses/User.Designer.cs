namespace SistemaDeBuses
{
    partial class User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(User));
            comprarToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            cambiarContraseñaToolStripMenuItem = new ToolStripMenuItem();
            cerrarSesionToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            DataUser = new DataGridView();
            pictureBox1 = new PictureBox();
            txtnombreUsuario = new Label();
            txtnombreCompleto = new Label();
            txtcorreo = new Label();
            label1 = new Label();
            InfoData = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnActCompras = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataUser).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comprarToolStripMenuItem
            // 
            comprarToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            comprarToolStripMenuItem.Name = "comprarToolStripMenuItem";
            comprarToolStripMenuItem.Size = new Size(101, 20);
            comprarToolStripMenuItem.Text = "Nueva Compra";
            comprarToolStripMenuItem.Click += comprarToolStripMenuItem_Click;
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cambiarContraseñaToolStripMenuItem });
            perfilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(47, 20);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            cambiarContraseñaToolStripMenuItem.Size = new Size(187, 22);
            cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            cambiarContraseñaToolStripMenuItem.Click += cambiarContraseñaToolStripMenuItem_Click;
            // 
            // cerrarSesionToolStripMenuItem
            // 
            cerrarSesionToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            cerrarSesionToolStripMenuItem.Size = new Size(94, 20);
            cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            cerrarSesionToolStripMenuItem.Click += cerrarSesionToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { comprarToolStripMenuItem, perfilToolStripMenuItem, cerrarSesionToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(945, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // DataUser
            // 
            DataUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataUser.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataUser.Location = new Point(399, 76);
            DataUser.Name = "DataUser";
            DataUser.RowTemplate.Height = 25;
            DataUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataUser.Size = new Size(510, 284);
            DataUser.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(100, 59);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtnombreUsuario
            // 
            txtnombreUsuario.AutoSize = true;
            txtnombreUsuario.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombreUsuario.ForeColor = Color.White;
            txtnombreUsuario.Location = new Point(169, 233);
            txtnombreUsuario.Name = "txtnombreUsuario";
            txtnombreUsuario.Size = new Size(72, 15);
            txtnombreUsuario.TabIndex = 8;
            txtnombreUsuario.Text = "Informacion";
            // 
            // txtnombreCompleto
            // 
            txtnombreCompleto.AutoSize = true;
            txtnombreCompleto.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtnombreCompleto.ForeColor = Color.White;
            txtnombreCompleto.Location = new Point(169, 279);
            txtnombreCompleto.Name = "txtnombreCompleto";
            txtnombreCompleto.Size = new Size(72, 15);
            txtnombreCompleto.TabIndex = 9;
            txtnombreCompleto.Text = "Informacion";
            // 
            // txtcorreo
            // 
            txtcorreo.AutoSize = true;
            txtcorreo.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtcorreo.ForeColor = Color.White;
            txtcorreo.Location = new Point(169, 323);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.Size = new Size(72, 15);
            txtcorreo.TabIndex = 10;
            txtcorreo.Text = "Informacion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(390, 24);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 11;
            label1.Text = "Bienvenido";
            // 
            // InfoData
            // 
            InfoData.AutoSize = true;
            InfoData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            InfoData.ForeColor = Color.White;
            InfoData.Location = new Point(100, 168);
            InfoData.Name = "InfoData";
            InfoData.Size = new Size(104, 21);
            InfoData.TabIndex = 12;
            InfoData.Text = "Información";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(21, 323);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 15;
            label4.Text = "Correo Electronico:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(21, 279);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 14;
            label3.Text = "Nombre Completo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(13, 233);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 13;
            label2.Text = "Nombre de Usuario:";
            // 
            // btnActCompras
            // 
            btnActCompras.BackColor = Color.FromArgb(31, 10, 100);
            btnActCompras.FlatStyle = FlatStyle.Flat;
            btnActCompras.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnActCompras.ForeColor = SystemColors.Control;
            btnActCompras.Location = new Point(304, 92);
            btnActCompras.Name = "btnActCompras";
            btnActCompras.Size = new Size(89, 29);
            btnActCompras.TabIndex = 16;
            btnActCompras.Text = "Actualizar";
            btnActCompras.UseVisualStyleBackColor = false;
            btnActCompras.Click += btnActCompras_Click;
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 10, 100);
            ClientSize = new Size(945, 419);
            ControlBox = false;
            Controls.Add(btnActCompras);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(InfoData);
            Controls.Add(label1);
            Controls.Add(txtcorreo);
            Controls.Add(txtnombreCompleto);
            Controls.Add(txtnombreUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(DataUser);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "User";
            Opacity = 0.95D;
            Text = "Inicio";
            Load += User_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataUser).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem comprarToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem cerrarSesionToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
        private DataGridView DataUser;
        private PictureBox pictureBox1;
        private Label txtnombreUsuario;
        private Label txtnombreCompleto;
        private Label txtcorreo;
        private Label label1;
        private Label InfoData;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnActCompras;
    }
}