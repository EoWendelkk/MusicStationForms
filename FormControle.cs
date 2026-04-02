using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicStationForms
{
    public partial class FormControle : Form
    {
        private Form activeForm = null;

        public FormControle()
        {
            InitializeComponent();
        }

        // Método responsável por abrir um formulário dentro do painel pnlChildForm
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Remove qualquer controle anterior do painel
            pnlChildForm.Controls.Clear();
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        //Botões clicks\\

        // Evento do botão Usuários
        private void btnUsuários_Click(object sender, EventArgs e)
        {
            // Abre o formulário de usuários dentro do painel
            openChildForm(new FormUsuarios());
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            openChildForm(new FormClientes());
        }

        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            openChildForm(new FormFuncionarios());
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            openChildForm(new FormPedidos());
        }
        private void picboxLogo_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }


    }
}
