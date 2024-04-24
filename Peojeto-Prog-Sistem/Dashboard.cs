using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peojeto_Prog_Sistem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void CadastroPatrimonio_Load(object sender, EventArgs e)
        {

        }

        private void patrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPatrimonio cp = new CadastroPatrimonio();
            cp.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Locados_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroManutencao cm = new CadastroManutencao();
            cm.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cf = new CadastroFornecedor();
            cf.Show();
        }

        private void setoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setor mfcs = new setor();
            mfcs.ShowDialog();
        }
    }
}
