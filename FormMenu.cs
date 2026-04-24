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
    public partial class FormMenu : System.Windows.Forms.Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        //Vai pra área Controle
        private void btnControle_Click(object sender, EventArgs e)
        {
            FormControle controle = new FormControle();
            controle.Show();
            this.Close();
        }

        //Vai pra área Serviços
        private void btnServicos_Click(object sender, EventArgs e)
        {
            FormServicos servicos = new FormServicos();
            servicos.Show();
            this.Close();
        }

        //Vai pra área de Relatórios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            FormRelatorios relatorios = new FormRelatorios();
            relatorios.Show();
            this.Close();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            FormDashboard dashboard = new FormDashboard();
            dashboard.Show();
            this.Close();
        }
    }
}
