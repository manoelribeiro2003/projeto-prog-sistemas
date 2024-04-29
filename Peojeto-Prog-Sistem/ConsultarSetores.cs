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
    public partial class ConsultarSetores : Form
    {

        int id_setor;
        string nomeSetor;
        string subDivisao;
        public ConsultarSetores()
        {
            InitializeComponent();
        }

        private void ConsultarSetores_Load(object sender, EventArgs e)
        {
            dgvSetores.DataSource = Banco.ObterSetores();
            dgvSetores.Columns[0].Width = 100;
        }

        private void dgvSetores_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;

            if (contLinhas > 0)
            {
                id_setor = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);

                tbxNome.Text = dgv.SelectedRows[0].Cells["Nome"].Value.ToString();
                tbxSubdivisao.Text = dgv.SelectedRows[0].Cells["Subdivisão"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            nomeSetor = tbxNome.Text;
            subDivisao = tbxSubdivisao.Text;

            if (nomeSetor != "")
            {
                string nome = dgvSetores.SelectedRows[0].Cells["Nome"].Value.ToString();
                DialogResult res = MessageBox.Show("Confirmar edição do setor " + nome + "?", "PatriMundi - Confirmar edição", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    bool rowsAffected = Banco.editarSetor(id_setor, nomeSetor, subDivisao);
                    if (rowsAffected)
                    {
                        MessageBox.Show("Setor editado com sucesso!", "Edição de setor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    dgvSetores.DataSource = Banco.ObterSetores();
                }

            }
            else
            {
                MessageBox.Show("Selecione um setor e preencha os campos", "Edição de setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
