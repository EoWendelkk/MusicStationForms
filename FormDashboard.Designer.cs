namespace MusicStationForms
{
    partial class FormDashboard
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
            this.lblDashboard = new System.Windows.Forms.Label();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.cboPeriodo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEscolha = new System.Windows.Forms.ComboBox();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenuTop.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenuTop
            // 
            this.pnlMenuTop.BackColor = System.Drawing.Color.Black;
            this.pnlMenuTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMenuTop.Controls.Add(this.lblDashboard);
            this.pnlMenuTop.Controls.Add(this.pnlLogo);
            this.pnlMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuTop.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuTop.Name = "pnlMenuTop";
            this.pnlMenuTop.Size = new System.Drawing.Size(800, 46);
            this.pnlMenuTop.TabIndex = 6;
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.BackColor = System.Drawing.Color.Transparent;
            this.lblDashboard.Font = new System.Drawing.Font("Swis721 Blk BT", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblDashboard.Location = new System.Drawing.Point(302, 4);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(260, 42);
            this.lblDashboard.TabIndex = 0;
            this.lblDashboard.Text = "DASHBOARD";
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picboxLogo);
            this.pnlLogo.Location = new System.Drawing.Point(3, 3);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(147, 43);
            this.pnlLogo.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.button1.Location = new System.Drawing.Point(648, 94);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Gerar relatório";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // cboPeriodo
            // 
            this.cboPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.cboPeriodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboPeriodo.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboPeriodo.FormattingEnabled = true;
            this.cboPeriodo.Location = new System.Drawing.Point(185, 94);
            this.cboPeriodo.Name = "cboPeriodo";
            this.cboPeriodo.Size = new System.Drawing.Size(174, 21);
            this.cboPeriodo.TabIndex = 12;
            this.cboPeriodo.Text = "Período";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Filtro de Dashboard:";
            // 
            // cboEscolha
            // 
            this.cboEscolha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.cboEscolha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboEscolha.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboEscolha.FormattingEnabled = true;
            this.cboEscolha.Location = new System.Drawing.Point(11, 96);
            this.cboEscolha.Name = "cboEscolha";
            this.cboEscolha.Size = new System.Drawing.Size(149, 21);
            this.cboEscolha.TabIndex = 10;
            this.cboEscolha.Text = "Escolha o Dashboard";
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
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlMenuTop);
            this.Controls.Add(this.cboPeriodo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboEscolha);
            this.Name = "FormDashboard";
            this.Text = "FormDashboard";
            this.pnlMenuTop.ResumeLayout(false);
            this.pnlMenuTop.PerformLayout();
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuTop;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboPeriodo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEscolha;
    }
}