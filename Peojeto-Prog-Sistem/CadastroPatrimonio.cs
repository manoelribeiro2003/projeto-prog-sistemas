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
            //cbxOperador.Items.Clear();

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

            DataTable listFornecedores = Banco.ObterFornecedor();
            cbxFornecedor.Items.Clear();
            string fornecedor;
            foreach (DataRow item in listFornecedores.Rows)
            {
                fornecedor = item["R Social"].ToString() + " - " + item["CNPJ"].ToString();
                cbxFornecedor.Items.Add(fornecedor);
            }


        }

        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            patrimonio.descricaoPatri = txbDescricaoPatri.Text;
            patrimonio.nf = txbNf.Text;
            patrimonio.fornecedor = cbxFornecedor.SelectedItem.ToString();
            patrimonio.dtAquisicao = dtpDtAquisicao.Text;
            patrimonio.dtGarantia = dtpDtGarantia.Text;
            patrimonio.status = cbxStatus.Text;
            patrimonio.locacao = cbxLocacao.Text;
            patrimonio.localizacao = cbxLocalizacao.Text;
            patrimonio.operador = cbxOperador.Text;
            patrimonio.gestorResp = cbbGestorResp.Text;
            patrimonio.valor = txbValor.Text;
            patrimonio.obs = cbxObservacoes.Text;

            if (patrimonio.descricaoPatri == "" || patrimonio.nf == "" ||
                patrimonio.fornecedor == "" || patrimonio.status == "" ||
                patrimonio.localizacao == "" || patrimonio.valor == "")
            {
                MessageBox.Show("Preencha todos os campos obrigatórios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Banco.cadastrarPatrimonio(patrimonio);
                txbDescricaoPatri.Text = "";
                txbNf.Text = "";
                cbxFornecedor.SelectedIndex = -1;
                dtpDtAquisicao.Text = "";
                dtpDtGarantia.Text = "";
                cbxStatus.SelectedIndex = -1;
                cbxLocalizacao.SelectedIndex = -1;
                cbxLocacao.SelectedIndex = -1;
                cbxOperador.SelectedIndex = -1;
                cbbGestorResp.SelectedIndex = -1;
                txbValor.Text = "";
                cbxObservacoes.Text = "";
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
                //if (item["nome"].ToString() != "")
                //{
                    cbxOperador.Items.Add(item["nome"].ToString());
                //}
            }
        }
    }
}
