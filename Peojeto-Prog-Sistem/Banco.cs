using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;


namespace Peojeto_Prog_Sistem
{
    internal class Banco
    {
        private static SQLiteConnection conexao;

        public static SQLiteConnection ConexaoBanco()
        {
            conexao = new SQLiteConnection("Data Source = ..\\..\\..\\Banco\\patriBanco.db");
            conexao.Open();
            return conexao;
        }
        public static DataTable consulta(string sql)
        {
            SQLiteDataAdapter da;
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

        public static void DmlStatus(string comando, string oldStatus, string newStatus = "")
        {
            if (comando == "INSERT")
            {
                if (existeStatus(newStatus))
                {
                    MessageBox.Show("Este status já está cadastrado!", "Erro");
                }
                else
                {
                    try
                    {
                        using (var cmd = ConexaoBanco().CreateCommand())
                        {
                            cmd.CommandText = $"INSERT INTO configuracoes (ListStatusPatri) VALUES ('{newStatus}')";

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Status cadastrado com sucesso", "PatriMundo - Cadastro de Status");
                            ConexaoBanco().Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Status");
                        ConexaoBanco().Close();
                        throw ex;
                    }
                }
            }
            else if (comando == "UPDATE")
            {
                if (oldStatus != newStatus && newStatus != "")
                {
                    if (existeStatus(oldStatus))
                    {
                        try
                        {
                            using (var cmd = ConexaoBanco().CreateCommand())
                            {
                                cmd.CommandText = $"UPDATE configuracoes SET ListStatusPatri = '{newStatus}' WHERE ListStatusPatri = '{oldStatus}'";

                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Status editado com sucesso", "PatriMundo - Cadastro de Status");
                                ConexaoBanco().Close();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ops!!! erro na edição do status", "PatriMundo - Cadastro de Status");
                            ConexaoBanco().Close();
                            throw ex;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Status já cadastrado!", "Erro");
                }
            }
            else if (comando == "DELETE")
            {
                if (existeStatus(oldStatus))
                {
                    try
                    {
                        using (var cmd = ConexaoBanco().CreateCommand())
                        {
                            cmd.CommandText = $"DELETE from configuracoes WHERE ListStatusPatri = '{oldStatus}'";

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Status deletado com sucesso", "PatriMundo - Cadastro de Status");
                            ConexaoBanco().Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ops!!! erro na deleção do status", "PatriMundo - Cadastro de Status");
                        ConexaoBanco().Close();
                        throw ex;
                    }
                }
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

        private static bool existeStatus(string status)
        {
            DataTable dt = null;
            bool res = false;
            string sql = $"SELECT * FROM configuracoes WHERE ListStatusPatri = '{status}'";
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
                    cmd.CommandText = "INSERT INTO t_manutencao (id_patrimonio, descPatri, previsao, motivo) VALUES (@id_patrimonio, @descPatri, @previsao, @motivo)";
                    cmd.Parameters.AddWithValue("@id_patrimonio", c.id_patrimonio);
                    cmd.Parameters.AddWithValue("@descPatri", c.descPatri);
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
        public static DataTable ObterManutencao(string descPatri = "")
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            if (descPatri == "")
            {
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = "SELECT id_manutencao as 'ID Manutenção', id_patrimonio as 'ID Patrimônio', descPatri as 'Descrição', previsao as 'Previsão', motivo as 'Motivo' FROM t_manutencao";

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
            else 
            {
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM t_manutencao WHERE descPatri = '{descPatri}'";

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
            

        }

        public static DataTable buscarListStatusPatri()
        {
            //Usando apenas DataTable (sem uso de List<>)
            SQLiteDataAdapter da;
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


            //Usando DataTable com auxilio de List<>
            /*SQLiteDataReader reader;
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    List<string> listaStatus = new List<string>();
                    cmd.CommandText = "SELECT ListStatusPatri FROM configuracoes";
                    reader = cmd.ExecuteReader(); //retorna um DataReader

                    //Aqui é como se fosse o Fill()
                    while (reader.Read())//Lê o proximo registro
                    {
                        listaStatus.Add(reader.GetString(0));
                        // substitua 0 pelo índice da coluna que você deseja adicionar à lista
                        //Neste caso estou usando index 0 porque quero a coluna ListStatusPatri
                    }
                    reader.Close();
                    ConexaoBanco().Close();
                    return listaStatus;
                }
            }
            catch (Exception ex)
            {
                ConexaoBanco().Close();
                throw ex;
            }*/



        }

        public static DataTable BuscarDescricao()
        {
            //Usando apenas DataTable (sem uso de List<>)
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT DISTINCT descricaoPatri FROM Patrimonios";
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

        public static DataTable DashboardBuscarPatrimonioEspecifico(string descricaoPatri)
        {
            //Usando apenas DataTable (sem uso de List<>)
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM patrimonios WHERE descricaoPatri = '{descricaoPatri}'";
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

        public static DataTable DashboardBuscarQuantAloc(string descricaoPatri)
        {
            //Usando apenas DataTable (sem uso de List<>)
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"SELECT * FROM patrimonios WHERE descricaoPatri = '{descricaoPatri}' AND locacao != 0";
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
        public static void excluirManutencao(int id_manutencao)
                           
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM t_manutencao WHERE id_manutencao = @id_manutencao";
                    cmd.Parameters.AddWithValue("@id_manutencao", id_manutencao);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cadastro", "PatriMundi - Excluir cadastro de Manutencao");
                ConexaoBanco().Close();
                throw ex;
            }
            
        }

        public static bool editarManutencao(Manutencao manutencao)

        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"UPDATE t_manutencao SET descPatri = '{manutencao.descPatri}', previsao = '{manutencao.previsao}', motivo = '{manutencao.motivo}' WHERE id_manutencao = {manutencao.id_manutencao}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cadastro", "PatriMundi - Edição cadastro de Manutencao");
                ConexaoBanco().Close();
                return false;
            }

        }


    }
}
