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
    public partial class ConsultarUsuarioPatri : Form
    {
        public ConsultarUsuarioPatri()
        {
            InitializeComponent();
        }

        private void ConsultarUsuarioPatri_Load(object sender, EventArgs e)
        {
            string sql = "SELECT id as 'ID', nome as 'Nome', responsavel as 'Responsável', cargo as 'Cargo', setor as 'Setor', subdivisao as 'Subdivisão' FROM t_usuario_patri";
            dgvUsuariosPatri.DataSource = Banco.consulta(sql);
            dgvUsuariosPatri.Columns[0].Width = 50;
        }

        private void cbxSetor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable listLocacao = Banco.buscarListLocalizacoes(distinct: false, subdivisao: true, setor: cbxSetor.SelectedItem.ToString());
            cbxSubdivisao.Items.Clear();
            foreach (DataRow item in listLocacao.Rows)
            {
                if (item["subDivisao"].ToString() != "" && item["subDivisao"].ToString() != null)
                {
                    cbxSubdivisao.Items.Add(item["subDivisao"].ToString());
                }
            }
            cbxSubdivisao.Items.Add(cbxSetor.SelectedItem.ToString());
        }
    }
}
