using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MusicStationForms
{
    public partial class FormUsuarios : Form
    {
        // Guarda todos os itens para poder filtrar corretamente
        private List<ListViewItem> itensOriginais = new List<ListViewItem>();

        public FormUsuarios()
        {
            InitializeComponent();
            ConfigurarListView();
        }

        // ================== BORDAS DOS PAINÉIS ================== \\

        private void pnlUsuarios_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(238, 182, 34), 3))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    1,
                    1,
                    pnlUsuarios.Width - 2,
                    pnlUsuarios.Height - 2
                );
            }
        }

        private void pnlDados_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.FromArgb(238, 182, 34), 3))
            {
                e.Graphics.DrawRectangle(
                    pen,
                    1,
                    1,
                    pnlDados.Width - 2,
                    pnlDados.Height - 2
                );
            }
        }

        // ================== LISTVIEW ================== \\

        private void ConfigurarListView()
        {
            lvUsuarios.Columns.Clear();
            lvUsuarios.View = View.Details;
            lvUsuarios.FullRowSelect = true;
            lvUsuarios.GridLines = true;
            lvUsuarios.MultiSelect = false;
            lvUsuarios.Columns.Add("ID", 80);
            lvUsuarios.Columns.Add("Nome", 150);
            lvUsuarios.Columns.Add("Email", 200);
            lvUsuarios.Columns.Add("Senha", 100);
            lvUsuarios.Columns.Add("Data de Criação", 150);
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
            lvUsuarios.BeginUpdate();
            lvUsuarios.Items.Clear();

            // Se o texto estiver vazio, mostra tudo novamente
            if (string.IsNullOrWhiteSpace(texto))
            {
                foreach (var item in itensOriginais)
                    lvUsuarios.Items.Add((ListViewItem)item.Clone());

                lvUsuarios.EndUpdate();
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
                    lvUsuarios.Items.Add((ListViewItem)item.Clone());
            }

            lvUsuarios.EndUpdate();
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