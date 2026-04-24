namespace MusicStationForms
{
    partial class FormUsuarios
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
            this.pnlUsuarios = new System.Windows.Forms.Panel();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblUsuarios = new System.Windows.Forms.Label();
            this.lvUsuarios = new System.Windows.Forms.ListView();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.textSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.pnlUsuarios.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDados.SuspendLayout();
            this.pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlUsuarios
            // 
            this.pnlUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.pnlUsuarios.Controls.Add(this.pnlPesquisa);
            this.pnlUsuarios.Controls.Add(this.txtPesquisa);
            this.pnlUsuarios.Controls.Add(this.lblUsuarios);
            this.pnlUsuarios.Controls.Add(this.lvUsuarios);
            this.pnlUsuarios.Location = new System.Drawing.Point(327, 15);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(703, 332);
            this.pnlUsuarios.TabIndex = 1;
            // 
            // pnlPesquisa
            // 
            this.pnlPesquisa.BackColor = System.Drawing.Color.White;
            this.pnlPesquisa.Controls.Add(this.pictureBox1);
            this.pnlPesquisa.Location = new System.Drawing.Point(43, 64);
            this.pnlPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPesquisa.Name = "pnlPesquisa";
            this.pnlPesquisa.Size = new System.Drawing.Size(43, 25);
            this.pnlPesquisa.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::MusicStationForms.Properties.Resources.search;
            this.pictureBox1.Location = new System.Drawing.Point(8, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisa.ForeColor = System.Drawing.Color.Gray;
            this.txtPesquisa.Location = new System.Drawing.Point(83, 64);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(601, 22);
            this.txtPesquisa.TabIndex = 6;
            this.txtPesquisa.Text = "Pesquisa";
            this.txtPesquisa.Enter += new System.EventHandler(this.txtPesquisa_Enter);
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            this.txtPesquisa.Leave += new System.EventHandler(this.txtPesquisa_Leave);
            // 
            // lblUsuarios
            // 
            this.lblUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblUsuarios.AutoSize = true;
            this.lblUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblUsuarios.Location = new System.Drawing.Point(280, 14);
            this.lblUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarios.Name = "lblUsuarios";
            this.lblUsuarios.Size = new System.Drawing.Size(160, 39);
            this.lblUsuarios.TabIndex = 2;
            this.lblUsuarios.Text = "Usuários";
            // 
            // lvUsuarios
            // 
            this.lvUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvUsuarios.FullRowSelect = true;
            this.lvUsuarios.GridLines = true;
            this.lvUsuarios.HideSelection = false;
            this.lvUsuarios.Location = new System.Drawing.Point(43, 96);
            this.lvUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvUsuarios.MultiSelect = false;
            this.lvUsuarios.Name = "lvUsuarios";
            this.lvUsuarios.Size = new System.Drawing.Size(640, 218);
            this.lvUsuarios.TabIndex = 0;
            this.lvUsuarios.UseCompatibleStateImageBehavior = false;
            this.lvUsuarios.View = System.Windows.Forms.View.Details;
            // 
            // pnlDados
            // 
            this.pnlDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.pnlDados.Controls.Add(this.lblDados);
            this.pnlDados.Controls.Add(this.pnl);
            this.pnlDados.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlDados.Location = new System.Drawing.Point(16, 15);
            this.pnlDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(271, 332);
            this.pnlDados.TabIndex = 0;
            // 
            // lblDados
            // 
            this.lblDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDados.AutoSize = true;
            this.lblDados.BackColor = System.Drawing.Color.Transparent;
            this.lblDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblDados.Location = new System.Drawing.Point(64, 14);
            this.lblDados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDados.Name = "lblDados";
            this.lblDados.Size = new System.Drawing.Size(121, 39);
            this.lblDados.TabIndex = 0;
            this.lblDados.Text = "Dados";
            // 
            // pnl
            // 
            this.pnl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.pnl.Controls.Add(this.btnLancar);
            this.pnl.Controls.Add(this.btnExcluir);
            this.pnl.Controls.Add(this.btnAtualizar);
            this.pnl.Controls.Add(this.textSenha);
            this.pnl.Controls.Add(this.lblSenha);
            this.pnl.Controls.Add(this.txtEmail);
            this.pnl.Controls.Add(this.lblEmail);
            this.pnl.Controls.Add(this.txtNome);
            this.pnl.Controls.Add(this.lblNome);
            this.pnl.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnl.Location = new System.Drawing.Point(0, 64);
            this.pnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(271, 268);
            this.pnl.TabIndex = 1;
            // 
            // btnLancar
            // 
            this.btnLancar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLancar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnLancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnLancar.Location = new System.Drawing.Point(93, 222);
            this.btnLancar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLancar.Name = "btnLancar";
            this.btnLancar.Size = new System.Drawing.Size(84, 28);
            this.btnLancar.TabIndex = 8;
            this.btnLancar.Text = "Lançar";
            this.btnLancar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnExcluir.Location = new System.Drawing.Point(183, 222);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 28);
            this.btnExcluir.TabIndex = 7;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAtualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.btnAtualizar.Location = new System.Drawing.Point(4, 222);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(84, 28);
            this.btnAtualizar.TabIndex = 6;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = false;
            // 
            // textSenha
            // 
            this.textSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textSenha.Location = new System.Drawing.Point(4, 143);
            this.textSenha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textSenha.Name = "textSenha";
            this.textSenha.Size = new System.Drawing.Size(262, 22);
            this.textSenha.TabIndex = 5;
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.Transparent;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSenha.Location = new System.Drawing.Point(5, 116);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(82, 25);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "Senha:";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(4, 87);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(5, 60);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(72, 25);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(4, 32);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 22);
            this.txtNome.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(5, 5);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // FormUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1045, 362);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormUsuarios";
            this.Text = "FormRelatórios";
            this.pnlUsuarios.ResumeLayout(false);
            this.pnlUsuarios.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlUsuarios;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.TextBox textSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ListView lvUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlPesquisa;
    }
}