using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Peojeto_Prog_Sistem
{
    public partial class FormLogin : Form
    {
        DataTable dt = new DataTable();
        Thread td;
        string login;
        string senha;
        string nomeUsuario;
        int adm;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            login = txbLogin.Text;
            senha = txbSenha.Text;

            if (login == "" || senha == "")
            {
                MessageBox.Show("usuario ou senha invalida");
                txbLogin.Focus();
                return;
            }
            else
            {
                string sql = $"SELECT * FROM usuario_sis WHERE usuario = '{login}' AND senha = '{senha}'";
                dt = Banco.consulta(sql);

                if (dt.Rows.Count == 1)
                {
                    DataRow dataRow = dt.Rows[0];
                    nomeUsuario = dataRow["nome"].ToString();
                    adm = Convert.ToInt32(dataRow["adm"].ToString());

                    this.Close();

                    td = new Thread(abrirDashboard);
                    td.SetApartmentState(ApartmentState.STA);
                    td.Start();
                }
                else
                {
                    MessageBox.Show("Dados Incorretos!");
                }
            }
        }

        public void abrirDashboard(object obj)
        {
            Application.Run(new Dashboard(nomeUsuario, adm));
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

             
            
        
