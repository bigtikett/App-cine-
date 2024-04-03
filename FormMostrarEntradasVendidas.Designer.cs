namespace AppCine
{
    partial class FormMostrarEntradasVendidas
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
            listViewEntradasVendidas = new ListView();
            labelTotalBeneficios = new Label();
            listBoxBeneficios = new ListBox();
            lblTotalEntradas = new Label();
            SuspendLayout();
            // 
            // listViewEntradasVendidas
            // 
            listViewEntradasVendidas.Location = new Point(0, 12);
            listViewEntradasVendidas.Name = "listViewEntradasVendidas";
            listViewEntradasVendidas.Size = new Size(288, 426);
            listViewEntradasVendidas.TabIndex = 0;
            listViewEntradasVendidas.UseCompatibleStateImageBehavior = false;
            listViewEntradasVendidas.View = View.Details;
            listViewEntradasVendidas.SelectedIndexChanged += listViewEntradasVendidas_SelectedIndexChanged;
            // 
            // labelTotalBeneficios
            // 
            labelTotalBeneficios.AutoSize = true;
            labelTotalBeneficios.Location = new Point(462, 12);
            labelTotalBeneficios.Name = "labelTotalBeneficios";
            labelTotalBeneficios.Size = new Size(95, 15);
            labelTotalBeneficios.TabIndex = 1;
            labelTotalBeneficios.Text = "Total Beneficios :";
            // 
            // listBoxBeneficios
            // 
            listBoxBeneficios.FormattingEnabled = true;
            listBoxBeneficios.ItemHeight = 15;
            listBoxBeneficios.Location = new Point(462, 44);
            listBoxBeneficios.Name = "listBoxBeneficios";
            listBoxBeneficios.Size = new Size(316, 64);
            listBoxBeneficios.TabIndex = 2;
            listBoxBeneficios.SelectedIndexChanged += listBoxBeneficios_SelectedIndexChanged;
            // 
            // lblTotalEntradas
            // 
            lblTotalEntradas.AutoSize = true;
            lblTotalEntradas.Location = new Point(462, 26);
            lblTotalEntradas.Name = "lblTotalEntradas";
            lblTotalEntradas.Size = new Size(136, 15);
            lblTotalEntradas.TabIndex = 3;
            lblTotalEntradas.Text = "Total Entradas Vendidas :";
            // 
            // FormMostrarEntradasVendidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotalEntradas);
            Controls.Add(listBoxBeneficios);
            Controls.Add(labelTotalBeneficios);
            Controls.Add(listViewEntradasVendidas);
            Name = "FormMostrarEntradasVendidas";
            Text = "FormMostrarEntradasVendidas";
            Load += FormMostrarEntradasVendidas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewEntradasVendidas;
        private Label labelTotalBeneficios;
        private ListBox listBoxBeneficios;
        private Label lblTotalEntradas;
    }
}