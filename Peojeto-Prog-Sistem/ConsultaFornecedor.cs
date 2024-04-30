using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Peojeto_Prog_Sistem
{
    public partial class ConsultaFornecedor : Form
    {
        Fornecedor fornecedor = new Fornecedor();
        public ConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void ConsultaFornecedor_Load(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = Banco.ObterFornecedor();
            dgvFornecedor.Columns[0].Width = 50;
        }

        private void dgvFornecedor_DoubleClick(object sender, EventArgs e)
        {

            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)

            {
                fornecedor.id_Fornecedor = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
                tbxcnpj.Text = dgv.SelectedRows[0].Cells["CNPJ"].Value.ToString();
                tbxRazaoSocial.Text = dgv.SelectedRows[0].Cells["R Social"].Value.ToString();
                tbxEnd.Text = dgv.SelectedRows[0].Cells["Endereço"].Value.ToString();
                tbxContato.Text = dgv.SelectedRows[0].Cells["Contato"].Value.ToString();
                tbxObs.Text = dgv.SelectedRows[0].Cells["Obs"].Value.ToString();
                
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            fornecedor.cnpj = tbxcnpj.Text;
            fornecedor.razaosocial = tbxRazaoSocial.Text;
            fornecedor.endFornecedor = tbxEnd.Text;
            fornecedor.contato = tbxContato.Text;
            fornecedor.obs = tbxObs.Text;

            Banco.editarFornecedor(fornecedor);
            dgvFornecedor.DataSource = Banco.ObterFornecedor();
            /*
            string nome = dgvFornecedor.SelectedRows[0].Cells["R Social"].Value.ToString();
            DialogResult res = MessageBox.Show("Confirmar edição do Fornecedor " + nome + "?", "PatriMundi - Confirmar Edição", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fornecedor.id_Fornecedor = Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells["ID"].Value.ToString());
                bool rowsAffected = Banco.editarManutencao(fornecedor);
                if (rowsAffected)
                {
                    MessageBox.Show("Fornecedor editado com sucesso!", "Edição do Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvFornecedor.DataSource = Banco.editarFornecedor(Fornecedor fornecedor);

            }
            tbxcnpj.Text = "";
            tbxRazaoSocial.Text = "";
            tbxEnd.Text = "";
            tbxContato.Text = "";
            tbxObs.Text = "";
            */
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            fornecedor.cnpj = dgvFornecedor.SelectedRows[0].Cells["CNPJ"].Value.ToString();
            DialogResult res = MessageBox.Show("Confirmar exclusão de Fornecedor " + fornecedor.cnpj + "?", "PatriMundi - Confirmar exclusao", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                fornecedor.id_Fornecedor = Convert.ToInt32(dgvFornecedor.SelectedRows[0].Cells["ID"].Value);
                Banco.excluirFornecedor(fornecedor.id_Fornecedor);
                dgvFornecedor.DataSource = Banco.ObterFornecedor();
            }
            tbxcnpj.Text = "";
            tbxRazaoSocial.Text = "";
            tbxEnd.Text = "";
            tbxContato.Text = "";
            tbxObs.Text = "";
        }
    }
}
