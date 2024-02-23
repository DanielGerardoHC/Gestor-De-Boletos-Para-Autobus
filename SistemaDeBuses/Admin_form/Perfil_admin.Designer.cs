namespace SistemaDeBuses.Admin_form
{
    partial class Perfil_admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Perfil_admin));
            label1 = new Label();
            dgvPerfiles = new DataGridView();
            btnAgregarPerfil = new Button();
            btnModificarPerfil = new Button();
            btnEliminarPerfil = new Button();
            label2 = new Label();
            txtNomComAdm = new TextBox();
            label4 = new Label();
            txtCorreoAdm = new TextBox();
            label5 = new Label();
            label6 = new Label();
            nudEdadAdm = new NumericUpDown();
            txtContraAdm = new TextBox();
            label7 = new Label();
            txtUsuarioAdm = new TextBox();
            label8 = new Label();
            cbNivelAdm = new ComboBox();
            groupBox1 = new GroupBox();
            btnVolverPerfil = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtID = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEdadAdm).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(370, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 32);
            label1.TabIndex = 1;
            label1.Text = "Perfiles";
            // 
            // dgvPerfiles
            // 
            dgvPerfiles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPerfiles.BorderStyle = BorderStyle.None;
            dgvPerfiles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerfiles.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvPerfiles.Location = new Point(6, 22);
            dgvPerfiles.Name = "dgvPerfiles";
            dgvPerfiles.RowTemplate.Height = 25;
            dgvPerfiles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerfiles.Size = new Size(715, 154);
            dgvPerfiles.TabIndex = 2;
            dgvPerfiles.Click += dgvPerfiles_Click;
            // 
            // btnAgregarPerfil
            // 
            btnAgregarPerfil.FlatStyle = FlatStyle.Flat;
            btnAgregarPerfil.ForeColor = SystemColors.ControlLightLight;
            btnAgregarPerfil.Location = new Point(647, 78);
            btnAgregarPerfil.Name = "btnAgregarPerfil";
            btnAgregarPerfil.Size = new Size(108, 34);
            btnAgregarPerfil.TabIndex = 3;
            btnAgregarPerfil.Text = "Agregar";
            btnAgregarPerfil.UseVisualStyleBackColor = true;
            btnAgregarPerfil.Click += btnAgregarPerfil_Click;
            // 
            // btnModificarPerfil
            // 
            btnModificarPerfil.FlatStyle = FlatStyle.Flat;
            btnModificarPerfil.ForeColor = SystemColors.ControlLightLight;
            btnModificarPerfil.Location = new Point(647, 118);
            btnModificarPerfil.Name = "btnModificarPerfil";
            btnModificarPerfil.Size = new Size(108, 34);
            btnModificarPerfil.TabIndex = 4;
            btnModificarPerfil.Text = "Modificar";
            btnModificarPerfil.UseVisualStyleBackColor = true;
            btnModificarPerfil.Click += btnModificarPerfil_Click;
            // 
            // btnEliminarPerfil
            // 
            btnEliminarPerfil.FlatStyle = FlatStyle.Flat;
            btnEliminarPerfil.ForeColor = SystemColors.ControlLightLight;
            btnEliminarPerfil.Location = new Point(647, 158);
            btnEliminarPerfil.Name = "btnEliminarPerfil";
            btnEliminarPerfil.Size = new Size(108, 34);
            btnEliminarPerfil.TabIndex = 5;
            btnEliminarPerfil.Text = "Eliminar";
            btnEliminarPerfil.UseVisualStyleBackColor = true;
            btnEliminarPerfil.Click += btnEliminarPerfil_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(28, 49);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre Completo";
            // 
            // txtNomComAdm
            // 
            txtNomComAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtNomComAdm.BorderStyle = BorderStyle.None;
            txtNomComAdm.ForeColor = SystemColors.Window;
            txtNomComAdm.Location = new Point(28, 67);
            txtNomComAdm.Name = "txtNomComAdm";
            txtNomComAdm.Size = new Size(263, 16);
            txtNomComAdm.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.AliceBlue;
            label4.Location = new Point(28, 147);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 10;
            label4.Text = "Edad";
            // 
            // txtCorreoAdm
            // 
            txtCorreoAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtCorreoAdm.BorderStyle = BorderStyle.None;
            txtCorreoAdm.ForeColor = SystemColors.Window;
            txtCorreoAdm.Location = new Point(28, 111);
            txtCorreoAdm.Name = "txtCorreoAdm";
            txtCorreoAdm.Size = new Size(263, 16);
            txtCorreoAdm.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(28, 93);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 12;
            label5.Text = "Correo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.AliceBlue;
            label6.Location = new Point(205, 145);
            label6.Name = "label6";
            label6.Size = new Size(34, 15);
            label6.TabIndex = 14;
            label6.Text = "Nivel";
            // 
            // nudEdadAdm
            // 
            nudEdadAdm.BackColor = Color.FromArgb(31, 10, 100);
            nudEdadAdm.BorderStyle = BorderStyle.None;
            nudEdadAdm.ForeColor = SystemColors.Window;
            nudEdadAdm.Location = new Point(28, 165);
            nudEdadAdm.Name = "nudEdadAdm";
            nudEdadAdm.Size = new Size(100, 19);
            nudEdadAdm.TabIndex = 16;
            // 
            // txtContraAdm
            // 
            txtContraAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtContraAdm.BorderStyle = BorderStyle.None;
            txtContraAdm.ForeColor = SystemColors.Window;
            txtContraAdm.Location = new Point(332, 111);
            txtContraAdm.Name = "txtContraAdm";
            txtContraAdm.Size = new Size(118, 16);
            txtContraAdm.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.AliceBlue;
            label7.Location = new Point(332, 93);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 19;
            label7.Text = "Contraseña";
            // 
            // txtUsuarioAdm
            // 
            txtUsuarioAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtUsuarioAdm.BorderStyle = BorderStyle.None;
            txtUsuarioAdm.ForeColor = SystemColors.Window;
            txtUsuarioAdm.Location = new Point(332, 67);
            txtUsuarioAdm.Name = "txtUsuarioAdm";
            txtUsuarioAdm.Size = new Size(118, 16);
            txtUsuarioAdm.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.AliceBlue;
            label8.Location = new Point(332, 49);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 17;
            label8.Text = "Usuario";
            // 
            // cbNivelAdm
            // 
            cbNivelAdm.BackColor = Color.FromArgb(31, 10, 100);
            cbNivelAdm.ForeColor = SystemColors.Window;
            cbNivelAdm.FormattingEnabled = true;
            cbNivelAdm.Items.AddRange(new object[] { "1", "2" });
            cbNivelAdm.Location = new Point(205, 164);
            cbNivelAdm.Name = "cbNivelAdm";
            cbNivelAdm.Size = new Size(86, 23);
            cbNivelAdm.TabIndex = 21;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvPerfiles);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(28, 193);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(727, 182);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Perfiles Registrados";
            // 
            // btnVolverPerfil
            // 
            btnVolverPerfil.FlatStyle = FlatStyle.Flat;
            btnVolverPerfil.ForeColor = SystemColors.ControlLightLight;
            btnVolverPerfil.Location = new Point(647, 9);
            btnVolverPerfil.Name = "btnVolverPerfil";
            btnVolverPerfil.Size = new Size(108, 23);
            btnVolverPerfil.TabIndex = 23;
            btnVolverPerfil.Text = "Volver";
            btnVolverPerfil.UseVisualStyleBackColor = true;
            btnVolverPerfil.Click += btnVolverPerfil_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(489, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(111, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(28, 75);
            label3.Name = "label3";
            label3.Size = new Size(262, 15);
            label3.TabIndex = 26;
            label3.Text = "___________________________________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(29, 118);
            label9.Name = "label9";
            label9.Size = new Size(262, 15);
            label9.TabIndex = 27;
            label9.Text = "___________________________________________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(332, 75);
            label10.Name = "label10";
            label10.Size = new Size(117, 15);
            label10.TabIndex = 28;
            label10.Text = "______________________";
            // 
            // label11
            // 
            label11.AccessibleDescription = "txtContraAdm";
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(332, 118);
            label11.Name = "label11";
            label11.Size = new Size(117, 15);
            label11.TabIndex = 29;
            label11.Text = "______________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(28, 175);
            label12.Name = "label12";
            label12.Size = new Size(117, 15);
            label12.TabIndex = 30;
            label12.Text = "______________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(332, 158);
            label13.Name = "label13";
            label13.Size = new Size(117, 15);
            label13.TabIndex = 31;
            label13.Text = "______________________";
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.ForeColor = Color.AliceBlue;
            txtID.Location = new Point(332, 145);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 15);
            txtID.TabIndex = 32;
            txtID.Text = "ID registro";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(31, 10, 100);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(507, 164);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 28);
            btnLimpiar.TabIndex = 33;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Perfil_admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 10, 100);
            ClientSize = new Size(784, 387);
            ControlBox = false;
            Controls.Add(btnLimpiar);
            Controls.Add(txtID);
            Controls.Add(label13);
            Controls.Add(nudEdadAdm);
            Controls.Add(label12);
            Controls.Add(pictureBox1);
            Controls.Add(btnVolverPerfil);
            Controls.Add(groupBox1);
            Controls.Add(cbNivelAdm);
            Controls.Add(txtContraAdm);
            Controls.Add(label7);
            Controls.Add(txtUsuarioAdm);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(txtCorreoAdm);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnEliminarPerfil);
            Controls.Add(btnModificarPerfil);
            Controls.Add(btnAgregarPerfil);
            Controls.Add(label1);
            Controls.Add(txtNomComAdm);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label3);
            ForeColor = SystemColors.HighlightText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Perfil_admin";
            Text = "Perfiles";
            Load += Perfil_admin_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPerfiles).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEdadAdm).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView dgvPerfiles;
        private Button btnAgregarPerfil;
        private Button btnModificarPerfil;
        private Button btnEliminarPerfil;
        private Label label2;
        private TextBox txtNomComAdm;
        private Label label4;
        private TextBox txtCorreoAdm;
        private Label label5;
        private Label label6;
        private NumericUpDown nudEdadAdm;
        private TextBox txtContraAdm;
        private Label label7;
        private TextBox txtUsuarioAdm;
        private Label label8;
        private ComboBox cbNivelAdm;
        private GroupBox groupBox1;
        private Button btnVolverPerfil;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label txtID;
        private Button btnLimpiar;
    }
}