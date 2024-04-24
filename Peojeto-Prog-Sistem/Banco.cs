using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace Peojeto_Prog_Sistem
{
    internal class banco
    {
        private static SQLiteConnection conexao;
        private static SQLiteConnection ConexaoBanco()

        {
            conexao = new SQLiteConnection("Data Source = ..\\..\\banco\\patri.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql) 
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = sql;
                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }        
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }
        }
    }
}
