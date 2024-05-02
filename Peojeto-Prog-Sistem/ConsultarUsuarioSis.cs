using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Peojeto_Prog_Sistem
{
    public partial class ConsultarUsuarioSis : Form
    {
        int id, adm;
        string nome, userName, senha;

        public ConsultarUsuarioSis()
        {
            InitializeComponent();
        }

        private void btnExcluirManut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Confirmar exclusão do usuário " + dgvUsuariosPatri.SelectedRows[0].Cells["Usuário"].Value.ToString() + "?", "PatriMundi - Confirmar exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                
                Banco.excluirUserSis(Convert.ToInt32(dgvUsuariosPatri.SelectedRows[0].Cells["ID"].Value));
                tbxNome.Text = "";
                tbxNomeDeUsuario.Text = "";
                tbxSenha.Text = "";
                tbxRepitaSenha.Text = "";
                cbxEAdm.Checked = false;
                string sql = "SELECT id as 'ID', usuario as 'Usuário', nome as 'Nome', senha as 'Senha', CASE WHEN adm = 1 THEN 'sim' ELSE 'não' END AS Adm FROM usuario_sis;";
                dgvUsuariosPatri.DataSource = Banco.consulta(sql);
            }
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbxSenha.Text == tbxRepitaSenha.Text)
            {
                userName = tbxNomeDeUsuario.Text;
                nome = tbxNome.Text;
                senha = tbxSenha.Text;
                if (cbxEAdm.Checked)
                {
                    adm = 1;
                }
                else
                {
                    adm = 0;
                }

                DialogResult res = MessageBox.Show($"Quer realmente editar o usuário {dgvUsuariosPatri.SelectedRows[0].Cells["Usuário"].Value.ToString()}?", "Editar Usuário", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (res == DialogResult.Yes)
                {
                    if (Banco.editarUserSis(id, userName, nome, senha, adm))
                    {
                        MessageBox.Show("Usuário editado com sucesso", "Edição de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tbxNome.Text = "";
                        tbxNomeDeUsuario.Text = "";
                        tbxSenha.Text = "";
                        tbxRepitaSenha.Text = "";
                        cbxEAdm.Checked = false;

                        string sql = "SELECT id as 'ID', usuario as 'Usuário', nome as 'Nome', senha as 'Senha', CASE WHEN adm = 1 THEN 'sim' ELSE 'não' END AS Adm FROM usuario_sis;";
                        dgvUsuariosPatri.DataSource = Banco.consulta(sql);
                        dgvUsuariosPatri.Columns[0].Width = 50;

                    }
                    else
                    {
                        MessageBox.Show("Não foi possível editar o usuário", "Edição de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            else
            {
                MessageBox.Show("As senhas são divergentes!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
