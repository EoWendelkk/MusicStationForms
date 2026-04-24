namespace MusicStationForms
{
    partial class FormCursos
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
            this.pnlClientes = new System.Windows.Forms.Panel();
            this.pnlPesquisa = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.lblCursos = new System.Windows.Forms.Label();
            this.lvCursos = new System.Windows.Forms.ListView();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.lblPreco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtidprofissional = new System.Windows.Forms.TextBox();
            this.lblID_profissional = new System.Windows.Forms.Label();
            this.pnlClientes.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientes
            // 
            this.pnlClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.pnlClientes.Controls.Add(this.pnlPesquisa);
            this.pnlClientes.Controls.Add(this.txtPesquisa);
            this.pnlClientes.Controls.Add(this.lblCursos);
            this.pnlClientes.Controls.Add(this.lvCursos);
            this.pnlClientes.Location = new System.Drawing.Point(327, 15);
            this.pnlClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(703, 332);
            this.pnlClientes.TabIndex = 7;
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
            // lblCursos
            // 
            this.lblCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCursos.AutoSize = true;
            this.lblCursos.BackColor = System.Drawing.Color.Transparent;
            this.lblCursos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblCursos.Location = new System.Drawing.Point(251, 14);
            this.lblCursos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCursos.Name = "lblCursos";
            this.lblCursos.Size = new System.Drawing.Size(131, 39);
            this.lblCursos.TabIndex = 2;
            this.lblCursos.Text = "Cursos";
            // 
            // lvCursos
            // 
            this.lvCursos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvCursos.FullRowSelect = true;
            this.lvCursos.GridLines = true;
            this.lvCursos.HideSelection = false;
            this.lvCursos.Location = new System.Drawing.Point(43, 96);
            this.lvCursos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvCursos.MultiSelect = false;
            this.lvCursos.Name = "lvCursos";
            this.lvCursos.Size = new System.Drawing.Size(640, 218);
            this.lvCursos.TabIndex = 0;
            this.lvCursos.UseCompatibleStateImageBehavior = false;
            this.lvCursos.View = System.Windows.Forms.View.Details;
            // 
            // pnlDados
            // 
            this.pnlDados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.pnlDados.Controls.Add(this.lblDados);
            this.pnlDados.Controls.Add(this.panel1);
            this.pnlDados.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlDados.Location = new System.Drawing.Point(16, 15);
            this.pnlDados.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlDados.Name = "pnlDados";
            this.pnlDados.Size = new System.Drawing.Size(271, 332);
            this.pnlDados.TabIndex = 6;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnLancar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.textPreco);
            this.panel1.Controls.Add(this.lblPreco);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.txtidprofissional);
            this.panel1.Controls.Add(this.lblID_profissional);
            this.panel1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(271, 268);
            this.panel1.TabIndex = 1;
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
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNome.Location = new System.Drawing.Point(4, 87);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(262, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.Transparent;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNome.Location = new System.Drawing.Point(5, 60);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(75, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtidprofissional
            // 
            this.txtidprofissional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtidprofissional.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidprofissional.Location = new System.Drawing.Point(4, 32);
            this.txtidprofissional.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtidprofissional.Name = "txtidprofissional";
            this.txtidprofissional.Size = new System.Drawing.Size(262, 22);
            this.txtidprofissional.TabIndex = 1;
            // 
            // lblID_profissional
            // 
            this.lblID_profissional.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID_profissional.AutoSize = true;
            this.lblID_profissional.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_profissional.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID_profissional.Location = new System.Drawing.Point(5, 5);
            this.lblID_profissional.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID_profissional.Name = "lblID_profissional";
            this.lblID_profissional.Size = new System.Drawing.Size(162, 25);
            this.lblID_profissional.TabIndex = 0;
            this.lblID_profissional.Text = "ID_profissional:";
            // 
            // FormCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1045, 362);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormCursos";
            this.Text = "FormCursos";
            this.pnlClientes.ResumeLayout(false);
            this.pnlClientes.PerformLayout();
            this.pnlPesquisa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlDados.ResumeLayout(false);
            this.pnlDados.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClientes;
        private System.Windows.Forms.Panel pnlPesquisa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.Label lblCursos;
        private System.Windows.Forms.ListView lvCursos;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtidprofissional;
        private System.Windows.Forms.Label lblID_profissional;
    }
}