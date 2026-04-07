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
    
    public partial class FormProdutos : Form
    {
        private List<ListViewItem> itensOriginais = new List<ListViewItem>();
        public FormProdutos()
        {
            InitializeComponent();
            ConfigurarListView();
        }

        // ================== LISTVIEW ================== \\

        private void ConfigurarListView()
        {
            lvProdutos.Columns.Clear();
            lvProdutos.View = View.Details;
            lvProdutos.FullRowSelect = true;
            lvProdutos.GridLines = true;
            lvProdutos.MultiSelect = false;
            lvProdutos.Columns.Add("ID", 80);
            lvProdutos.Columns.Add("NOME", 150);
            lvProdutos.Columns.Add("DESCRIÇÃO", 200);
            lvProdutos.Columns.Add("PREÇO", 100);
            lvProdutos.Columns.Add("DATA DE CRIAÇÃO", 150);
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
            lvProdutos.BeginUpdate();
            lvProdutos.Items.Clear();

            // Se o texto estiver vazio, mostra tudo novamente
            if (string.IsNullOrWhiteSpace(texto))
            {
                foreach (var item in itensOriginais)
                    lvProdutos.Items.Add((ListViewItem)item.Clone());

                lvProdutos.EndUpdate();
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
                    lvProdutos.Items.Add((ListViewItem)item.Clone());
            }

            lvProdutos.EndUpdate();
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
