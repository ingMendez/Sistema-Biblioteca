namespace SistemaBiblioteca.UI.Registros
{
    partial class RPrestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PrestamoId = new System.Windows.Forms.Label();
            this.LectorcomboBox = new System.Windows.Forms.ComboBox();
            this.LibrocomboBox = new System.Windows.Forms.ComboBox();
            this.FechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.prestamoidnumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PrestamoDetalleDataGridView = new System.Windows.Forms.DataGridView();
            this.RemoverButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.SuperErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.AgregarButtton = new System.Windows.Forms.Button();
            this.UsuarioTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.MatriculatextBox = new System.Windows.Forms.MaskedTextBox();
            this.prestamoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoidnumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoDetalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDetalleBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Libro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha Prestamo";
            // 
            // PrestamoId
            // 
            this.PrestamoId.AutoSize = true;
            this.PrestamoId.Location = new System.Drawing.Point(38, 24);
            this.PrestamoId.Name = "PrestamoId";
            this.PrestamoId.Size = new System.Drawing.Size(60, 13);
            this.PrestamoId.TabIndex = 3;
            this.PrestamoId.Text = "PrestamoId";
            // 
            // LectorcomboBox
            // 
            this.LectorcomboBox.FormattingEnabled = true;
            this.LectorcomboBox.Location = new System.Drawing.Point(114, 93);
            this.LectorcomboBox.Name = "LectorcomboBox";
            this.LectorcomboBox.Size = new System.Drawing.Size(121, 21);
            this.LectorcomboBox.TabIndex = 4;
            // 
            // LibrocomboBox
            // 
            this.LibrocomboBox.FormattingEnabled = true;
            this.LibrocomboBox.Location = new System.Drawing.Point(326, 94);
            this.LibrocomboBox.Name = "LibrocomboBox";
            this.LibrocomboBox.Size = new System.Drawing.Size(121, 21);
            this.LibrocomboBox.TabIndex = 5;
            this.LibrocomboBox.SelectedIndexChanged += new System.EventHandler(this.LibrocomboBox_SelectedIndexChanged);
            // 
            // FechadateTimePicker
            // 
            this.FechadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker.Location = new System.Drawing.Point(364, 53);
            this.FechadateTimePicker.Name = "FechadateTimePicker";
            this.FechadateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.FechadateTimePicker.TabIndex = 6;
            // 
            // prestamoidnumericUpDown
            // 
            this.prestamoidnumericUpDown.Location = new System.Drawing.Point(105, 25);
            this.prestamoidnumericUpDown.Name = "prestamoidnumericUpDown";
            this.prestamoidnumericUpDown.Size = new System.Drawing.Size(76, 20);
            this.prestamoidnumericUpDown.TabIndex = 7;
            // 
            // PrestamoDetalleDataGridView
            // 
            this.PrestamoDetalleDataGridView.AllowUserToOrderColumns = true;
            this.PrestamoDetalleDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.PrestamoDetalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrestamoDetalleDataGridView.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.PrestamoDetalleDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.PrestamoDetalleDataGridView.Location = new System.Drawing.Point(30, 183);
            this.PrestamoDetalleDataGridView.Name = "PrestamoDetalleDataGridView";
            this.PrestamoDetalleDataGridView.Size = new System.Drawing.Size(406, 203);
            this.PrestamoDetalleDataGridView.TabIndex = 8;
            this.PrestamoDetalleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PrestamoDetalleDataGridView_CellContentClick);
            // 
            // RemoverButton
            // 
            this.RemoverButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemoverButton.Location = new System.Drawing.Point(31, 387);
            this.RemoverButton.Name = "RemoverButton";
            this.RemoverButton.Size = new System.Drawing.Size(85, 29);
            this.RemoverButton.TabIndex = 87;
            this.RemoverButton.Text = "Remover";
            this.RemoverButton.UseVisualStyleBackColor = true;
            this.RemoverButton.Click += new System.EventHandler(this.RemoverButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Location = new System.Drawing.Point(352, 421);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(85, 32);
            this.EliminarButton.TabIndex = 90;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Location = new System.Drawing.Point(206, 421);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(93, 32);
            this.GuardarButton.TabIndex = 89;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Location = new System.Drawing.Point(60, 421);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(91, 32);
            this.NuevoButton.TabIndex = 88;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarButton.Location = new System.Drawing.Point(187, 20);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(63, 32);
            this.BuscarButton.TabIndex = 91;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // SuperErrorProvider
            // 
            this.SuperErrorProvider.ContainerControl = this;
            // 
            // AgregarButtton
            // 
            this.AgregarButtton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AgregarButtton.Location = new System.Drawing.Point(352, 154);
            this.AgregarButtton.Name = "AgregarButtton";
            this.AgregarButtton.Size = new System.Drawing.Size(85, 29);
            this.AgregarButtton.TabIndex = 92;
            this.AgregarButtton.Text = "Agregar";
            this.AgregarButtton.UseVisualStyleBackColor = true;
            this.AgregarButtton.Click += new System.EventHandler(this.AgregarButtton_Click_1);
            // 
            // UsuarioTextBox
            // 
            this.UsuarioTextBox.Location = new System.Drawing.Point(326, 17);
            this.UsuarioTextBox.Name = "UsuarioTextBox";
            this.UsuarioTextBox.Size = new System.Drawing.Size(156, 20);
            this.UsuarioTextBox.TabIndex = 94;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Matricula lector";
            // 
            // MatriculatextBox
            // 
            this.MatriculatextBox.Location = new System.Drawing.Point(114, 138);
            this.MatriculatextBox.Mask = "0000-0000";
            this.MatriculatextBox.Name = "MatriculatextBox";
            this.MatriculatextBox.Size = new System.Drawing.Size(78, 20);
            this.MatriculatextBox.TabIndex = 97;
            this.MatriculatextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prestamoDetalleBindingSource
            // 
            this.prestamoDetalleBindingSource.DataSource = typeof(SistemaBiblioteca.Entidades.PrestamoDetalle);
            // 
            // RPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(488, 474);
            this.Controls.Add(this.MatriculatextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsuarioTextBox);
            this.Controls.Add(this.AgregarButtton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.RemoverButton);
            this.Controls.Add(this.PrestamoDetalleDataGridView);
            this.Controls.Add(this.prestamoidnumericUpDown);
            this.Controls.Add(this.FechadateTimePicker);
            this.Controls.Add(this.LibrocomboBox);
            this.Controls.Add(this.LectorcomboBox);
            this.Controls.Add(this.PrestamoId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RPrestamo";
            this.Text = "RPrestamo";
            this.Load += new System.EventHandler(this.RPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prestamoidnumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrestamoDetalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuperErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prestamoDetalleBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PrestamoId;
        private System.Windows.Forms.ComboBox LectorcomboBox;
        private System.Windows.Forms.ComboBox LibrocomboBox;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker;
        private System.Windows.Forms.NumericUpDown prestamoidnumericUpDown;
        private System.Windows.Forms.DataGridView PrestamoDetalleDataGridView;
        private System.Windows.Forms.Button RemoverButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.ErrorProvider SuperErrorProvider;
        private System.Windows.Forms.Button AgregarButtton;
        private System.Windows.Forms.TextBox UsuarioTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource prestamoDetalleBindingSource;
        private System.Windows.Forms.MaskedTextBox MatriculatextBox;
    }
}