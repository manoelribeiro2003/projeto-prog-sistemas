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
    }
}
