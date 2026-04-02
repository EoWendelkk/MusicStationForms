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
    public partial class FormServicos : Form
    {
        private Form activeForm = null;

        public FormServicos()
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

        // ================== BOTÕES CLICKS ================== \\
        private void btnCursos_Click(object sender, EventArgs e)
        {
            FormCursos cursos = new FormCursos();
            cursos.Show();
            this.Close();
        }

        private void picboxLogo_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show(this);
            this.Close();
        }
    }
}
