namespace CrudPacientes1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarraDeProgresso = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnCadastrodeClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BarraDeProgresso
            // 
            this.BarraDeProgresso.Location = new System.Drawing.Point(12, 415);
            this.BarraDeProgresso.Name = "BarraDeProgresso";
            this.BarraDeProgresso.Size = new System.Drawing.Size(776, 19);
            this.BarraDeProgresso.TabIndex = 2;
            this.BarraDeProgresso.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnCadastrodeClientes
            // 
            this.btnCadastrodeClientes.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCadastrodeClientes.Font = new System.Drawing.Font("Poor Richard", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrodeClientes.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCadastrodeClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrodeClientes.Image")));
            this.btnCadastrodeClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrodeClientes.Location = new System.Drawing.Point(83, 38);
            this.btnCadastrodeClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrodeClientes.Name = "btnCadastrodeClientes";
            this.btnCadastrodeClientes.Size = new System.Drawing.Size(333, 69);
            this.btnCadastrodeClientes.TabIndex = 34;
            this.btnCadastrodeClientes.Text = "Pacientes";
            this.btnCadastrodeClientes.UseVisualStyleBackColor = false;
            this.btnCadastrodeClientes.Click += new System.EventHandler(this.btnCadastrodeClientes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrodeClientes);
            this.Controls.Add(this.BarraDeProgresso);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar BarraDeProgresso;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCadastrodeClientes;
    }
}

