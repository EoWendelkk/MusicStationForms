namespace MusicStationForms
{
    partial class FormServicos
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
            this.lblServicos = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pnlSubTitles = new System.Windows.Forms.Panel();
            this.btnCursos = new System.Windows.Forms.Button();
            this.btnProfissionais = new System.Windows.Forms.Button();
            this.btnShows = new System.Windows.Forms.Button();
            this.btnProdutos = new System.Windows.Forms.Button();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenuTop.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlSubTitles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuTop
            // 
            this.pnlMenuTop.BackColor = System.Drawing.Color.Black;
            this.pnlMenuTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenuTop.Controls.Add(this.lblServicos);
            this.pnlMenuTop.Controls.Add(this.pnlLogo);
            this.pnlMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuTop.Name = "pnlMenuTop";
            this.pnlMenuTop.Size = new System.Drawing.Size(800, 46);
            this.pnlMenuTop.TabIndex = 5;
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServicos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblServicos.Location = new System.Drawing.Point(308, 2);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(181, 42);
            this.lblServicos.TabIndex = 0;
            this.lblServicos.Text = "Serviços";
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picboxLogo);
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(147, 43);
            this.pnlLogo.TabIndex = 6;
            // 
            // pnlSubTitles
            // 
            this.pnlSubTitles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.pnlSubTitles.Controls.Add(this.btnCursos);
            this.pnlSubTitles.Controls.Add(this.btnProfissionais);
            this.pnlSubTitles.Controls.Add(this.btnShows);
            this.pnlSubTitles.Controls.Add(this.btnProdutos);
            this.pnlSubTitles.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubTitles.Location = new System.Drawing.Point(0, 46);
            this.pnlSubTitles.Name = "pnlSubTitles";
            this.pnlSubTitles.Size = new System.Drawing.Size(800, 71);
            this.pnlSubTitles.TabIndex = 13;
            // 
            // btnCursos
            // 
            this.btnCursos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursos.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnCursos.Location = new System.Drawing.Point(12, 12);
            this.btnCursos.Name = "btnCursos";
            this.btnCursos.Size = new System.Drawing.Size(174, 46);
            this.btnCursos.TabIndex = 10;
            this.btnCursos.Text = "Cursos";
            this.btnCursos.UseVisualStyleBackColor = false;
            this.btnCursos.Click += new System.EventHandler(this.btnCursos_Click);
            // 
            // btnProfissionais
            // 
            this.btnProfissionais.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnProfissionais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfissionais.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfissionais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnProfissionais.Location = new System.Drawing.Point(614, 12);
            this.btnProfissionais.Name = "btnProfissionais";
            this.btnProfissionais.Size = new System.Drawing.Size(174, 46);
            this.btnProfissionais.TabIndex = 11;
            this.btnProfissionais.Text = "Profissionais";
            this.btnProfissionais.UseVisualStyleBackColor = false;
            this.btnProfissionais.Click += new System.EventHandler(this.btnProfissionais_Click);
            // 
            // btnShows
            // 
            this.btnShows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnShows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShows.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnShows.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnShows.Location = new System.Drawing.Point(213, 12);
            this.btnShows.Name = "btnShows";
            this.btnShows.Size = new System.Drawing.Size(174, 46);
            this.btnShows.TabIndex = 6;
            this.btnShows.Text = "Shows";
            this.btnShows.UseVisualStyleBackColor = false;
            this.btnShows.Click += new System.EventHandler(this.btnShows_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(20)))), ((int)(((byte)(71)))));
            this.btnProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProdutos.Font = new System.Drawing.Font("News706 BT", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnProdutos.Location = new System.Drawing.Point(413, 12);
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(174, 46);
            this.btnProdutos.TabIndex = 8;
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.UseVisualStyleBackColor = false;
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(0, 117);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(800, 333);
            this.pnlChildForm.TabIndex = 14;
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
            // FormServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.pnlSubTitles);
            this.Controls.Add(this.pnlMenuTop);
            this.Name = "FormServicos";
            this.Text = "FormServicos";
            this.pnlMenuTop.ResumeLayout(false);
            this.pnlMenuTop.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            this.pnlSubTitles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Panel pnlSubTitles;
        private System.Windows.Forms.Button btnCursos;
        private System.Windows.Forms.Button btnProfissionais;
        private System.Windows.Forms.Button btnShows;
        private System.Windows.Forms.Button btnProdutos;
        private System.Windows.Forms.Panel pnlChildForm;
    }
}