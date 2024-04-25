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
                usuariopatri.responsavel = tbxResponsavel.Text;
                usuariopatri.cargo = tbxCargo.Text;
                usuariopatri.setor = cbxSetor.SelectedItem.ToString();
                usuariopatri.subdivisao = cbxSubdivisao.SelectedItem.ToString();

                if (usuariopatri.nome != "" && usuariopatri.responsavel != "" &&
                                usuariopatri.cargo != "" && usuariopatri.setor != "")
                {
                    Banco.cadastrarUserPatri(usuariopatri);
                    tbxNome.Text = "";
                    tbxResponsavel.Text = "";
                    tbxCargo.Text = "";
                    cbxSetor.SelectedIndex = -1;
                    cbxSubdivisao.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch{
                MessageBox.Show("Erro ao realizar cadastro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



            
        }

        private void CadastroUsuarioPatri_Load(object sender, EventArgs e)
        {
            DataTable listSetor = Banco.buscarListLocacoes();
            foreach (DataRow item in listSetor.Rows)
            {
                cbxSetor.Items.Add(item["nome"].ToString());
            }
        }

        private void cbxSetor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable listLocacao = Banco.buscarListLocalizacoes(distinct: false, subdivisao: true, setor: cbxSetor.SelectedItem.ToString());
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
    }
}
