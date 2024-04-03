namespace AppCine
{
    partial class FormMostrarPeliculas
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
            listViewPeliculas = new ListView();
            ID = new ColumnHeader();
            Título = new ColumnHeader();
            Género = new ColumnHeader();
            Precio = new ColumnHeader();
            SuspendLayout();
            // 
            // listViewPeliculas
            // 
            listViewPeliculas.Columns.AddRange(new ColumnHeader[] { ID, Título, Género, Precio });
            listViewPeliculas.Dock = DockStyle.Fill;
            listViewPeliculas.Location = new Point(0, 0);
            listViewPeliculas.Name = "listViewPeliculas";
            listViewPeliculas.Size = new Size(302, 360);
            listViewPeliculas.TabIndex = 0;
            listViewPeliculas.UseCompatibleStateImageBehavior = false;
            listViewPeliculas.View = View.Details;
            listViewPeliculas.SelectedIndexChanged += listViewPeliculas_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Tag = "";
            ID.Text = "ID";
            // 
            // Título
            // 
            Título.Text = "Título";
            // 
            // Género
            // 
            Género.Text = "Género";
            // 
            // Precio
            // 
            Precio.Text = "Precio";
            // 
            // FormMostrarPeliculas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 360);
            Controls.Add(listViewPeliculas);
            Name = "FormMostrarPeliculas";
            Text = "FormMostrarPeliculas";
            Load += FormMostrarPeliculas_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewPeliculas;
        private ColumnHeader ID;
        private ColumnHeader Título;
        private ColumnHeader Género;
        private ColumnHeader Precio;
    }
}