using System;
using System.Windows.Forms;

namespace MusicStationForms
{
    public partial class FormRelatorios : Form
    {
        public FormRelatorios()
        {
            InitializeComponent();

            ConfigurarComboBoxRelatorio();
            ConfigurarComboBoxPeriodo();
            ConfigurarListViewBase();

            // Relatório inicial
            ConfigurarRelatorioUsuarios();
        }

        // ================== COMBOBOX: TIPO DE RELATÓRIO ==================
        private void ConfigurarComboBoxRelatorio()
        {
            cboEscolha.Items.Add("Relatório de Usuários");
            cboEscolha.Items.Add("Relatório de Serviços");
            cboEscolha.Items.Add("Relatório de Pedidos");

            cboEscolha.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEscolha.SelectedIndex = 0;
        }

        // ================== COMBOBOX: PERÍODO ==================
        private void ConfigurarComboBoxPeriodo()
        {
            cboPeriodo.Items.Add("Últimos 7 dias");
            cboPeriodo.Items.Add("Últimos 15 dias");
            cboPeriodo.Items.Add("Últimos 30 dias");
            cboPeriodo.Items.Add("Últimos 90 dias");
            cboPeriodo.Items.Add("Todo o período");

            cboPeriodo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPeriodo.SelectedIndex = 2; // padrão: últimos 30 dias
        }

        // ================== LISTVIEW BASE ==================
        private void ConfigurarListViewBase()
        {
            lvRelatorios.View = View.Details;
            lvRelatorios.FullRowSelect = true;
            lvRelatorios.GridLines = true;
            lvRelatorios.MultiSelect = false;
            lvRelatorios.HideSelection = false;
        }

        private void LimparListView()
        {
            lvRelatorios.Clear();
            ConfigurarListViewBase();
        }

        // ================== RELATÓRIO: USUÁRIOS ==================
        private void ConfigurarRelatorioUsuarios()
        {
            LimparListView();

            lvRelatorios.Columns.Add("ID", 80);
            lvRelatorios.Columns.Add("Nome", 200);
            lvRelatorios.Columns.Add("Data de Cadastro", 150);
            lvRelatorios.Columns.Add("Status", 100);
        }

        // ================== RELATÓRIO: SERVIÇOS ==================
        private void ConfigurarRelatorioServicos()
        {
            LimparListView();

            lvRelatorios.Columns.Add("ID", 80);
            lvRelatorios.Columns.Add("Serviço", 200);
            lvRelatorios.Columns.Add("Profissional", 200);
            lvRelatorios.Columns.Add("Data", 120);
            lvRelatorios.Columns.Add("Status", 100);
        }

        // ================== RELATÓRIO: PEDIDOS ==================
        private void ConfigurarRelatorioPedidos()
        {
            LimparListView();

            lvRelatorios.Columns.Add("Pedido", 100);
            lvRelatorios.Columns.Add("Cliente", 200);
            lvRelatorios.Columns.Add("Serviço", 200);
            lvRelatorios.Columns.Add("Data", 120);
            lvRelatorios.Columns.Add("Situação", 120);
        }

        // ================== EVENTOS ==================
        private void cboTipoRelatorio_SelectedIndexChanged(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }

        // ================== LÓGICA CENTRAL ==================
        private void GerarRelatorio()
        {
            switch (cboEscolha.SelectedItem.ToString())
            {
                case "Relatório de Usuários":
                    ConfigurarRelatorioUsuarios();
                    break;

                case "Relatório de Serviços":
                    ConfigurarRelatorioServicos();
                    break;

                case "Relatório de Pedidos":
                    ConfigurarRelatorioPedidos();
                    break;
            }
        }

        private void picboxLogo_Click(object sender, EventArgs e)
        {
            FormMenu menu = new FormMenu();
            menu.Show();
            this.Close();
        }
    }
}