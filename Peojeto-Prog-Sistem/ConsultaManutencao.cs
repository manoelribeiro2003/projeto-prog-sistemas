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
        Manutencao c = new Manutencao();
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
                DataTable dt = new DataTable();
                string vid = dgv.SelectedRows[0].Cells[0].Value.ToString();
                c.id_manutencao = Convert.ToInt32(dgv.SelectedRows[0].Cells["id_manutencao"].Value);
                tbxCadastro.Text = dgv.SelectedRows[0].Cells["cadastro"].Value.ToString();
                tbxPrevisao.Text = dgv.SelectedRows[0].Cells["previsao"].Value.ToString();
                tbxObs.Text = dgv.SelectedRows[0].Cells["motivo"].Value.ToString();
            }
        }

        private void btnExcluirManut_Click(object sender, EventArgs e)
        {
            //c.cadastro = dgvManutencao.SelectedRows[0].Cells["cadastro"].Value.ToString();
            DialogResult res = MessageBox.Show("Confirmar exclusão do curriculo de " + c.cadastro + "?", "PatriMundi - Confirmar exclusao", MessageBox.YesNo);
            if (res == DialogResult.Yes)
            {
                c.id_manutencao = Convert.ToInt32(dgvManutencao.SelectedRows[0].Cells["id_patrimonio"].Value);
                Banco.excluirCurriclo(c.id_manutencao);
                dgvManutencao.DataSource = Banco.ObterManutencao();
            }
        }
    }
}
