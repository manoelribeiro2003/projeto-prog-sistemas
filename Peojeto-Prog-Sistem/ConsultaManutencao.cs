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
    public partial class ConsultaManutencao : Form
    {
        Manutencao manutencao = new Manutencao();
        public ConsultaManutencao()
        {
            InitializeComponent();
        }

        private void ConsultaManutencao_Load(object sender, EventArgs e)
        {
            dgvManutencao.DataSource = Banco.ObterManutencao();
            dgvManutencao.Columns[0].Width = 50;
        }

        private void dgvManutencao_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                manutencao.id_manutencao = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID Manutenção"].Value);

                tbxDescPatri.Text = dgv.SelectedRows[0].Cells["Descrição"].Value.ToString();
                tbxPrevisao.Text = dgv.SelectedRows[0].Cells["Previsão"].Value.ToString();
                tbxObs.Text = dgv.SelectedRows[0].Cells["Motivo"].Value.ToString();
                tbxPatrimonio.Text = dgv.SelectedRows[0].Cells["ID Patrimônio"].Value.ToString();
            }
        }

        private void btnExcluirManut_Click(object sender, EventArgs e)
        {
            manutencao.descPatri = dgvManutencao.SelectedRows[0].Cells["Descrição"].Value.ToString();
            DialogResult res = MessageBox.Show("Confirmar exclusão de manutencao do item " + manutencao.descPatri + "?", "PatriMundi - Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                manutencao.id_manutencao = Convert.ToInt32(dgvManutencao.SelectedRows[0].Cells["ID Manutenção"].Value);
                Banco.excluirManutencao(manutencao.id_manutencao);
                dgvManutencao.DataSource = Banco.ObterManutencao();
            }
            tbxPatrimonio.Text = "";
            tbxDescPatri.Text = "";
            tbxPrevisao.Text = "";
            tbxObs.Text = "";

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            manutencao.descPatri = tbxDescPatri.Text;
            manutencao.previsao = tbxPrevisao.Text;
            manutencao.motivo = tbxObs.Text;
            string nome = dgvManutencao.SelectedRows[0].Cells["Descrição"].Value.ToString();
            DialogResult res = MessageBox.Show("Confirmar edição de manutenção do item " + nome + "?", "PatriMundi - Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                manutencao.id_manutencao = Convert.ToInt32(dgvManutencao.SelectedRows[0].Cells["ID Manutenção"].Value.ToString());
                bool rowsAffected = Banco.editarManutencao(manutencao);
                if (rowsAffected)
                {
                    MessageBox.Show("Item editado com sucesso!", "Edição de manutenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                dgvManutencao.DataSource = Banco.ObterManutencao();

            }
            tbxPatrimonio.Text = "";
            tbxDescPatri.Text = "";
            tbxPrevisao.Text = "";
            tbxObs.Text = "";

        }
    }
}
