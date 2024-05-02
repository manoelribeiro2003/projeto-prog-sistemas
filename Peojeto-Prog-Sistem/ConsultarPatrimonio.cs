using System;
using System.Data;
using System.Windows.Forms;

namespace Peojeto_Prog_Sistem
{
    public partial class ConsultarPatrimonio : Form
    {

        int id;
        public ConsultarPatrimonio()
        {
            InitializeComponent();
        }

        private void ConsultarPatrimonio_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id as 'ID', descricaoPatri as 'Descrição', nf as 'Nota Fiscal', fornecedor as 'Fornecedor', " +
                "dtAquisicao as 'Aquisição', dtGarantia as 'Garantia', status as 'Status', localizacao as 'Localização', " +
                "locacao as 'Locação', operador as 'Operador', gestorResp as 'Gestor', valor as 'Valor', obs as 'Obs' FROM patrimonios";

            dgvPatrimonios.DataSource = Banco.consulta(sql);
            dgvPatrimonios.Columns[0].Width = 50;

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

        private void dgvPatrimonios_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);

                txbDescricaoPatri.Text = dgv.SelectedRows[0].Cells["Descrição"].Value.ToString();
                txbNf.Text = dgv.SelectedRows[0].Cells["Nota Fiscal"].Value.ToString();
                cbxFornecedor.SelectedItem = dgv.SelectedRows[0].Cells["Fornecedor"].Value.ToString();
                dtpDtAquisicao.Text = dgv.SelectedRows[0].Cells["Aquisição"].Value.ToString();
                dtpDtGarantia.Text = dgv.SelectedRows[0].Cells["Garantia"].Value.ToString();
                cbxStatus.SelectedItem = dgv.SelectedRows[0].Cells["Status"].Value.ToString();
                cbxLocalizacao.SelectedItem = dgv.SelectedRows[0].Cells["Localização"].Value.ToString();

                DataTable listLocacao = Banco.consulta($"SELECT subDivisao FROM t_setor WHERE nome = '{cbxLocalizacao.SelectedItem.ToString()}'");
                cbxLocacao.Items.Clear();
                foreach (DataRow item in listLocacao.Rows)
                {
                    if (item["subDivisao"].ToString() != "")
                    {
                        cbxLocacao.Items.Add(item["subDivisao"].ToString());
                    }
                }
                cbxLocacao.Items.Add(dgv.SelectedRows[0].Cells["Localização"].Value.ToString());
                cbxLocacao.SelectedItem = dgv.SelectedRows[0].Cells["Locação"].Value.ToString();

                cbxLocacao.SelectedItem = dgv.SelectedRows[0].Cells["Locação"].Value.ToString();

                string sql;
                if (cbxLocacao.SelectedItem.ToString() == cbxLocalizacao.SelectedItem.ToString())
                {
                    sql = $"select * from t_usuario_patri where setor = '{cbxLocalizacao.SelectedItem.ToString()}'";
                }
                else
                {
                    sql = $"select * from t_usuario_patri where subDivisao = '{cbxLocacao.SelectedItem.ToString()}'";
                }
                DataTable listOperador = Banco.consulta(sql);
                cbxOperador.Items.Clear();
                foreach (DataRow item in listOperador.Rows)
                {
                    cbxOperador.Items.Add(item["nome"].ToString());
                }
                cbxOperador.SelectedItem = dgv.SelectedRows[0].Cells["Operador"].Value.ToString();

                cbbGestorResp.SelectedItem = dgv.SelectedRows[0].Cells["Gestor"].Value.ToString();
                txbValor.Text = dgv.SelectedRows[0].Cells["Valor"].Value.ToString();
                tbxObservacoes.Text = dgv.SelectedRows[0].Cells["Obs"].Value.ToString();
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

