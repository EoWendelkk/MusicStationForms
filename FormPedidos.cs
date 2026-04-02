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
    public partial class FormPedidos : Form
    {
        // Guarda todos os itens para poder filtrar corretamente
        private List<ListViewItem> itensOriginais = new List<ListViewItem>();
        public FormPedidos()
        {
            InitializeComponent();
            ConfigurarListView();
        }

        // ================== LISTVIEW ================== \\

        private void ConfigurarListView()
        {
            lvPedidos.Columns.Clear();
            lvPedidos.View = View.Details;
            lvPedidos.FullRowSelect = true;
            lvPedidos.GridLines = true;
            lvPedidos.MultiSelect = false;
            lvPedidos.Columns.Add("ID", 80);
            lvPedidos.Columns.Add("ID_usuario", 150);
            lvPedidos.Columns.Add("Telefone", 200);
            lvPedidos.Columns.Add("Endereço", 100);
            lvPedidos.Columns.Add("Data de Criação", 150);
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
            lvPedidos.BeginUpdate();
            lvPedidos.Items.Clear();

            // Se o texto estiver vazio, mostra tudo novamente
            if (string.IsNullOrWhiteSpace(texto))
            {
                foreach (var item in itensOriginais)
                    lvPedidos.Items.Add((ListViewItem)item.Clone());

                lvPedidos.EndUpdate();
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
                    lvPedidos.Items.Add((ListViewItem)item.Clone());
            }

            lvPedidos.EndUpdate();
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
