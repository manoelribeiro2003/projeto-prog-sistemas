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
    public partial class CadastroUsuarioSistema : Form
    {
        public CadastroUsuarioSistema()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UsuarioSistema usuarioSistema = new UsuarioSistema();
            usuarioSistema.usuario = tbxNomeDeUsuario.Text;
            usuarioSistema.senha = tbxSenha.Text;
            if (cbxEAdm.Checked)
            {
                usuarioSistema.adm = 1;
            }
            else
            {
                usuarioSistema.adm = 0;
            }
            usuarioSistema.nome = tbxNome.Text;

            if (tbxSenha.Text == tbxRepitaSenha.Text)
            {
                if (usuarioSistema.usuario != "" && usuarioSistema.senha != "" &&
                                usuarioSistema.nome != "")
                {
                    Banco.cadastraruserSis(usuarioSistema);
                    tbxNomeDeUsuario.Text = "";
                    tbxNome.Text = "";
                    tbxSenha.Text = "";
                    tbxRepitaSenha.Text = "";
                    cbxEAdm.Checked = false;
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos obrigatórios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("As senhas são divergentes", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
