namespace ProyectoBiblioteca
{
    partial class frmVentas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtCliente = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblFecha = new Label();
            lblHora = new Label();
            groupBox2 = new GroupBox();
            txtCantidad = new TextBox();
            label9 = new Label();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lblPrecio = new Label();
            label6 = new Label();
            label5 = new Label();
            cobLibro = new ComboBox();
            lvRegistro = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            lblTotalNeto = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 128);
            label1.Location = new Point(200, 20);
            label1.Name = "label1";
            label1.Size = new Size(518, 45);
            label1.TabIndex = 0;
            label1.Text = "CONTROL DE VENTAS DE LIBROS";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCliente);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 14F);
            groupBox1.ForeColor = Color.FromArgb(64, 64, 128);
            groupBox1.Location = new Point(20, 80);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(420, 120);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 12F);
            txtCliente.Location = new Point(10, 60);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(390, 29);
            txtCliente.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 35);
            label2.Name = "label2";
            label2.Size = new Size(58, 21);
            label2.TabIndex = 0;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(485, 111);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Fecha";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(665, 111);
            label4.Name = "label4";
            label4.Size = new Size(53, 25);
            label4.TabIndex = 3;
            label4.Text = "Hora";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFecha.Location = new Point(485, 141);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(84, 25);
            lblFecha.TabIndex = 4;
            lblFecha.Text = "lblFecha";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHora.Location = new Point(665, 141);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(79, 25);
            lblHora.TabIndex = 5;
            lblHora.Text = "lblHora";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtCantidad);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(btnRegistrar);
            groupBox2.Controls.Add(btnCancelar);
            groupBox2.Controls.Add(lblPrecio);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(cobLibro);
            groupBox2.Font = new Font("Segoe UI", 14F);
            groupBox2.ForeColor = Color.FromArgb(64, 64, 128);
            groupBox2.Location = new Point(20, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 140);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Datos del Libro";
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(436, 74);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(88, 29);
            txtCantidad.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F);
            label9.Location = new Point(436, 43);
            label9.Name = "label9";
            label9.Size = new Size(88, 25);
            label9.TabIndex = 9;
            label9.Text = "Cantidad";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.FromArgb(72, 201, 176);
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(652, 70);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(140, 40);
            btnRegistrar.TabIndex = 8;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(652, 25);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 40);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblPrecio.Location = new Point(550, 73);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(90, 25);
            lblPrecio.TabIndex = 6;
            lblPrecio.Text = "lblPrecio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F);
            label6.Location = new Point(550, 43);
            label6.Name = "label6";
            label6.Size = new Size(65, 25);
            label6.TabIndex = 4;
            label6.Text = "Precio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(10, 40);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 3;
            label5.Text = "Libro";
            // 
            // cobLibro
            // 
            cobLibro.Font = new Font("Segoe UI", 14F);
            cobLibro.FormattingEnabled = true;
            cobLibro.Location = new Point(10, 70);
            cobLibro.Name = "cobLibro";
            cobLibro.Size = new Size(390, 33);
            cobLibro.TabIndex = 0;
            cobLibro.SelectedIndexChanged += cobLibro_SelectedIndexChanged;
            // 
            // lvRegistro
            // 
            lvRegistro.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            lvRegistro.Font = new Font("Segoe UI", 12F);
            lvRegistro.Location = new Point(20, 380);
            lvRegistro.Name = "lvRegistro";
            lvRegistro.Size = new Size(800, 326);
            lvRegistro.TabIndex = 7;
            lvRegistro.UseCompatibleStateImageBehavior = false;
            lvRegistro.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Libro";
            columnHeader1.Width = 250;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Cant.";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Precio";
            columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Subtotal";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Descuento";
            columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Neto";
            columnHeader6.Width = 150;
            // 
            // lblTotalNeto
            // 
            lblTotalNeto.AutoSize = true;
            lblTotalNeto.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalNeto.ForeColor = Color.FromArgb(64, 64, 128);
            lblTotalNeto.Location = new Point(665, 709);
            lblTotalNeto.Name = "lblTotalNeto";
            lblTotalNeto.Size = new Size(155, 32);
            lblTotalNeto.TabIndex = 9;
            lblTotalNeto.Text = "lblTotalNeto";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label8.Location = new Point(514, 709);
            label8.Name = "label8";
            label8.Size = new Size(121, 30);
            label8.TabIndex = 8;
            label8.Text = "Total Neto";
            // 
            // frmVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(860, 750);
            Controls.Add(lblTotalNeto);
            Controls.Add(label8);
            Controls.Add(lvRegistro);
            Controls.Add(groupBox2);
            Controls.Add(lblHora);
            Controls.Add(lblFecha);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CANTIDAD";
            Load += frmVentas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblFecha;
        private Label lblHora;
        private GroupBox groupBox2;
        private Label label5;
        private ComboBox cobLibro;
        private Button btnRegistrar;
        private Button btnCancelar;
        private Label lblPrecio;
        private Label label6;
        private ListView lvRegistro;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private Label lblTotalNeto;
        private Label label8;
        private Label label9;
        private TextBox txtCantidad;
    }
}
