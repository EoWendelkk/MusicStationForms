namespace MusicStationForms
{
    partial class FormProdutos
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
            this.lblProdutos = new System.Windows.Forms.Label();
            this.lvProdutos = new System.Windows.Forms.ListView();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
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
            this.pnlUsuarios.Controls.Add(this.lblProdutos);
            this.pnlUsuarios.Controls.Add(this.lvProdutos);
            this.pnlUsuarios.Location = new System.Drawing.Point(327, 15);
            this.pnlUsuarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlUsuarios.Name = "pnlUsuarios";
            this.pnlUsuarios.Size = new System.Drawing.Size(703, 332);
            this.pnlUsuarios.TabIndex = 3;
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
            // 
            // lblProdutos
            // 
            this.lblProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProdutos.AutoSize = true;
            this.lblProdutos.BackColor = System.Drawing.Color.Transparent;
            this.lblProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProdutos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblProdutos.Location = new System.Drawing.Point(292, 14);
            this.lblProdutos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProdutos.Name = "lblProdutos";
            this.lblProdutos.Size = new System.Drawing.Size(161, 39);
            this.lblProdutos.TabIndex = 2;
            this.lblProdutos.Text = "Produtos";
            // 
            // lvProdutos
            // 
            this.lvProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProdutos.FullRowSelect = true;
            this.lvProdutos.GridLines = true;
            this.lvProdutos.HideSelection = false;
            this.lvProdutos.Location = new System.Drawing.Point(43, 96);
            this.lvProdutos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvProdutos.MultiSelect = false;
            this.lvProdutos.Name = "lvProdutos";
            this.lvProdutos.Size = new System.Drawing.Size(640, 218);
            this.lvProdutos.TabIndex = 0;
            this.lvProdutos.UseCompatibleStateImageBehavior = false;
            this.lvProdutos.View = System.Windows.Forms.View.Details;
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
            this.pnlDados.TabIndex = 2;
            // 
            // lblDados
            // 
            this.lblDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnl.Controls.Add(this.textPreco);
            this.pnl.Controls.Add(this.lblPreco);
            this.pnl.Controls.Add(this.txtDescricao);
            this.pnl.Controls.Add(this.lblDescricao);
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
            // textPreco
            // 
            this.textPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textPreco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textPreco.Location = new System.Drawing.Point(4, 143);
            this.textPreco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(262, 22);
            this.textPreco.TabIndex = 5;
            // 
            // lblPreco
            // 
            this.lblPreco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPreco.AutoSize = true;
            this.lblPreco.BackColor = System.Drawing.Color.Transparent;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPreco.Location = new System.Drawing.Point(5, 116);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(75, 25);
            this.lblPreco.TabIndex = 4;
            this.lblPreco.Text = "Preço:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescricao.Location = new System.Drawing.Point(4, 87);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(262, 22);
            this.txtDescricao.TabIndex = 3;
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.Transparent;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDescricao.Location = new System.Drawing.Point(5, 60);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(115, 25);
            this.lblDescricao.TabIndex = 2;
            this.lblDescricao.Text = "Descrição:";
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
            // FormProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1045, 362);
            this.Controls.Add(this.pnlUsuarios);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormProdutos";
            this.Text = "FormProdutos";
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
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblProdutos;
        private System.Windows.Forms.ListView lvProdutos;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
    }
}