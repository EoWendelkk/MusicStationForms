namespace MusicStationForms
{
    partial class FormControle
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
            this.pnlMenuTop = new System.Windows.Forms.Panel();
            this.lblControle = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.btnFuncionarios = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnUsuários = new System.Windows.Forms.Button();
            this.pnlSubTitles = new System.Windows.Forms.Panel();
            this.pnlMenuTop.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.pnlSubTitles.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuTop
            // 
            this.pnlMenuTop.BackColor = System.Drawing.Color.Black;
            this.pnlMenuTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenuTop.Controls.Add(this.lblControle);
            this.pnlMenuTop.Controls.Add(this.pnlLogo);
            this.pnlMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuTop.Name = "pnlMenuTop";
            this.pnlMenuTop.Size = new System.Drawing.Size(800, 46);
            this.pnlMenuTop.TabIndex = 4;
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblControle.Location = new System.Drawing.Point(308, 2);
            this.lblControle.Name = "lblControle";
            this.lblControle.Size = new System.Drawing.Size(181, 42);
            this.lblControle.TabIndex = 0;
            this.lblControle.Text = "Controle";
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picboxLogo);
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(147, 43);
            this.pnlLogo.TabIndex = 6;
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackColor = System.Drawing.Color.Transparent;
            this.picboxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picboxLogo.Image = global::MusicStationForms.Properties.Resources.music_station_vetorizada_1__1_;
            this.picboxLogo.Location = new System.Drawing.Point(0, 0);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(144, 40);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLogo.TabIndex = 5;
            this.picboxLogo.TabStop = false;
            this.picboxLogo.Click += new System.EventHandler(this.picboxLogo_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(0, 117);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(800, 333);
            this.pnlChildForm.TabIndex = 13;
            // 
            // btnFuncionarios
            // 
            this.btnFuncionarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnFuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionarios.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFuncionarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnFuncionarios.Location = new System.Drawing.Point(413, 12);
            this.btnFuncionarios.Name = "btnFuncionarios";
            this.btnFuncionarios.Size = new System.Drawing.Size(174, 46);
            this.btnFuncionarios.TabIndex = 8;
            this.btnFuncionarios.Text = "Funcionários";
            this.btnFuncionarios.UseVisualStyleBackColor = false;
            this.btnFuncionarios.Click += new System.EventHandler(this.btnFuncionarios_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnClientes.Location = new System.Drawing.Point(213, 12);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(174, 46);
            this.btnClientes.TabIndex = 6;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPedidos.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnPedidos.Location = new System.Drawing.Point(614, 12);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(174, 46);
            this.btnPedidos.TabIndex = 11;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnUsuários
            // 
            this.btnUsuários.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnUsuários.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuários.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnUsuários.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnUsuários.Location = new System.Drawing.Point(12, 12);
            this.btnUsuários.Name = "btnUsuários";
            this.btnUsuários.Size = new System.Drawing.Size(174, 46);
            this.btnUsuários.TabIndex = 10;
            this.btnUsuários.Text = "Usuários";
            this.btnUsuários.UseVisualStyleBackColor = false;
            this.btnUsuários.Click += new System.EventHandler(this.btnUsuários_Click);
            // 
            // pnlSubTitles
            // 
            this.pnlSubTitles.Controls.Add(this.btnUsuários);
            this.pnlSubTitles.Controls.Add(this.btnPedidos);
            this.pnlSubTitles.Controls.Add(this.btnClientes);
            this.pnlSubTitles.Controls.Add(this.btnFuncionarios);
            this.pnlSubTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubTitles.Location = new System.Drawing.Point(0, 46);
            this.pnlSubTitles.Name = "pnlSubTitles";
            this.pnlSubTitles.Size = new System.Drawing.Size(800, 71);
            this.pnlSubTitles.TabIndex = 12;
            // 
            // FormControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSubTitles);
            this.Controls.Add(this.pnlMenuTop);
            this.Name = "FormControle";
            this.Text = "Controle";
            this.pnlMenuTop.ResumeLayout(false);
            this.pnlMenuTop.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.pnlSubTitles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Button btnFuncionarios;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnUsuários;
        private System.Windows.Forms.Panel pnlSubTitles;
    }
}