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
    public partial class FormPrincipal : System.Windows.Forms.Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            customizeDesign();
        }

        //abre o formulário e já deixa a área escolhida aberta
        public FormPrincipal(AreaInicial area)
        {
            InitializeComponent();
            customizeDesign();
            AbrirAreaInicial(area);
        }
        //
        private void AbrirAreaInicial(AreaInicial area)
        {
            switch (area)
            {
                case AreaInicial.controle:
                    showSubMenu(pnlControleSubMenu);
                    break;

                case AreaInicial.servicos:
                    showSubMenu(pnlServicosSubMenu);
                    break;

                case AreaInicial.relatorios:
                    showSubMenu(pnlRelatoriosSubMenu);
                    break;
            }
        }

        public enum AreaInicial
        {
            nenhum,
            controle,
            servicos,
            relatorios
        }
        private void customizeDesign()
        {
            pnlControleSubMenu.Visible = false;
            pnlServicosSubMenu.Visible = false;
            pnlRelatoriosSubMenu.Visible = false;
            //..
        }

        private void hideSubMenu()
        {
            if (pnlControleSubMenu.Visible == true)
                pnlControleSubMenu.Visible = false;
            if (pnlServicosSubMenu.Visible == true)
                pnlServicosSubMenu.Visible = false;
            if (pnlRelatoriosSubMenu.Visible == true)
                pnlRelatoriosSubMenu.Visible = false;
        }   

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        //TÓPICO - CONTROLE
        private void btnControle_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlControleSubMenu);
        }
        #region Controle
        private void btnUsuário_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void btnFuncionários_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }
#endregion

        //TÓPICO - SERVIÇOS
        private void btnServicos_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlServicosSubMenu);
        }
        #region Serviços
        private void btnCursos_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }
        private void btnShows_Click(object sender, EventArgs e)
        {
                    //..
                    //meus códgios
                    //..

                    hideSubMenu();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void btnProfissionais_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }
        #endregion

        //TÓPICO - RELATÓRIOS
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            showSubMenu(pnlRelatoriosSubMenu);
        }
        #region Relatórios
        private void btnVendas_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void btnAtividades_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void btnCadastros_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }
        #endregion

        //TÓPICO - Dashboard
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        //TÓPICO - Perfil
        private void btnPerfil_Click(object sender, EventArgs e)
        {
            //..
            //meus códgios
            //..

            hideSubMenu();
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }
    }
}
