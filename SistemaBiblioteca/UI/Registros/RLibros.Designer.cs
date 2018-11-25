namespace SistemaBiblioteca.UI.Registros
{
    partial class RLibros
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RLibros));
            this.NobretextBox = new System.Windows.Forms.TextBox();
            this.LibroIdnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.ISBNtextBox = new System.Windows.Forms.TextBox();
            this.DescripciontextBox = new System.Windows.Forms.TextBox();
            this.Categoriabutton = new System.Windows.Forms.Button();
            this.CategoriacomboBox = new System.Windows.Forms.ComboBox();
            this.EditoracomboBox = new System.Windows.Forms.ComboBox();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEditorial = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // NobretextBox
            // 
            this.NobretextBox.Location = new System.Drawing.Point(125, 79);
            this.NobretextBox.Name = "NobretextBox";
            this.NobretextBox.Size = new System.Drawing.Size(167, 20);
            this.NobretextBox.TabIndex = 1;
            // 
            // LibroIdnumericUpDown
            // 
            this.LibroIdnumericUpDown.Location = new System.Drawing.Point(125, 45);
            this.LibroIdnumericUpDown.Name = "LibroIdnumericUpDown";
            this.LibroIdnumericUpDown.Size = new System.Drawing.Size(84, 20);
            this.LibroIdnumericUpDown.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(132, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fecha Creacion";
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Enabled = false;
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(220, 16);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(99, 20);
            this.FechadateTimePicker.TabIndex = 10;
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Eliminarbutton.BackgroundImage")));
            this.Eliminarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Eliminarbutton.Location = new System.Drawing.Point(311, 266);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(65, 41);
            this.Eliminarbutton.TabIndex = 9;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = true;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Guardarbutton.BackgroundImage")));
            this.Guardarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Guardarbutton.Location = new System.Drawing.Point(182, 267);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(70, 41);
            this.Guardarbutton.TabIndex = 6;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Nuevobutton.BackgroundImage")));
            this.Nuevobutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Nuevobutton.Location = new System.Drawing.Point(46, 267);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(70, 40);
            this.Nuevobutton.TabIndex = 7;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.BackgroundImage")));
            this.Buscarbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Buscarbutton.Location = new System.Drawing.Point(298, 42);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(51, 39);
            this.Buscarbutton.TabIndex = 8;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // ISBNtextBox
            // 
            this.ISBNtextBox.Location = new System.Drawing.Point(125, 115);
            this.ISBNtextBox.Name = "ISBNtextBox";
            this.ISBNtextBox.Size = new System.Drawing.Size(167, 20);
            this.ISBNtextBox.TabIndex = 2;
            // 
            // DescripciontextBox
            // 
            this.DescripciontextBox.Location = new System.Drawing.Point(125, 175);
            this.DescripciontextBox.Name = "DescripciontextBox";
            this.DescripciontextBox.Size = new System.Drawing.Size(167, 20);
            this.DescripciontextBox.TabIndex = 4;
            // 
            // Categoriabutton
            // 
            this.Categoriabutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Categoriabutton.Location = new System.Drawing.Point(298, 146);
            this.Categoriabutton.Name = "Categoriabutton";
            this.Categoriabutton.Size = new System.Drawing.Size(29, 22);
            this.Categoriabutton.TabIndex = 18;
            this.Categoriabutton.Text = "+";
            this.Categoriabutton.UseVisualStyleBackColor = false;
            this.Categoriabutton.Click += new System.EventHandler(this.Categoriabutton_Click);
            // 
            // CategoriacomboBox
            // 
            this.CategoriacomboBox.FormattingEnabled = true;
            this.CategoriacomboBox.Location = new System.Drawing.Point(125, 148);
            this.CategoriacomboBox.Name = "CategoriacomboBox";
            this.CategoriacomboBox.Size = new System.Drawing.Size(167, 21);
            this.CategoriacomboBox.TabIndex = 3;
            // 
            // EditoracomboBox
            // 
            this.EditoracomboBox.FormattingEnabled = true;
            this.EditoracomboBox.Location = new System.Drawing.Point(125, 201);
            this.EditoracomboBox.Name = "EditoracomboBox";
            this.EditoracomboBox.Size = new System.Drawing.Size(167, 21);
            this.EditoracomboBox.TabIndex = 5;
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(13, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Casa Editora";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(13, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Descripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(13, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nombre Libro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Libro ID";
            // 
            // AddEditorial
            // 
            this.AddEditorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.AddEditorial.Location = new System.Drawing.Point(298, 205);
            this.AddEditorial.Name = "AddEditorial";
            this.AddEditorial.Size = new System.Drawing.Size(29, 22);
            this.AddEditorial.TabIndex = 17;
            this.AddEditorial.Text = "+";
            this.AddEditorial.UseVisualStyleBackColor = false;
            this.AddEditorial.Click += new System.EventHandler(this.AddEditorial_Click);
            // 
            // RLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(405, 331);
            this.Controls.Add(this.AddEditorial);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EditoracomboBox);
            this.Controls.Add(this.CategoriacomboBox);
            this.Controls.Add(this.Categoriabutton);
            this.Controls.Add(this.DescripciontextBox);
            this.Controls.Add(this.ISBNtextBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LibroIdnumericUpDown);
            this.Controls.Add(this.NobretextBox);
            this.Name = "RLibros";
            this.Text = "RLibros";
            this.Load += new System.EventHandler(this.RLibros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LibroIdnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox NobretextBox;
        private System.Windows.Forms.NumericUpDown LibroIdnumericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox ISBNtextBox;
        private System.Windows.Forms.TextBox DescripciontextBox;
        private System.Windows.Forms.Button Categoriabutton;
        private System.Windows.Forms.ComboBox CategoriacomboBox;
        private System.Windows.Forms.ComboBox EditoracomboBox;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddEditorial;
    }
}