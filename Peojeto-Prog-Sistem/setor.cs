using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Peojeto_Prog_Sistem
{
    public partial class setor : Form
    {
        CadastrarSetor cadastrarSetor = new CadastrarSetor();
        public setor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            cadastrarSetor.nome = tbxNome.Text;
            cadastrarSetor.subDivisao = tbxSubDivisao.Text;

            if (cadastrarSetor.nome == "")
            {
                MessageBox.Show("Preencha o nome do setor", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Banco.CadastrarSetor(cadastrarSetor);
                tbxSubDivisao.Text = "";

            }


        }

        private void setor_Load(object sender, EventArgs e)
        {
            tbxSubDivisao.Enabled = false;
        }

        private void cbxSubdivisao_Click(object sender, EventArgs e)
        {
            if (cbxSubdivisao.Checked == true)
            {
                tbxSubDivisao.Enabled = true;
            }
            else
            {
                tbxSubDivisao.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
