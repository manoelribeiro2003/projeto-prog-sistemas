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
        public setor()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            CadastrarSetor cadastrarSetor   = new CadastrarSetor();
            cadastrarSetor.nome             = tbxNome.Text;
            cadastrarSetor.subDivisao       = tbxSubDivisao.Text;

            Banco.CadastrarSetor2(cadastrarSetor);
        }
    }
}
