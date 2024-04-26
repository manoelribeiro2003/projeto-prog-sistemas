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

        private void patrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPatrimonio cp = new CadastroPatrimonio();
            cp.Show();
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

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroManutencao cm = new CadastroManutencao();
                cm.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaManutencao conManu = new ConsultaManutencao();
            conManu.ShowDialog();
        }

        private void statusDePatrimônioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusPatrimonio statusPatrimonio = new StatusPatrimonio();
            statusPatrimonio.ShowDialog();
        }
    }
}
