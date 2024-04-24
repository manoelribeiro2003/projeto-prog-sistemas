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
    public partial class FormLogin : Form
    {
        DataTable dt = new DataTable();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // pegar os valores das caixas de texto tbxLogin e tbxSenha
            string login = txbLogin.Text;
            string senha = txbSenha.Text;
            // verificar se Usuário e senha são válido

            if (login == "" || senha == "")
            {
                MessageBox.Show("usuario ou senha invalida");
                txbLogin.Focus();
                return;
            }
            string sql = "SELECT * FROM t_usuarios WHERE usuario = '" + login + "' AND senha = '" + senha + "'";
            dt = banco.consulta(sql);
            if (dt.Rows.Count == 1)
            {
                Form2 d = new Form2();
                d.Show();
            }
            else
            {
                MessageBox.Show("Usuário e senha incorreta");
            }
            
        }
    }
}
                /*if (senha == "admin123")
                {
                    MsnConfirm.ForeColor = Color.Green;
                    MsnConfirm.Text = "Bem-Vindo! Ok, Acesso Confirmado!";

                }
                else
                {
                    MsnConfirm.ForeColor = Color.Red;
                    MsnConfirm.Text = "Senha incorreta!";
                }
            }
            else
            {
                MsnConfirm.ForeColor = Color.Red;
                MsnConfirm.Text = "Login incorreto.";
            }
            // modificar o label MsnConfirm
        }*/

             
            
        
