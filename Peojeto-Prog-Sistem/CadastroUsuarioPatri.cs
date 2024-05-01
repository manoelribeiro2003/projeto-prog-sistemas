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
    public partial class CadastroUsuarioPatri : Form
    {
        public CadastroUsuarioPatri()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioPatri usuariopatri = new UsuarioPatri();
                usuariopatri.nome = tbxNome.Text;
                if (cbxEGerente.Checked)
                {
                    usuariopatri.responsavel = tbxEGerente.Text;
                }
                else
                {
                    usuariopatri.responsavel = cbxResponsável.SelectedItem.ToString();
                }
                usuariopatri.cargo = tbxCargo.Text;
                usuariopatri.setor = cbxSetor.SelectedItem.ToString();
                usuariopatri.subdivisao = cbxSubdivisao.SelectedItem.ToString();

                if (usuariopatri.nome != "" && usuariopatri.responsavel != "" &&
                                usuariopatri.cargo != "" && usuariopatri.setor != "")
                {
                    Banco.cadastrarUserPatri(usuariopatri);
                    tbxNome.Text = "";
                    cbxResponsável.SelectedIndex = -1;
                    tbxCargo.Text = "";
                    tbxEGerente.Text = "";
                    cbxSetor.SelectedIndex = -1;
                    cbxSubdivisao.SelectedIndex = -1;
                    cbxEGerente.Checked = false;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Erro ao realizar cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CadastroUsuarioPatri_Load(object sender, EventArgs e)
        {
            tbxEGerente.Enabled = false;

            DataTable listSetor = Banco.buscarListLocacoes();
            foreach (DataRow item in listSetor.Rows)
            {
                cbxSetor.Items.Add(item["nome"].ToString());
            }

            string sql = "SELECT DISTINCT responsavel FROM t_usuario_patri";
            DataTable listResponsavel = Banco.consulta(sql);
            foreach (DataRow item in listResponsavel.Rows)
            {
                cbxResponsável.Items.Add(item["responsavel"].ToString());
            }
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

        private void cbxEGerente_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxEGerente.Checked)
            {
                tbxEGerente.Enabled = true;
                tbxEGerente.Text = tbxNome.Text;
                cbxResponsável.SelectedIndex = -1;
                cbxResponsável.Enabled = false;
                tbxCargo.Text = "Gerente";
            }
            else
            {
                tbxEGerente.Enabled = false;
                cbxResponsável.Enabled = true;
                tbxCargo.Text = "";
            }
        }
    }
}
