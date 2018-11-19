namespace SistemaBiblioteca.UI.Registros
{
    partial class REditorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(REditorial));
            this.label1 = new System.Windows.Forms.Label();
            this.IDEditorialnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.NombretextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Direccicon = new System.Windows.Forms.Label();
            this.DireccionTextBox = new System.Windows.Forms.TextBox();
            this.Eliminarbutton = new System.Windows.Forms.Button();
            this.Guardarbutton = new System.Windows.Forms.Button();
            this.Nuevobutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IDEditorialnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // IDEditorialnumericUpDown
            // 
            this.IDEditorialnumericUpDown.Location = new System.Drawing.Point(71, 40);
            this.IDEditorialnumericUpDown.Name = "IDEditorialnumericUpDown";
            this.IDEditorialnumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.IDEditorialnumericUpDown.TabIndex = 1;
            this.IDEditorialnumericUpDown.ValueChanged += new System.EventHandler(this.IDEditorialnumericUpDown_ValueChanged);
            // 
            // NombretextBox
            // 
            this.NombretextBox.Location = new System.Drawing.Point(71, 95);
            this.NombretextBox.Name = "NombretextBox";
            this.NombretextBox.Size = new System.Drawing.Size(120, 20);
            this.NombretextBox.TabIndex = 2;
            this.NombretextBox.TextChanged += new System.EventHandler(this.NombretextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Direccicon
            // 
            this.Direccicon.AutoSize = true;
            this.Direccicon.Location = new System.Drawing.Point(13, 130);
            this.Direccicon.Name = "Direccicon";
            this.Direccicon.Size = new System.Drawing.Size(52, 13);
            this.Direccicon.TabIndex = 5;
            this.Direccicon.Text = "Direccion";
            this.Direccicon.Click += new System.EventHandler(this.Direccicon_Click);
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(71, 127);
            this.DireccionTextBox.Multiline = true;
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(208, 23);
            this.DireccionTextBox.TabIndex = 4;
            this.DireccionTextBox.TextChanged += new System.EventHandler(this.DireccionTextBox_TextChanged);
            // 
            // Eliminarbutton
            // 
            this.Eliminarbutton.BackColor = System.Drawing.Color.Transparent;
            this.Eliminarbutton.Location = new System.Drawing.Point(222, 197);
            this.Eliminarbutton.Name = "Eliminarbutton";
            this.Eliminarbutton.Size = new System.Drawing.Size(80, 41);
            this.Eliminarbutton.TabIndex = 17;
            this.Eliminarbutton.Text = "Eliminar";
            this.Eliminarbutton.UseVisualStyleBackColor = false;
            this.Eliminarbutton.Click += new System.EventHandler(this.Eliminarbutton_Click);
            // 
            // Guardarbutton
            // 
            this.Guardarbutton.Location = new System.Drawing.Point(125, 197);
            this.Guardarbutton.Name = "Guardarbutton";
            this.Guardarbutton.Size = new System.Drawing.Size(83, 41);
            this.Guardarbutton.TabIndex = 16;
            this.Guardarbutton.Text = "Guardar";
            this.Guardarbutton.UseVisualStyleBackColor = true;
            this.Guardarbutton.Click += new System.EventHandler(this.Guardarbutton_Click);
            // 
            // Nuevobutton
            // 
            this.Nuevobutton.Location = new System.Drawing.Point(12, 197);
            this.Nuevobutton.Name = "Nuevobutton";
            this.Nuevobutton.Size = new System.Drawing.Size(83, 41);
            this.Nuevobutton.TabIndex = 15;
            this.Nuevobutton.Text = "Nuevo";
            this.Nuevobutton.UseVisualStyleBackColor = true;
            this.Nuevobutton.Click += new System.EventHandler(this.Nuevobutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Location = new System.Drawing.Point(203, 53);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(51, 39);
            this.Buscarbutton.TabIndex = 18;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Enabled = false;
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(178, 27);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.FechadateTimePicker.TabIndex = 19;
            this.FechadateTimePicker.ValueChanged += new System.EventHandler(this.FechadateTimePicker_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Fecha";
            // 
            // REditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(323, 268);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Eliminarbutton);
            this.Controls.Add(this.Guardarbutton);
            this.Controls.Add(this.Nuevobutton);
            this.Controls.Add(this.Direccicon);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NombretextBox);
            this.Controls.Add(this.IDEditorialnumericUpDown);
            this.Controls.Add(this.label1);
            this.Name = "REditorial";
            this.Text = "REditorial";
            ((System.ComponentModel.ISupportInitialize)(this.IDEditorialnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDEditorialnumericUpDown;
        private System.Windows.Forms.TextBox NombretextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Direccicon;
        private System.Windows.Forms.TextBox DireccionTextBox;
        private System.Windows.Forms.Button Eliminarbutton;
        private System.Windows.Forms.Button Guardarbutton;
        private System.Windows.Forms.Button Nuevobutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.Label label3;
    }
}