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
    public partial class FormCursos : Form
    {
        /// Guarda todos os itens para poder filtrar corretamente
        private List<ListViewItem> itensOriginais = new List<ListViewItem>();
        public FormCursos()
        {
            InitializeComponent();
            ConfigurarListView();
        }

        // ================== LISTVIEW ================== \\

        private void ConfigurarListView()
        {
            lvCursos.Columns.Clear();
            lvCursos.View = View.Details;
            lvCursos.FullRowSelect = true;
            lvCursos.GridLines = true;
            lvCursos.MultiSelect = false;
            lvCursos.Columns.Add("ID", 80);
            lvCursos.Columns.Add("ID_PROFISSIONAL", 150);
            lvCursos.Columns.Add("NOME", 200);
            lvCursos.Columns.Add("PREÇO", 100);
            lvCursos.Columns.Add("DATA DE CRIAÇÃO", 150);
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
            lvCursos.BeginUpdate();
            lvCursos.Items.Clear();

            // Se o texto estiver vazio, mostra tudo novamente
            if (string.IsNullOrWhiteSpace(texto))
            {
                foreach (var item in itensOriginais)
                    lvCursos.Items.Add((ListViewItem)item.Clone());

                lvCursos.EndUpdate();
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
                    lvCursos.Items.Add((ListViewItem)item.Clone());
            }

            lvCursos.EndUpdate();
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
