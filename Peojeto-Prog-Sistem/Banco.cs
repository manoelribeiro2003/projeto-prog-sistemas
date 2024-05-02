using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


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
                    MessageBox.Show("Patrimônio cadastrado com sucesso", "PatriMundo - Cadastro de Patrimônio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Patrimônio", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Manutenção cadastrada com sucesso", "PatriMundo - Cadastro de Manutenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Manutenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Fornecedor cadastrado com sucesso", "PatriMundo - Cadastro de Fornecedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public static void CadastrarSetor(CadastrarSetor c)
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
                    MessageBox.Show("Setor cadastrado com sucesso!!!", "PatriMundo - Cadastro de Setor");
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
        public static void cadastrarUserSis(UsuarioSistema usuarioSistema)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preenche o comando com a string
                    cmd.CommandText = $"INSERT INTO usuario_sis (usuario, senha, adm, nome) VALUES ('{usuarioSistema.usuario}', '{usuarioSistema.senha}', {usuarioSistema.adm}, '{usuarioSistema.nome}')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário cadastrado com sucesso!", "PatriMundo - Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                throw ex;
            }
        }

        public static void cadastrarUserPatri(UsuarioPatri usuarioPatri)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preenche o comando com a string
                    cmd.CommandText = $"INSERT INTO t_usuario_patri (nome, responsavel, cargo, setor, subdivisao) VALUES ('{usuarioPatri.nome}', '{usuarioPatri.responsavel}', '{usuarioPatri.cargo}', '{usuarioPatri.setor}', '{usuarioPatri.subdivisao}')";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário cadastrado com sucesso!!!", "PatriMundo - Cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConexaoBanco().Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ops!!! erro no Cadastro", "PatriMundo - Cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        //trazer os dados da tabela fornecedores para o dataGridView

        public static DataTable ObterFornecedor(string razaoSocial = "")
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            if (razaoSocial == "")
            {
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = "SELECT id_fornecedor as 'ID', cnpj as 'CNPJ', razaoSocial as 'R Social', enderecoFornecedor as 'Endereço', contato as 'Contato', obs as 'Obs' FROM t_fornecedores";

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
                        cmd.CommandText = $"SELECT * FROM t_fornecedores WHERE razaoSocial = '{razaoSocial}'";

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

        public static DataTable ObterSetores()
        {
            SQLiteDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT id as 'ID', nome as 'Nome', subDivisao as 'Subdivisão' FROM t_setor";

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

        public static DataTable buscarListLocalizacoes(bool distinct = false, bool subdivisao = false, string setor = "")
        {
            //Usando apenas DataTable (sem uso de List<>)
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();

            if (distinct == true && subdivisao == false && setor == "")
            {
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = "SELECT DISTINCT nome FROM t_setor";
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
            else if (distinct == false && subdivisao == true && setor == "")
            {
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = "SELECT subDivisao FROM t_setor";
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
            else if (distinct == false && subdivisao == true && setor != "")
            {
                try
                {
                    using (var cmd = ConexaoBanco().CreateCommand())
                    {
                        cmd.CommandText = $"SELECT * FROM t_setor WHERE nome = '{setor}' AND subDivisao != ''";
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
            else
            {
                return dt;
            }

        }

        public static DataTable buscarListLocacoes()
        {
            //Locacoes sao as subdivisoes. Se nao houver subdivisao, entao é so o nome do setor mesmo

            SQLiteDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT DISTINCT nome FROM t_setor";
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
        public static DataTable buscarListUserPatri(string setor)
        {
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"SELECT DISTINCT * FROM T_usuario_patri WHERE setor = '{setor}'";
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

        public static DataTable buscarListGestor()
        {
            SQLiteDataAdapter da;
            DataTable dt = new DataTable();

            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "SELECT DISTINCT responsavel FROM T_usuario_patri";
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
                    cmd.CommandText = $"SELECT * FROM patrimonios WHERE status = 'Alocado' AND descricaoPatri = '{descricaoPatri}'";
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
        public static void excluirManutencao(int id_manutencao, int id_patri)

        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM t_manutencao WHERE id_manutencao = @id_manutencao";
                    cmd.Parameters.AddWithValue("@id_manutencao", id_manutencao);
                    int affectedRows = cmd.ExecuteNonQuery();
                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Manutenção excluída com sucesso!", "PatriMundi - Excluir cadastro de Manutencao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    cmd.CommandText = "UPDATE patrimonios SET status = 'Alocado' WHERE id = @id_patri";
                    cmd.Parameters.AddWithValue("@id_patri", id_patri);
                    cmd.ExecuteNonQuery();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cadastro", "PatriMundi - Excluir cadastro de Manutencao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                throw ex;
            }

        }
        public static void excluirUserPatri(int id)

        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"DELETE FROM t_usuario_patri WHERE id = {id}";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Usuário excluído!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cadastro", "PatriMundi - Excluir cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static void excluirUserSis(int id)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"DELETE FROM usuario_sis WHERE id = {id}";
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Usuário excluído!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cadastro", "PatriMundi - Excluir cadastro de Usuário", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static void editarPatrimonio(Patrimonio p)

        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"UPDATE patrimonios SET descricaoPatri = '{p.descricaoPatri}', " +
                        $"nf = '{p.nf}', fornecedor = '{p.fornecedor}', dtAquisicao = '{p.dtAquisicao}', " +
                        $"dtGarantia = '{p.dtGarantia}', status = '{p.status}', locacao = '{p.locacao}', " +
                        $"localizacao = '{p.localizacao}', operador = '{p.operador}', gestorResp = '{p.gestorResp}', " +
                        $"valor = '{p.valor}', obs = '{p.obs}' WHERE id = {p.id}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patrimônio editado com sucesso!", "PatriMundi - Edição de Patrimônio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar patrimonio", "PatriMundi - Edição de patrimônio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
            }

        }

        public static void editarUserPatri(int id, string nome, string responsavel, string cargo, string setor, string subdivisao)

        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"UPDATE t_usuario_patri SET nome = '{nome}', responsavel = '{responsavel}', cargo = '{cargo}', setor = '{setor}', subDivisao = '{subdivisao}' WHERE id = {id}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Usuário editado com sucesso!", "PatriMundi - Edição cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cadastro", "PatriMundi - Edição cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
            }

        }

        public static bool editarUserSis(int id, string userName, string nome, string senha, int adm)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"UPDATE usuario_sis SET usuario = '{userName}', senha = '{senha}', adm = {adm}, nome = '{nome}' WHERE id = {id}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cadastro", "PatriMundi - Edição cadastro de Usuários", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                return false;
            }
        }

        public static bool editarSetor(int id, string nome, string subdivisao)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"UPDATE t_setor SET nome = '{nome}', subDivisao = '{subdivisao}' WHERE id = {id}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar cadastro", "PatriMundi - Edição cadastro de Setores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                return false;
            }
        }

        public static bool editarPatrimonioManutencao(int id)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"UPDATE patrimonios SET status = 'Em manutenção' WHERE id = {id}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar patrimônio\nCertifique-se que o Patrimônio está no setor de Manutenção", "PatriMundi - Edição de Patrimônios", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                return false;
            }
        }
        public static void editarFornecedor(Fornecedor fornecedor)

        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    //preencer o comando com a string sql para alteração
                    cmd.CommandText = "UPDATE t_fornecedores SET cnpj = @cnpj, razaoSocial = @razaoSocial, enderecoFornecedor = @enderecoFornecedor, contato = @contato, obs = @obs  WHERE id_fornecedor = @id_fornecedor";
                    cmd.Parameters.AddWithValue("@id_fornecedor", fornecedor.id_Fornecedor);
                    cmd.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                    cmd.Parameters.AddWithValue("@razaoSocial", fornecedor.razaosocial);
                    cmd.Parameters.AddWithValue("@enderecoFornecedor", fornecedor.endFornecedor);
                    cmd.Parameters.AddWithValue("@contato", fornecedor.contato);
                    cmd.Parameters.AddWithValue("@obs", fornecedor.obs);


                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor editado com sucesso!", "Edição de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ConexaoBanco().Clone();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível editar o fornecedor", "Edição de fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw ex;
            }
        }
        public static void excluirFornecedor(int id_fornecedor)

        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM t_fornecedores WHERE id_fornecedor = @id_fornecedor";
                    cmd.Parameters.AddWithValue("@id_fornecedor", id_fornecedor);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Fornecedor excluído com sucesso!", "PatriMundi - Excluir cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cadastro", "PatriMundi - Excluir cadastro de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static void excluirSetor(int id)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"DELETE FROM t_setor WHERE id = {id}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Setor excluído com sucesso!", "PatriMundi - Excluir cadastro de Setor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir cadastro", "PatriMundi - Excluir cadastro de Setor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                throw ex;
            }

        }

        public static void excluirPatrimonio(Patrimonio p)
        {
            try
            {
                using (var cmd = ConexaoBanco().CreateCommand())
                {
                    cmd.CommandText = $"DELETE FROM patrimonios WHERE id = {p.id}";
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Patrimônio excluído com sucesso!", "PatriMundi - Excluir patrimônio", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir patrimônio", "PatriMundi - Excluir Patrimônio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConexaoBanco().Close();
                throw ex;
            }
        }



    }
}
