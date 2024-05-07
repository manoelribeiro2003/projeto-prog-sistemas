﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Web.UI.WebControls;
using System.Threading;
using System.IO;

namespace Peojeto_Prog_Sistem
{
    public partial class Dashboard : Form
    {
        int adm;
        public Dashboard(string login, int adm)
        {
            InitializeComponent();
            lblUserName.Text = login;
            this.adm = adm;
            if (this.adm == 1)
            {
                usuarioToolStripMenuItem.Enabled = true;
                setorToolStripMenuItem.Enabled = true;
                configuracoesToolStripMenuItem.Enabled = true;
                usuárioDoSistemaToolStripMenuItem.Enabled = true;

            }
            else
            {
                usuarioToolStripMenuItem.Enabled = false;
                setorToolStripMenuItem.Enabled = false;
                configuracoesToolStripMenuItem.Enabled = false;
                usuárioDoSistemaToolStripMenuItem.Enabled = false;
            }

        }

        private void patrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroPatrimonio cp = new CadastroPatrimonio();
            cp.ShowDialog();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFornecedor cf = new CadastroFornecedor();
            cf.ShowDialog();
        }

        private void setoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setor mfcs = new setor();
            mfcs.ShowDialog();
        }

        private void cadastrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CadastroManutencao cm = new CadastroManutencao();
            cm.ShowDialog();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaManutencao conManu = new ConsultaManutencao();
            conManu.ShowDialog();
        }

        private void statusDePatrimônioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatusPatrimonio statusPatrimonio = new StatusPatrimonio();
            statusPatrimonio.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            //Usando apenas DataTable (sem uso de List<>)
            DataTable listDesc = Banco.BuscarDescricao();
            foreach (DataRow item in listDesc.Rows)
            {
                cbxPatrimonio.Items.Add(item[0].ToString());
            }
        }

        private void cbxPatrimonio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //Usando apenas DataTable (sem uso de List<>)
            string descricaoPatri = cbxPatrimonio.SelectedItem.ToString();

            DataTable dtQuantidade = Banco.DashboardBuscarPatrimonioEspecifico(descricaoPatri);
            tbxQuantidade.Text = Convert.ToString(dtQuantidade.Rows.Count);

            DataTable dtQuantAloc = Banco.DashboardBuscarQuantAloc(descricaoPatri);
            tbxAlocados.Text = Convert.ToString(dtQuantAloc.Rows.Count);

            DataTable dtQuantManut = Banco.ObterManutencao(descricaoPatri);
            tbxManutencao.Text = Convert.ToString(dtQuantManut.Rows.Count);

            string sql = $"SELECT * FROM patrimonios WHERE status = 'Em manutenção' AND descricaoPatri = '{descricaoPatri}'";
            DataTable dtQuantManutencao = Banco.consulta(sql);
            int quantManut = dtQuantManutencao.Rows.Count;

            sql = $"SELECT * FROM patrimonios WHERE descricaoPatri = '{descricaoPatri}'";
            DataTable dtQuantTotal = Banco.consulta(sql);
            int total = dtQuantTotal.Rows.Count;

            int disp = total - (quantManut + dtQuantAloc.Rows.Count);

            tbxDisponíveis.Text = Convert.ToString(disp);



        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Thread td = new Thread(fecharDashboard);
            td.SetApartmentState(ApartmentState.STA);
            td.Start();
        }

        private void fecharDashboard()
        {
            this.Close();

            Application.Run(new FormLogin());

        }

        

        private void usuarioDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuarioSistema usuarioSistema = new CadastroUsuarioSistema();
            usuarioSistema.ShowDialog();
        }

        private void usuarioPatrimonioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroUsuarioPatri cadastroUsuarioPatri = new CadastroUsuarioPatri();
            cadastroUsuarioPatri.ShowDialog();
        }

        private void cadastroDeSetoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarSetores consultarSetores = new ConsultarSetores();
            consultarSetores.ShowDialog();
        }

        private void cbxPatrimonio_Click(object sender, EventArgs e)
        {
            DataTable listDesc = Banco.BuscarDescricao();
            cbxPatrimonio.Items.Clear();
            foreach (DataRow item in listDesc.Rows)
            {
                cbxPatrimonio.Items.Add(item[0].ToString());
            }
        }

        private void usuárioDePatrimônioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuarioPatri cup = new ConsultarUsuarioPatri();
            cup.ShowDialog();
        }

        private void fornecedorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaFornecedor cF = new ConsultaFornecedor();
            cF.ShowDialog();
        }

        private void usuárioDoSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarUsuarioSis cus = new ConsultarUsuarioSis();
            cus.ShowDialog();
        }

        private void patrimonioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarPatrimonio cs = new ConsultarPatrimonio();
            cs.ShowDialog();
        }

        private void Dashboard_Load_1(object sender, EventArgs e)
        {

        }

        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                // Get current date and time
                string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");

                // Set the file name and path
                string filePath = @"C:\Backup\" + timestamp + ".sql";

                // Set the content to be saved in the file
                string content = "This is the content to be saved in the backup file.";

                // Save the content to the file
                File.WriteAllText(filePath, content);

                // Show a message box to confirm that the backup was successful
                MessageBox.Show("Backup realizado com sucesso nome do arquivo " + timestamp +" ", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
    }
}
