namespace MusicStationForms
{
    partial class FormRelatorios
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
            this.cboEscolha = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lvRelatorios = new System.Windows.Forms.ListView();
            this.pnlMenuTop.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
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
            this.pnlMenuTop.TabIndex = 5;
            // 
            // lblControle
            // 
            this.lblControle.AutoSize = true;
            this.lblControle.BackColor = System.Drawing.Color.Transparent;
            this.lblControle.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblControle.Location = new System.Drawing.Point(302, 4);
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
            // cboEscolha
            // 
            this.cboEscolha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.cboEscolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEscolha.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboEscolha.FormattingEnabled = true;
            this.cboEscolha.Location = new System.Drawing.Point(12, 90);
            this.cboEscolha.Name = "cboEscolha";
            this.cboEscolha.Size = new System.Drawing.Size(149, 21);
            this.cboEscolha.TabIndex = 6;
            this.cboEscolha.Text = "Escolha o Relatório";
            this.cboEscolha.SelectedIndexChanged += new System.EventHandler(this.cboTipoRelatorio_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(13, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Filtro de Relatório:";
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodo.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(186, 88);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(174, 21);
            this.cboPeriodo.TabIndex = 8;
            this.cboPeriodo.Text = "Período";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.button1.Location = new System.Drawing.Point(649, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Gerar relatório";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lvRelatorios
            // 
            this.lvRelatorios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvRelatorios.FullRowSelect = true;
            this.lvRelatorios.GridLines = true;
            this.lvRelatorios.HideSelection = false;
            this.lvRelatorios.Location = new System.Drawing.Point(13, 136);
            this.lvRelatorios.MultiSelect = false;
            this.lvRelatorios.Name = "lvRelatorios";
            this.lvRelatorios.Size = new System.Drawing.Size(775, 284);
            this.lvRelatorios.TabIndex = 10;
            this.lvRelatorios.UseCompatibleStateImageBehavior = false;
            this.lvRelatorios.View = System.Windows.Forms.View.Details;
            // 
            // FormRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvRelatorios);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEscolha);
            this.Controls.Add(this.pnlMenuTop);
            this.Name = "FormRelatorios";
            this.Text = "FormRelatorios";
            this.pnlMenuTop.ResumeLayout(false);
            this.pnlMenuTop.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.Label lblControle;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.ComboBox cboEscolha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lvRelatorios;
    }
}