namespace SistemaDeBuses
{
    partial class Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compras));
            DataCompras = new DataGridView();
            txtCompra = new TextBox();
            txtcantidadAsientos = new NumericUpDown();
            btnComprar = new Button();
            btnAtras = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataCompras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidadAsientos).BeginInit();
            SuspendLayout();
            // 
            // DataCompras
            // 
            DataCompras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DataCompras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataCompras.EditMode = DataGridViewEditMode.EditProgrammatically;
            DataCompras.Location = new Point(368, 70);
            DataCompras.Name = "DataCompras";
            DataCompras.RowTemplate.Height = 25;
            DataCompras.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataCompras.Size = new Size(527, 314);
            DataCompras.TabIndex = 0;
            DataCompras.Click += DataCompras_Click;
            // 
            // txtCompra
            // 
            txtCompra.BackColor = Color.FromArgb(31, 10, 100);
            txtCompra.BorderStyle = BorderStyle.None;
            txtCompra.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompra.ForeColor = Color.White;
            txtCompra.Location = new Point(76, 117);
            txtCompra.Name = "txtCompra";
            txtCompra.PlaceholderText = "Ruta a comprar";
            txtCompra.Size = new Size(185, 14);
            txtCompra.TabIndex = 1;
            // 
            // txtcantidadAsientos
            // 
            txtcantidadAsientos.BackColor = Color.FromArgb(31, 10, 100);
            txtcantidadAsientos.BorderStyle = BorderStyle.None;
            txtcantidadAsientos.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            txtcantidadAsientos.ForeColor = SystemColors.Window;
            txtcantidadAsientos.Location = new Point(76, 216);
            txtcantidadAsientos.Name = "txtcantidadAsientos";
            txtcantidadAsientos.Size = new Size(120, 17);
            txtcantidadAsientos.TabIndex = 2;
            // 
            // btnComprar
            // 
            btnComprar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnComprar.BackColor = Color.FromArgb(31, 10, 100);
            btnComprar.FlatAppearance.BorderColor = Color.White;
            btnComprar.FlatAppearance.BorderSize = 2;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(97, 287);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(99, 37);
            btnComprar.TabIndex = 3;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // btnAtras
            // 
            btnAtras.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnAtras.BackColor = Color.FromArgb(31, 10, 100);
            btnAtras.FlatAppearance.BorderColor = Color.White;
            btnAtras.FlatAppearance.BorderSize = 2;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnAtras.ForeColor = SystemColors.Control;
            btnAtras.Location = new Point(775, 406);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(99, 37);
            btnAtras.TabIndex = 4;
            btnAtras.Text = "<-- Atras";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(108, 90);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(72, 187);
            label2.Name = "label2";
            label2.Size = new Size(181, 15);
            label2.TabIndex = 6;
            label2.Text = "Cantidad de asientos a comprar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 134);
            label4.Name = "label4";
            label4.Size = new Size(157, 15);
            label4.TabIndex = 9;
            label4.Text = "______________________________";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(416, 22);
            label3.Name = "label3";
            label3.Size = new Size(216, 32);
            label3.TabIndex = 11;
            label3.Text = "Rutas disponibles";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(69, 227);
            label5.Name = "label5";
            label5.Size = new Size(127, 15);
            label5.TabIndex = 12;
            label5.Text = "________________________";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(31, 10, 100);
            ClientSize = new Size(954, 450);
            ControlBox = false;
            Controls.Add(txtcantidadAsientos);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAtras);
            Controls.Add(btnComprar);
            Controls.Add(txtCompra);
            Controls.Add(DataCompras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Compras";
            Opacity = 0.95D;
            Text = "Compras de boletos";
            Load += Compras_Load;
            ((System.ComponentModel.ISupportInitialize)DataCompras).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtcantidadAsientos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DataCompras;
        private TextBox txtCompra;
        private NumericUpDown txtcantidadAsientos;
        private Button btnComprar;
        private Button btnAtras;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
    }
}