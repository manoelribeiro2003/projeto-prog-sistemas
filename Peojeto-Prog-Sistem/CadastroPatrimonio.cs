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
    public partial class CadastroPatrimonio : Form
    {
        public CadastroPatrimonio()
        {
            Patrimonio patrimonio = new Patrimonio();
            InitializeComponent();
            cbbStatus.Items.Add(patrimonio.listaStatus[0].ToString());
            cbbStatus.Items.Add(patrimonio.listaStatus[1].ToString());
        }

        private void CadastroPatrimonio_Load(object sender, EventArgs e)
        {

        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            Patrimonio patrimonio     = new Patrimonio();

            patrimonio.descricaoPatri = txbDescricaoPatri.Text;
            patrimonio.nf             = txbNf.Text;
            patrimonio.fornecedor     = txbFornecedor.Text;
            patrimonio.dtAquisicao    = dtpDtAquisicao.Text;
            patrimonio.dtGarantia     = dtpDtGarantia.Text;
            patrimonio.status         = cbbStatus.Text;
            patrimonio.locacao        = cbbLocacao.Text;
            patrimonio.localizacao    = cbbLocalizacao.Text;
            patrimonio.operador       = cbbOperador.Text;
            patrimonio.gestorResp     = cbbGestorResp.Text;
            patrimonio.valor          = txbValor.Text;
            patrimonio.obs            = cbxObservacoes.Text;

            Banco.cadastrarPatrimonio(patrimonio);
        }
    }
}
