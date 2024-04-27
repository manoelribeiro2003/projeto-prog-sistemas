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
    public partial class CadastroManutencao : Form
    {
        Manutencao manutencao = new Manutencao();

        public CadastroManutencao()
        {
            InitializeComponent();
        }

        private void CadastroManutencao_Load(object sender, EventArgs e)
        {
            string nome = "";
            string sql = "SELECT id, descricaoPatri FROM patrimonios";
            DataTable listDesc = Banco.consulta(sql);
            foreach (DataRow item in listDesc.Rows)
            {
                nome  = item[0].ToString() + " - " + item[1].ToString();
                cbxPatrimonio.Items.Add(nome);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void cbxPatrimonio_SelectedIndexChanged(object sender, EventArgs e)
        {
            manutencao.item_patrimonio = cbxPatrimonio.SelectedItem.ToString();
            MessageBox.Show("Item: " + manutencao.item_patrimonio);

            string id_patri = manutencao.item_patrimonio.ToString();
            

        }

        /*private void btnSalvar_Click(object sender, EventArgs e)
        {
            Manutencao manutencao = new Manutencao();
            manutencao.cadastro = Convert.ToInt32(cbxPatrimonio.Text);
            manutencao.previsao = dtbManutPrevisao.Text;
            manutencao.motivo = rtbManutMotivo.Text;

            Banco.cadastroManutencao(manutencao);

        }*/
    }
}
