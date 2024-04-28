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
        Patrimonio patrimonio = new Patrimonio();
        public CadastroPatrimonio()
        {
            InitializeComponent();
        }

        private void CadastroPatrimonio_Load(object sender, EventArgs e)
        {
            cbxOperador.Items.Clear();

            DataTable listStatus = Banco.buscarListStatusPatri();
            foreach (DataRow item in listStatus.Rows)
            {
                cbxStatus.Items.Add(item[0].ToString());
            }

            DataTable listLocalizacao = Banco.buscarListLocalizacoes(distinct: true);
            cbxLocalizacao.Items.Clear();
            foreach (DataRow item in listLocalizacao.Rows)
            {
                cbxLocalizacao.Items.Add(item["nome"].ToString());
            }

            

            DataTable listGestor = Banco.buscarListGestor();
            cbbGestorResp.Items.Clear();
            foreach (DataRow item in listGestor.Rows)
            {
                cbbGestorResp.Items.Add(item["responsavel"].ToString());
            }
        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            patrimonio.descricaoPatri = txbDescricaoPatri.Text;
            patrimonio.nf             = txbNf.Text;
            patrimonio.fornecedor     = txbFornecedor.Text;
            patrimonio.dtAquisicao    = dtpDtAquisicao.Text;
            patrimonio.dtGarantia     = dtpDtGarantia.Text;
            patrimonio.status         = cbxStatus.Text;
            patrimonio.locacao        = cbxLocacao.Text;
            patrimonio.localizacao    = cbxLocalizacao.Text;
            patrimonio.operador       = cbxOperador.Text;
            patrimonio.gestorResp     = cbbGestorResp.Text;
            patrimonio.valor          = txbValor.Text;
            patrimonio.obs            = cbxObservacoes.Text;

            if (patrimonio.descricaoPatri == "" || patrimonio.nf == "" || 
                patrimonio.fornecedor == "" || patrimonio.status == "" || 
                patrimonio.localizacao == "" || patrimonio.valor == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios","Erro");
            }
            else
            {
                Banco.cadastrarPatrimonio(patrimonio);
            }
        }

        private void cbxLocalizacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            DataTable listLocacao = Banco.buscarListLocalizacoes(distinct: false, subdivisao: true, setor: cbxLocalizacao.SelectedItem.ToString());
            cbxLocacao.Items.Clear();
            foreach (DataRow item in listLocacao.Rows)
            {
                if (item["subDivisao"].ToString() != "")
                {
                    cbxLocacao.Items.Add(item["subDivisao"].ToString());
                }
            }
            cbxLocacao.Items.Add(cbxLocalizacao.SelectedItem.ToString());

            DataTable listUsuarios = Banco.buscarListUserPatri(cbxLocalizacao.SelectedItem.ToString());
            cbxOperador.Items.Clear();
            foreach (DataRow item in listUsuarios.Rows)
            {
                cbxOperador.Items.Add(item["nome"].ToString());
            }
        }
    }
}
