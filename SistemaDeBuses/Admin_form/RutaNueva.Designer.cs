namespace SistemaDeBuses.Admin_form
{
    partial class RutaNueva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RutaNueva));
            dgvRutas = new DataGridView();
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtRutaAdm = new TextBox();
            txtOrigenAdm = new TextBox();
            label2 = new Label();
            txtDestinoAdm = new TextBox();
            label3 = new Label();
            txtPrecioAdm = new TextBox();
            label4 = new Label();
            btnAgregarRuta = new Button();
            btnModificarRuta = new Button();
            btnEliminarRuta = new Button();
            label5 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnVolverRutaNv = new Button();
            cbAsientosAdm = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            txtID = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRutas).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvRutas
            // 
            dgvRutas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRutas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRutas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvRutas.Location = new Point(9, 22);
            dgvRutas.Name = "dgvRutas";
            dgvRutas.RowTemplate.Height = 25;
            dgvRutas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRutas.Size = new Size(730, 171);
            dgvRutas.TabIndex = 2;
            dgvRutas.Click += dgvRutas_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvRutas);
            groupBox1.ForeColor = SystemColors.ControlLightLight;
            groupBox1.Location = new Point(22, 181);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(745, 203);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Rutas Agregadas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(30, 35);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 2;
            // 
            // txtRutaAdm
            // 
            txtRutaAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtRutaAdm.BorderStyle = BorderStyle.None;
            txtRutaAdm.ForeColor = Color.White;
            txtRutaAdm.Location = new Point(31, 24);
            txtRutaAdm.Name = "txtRutaAdm";
            txtRutaAdm.PlaceholderText = "Ruta";
            txtRutaAdm.Size = new Size(100, 16);
            txtRutaAdm.TabIndex = 3;
            // 
            // txtOrigenAdm
            // 
            txtOrigenAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtOrigenAdm.BorderStyle = BorderStyle.None;
            txtOrigenAdm.ForeColor = SystemColors.Window;
            txtOrigenAdm.Location = new Point(30, 76);
            txtOrigenAdm.Name = "txtOrigenAdm";
            txtOrigenAdm.PlaceholderText = "Origen";
            txtOrigenAdm.Size = new Size(179, 16);
            txtOrigenAdm.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(31, 69);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 4;
            // 
            // txtDestinoAdm
            // 
            txtDestinoAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtDestinoAdm.BorderStyle = BorderStyle.None;
            txtDestinoAdm.ForeColor = SystemColors.Window;
            txtDestinoAdm.Location = new Point(30, 134);
            txtDestinoAdm.Name = "txtDestinoAdm";
            txtDestinoAdm.PlaceholderText = "Destino";
            txtDestinoAdm.Size = new Size(179, 16);
            txtDestinoAdm.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(30, 134);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 6;
            // 
            // txtPrecioAdm
            // 
            txtPrecioAdm.BackColor = Color.FromArgb(31, 10, 100);
            txtPrecioAdm.BorderStyle = BorderStyle.None;
            txtPrecioAdm.ForeColor = SystemColors.Control;
            txtPrecioAdm.Location = new Point(315, 35);
            txtPrecioAdm.Name = "txtPrecioAdm";
            txtPrecioAdm.PlaceholderText = "Precio";
            txtPrecioAdm.Size = new Size(120, 16);
            txtPrecioAdm.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(299, 35);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 8;
            label4.Text = "$";
            // 
            // btnAgregarRuta
            // 
            btnAgregarRuta.BackColor = Color.Transparent;
            btnAgregarRuta.FlatAppearance.BorderColor = Color.White;
            btnAgregarRuta.FlatAppearance.BorderSize = 2;
            btnAgregarRuta.FlatStyle = FlatStyle.Flat;
            btnAgregarRuta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnAgregarRuta.ForeColor = SystemColors.ControlLightLight;
            btnAgregarRuta.Location = new Point(650, 76);
            btnAgregarRuta.Name = "btnAgregarRuta";
            btnAgregarRuta.Size = new Size(108, 34);
            btnAgregarRuta.TabIndex = 10;
            btnAgregarRuta.Text = "Agregar";
            btnAgregarRuta.UseVisualStyleBackColor = false;
            btnAgregarRuta.Click += btnAgregarRuta_Click;
            // 
            // btnModificarRuta
            // 
            btnModificarRuta.BackColor = Color.Transparent;
            btnModificarRuta.FlatAppearance.BorderColor = Color.White;
            btnModificarRuta.FlatAppearance.BorderSize = 2;
            btnModificarRuta.FlatStyle = FlatStyle.Flat;
            btnModificarRuta.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnModificarRuta.ForeColor = SystemColors.ControlLightLight;
            btnModificarRuta.Location = new Point(650, 116);
            btnModificarRuta.Name = "btnModificarRuta";
            btnModificarRuta.Size = new Size(108, 29);
            btnModificarRuta.TabIndex = 11;
            btnModificarRuta.Text = "Modificar";
            btnModificarRuta.UseVisualStyleBackColor = false;
            btnModificarRuta.Click += btnModificarRuta_Click;
            // 
            // btnEliminarRuta
            // 
            btnEliminarRuta.BackColor = Color.Transparent;
            btnEliminarRuta.FlatAppearance.BorderColor = Color.White;
            btnEliminarRuta.FlatAppearance.BorderSize = 2;
            btnEliminarRuta.FlatStyle = FlatStyle.Flat;
            btnEliminarRuta.ForeColor = SystemColors.ControlLightLight;
            btnEliminarRuta.Location = new Point(650, 151);
            btnEliminarRuta.Name = "btnEliminarRuta";
            btnEliminarRuta.Size = new Size(108, 29);
            btnEliminarRuta.TabIndex = 12;
            btnEliminarRuta.Text = "Eliminar";
            btnEliminarRuta.UseVisualStyleBackColor = false;
            btnEliminarRuta.Click += btnEliminarRuta_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(298, 73);
            label5.Name = "label5";
            label5.Size = new Size(113, 15);
            label5.TabIndex = 13;
            label5.Text = "Numero de asientos";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Impact", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(360, 6);
            label6.Name = "label6";
            label6.Size = new Size(108, 26);
            label6.TabIndex = 15;
            label6.Text = "Nueva Ruta";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(464, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // btnVolverRutaNv
            // 
            btnVolverRutaNv.BackColor = Color.Transparent;
            btnVolverRutaNv.FlatAppearance.BorderColor = Color.White;
            btnVolverRutaNv.FlatAppearance.BorderSize = 2;
            btnVolverRutaNv.FlatStyle = FlatStyle.Flat;
            btnVolverRutaNv.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnVolverRutaNv.ForeColor = SystemColors.ControlLightLight;
            btnVolverRutaNv.Location = new Point(650, 12);
            btnVolverRutaNv.Name = "btnVolverRutaNv";
            btnVolverRutaNv.Size = new Size(108, 38);
            btnVolverRutaNv.TabIndex = 17;
            btnVolverRutaNv.Text = "Volver";
            btnVolverRutaNv.UseVisualStyleBackColor = false;
            btnVolverRutaNv.Click += btnVolverRutaNv_Click;
            // 
            // cbAsientosAdm
            // 
            cbAsientosAdm.BackColor = Color.FromArgb(31, 10, 100);
            cbAsientosAdm.FlatStyle = FlatStyle.Flat;
            cbAsientosAdm.ForeColor = SystemColors.Window;
            cbAsientosAdm.FormattingEnabled = true;
            cbAsientosAdm.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30" });
            cbAsientosAdm.Location = new Point(298, 90);
            cbAsientosAdm.Name = "cbAsientosAdm";
            cbAsientosAdm.Size = new Size(121, 23);
            cbAsientosAdm.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 35);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 21;
            label7.Text = "__________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(28, 87);
            label8.Name = "label8";
            label8.Size = new Size(167, 15);
            label8.TabIndex = 22;
            label8.Text = "________________________________";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(28, 142);
            label9.Name = "label9";
            label9.Size = new Size(167, 15);
            label9.TabIndex = 23;
            label9.Text = "________________________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(299, 42);
            label10.Name = "label10";
            label10.Size = new Size(97, 15);
            label10.TabIndex = 24;
            label10.Text = "__________________";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlLightLight;
            label13.Location = new Point(294, 158);
            label13.Name = "label13";
            label13.Size = new Size(117, 15);
            label13.TabIndex = 32;
            label13.Text = "______________________";
            // 
            // txtID
            // 
            txtID.AutoSize = true;
            txtID.ForeColor = Color.AliceBlue;
            txtID.Location = new Point(299, 142);
            txtID.Name = "txtID";
            txtID.Size = new Size(61, 15);
            txtID.TabIndex = 33;
            txtID.Text = "ID registro";
            txtID.Click += txtID_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(31, 10, 100);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(487, 151);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 28);
            btnLimpiar.TabIndex = 34;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // RutaNueva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 10, 100);
            ClientSize = new Size(784, 387);
            ControlBox = false;
            Controls.Add(btnLimpiar);
            Controls.Add(txtID);
            Controls.Add(label13);
            Controls.Add(txtDestinoAdm);
            Controls.Add(txtRutaAdm);
            Controls.Add(txtPrecioAdm);
            Controls.Add(label9);
            Controls.Add(cbAsientosAdm);
            Controls.Add(btnVolverRutaNv);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnEliminarRuta);
            Controls.Add(btnModificarRuta);
            Controls.Add(btnAgregarRuta);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtOrigenAdm);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(label7);
            Controls.Add(label8);
            ForeColor = SystemColors.Control;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RutaNueva";
            Text = "Rutas de buses";
            Load += RutaNueva_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRutas).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRutas;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtRutaAdm;
        private TextBox txtOrigenAdm;
        private Label label2;
        private TextBox txtDestinoAdm;
        private Label label3;
        private TextBox txtPrecioAdm;
        private Label label4;
        private Button btnAgregarRuta;
        private Button btnModificarRuta;
        private Button btnEliminarRuta;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox1;
        private Button btnVolverRutaNv;
        private ComboBox cbAsientosAdm;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label txtID;
        private Button btnLimpiar;
    }
}