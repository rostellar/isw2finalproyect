
namespace isw2finalproyect
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBuscarLibros = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnPrestar = new System.Windows.Forms.Button();
            this.btnPrestados = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(28, 25);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(147, 20);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bienvenido, usuario";
            // 
            // btnBuscarLibros
            // 
            this.btnBuscarLibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBuscarLibros.Location = new System.Drawing.Point(32, 240);
            this.btnBuscarLibros.Name = "btnBuscarLibros";
            this.btnBuscarLibros.Size = new System.Drawing.Size(195, 50);
            this.btnBuscarLibros.TabIndex = 1;
            this.btnBuscarLibros.Text = "Buscar libro";
            this.btnBuscarLibros.UseVisualStyleBackColor = true;
            this.btnBuscarLibros.Click += new System.EventHandler(this.btnBuscarLibros_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddBook.Location = new System.Drawing.Point(32, 72);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(195, 50);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Añadir nuevo libro";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnPrestar
            // 
            this.btnPrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrestar.Location = new System.Drawing.Point(32, 128);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(195, 50);
            this.btnPrestar.TabIndex = 3;
            this.btnPrestar.Text = "Prestar libro";
            this.btnPrestar.UseVisualStyleBackColor = true;
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            // 
            // btnPrestados
            // 
            this.btnPrestados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPrestados.Location = new System.Drawing.Point(32, 184);
            this.btnPrestados.Name = "btnPrestados";
            this.btnPrestados.Size = new System.Drawing.Size(195, 50);
            this.btnPrestados.TabIndex = 4;
            this.btnPrestados.Text = "Ver libros prestados";
            this.btnPrestados.UseVisualStyleBackColor = true;
            this.btnPrestados.Click += new System.EventHandler(this.btnPrestados_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(263, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 253);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 336);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnPrestados);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnBuscarLibros);
            this.Controls.Add(this.lblWelcome);
            this.Name = "homeForm";
            this.Text = "Biblioteca System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBuscarLibros;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnPrestar;
        private System.Windows.Forms.Button btnPrestados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}