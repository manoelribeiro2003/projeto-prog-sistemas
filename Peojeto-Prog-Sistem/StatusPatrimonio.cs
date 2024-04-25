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
    public partial class StatusPatrimonio : Form
    {
        object itemSelecionado;

        public StatusPatrimonio()
        {
            InitializeComponent();
        }

        private void StatusPatrimonio_Load(object sender, EventArgs e)
        {
            btnAdicionar.Enabled = false;
            if (lbxStatusPatri.SelectedItem == null)
            {
                btnEditar.Enabled = false;
            }
            

            //Usando apenas DataTable (sem uso de List<>)
            DataTable listStatus = Banco.buscarListStatusPatri();
            foreach (DataRow item in listStatus.Rows)
            {
                lbxStatusPatri.Items.Add(item[0].ToString());
            }

            //Usando DataTable com auxilio de List<>
            /*List<string> listStatus = Banco.buscarListStatusPatri();
            foreach (string item in listStatus)
            {
                lbxStatusPatri.Items.Add(item.ToString());
            }*/
        }

        private void tbxAddPatrimonio_TextChanged(object sender, EventArgs e)
        {
            if (tbxAddPatrimonio.Text == "")
            {
                btnAdicionar.Enabled = false;
                btnEditar.Enabled = false;
            }
            else
            {
                if (lbxStatusPatri.SelectedItem == itemSelecionado)
                {
                    btnEditar.Enabled = true;
                }
                btnAdicionar.Enabled = true;
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Banco.DmlStatus("INSERT", "",tbxAddPatrimonio.Text);
            lbxStatusPatri.Items.Clear();
            DataTable listStatus = Banco.buscarListStatusPatri();
            foreach (DataRow item in listStatus.Rows)
            {
                lbxStatusPatri.Items.Add(item[0].ToString());
            }
            btnEditar.Enabled = false;
            tbxAddPatrimonio.Text = "";
            tbxAddPatrimonio.Focus();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lbxStatusPatri.SelectedItem != null)
            {
                Banco.DmlStatus("UPDATE", lbxStatusPatri.SelectedItem.ToString(), tbxAddPatrimonio.Text);
                lbxStatusPatri.Items.Clear();
                DataTable listStatus = Banco.buscarListStatusPatri();
                foreach (DataRow item in listStatus.Rows)
                {
                    lbxStatusPatri.Items.Add(item[0].ToString());
                }
            }

            btnEditar.Enabled = false;
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lbxStatusPatri.SelectedItem != null)
            {
                Banco.DmlStatus("DELETE", lbxStatusPatri.SelectedItem.ToString());
                lbxStatusPatri.Items.Clear();
                DataTable listStatus = Banco.buscarListStatusPatri();
                foreach (DataRow item in listStatus.Rows)
                {
                    lbxStatusPatri.Items.Add(item[0].ToString());
                }
            }
        }

        private void lbxStatusPatri_DoubleClick(object sender, EventArgs e)
        {
            itemSelecionado = lbxStatusPatri.SelectedItem;
            tbxAddPatrimonio.Text = lbxStatusPatri.SelectedItem.ToString();
            btnEditar.Enabled = true;
        }



        private void lbxStatusPatri_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
        }
    }
}
