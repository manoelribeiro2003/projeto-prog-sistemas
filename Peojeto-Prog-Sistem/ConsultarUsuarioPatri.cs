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
    public partial class ConsultarUsuarioPatri : Form
    {
        int id;
        string nome, responsavel, cargo, setor, subdivisao;

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nome = tbxNome.Text;
            responsavel = tbxResponsavel.Text;
            cargo = tbxCargo.Text;
            setor = cbxSetor.SelectedItem.ToString();
            subdivisao = cbxSubdivisao.SelectedItem.ToString();

            if (nome != "" && responsavel != "" && cargo != "" && subdivisao != "")
            {
                DialogResult res = MessageBox.Show("Deseja realmente editar?", "Edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    Banco.editarUserPatri(id, nome, responsavel, cargo, setor, subdivisao);
                    tbxNome.Text = "";
                    tbxResponsavel.Text = "";
                    tbxCargo.Text = "";
                    cbxSetor.SelectedIndex = -1;
                    cbxSubdivisao.SelectedIndex = -1;

                    string sql = "SELECT id as 'ID', nome as 'Nome', responsavel as 'Responsável', cargo as 'Cargo', setor as 'Setor', subdivisao as 'Subdivisão' FROM t_usuario_patri";
                    dgvUsuariosPatri.DataSource = Banco.consulta(sql);
                    dgvUsuariosPatri.Columns[0].Width = 50;

                }
            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluirManut_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Confirmar exclusão do usuário " + dgvUsuariosPatri.SelectedRows[0].Cells["Nome"].Value.ToString() + "?", "PatriMundi - Confirmar exclusao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                id = Convert.ToInt32(dgvUsuariosPatri.SelectedRows[0].Cells["ID"].Value.ToString());
                Banco.excluirUserPatri(id);

                string sql = "SELECT id as 'ID', nome as 'Nome', responsavel as 'Responsável', cargo as 'Cargo', setor as 'Setor', subdivisao as 'Subdivisão' FROM t_usuario_patri";
                dgvUsuariosPatri.DataSource = Banco.consulta(sql);
                dgvUsuariosPatri.Columns[0].Width = 50;
            }
        }

        public ConsultarUsuarioPatri()
        {
            InitializeComponent();
        }

        private void ConsultarUsuarioPatri_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id as 'ID', nome as 'Nome', responsavel as 'Responsável', cargo as 'Cargo', setor as 'Setor', subdivisao as 'Subdivisão' FROM t_usuario_patri";
            dgvUsuariosPatri.DataSource = Banco.consulta(sql);
            dgvUsuariosPatri.Columns[0].Width = 50;
        }

        private void cbxSetor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string sql = $"SELECT DISTINCT subDivisao FROM t_setor WHERE nome = '{cbxSetor.SelectedItem.ToString()}' AND subDivisao != ''";
            DataTable listLocacao = Banco.consulta(sql);
            cbxSubdivisao.Items.Clear();
            foreach (DataRow item in listLocacao.Rows)
            {
                if (item["subDivisao"].ToString() != "" && item["subDivisao"].ToString() != null)
                {
                    cbxSubdivisao.Items.Add(item["subDivisao"].ToString());
                }
            }
            cbxSubdivisao.Items.Add(cbxSetor.SelectedItem.ToString());
        }

        private void dgvUsuariosPatri_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);
                tbxNome.Text = dgv.SelectedRows[0].Cells["Nome"].Value.ToString();
                tbxResponsavel.Text = dgv.SelectedRows[0].Cells["Responsável"].Value.ToString();
                tbxCargo.Text = dgv.SelectedRows[0].Cells["Cargo"].Value.ToString();

                cbxSetor.Items.Clear();
                cbxSetor.Items.Add(dgv.SelectedRows[0].Cells["Setor"].Value.ToString());
                cbxSetor.SelectedIndex = 0;
                DataTable tabelaSetores = Banco.consulta($"SELECT DISTINCT nome FROM t_setor WHERE nome != '{dgv.SelectedRows[0].Cells["Setor"].Value.ToString()}'");
                foreach (DataRow linha in tabelaSetores.Rows)
                {
                    cbxSetor.Items.Add(linha["nome"].ToString());
                }

                cbxSubdivisao.Items.Clear();
                cbxSubdivisao.Items.Add(cbxSetor.SelectedItem.ToString());
                DataTable tabelaSubdivisao = Banco.consulta($"SELECT DISTINCT nome, subDivisao FROM t_setor WHERE nome = '{cbxSetor.SelectedItem.ToString()}' AND subDivisao != '' AND subDivisao != '{dgv.SelectedRows[0].Cells["Subdivisão"].Value.ToString()}'");
                foreach (DataRow linha in tabelaSubdivisao.Rows)
                {
                    if (tabelaSubdivisao.Rows[0][0].ToString() != tabelaSubdivisao.Rows[0][1].ToString())
                    {
                        cbxSubdivisao.Items.Add(linha["subDivisao"].ToString());
                    }
                }
                if (dgv.SelectedRows[0].Cells["Subdivisão"].Value.ToString() != dgv.SelectedRows[0].Cells["Setor"].Value.ToString())
                {
                    cbxSubdivisao.Items.Add(dgv.SelectedRows[0].Cells["Subdivisão"].Value.ToString());
                }
                cbxSubdivisao.SelectedItem = dgv.SelectedRows[0].Cells["Subdivisão"].Value.ToString();
            }
        }
    }
}
