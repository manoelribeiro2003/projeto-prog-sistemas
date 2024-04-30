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
    public partial class ConsultarUsuarioSis : Form
    {
        int id;
        string nome;
        string senha;
        int adm;
        public ConsultarUsuarioSis()
        {
            InitializeComponent();
        }

        private void ConsultarUsuarioSis_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id as 'ID', usuario as 'Usuário', nome as 'Nome', senha as 'Senha', CASE WHEN adm = 1 THEN 'sim' ELSE 'não' END AS Adm FROM usuario_sis;";
            dgvUsuariosPatri.DataSource = Banco.consulta(sql);
            dgvUsuariosPatri.Columns[0].Width = 50;
        }

        private void dgvUsuariosPatri_DoubleClick(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                id = Convert.ToInt32(dgv.SelectedRows[0].Cells["ID"].Value);

                tbxNomeDeUsuario.Text = dgv.SelectedRows[0].Cells["Usuário"].Value.ToString();
                tbxNome.Text = dgv.SelectedRows[0].Cells["Nome"].Value.ToString();
                tbxSenha.Text = dgv.SelectedRows[0].Cells["Senha"].Value.ToString();
                tbxRepitaSenha.Text = dgv.SelectedRows[0].Cells["Senha"].Value.ToString();
                if (dgv.SelectedRows[0].Cells["Adm"].Value.ToString() == "sim")
                {
                    cbxEAdm.Checked = true;
                }
                else if (dgv.SelectedRows[0].Cells["Adm"].Value.ToString() == "não")
                {
                    cbxEAdm.Checked = false;
                }
            }
        }
    }
}
