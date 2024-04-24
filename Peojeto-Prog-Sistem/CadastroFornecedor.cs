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
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
        {
            InitializeComponent();
        }

        private void CadastroFornecedor_Load(object sender, EventArgs e)
        {

        }

        private void labelNF_Click(object sender, EventArgs e)
        {

        }

        private void labelFornecedor_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.cnpj             = tbxcnpj.Text;
            fornecedor.razaosocial      = tbxRazaoSocial.Text;
            fornecedor.endFornecedor    = tbxEnd.Text;
            fornecedor.contato          = tbxContato.Text;
            fornecedor.obs              = tbxObs.Text;

            Banco.CadastroFornecedor(fornecedor);


        }

        private void patrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