            string sql = $"select * from t_usuario_patri where setor = '{cbxLocalizacao.SelectedItem.ToString()}'";
            DataTable listOperador = Banco.consulta(sql);
            cbxOperador.Items.Clear();
            foreach (DataRow item in listOperador.Rows)
            {
                //if (item["nome"].ToString() != "")
                //{
                cbxOperador.Items.Add(item["nome"].ToString());
                //}
            }
        }

        private void cbxLocacao_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sql;
            if (cbxLocacao.SelectedItem.ToString() == cbxLocalizacao.SelectedItem.ToString())
            {
                sql = $"select * from t_usuario_patri where setor = '{cbxLocalizacao.SelectedItem.ToString()}'";
            }
            else
            {
                sql = $"select * from t_usuario_patri where subDivisao = '{cbxLocacao.SelectedItem.ToString()}'";
            }
            DataTable listOperador = Banco.consulta(sql);
            cbxOperador.Items.Clear();
            foreach (DataRow item in listOperador.Rows)
            {
                //if (item["nome"].ToString() != "")
                //{
                cbxOperador.Items.Add(item["nome"].ToString());
                //}
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                Patrimonio patrimonio = new Patrimonio();
                patrimonio.descricaoPatri = txbDescricaoPatri.Text;
                patrimonio.nf = txbNf.Text;
                patrimonio.fornecedor = cbxFornecedor.Text;
                patrimonio.dtAquisicao = dtpDtAquisicao.Text;
                patrimonio.dtGarantia = dtpDtGarantia.Text;
                patrimonio.status = cbxStatus.SelectedItem.ToString();
                patrimonio.localizacao = cbxLocalizacao.SelectedItem.ToString();
                patrimonio.locacao = cbxLocacao.SelectedItem.ToString();
                patrimonio.operador = cbxOperador.SelectedItem.ToString();
                patrimonio.gestorResp = cbbGestorResp.SelectedItem.ToString();
                patrimonio.valor = txbValor.Text;
                patrimonio.obs = tbxObservacoes.Text;

                string nome = dgvPatrimonios.SelectedRows[0].Cells["Descrição"].Value.ToString();
                DialogResult res = MessageBox.Show("Confirmar edição do patrimônio " + nome + "?", "PatriMundi - Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    patrimonio.id = Convert.ToInt32(dgvPatrimonios.SelectedRows[0].Cells["ID"].Value.ToString());
                    Banco.editarPatrimonio(patrimonio);
                    string sql = "SELECT id as 'ID', descricaoPatri as 'Descrição', nf as 'Nota Fiscal', fornecedor as 'Fornecedor', " +
                    "dtAquisicao as 'Aquisição', dtGarantia as 'Garantia', status as 'Status', localizacao as 'Localização', " +
                    "locacao as 'Locação', operador as 'Operador', gestorResp as 'Gestor', valor as 'Valor', obs as 'Obs' FROM patrimonios";
                    dgvPatrimonios.DataSource = Banco.consulta(sql);

                    txbDescricaoPatri.Text = "";
                    txbNf.Text = "";
                    cbxFornecedor.Text = "";
                    cbxStatus.SelectedIndex = -1;
                    cbxLocalizacao.SelectedIndex = -1;
                    cbxLocacao.SelectedIndex = -1;
                    cbxOperador.SelectedIndex = -1;
                    cbbGestorResp.SelectedIndex = -1;
                    txbValor.Text = "";
                    tbxObservacoes.Text = "";

                }

            }
            catch
            {
                MessageBox.Show("Erro ao tentar editar", "PatriMundi - Edição de patrimônio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Patrimonio patrimonio = new Patrimonio();
            DialogResult res = MessageBox.Show("Confirmar exclusão do patrimônio " + dgvPatrimonios.SelectedRows[0].Cells["Descrição"].Value.ToString() + "?", "PatriMundi - Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                patrimonio.id = Convert.ToInt32(dgvPatrimonios.SelectedRows[0].Cells["ID"].Value.ToString());
                Banco.excluirPatrimonio(patrimonio);
                string sql = "SELECT id as 'ID', descricaoPatri as 'Descrição', nf as 'Nota Fiscal', fornecedor as 'Fornecedor', " +
                "dtAquisicao as 'Aquisição', dtGarantia as 'Garantia', status as 'Status', localizacao as 'Localização', " +
                "locacao as 'Locação', operador as 'Operador', gestorResp as 'Gestor', valor as 'Valor', obs as 'Obs' FROM patrimonios";
                dgvPatrimonios.DataSource = Banco.consulta(sql);
            }
        }
    }
}
