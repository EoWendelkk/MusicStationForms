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

        private void btnControle_Click(object sender, EventArgs e)
        {
            FormControle controle = new FormControle();
            controle.Show();
            this.Close();
        }

        private void btnServicos_Click(object sender, EventArgs e)
        {
            FormServicos controle = new FormServicos();
            controle.Show();
            this.Close();
        }
    }
}
