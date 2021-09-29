using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View.viewFilme
{
    public partial class FrmAlterarFilme : Form
    {
        public FrmAlterarFilme()
        {
            InitializeComponent();
        }

        private void FrmAlterarFilme_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Filme Alterado com sucesso!");
        }
    }
}
