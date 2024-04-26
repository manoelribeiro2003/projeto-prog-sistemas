using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;


namespace Peojeto_Prog_Sistem
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        private static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\Banco\\patriBanco.db");
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
        public static void cadastrarPatrimonio(Patrimonio c)
        {
            if (existePatrimonio(c))
            {
                MessageBox.Show("Esse patrimônio já está cadastrado", "PatriMundo - Cadastro de Patrimônio");
                return;
            }
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preenche o comando com a string
                    cmd.CommandText = "INSERT INTO patrimonios (descricaoPatri, nf, fornecedor, dtAquisicao, dtGarantia, status, locacao, localizacao, operador, gestorResp, valor, obs)" +
                        " VALUES (@descricaoPatri, @nf, @fornecedor, @dtAquisicao, @dtGarantia, @status, @locacao, @localizacao, @operador, @gestorResp, @valor, @obs)";
                    cmd.Parameters.AddWithValue("@descricaoPatri", c.descricaoPatri);
                    cmd.Parameters.AddWithValue("@nf", c.nf);
                    cmd.Parameters.AddWithValue("@fornecedor", c.fornecedor);
                    cmd.Parameters.AddWithValue("@dtAquisicao", c.dtAquisicao);
                    cmd.Parameters.AddWithValue("@dtGarantia", c.dtGarantia);
                    cmd.Parameters.AddWithValue("@status", c.status);
                    cmd.Parameters.AddWithValue("@locacao", c.locacao);
                    cmd.Parameters.AddWithValue("@localizacao", c.localizacao);
                    cmd.Parameters.AddWithValue("@operador", c.operador);
                    cmd.Parameters.AddWithValue("@gestorResp", c.gestorResp);
                    cmd.Parameters.AddWithValue("@valor", c.valor);
                    cmd.Parameters.AddWithValue("@obs", c.obs);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Patrimônio cadastrado com sucesso", "PatriMundo - Cadastro de Patrimônio");
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Patrimônio");
                ConexaoBanco().Close();
                throw ex;
            }
           
        }
        private static bool existePatrimonio(Patrimonio c)
        {
            DataTable dt = null;
            bool res = false;
            string sql = "SELECT descricaoPatri FROM patrimonios WHERE id = '" + c.descricaoPatri + "'";
            dt = Banco.consulta(sql);
            if (dt.Rows.Count > 0) 
            {
                res = true;
            }
            return res;
        }
        public static void cadastroManutencao(Manutencao c)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preenche o comando com a string
                    cmd.CommandText = "INSERT INTO t_manutencao (cadastro, previsao, motivo) VALUES (@cadastro, @previsao, @motivo)";
                    cmd.Parameters.AddWithValue("@cadastro", c.cadastro);
                    cmd.Parameters.AddWithValue("@previsao", c.previsao);
                    cmd.Parameters.AddWithValue("@motivo", c.motivo);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Manutenção cadastrada com sucesso", "PatriMundo - Cadastro de Manutenção");
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Manutenção");
                ConexaoBanco().Close();
                throw ex;
            }
        }
        /* cadastro fornecedor */
        private static bool existeFornecedor(Fornecedor c)
        {
            DataTable dt = null;
            bool res = false;
            string sql = "SELECT cnpj FROM t_fornecedores WHERE cnpj = '" + c.cnpj + "'";
            dt = Banco.consulta(sql);
            if (dt.Rows.Count > 0)
            {
                res = true;
            }
            return res;
        }
        public static void CadastroFornecedor(Fornecedor c)
        {
            if (existeFornecedor(c))
            {
                MessageBox.Show("Esse Fornecedor já está cadastrado", "PatriMundo - Cadastro de Fornecedor");
                return;
            }
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preenche o comando com a string
                    cmd.CommandText = "INSERT INTO t_fornecedores (cnpj, razaoSocial, enderecoFornecedor, contato, obs) VALUES (@cnpj, @razaoSocial, @enderecoFornecedor, @contato, @obs)";
                    cmd.Parameters.AddWithValue("@cnpj", c.cnpj);
                    cmd.Parameters.AddWithValue("@razaoSocial", c.razaosocial);
                    cmd.Parameters.AddWithValue("@enderecoFornecedor", c.endFornecedor);
                    cmd.Parameters.AddWithValue("@contato", c.contato);
                    cmd.Parameters.AddWithValue("@obs", c.obs);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor cadastrado com sucesso", "PatriMundo - Cadastro de Fornecedores");
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Manutenção");
                ConexaoBanco().Close();
                throw ex;
            }
        }
        /*Cadastro de setor*/
        public static void CadastrarSetor2(CadastrarSetor c)
        {
            
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preenche o comando com a string
                    cmd.CommandText = "INSERT INTO t_setor (nome, subDivisao) VALUES (@setor, @subDivisao)";
                    cmd.Parameters.AddWithValue("@setor", c.nome);
                    cmd.Parameters.AddWithValue("@subDivisao", c.subDivisao);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Setpr cadastrado com sucesso!!!", "PatriMundo - Cadastro de Setor");
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Setor");
                ConexaoBanco().Close();
                throw ex;
            }
        }
        public static DataTable ObterManutencao()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT id_manutencao, cadastro, previsao, motivo FROM t_manutencao";

                    da = new SQLiteDataAdapter(cmd.CommandText, ConexaoBanco());
                    da.Fill(dt);
                    ConexaoBanco().Close();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static DataTable buscarListStatusPatri()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT ListStatusPatri FROM configuracoes";

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
