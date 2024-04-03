namespace AppCine
{
    partial class FormAgregarPelicula
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
            cmbGenero = new ComboBox();
            txtTitulo = new TextBox();
            txtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregarPelicula = new Button();
            SuspendLayout();
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Comedia", "Drama", "Acción", "CienciaFicción", "Fantasía", "Musical", "Terror", "Suspense", "Romance", "Policíaco", "Infantil" });
            cmbGenero.Location = new Point(18, 99);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 0;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(18, 55);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 1;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(18, 143);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 37);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Título";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 125);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 4;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 81);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 5;
            label3.Text = "Género";
            // 
            // btnAgregarPelicula
            // 
            btnAgregarPelicula.Location = new Point(18, 172);
            btnAgregarPelicula.Name = "btnAgregarPelicula";
            btnAgregarPelicula.Size = new Size(75, 23);
            btnAgregarPelicula.TabIndex = 6;
            btnAgregarPelicula.Text = "Agregar";
            btnAgregarPelicula.UseVisualStyleBackColor = true;
            btnAgregarPelicula.Click += btnAgregarPelicula_Click;
            // 
            // FormAgregarPelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 328);
            Controls.Add(btnAgregarPelicula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrecio);
            Controls.Add(txtTitulo);
            Controls.Add(cmbGenero);
            Name = "FormAgregarPelicula";
            Text = "FormAgregarPelicula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGenero;
        private TextBox txtTitulo;
        private TextBox txtPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregarPelicula;
    }
}