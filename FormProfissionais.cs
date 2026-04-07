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

    public partial class FormProfissionais : Form
    {
        private List<ListViewItem> itensOriginais = new List<ListViewItem>();

        public FormProfissionais()
        {
            InitializeComponent();
            ConfigurarListView();
        }

        // ================== LISTVIEW ================== \\

        private void ConfigurarListView()
        {
            lvProfissionais.Columns.Clear();
            lvProfissionais.View = View.Details;
            lvProfissionais.FullRowSelect = true;
            lvProfissionais.GridLines = true;
            lvProfissionais.MultiSelect = false;
            lvProfissionais.Columns.Add("ID", 80);
            lvProfissionais.Columns.Add("ID_USUÁRIO", 150);
            lvProfissionais.Columns.Add("NOME", 200);
            lvProfissionais.Columns.Add("TELEFONE", 20);
            lvProfissionais.Columns.Add("ESPECIALIDADES", 150);
            lvProfissionais.Columns.Add("PREÇO", 100);

        }

        // ================== FILTRO ================== \\

        private void txtPesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FiltrarListView(txtPesquisa.Text);
            }
        }

        private void FiltrarListView(string texto)
        {
            lvProfissionais.BeginUpdate();
            lvProfissionais.Items.Clear();

            // Se o texto estiver vazio, mostra tudo novamente
            if (string.IsNullOrWhiteSpace(texto))
            {
                foreach (var item in itensOriginais)
                    lvProfissionais.Items.Add((ListViewItem)item.Clone());

                lvProfissionais.EndUpdate();
                return;
            }

            // Filtra os itens originais e adiciona os que correspondem ao filtro
            foreach (var item in itensOriginais)
            {
                bool encontrado = false;

                foreach (ListViewItem.ListViewSubItem sub in item.SubItems)
                {
                    if (sub.Text.ToLower().Contains(texto.ToLower()))
                    {
                        encontrado = true;
                        break;
                    }
                }

                if (encontrado)
                    lvProfissionais.Items.Add((ListViewItem)item.Clone());
            }

            lvProfissionais.EndUpdate();
        }

        // ================== PLACEHOLDER DO TEXTBOX DE PESQUISA ================== \\

        //Quando clicar no textbox, se o texto for "Pesquisa", limpa o texto e muda a cor para preto
        private void txtPesquisa_Enter(object sender, EventArgs e)
        {
            if (txtPesquisa.Text == "Pesquisa")
            {
                txtPesquisa.Text = "";
                txtPesquisa.ForeColor = Color.Black;
            }
        }
        //Quando sair do textbox, se o texto estiver vazio, coloca "Pesquisa" e muda a cor para cinza
        private void txtPesquisa_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPesquisa.Text))
            {
                txtPesquisa.Text = "Pesquisa";
                txtPesquisa.ForeColor = Color.Gray;
            }
        }
    }
}
