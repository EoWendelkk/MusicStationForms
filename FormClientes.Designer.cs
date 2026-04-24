namespace MusicStationForms
{
    partial class FormClientes
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
            this.lblClientes = new System.Windows.Forms.Label();
            this.lvClientes = new System.Windows.Forms.ListView();
            this.pnlDados = new System.Windows.Forms.Panel();
            this.lblDados = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLancar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereço = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.txtIDusuario = new System.Windows.Forms.TextBox();
            this.lblID_usuario = new System.Windows.Forms.Label();
            this.pnlClientes.SuspendLayout();
            this.pnlPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlDados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClientes
            // 
            this.pnlClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(30)))), ((int)(((byte)(98)))));
            this.pnlClientes.Controls.Add(this.pnlPesquisa);
            this.pnlClientes.Controls.Add(this.txtPesquisa);
            this.pnlClientes.Controls.Add(this.lblClientes);
            this.pnlClientes.Controls.Add(this.lvClientes);
            this.pnlClientes.Location = new System.Drawing.Point(327, 15);
            this.pnlClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlClientes.Name = "pnlClientes";
            this.pnlClientes.Size = new System.Drawing.Size(703, 332);
            this.pnlClientes.TabIndex = 3;
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
            // lblClientes
            // 
            this.lblClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblClientes.AutoSize = true;
            this.lblClientes.BackColor = System.Drawing.Color.Transparent;
            this.lblClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.lblClientes.Location = new System.Drawing.Point(280, 14);
            this.lblClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(149, 39);
            this.lblClientes.TabIndex = 2;
            this.lblClientes.Text = "Clientes";
            // 
            // lvClientes
            // 
            this.lvClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvClientes.FullRowSelect = true;
            this.lvClientes.GridLines = true;
            this.lvClientes.HideSelection = false;
            this.lvClientes.Location = new System.Drawing.Point(43, 96);
            this.lvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvClientes.MultiSelect = false;
            this.lvClientes.Name = "lvClientes";
            this.lvClientes.Size = new System.Drawing.Size(640, 218);
            this.lvClientes.TabIndex = 0;
            this.lvClientes.UseCompatibleStateImageBehavior = false;
            this.lvClientes.View = System.Windows.Forms.View.Details;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(182)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnLancar);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Controls.Add(this.textEndereco);
            this.panel1.Controls.Add(this.lblEndereço);
            this.panel1.Controls.Add(this.txtTelefone);
            this.panel1.Controls.Add(this.lblTelefone);
            this.panel1.Controls.Add(this.txtIDusuario);
            this.panel1.Controls.Add(this.lblID_usuario);
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
            // textEndereco
            // 
            this.textEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEndereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textEndereco.Location = new System.Drawing.Point(4, 143);
            this.textEndereco.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(262, 22);
            this.textEndereco.TabIndex = 5;
            // 
            // lblEndereço
            // 
            this.lblEndereço.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndereço.AutoSize = true;
            this.lblEndereço.BackColor = System.Drawing.Color.Transparent;
            this.lblEndereço.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereço.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEndereço.Location = new System.Drawing.Point(5, 116);
            this.lblEndereço.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndereço.Name = "lblEndereço";
            this.lblEndereço.Size = new System.Drawing.Size(111, 25);
            this.lblEndereço.TabIndex = 4;
            this.lblEndereço.Text = "Endereço:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefone.Location = new System.Drawing.Point(4, 87);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(262, 22);
            this.txtTelefone.TabIndex = 3;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.BackColor = System.Drawing.Color.Transparent;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTelefone.Location = new System.Drawing.Point(5, 60);
            this.lblTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(104, 25);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone:";
            // 
            // txtIDusuario
            // 
            this.txtIDusuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIDusuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDusuario.Location = new System.Drawing.Point(4, 32);
            this.txtIDusuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDusuario.Name = "txtIDusuario";
            this.txtIDusuario.Size = new System.Drawing.Size(262, 22);
            this.txtIDusuario.TabIndex = 1;
            // 
            // lblID_usuario
            // 
            this.lblID_usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblID_usuario.AutoSize = true;
            this.lblID_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID_usuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblID_usuario.Location = new System.Drawing.Point(5, 5);
            this.lblID_usuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID_usuario.Name = "lblID_usuario";
            this.lblID_usuario.Size = new System.Drawing.Size(123, 25);
            this.lblID_usuario.TabIndex = 0;
            this.lblID_usuario.Text = "ID_usuario:";
            // 
            // FormClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1045, 362);
            this.Controls.Add(this.pnlClientes);
            this.Controls.Add(this.pnlDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormClientes";
            this.Text = "FormClientes";
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
        private System.Windows.Forms.Label lblClientes;
        private System.Windows.Forms.ListView lvClientes;
        private System.Windows.Forms.Panel pnlDados;
        private System.Windows.Forms.Label lblDados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLancar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label lblEndereço;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TextBox txtIDusuario;
        private System.Windows.Forms.Label lblID_usuario;
    }
}