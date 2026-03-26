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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.FlatAppearance.BorderSize = 2;
            btnServicos.FlatAppearance.BorderColor = Color.FromArgb(238, 182, 34);

        }

        private void btnControle_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal(FormPrincipal.AreaInicial.controle);
            principal.Show();
            this.Close();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal(FormPrincipal.AreaInicial.servicos);
            principal.Show();
            this.Close();
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FormPrincipal principal = new FormPrincipal(FormPrincipal.AreaInicial.relatorios);
            principal.Show();
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            Form principal = new FormPrincipal(FormPrincipal.AreaInicial.nenhum);
            principal.Show();
            this.Close();
        }
    }
}
