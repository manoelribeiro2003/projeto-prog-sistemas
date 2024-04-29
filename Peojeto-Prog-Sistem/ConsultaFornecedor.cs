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
    public partial class ConsultaFornecedor : Form
    {
        public ConsultaFornecedor()
        {
            InitializeComponent();
        }

        private void ConsultaFornecedor_Load(object sender, EventArgs e)
        {
            dgvFornecedor.DataSource = Banco.ObterManutencao();
            dgvFornecedor.Columns[0].Width = 50;
        }
    }
}
