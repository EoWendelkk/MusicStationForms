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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

            btnServicos.FlatStyle = FlatStyle.Flat;
            btnServicos.FlatAppearance.BorderSize = 2;
            btnServicos.FlatAppearance.BorderColor = Color.FromArgb(238, 182, 34);

        }

        private void btnControle_Click(object sender, EventArgs e)
        {

        }
    }
}
