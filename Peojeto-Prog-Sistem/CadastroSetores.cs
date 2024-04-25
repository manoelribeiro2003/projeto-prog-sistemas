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
    public partial class CadastroSetores : Form
    {
        public CadastroSetores()
        {
            InitializeComponent();
        }

        private void CadastroSetores_Load(object sender, EventArgs e)
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
        }
    }
}
