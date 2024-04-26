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
        public StatusPatrimonio()
        {
            InitializeComponent();

        }

        private void StatusPatrimonio_Load(object sender, EventArgs e)
        {
            lbxStatusPatri.DataSource =  Banco.buscarListStatusPatri().ToString();
            //lbxStatusPatri.Items.Add();


            //dgvManutencao.DataSource = Banco.ObterManutencao();
            //dgvManutencao.Columns[0].Width = 50;
        }
    }
}
