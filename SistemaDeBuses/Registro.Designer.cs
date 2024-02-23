namespace SistemaDeBuses
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            btnCancelar = new Button();
            btnRegistrar = new Button();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtnombreCompleto = new TextBox();
            txtCorreo = new TextBox();
            txtContra = new TextBox();
            txtUsuario = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            txtEdad = new TextBox();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.White;
            btnCancelar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.ImageAlign = ContentAlignment.TopLeft;
            btnCancelar.Location = new Point(595, 400);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(133, 38);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "<-- Atras";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.FlatAppearance.BorderColor = Color.White;
            btnRegistrar.FlatAppearance.BorderSize = 2;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(75, 324);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(308, 39);
            btnRegistrar.TabIndex = 29;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(389, 160);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 28;
            label6.Text = "Correo Electronico";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(41, 213);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 27;
            label5.Text = "Edad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 160);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 25;
            label3.Text = "Nombre Completo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(427, 93);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 24;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 94);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 23;
            label1.Text = "Usuario";
            // 
            // txtnombreCompleto
            // 
            txtnombreCompleto.BackColor = Color.FromArgb(31, 10, 100);
            txtnombreCompleto.BorderStyle = BorderStyle.None;
            txtnombreCompleto.ForeColor = SystemColors.Window;
            txtnombreCompleto.Location = new Point(147, 152);
            txtnombreCompleto.Name = "txtnombreCompleto";
            txtnombreCompleto.PlaceholderText = "Full Name";
            txtnombreCompleto.Size = new Size(236, 16);
            txtnombreCompleto.TabIndex = 22;
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.FromArgb(31, 10, 100);
            txtCorreo.BorderStyle = BorderStyle.None;
            txtCorreo.ForeColor = SystemColors.Window;
            txtCorreo.Location = new Point(509, 147);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.PlaceholderText = "Email";
            txtCorreo.Size = new Size(236, 16);
            txtCorreo.TabIndex = 19;
            // 
            // txtContra
            // 
            txtContra.BackColor = Color.FromArgb(31, 10, 100);
            txtContra.BorderStyle = BorderStyle.None;
            txtContra.ForeColor = SystemColors.Window;
            txtContra.Location = new Point(506, 94);
            txtContra.Name = "txtContra";
            txtContra.PlaceholderText = "Password";
            txtContra.Size = new Size(162, 16);
            txtContra.TabIndex = 18;
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(31, 10, 100);
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(152, 94);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "User Name";
            txtUsuario.Size = new Size(162, 16);
            txtUsuario.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(150, 108);
            label7.Name = "label7";
            label7.Size = new Size(167, 15);
            label7.TabIndex = 8;
            label7.Text = "________________________________";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(506, 108);
            label8.Name = "label8";
            label8.Size = new Size(167, 15);
            label8.TabIndex = 8;
            label8.Text = "________________________________";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.White;
            label10.Location = new Point(147, 220);
            label10.Name = "label10";
            label10.Size = new Size(107, 15);
            label10.TabIndex = 8;
            label10.Text = "____________________";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.White;
            label11.Location = new Point(506, 161);
            label11.Name = "label11";
            label11.Size = new Size(242, 15);
            label11.TabIndex = 8;
            label11.Text = "_______________________________________________";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.White;
            label12.Location = new Point(147, 166);
            label12.Name = "label12";
            label12.Size = new Size(227, 15);
            label12.TabIndex = 8;
            label12.Text = "____________________________________________";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(489, 191);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 203);
            panel1.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(247, 21);
            label4.Name = "label4";
            label4.Size = new Size(315, 32);
            label4.TabIndex = 33;
            label4.Text = "Registro de nuevo usuario";
            // 
            // txtEdad
            // 
            txtEdad.BackColor = Color.FromArgb(31, 10, 100);
            txtEdad.BorderStyle = BorderStyle.None;
            txtEdad.ForeColor = SystemColors.Window;
            txtEdad.Location = new Point(150, 214);
            txtEdad.Name = "txtEdad";
            txtEdad.PlaceholderText = "Edad";
            txtEdad.Size = new Size(104, 16);
            txtEdad.TabIndex = 34;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(31, 10, 100);
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = SystemColors.ControlLightLight;
            btnLimpiar.Location = new Point(408, 213);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 28);
            btnLimpiar.TabIndex = 35;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Registro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 10, 100);
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(btnLimpiar);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnCancelar);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(btnRegistrar);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtnombreCompleto);
            Controls.Add(txtCorreo);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registro";
            Opacity = 0.95D;
            Text = "Registro";
            Load += Registro_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnCancelar;
        private Button btnRegistrar;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtnombreCompleto;
        private TextBox txtCorreo;
        private TextBox txtContra;
        private TextBox txtUsuario;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label11;
        private Label label12;
        private Panel panel1;
        private Label label4;
        private TextBox txtEdad;
        private Button btnLimpiar;
    }
}