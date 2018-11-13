namespace SistemaBiblioteca
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarLectorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarLibroToolStripMenuItem,
            this.registrarCategoriaToolStripMenuItem,
            this.registrarLectorToolStripMenuItem,
            this.registrarUsuarioToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarLibrosToolStripMenuItem,
            this.consultarUsuarioToolStripMenuItem,
            this.consultarPrestamosToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registrarLibroToolStripMenuItem
            // 
            this.registrarLibroToolStripMenuItem.Name = "registrarLibroToolStripMenuItem";
            this.registrarLibroToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarLibroToolStripMenuItem.Text = "Registrar Libro";
            // 
            // registrarCategoriaToolStripMenuItem
            // 
            this.registrarCategoriaToolStripMenuItem.Name = "registrarCategoriaToolStripMenuItem";
            this.registrarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarCategoriaToolStripMenuItem.Text = "Registrar Categoria";
            // 
            // registrarLectorToolStripMenuItem
            // 
            this.registrarLectorToolStripMenuItem.Name = "registrarLectorToolStripMenuItem";
            this.registrarLectorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarLectorToolStripMenuItem.Text = "Registrar  Lector";
            this.registrarLectorToolStripMenuItem.Click += new System.EventHandler(this.registrarLectorToolStripMenuItem_Click);
            // 
            // registrarUsuarioToolStripMenuItem
            // 
            this.registrarUsuarioToolStripMenuItem.Name = "registrarUsuarioToolStripMenuItem";
            this.registrarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.registrarUsuarioToolStripMenuItem.Text = "Registrar Usuario";
            // 
            // consultarLibrosToolStripMenuItem
            // 
            this.consultarLibrosToolStripMenuItem.Name = "consultarLibrosToolStripMenuItem";
            this.consultarLibrosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarLibrosToolStripMenuItem.Text = "Consultar Libros";
            // 
            // consultarUsuarioToolStripMenuItem
            // 
            this.consultarUsuarioToolStripMenuItem.Name = "consultarUsuarioToolStripMenuItem";
            this.consultarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarUsuarioToolStripMenuItem.Text = "Consultar Usuario";
            // 
            // consultarPrestamosToolStripMenuItem
            // 
            this.consultarPrestamosToolStripMenuItem.Name = "consultarPrestamosToolStripMenuItem";
            this.consultarPrestamosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.consultarPrestamosToolStripMenuItem.Text = "Consultar Prestamos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(639, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarLectorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPrestamosToolStripMenuItem;
    }
}

