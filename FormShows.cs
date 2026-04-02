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
    public partial class FormShows : Form
    {
        // Guarda todos os itens para poder filtrar corretamente
        private List<ListViewItem> itensOriginais = new List<ListViewItem>();
        public FormShows()
        {
            InitializeComponent();
            ConfigurarListView():
        }

        // ================== LISTVIEW ================== \\

        private void ConfigurarListView()
        {
            lvShows.Columns.Clear();
            lvShows.View = View.Details;
            lvShows.FullRowSelect = true;
            lvShows.GridLines = true;
            lvShows.MultiSelect = false;
            lvShows.Columns.Add("ID", 80);
            lvShows.Columns.Add("ID_PROFISSIONAL", 150);
            lvShows.Columns.Add("NOME", 200);
            lvShows.Columns.Add("PREÇO", 100);
            lvShows     .Columns.Add("DATA DE CRIAÇÃO", 150);
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
            lvShows.BeginUpdate();
            lvShows.Items.Clear();

            // Se o texto estiver vazio, mostra tudo novamente
            if (string.IsNullOrWhiteSpace(texto))
            {
                foreach (var item in itensOriginais)
                    lvShows.Items.Add((ListViewItem)item.Clone());

                lvShows.EndUpdate();
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
                    lvShows.Items.Add((ListViewItem)item.Clone());
            }

            lvShows.EndUpdate();
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
