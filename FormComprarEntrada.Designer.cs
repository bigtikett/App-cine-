namespace AppCine
{
    partial class FormComprarEntrada
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprarEntrada));
            label1 = new Label();
            txtIDPelicula = new TextBox();
            btnComprobarID = new Button();
            listViewID = new ListView();
            monthCalendar1 = new MonthCalendar();
            imageList1 = new ImageList(components);
            label2 = new Label();
            txtNEntradas = new TextBox();
            btnNEntradas = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "Introduce ID de la Película";
            // 
            // txtIDPelicula
            // 
            txtIDPelicula.Location = new Point(118, 27);
            txtIDPelicula.Name = "txtIDPelicula";
            txtIDPelicula.Size = new Size(38, 23);
            txtIDPelicula.TabIndex = 1;
            // 
            // btnComprobarID
            // 
            btnComprobarID.Location = new Point(65, 56);
            btnComprobarID.Name = "btnComprobarID";
            btnComprobarID.Size = new Size(91, 23);
            btnComprobarID.TabIndex = 2;
            btnComprobarID.Text = "Comprobar ID";
            btnComprobarID.UseVisualStyleBackColor = true;
            btnComprobarID.Click += btnComprobarID_Click;
            // 
            // listViewID
            // 
            listViewID.Anchor = AnchorStyles.None;
            listViewID.Location = new Point(162, 9);
            listViewID.Name = "listViewID";
            listViewID.Size = new Size(416, 86);
            listViewID.TabIndex = 3;
            listViewID.UseCompatibleStateImageBehavior = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Info;
            monthCalendar1.Location = new Point(590, 9);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 4;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "R.jfif");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 114);
            label2.Name = "label2";
            label2.Size = new Size(149, 15);
            label2.TabIndex = 5;
            label2.Text = "Introduce el nº de entradas";
            // 
            // txtNEntradas
            // 
            txtNEntradas.Location = new Point(118, 132);
            txtNEntradas.Name = "txtNEntradas";
            txtNEntradas.Size = new Size(38, 23);
            txtNEntradas.TabIndex = 6;
            // 
            // btnNEntradas
            // 
            btnNEntradas.Location = new Point(45, 161);
            btnNEntradas.Name = "btnNEntradas";
            btnNEntradas.Size = new Size(111, 23);
            btnNEntradas.TabIndex = 7;
            btnNEntradas.Text = "Comprar Entradas";
            btnNEntradas.UseVisualStyleBackColor = true;
            btnNEntradas.Click += btnNEntradas_Click;
            // 
            // FormComprarEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNEntradas);
            Controls.Add(txtNEntradas);
            Controls.Add(label2);
            Controls.Add(monthCalendar1);
            Controls.Add(listViewID);
            Controls.Add(btnComprobarID);
            Controls.Add(txtIDPelicula);
            Controls.Add(label1);
            Name = "FormComprarEntrada";
            Text = "FormComprarEntrada";
            Load += FormComprarEntrada_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIDPelicula;
        private Button btnComprobarID;
        private ListView listViewID;
        private MonthCalendar monthCalendar1;
        private ImageList imageList1;
        private Label label2;
        private TextBox txtNEntradas;
        private Button btnNEntradas;
    }
}