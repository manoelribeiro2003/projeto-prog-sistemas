--
-- Arquivo gerado com SQLiteStudio v3.4.4 em seg abr 29 09:05:36 2024
--
-- Codificação de texto usada: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Tabela: configuracoes
CREATE TABLE IF NOT EXISTS configuracoes (ListStatusPatri TEXT (110) UNIQUE);
INSERT INTO configuracoes (ListStatusPatri) VALUES ('Em manutenção');
INSERT INTO configuracoes (ListStatusPatri) VALUES ('Perdido');
INSERT INTO configuracoes (ListStatusPatri) VALUES ('Emprestado');
INSERT INTO configuracoes (ListStatusPatri) VALUES ('Vendido');
INSERT INTO configuracoes (ListStatusPatri) VALUES ('Alocado');
INSERT INTO configuracoes (ListStatusPatri) VALUES ('Inativo');
INSERT INTO configuracoes (ListStatusPatri) VALUES ('Em estoque');

-- Tabela: patrimonios
CREATE TABLE IF NOT EXISTS patrimonios (id INTEGER PRIMARY KEY AUTOINCREMENT, descricaoPatri TEXT (50) NOT NULL, nf TEXT (20) NOT NULL, fornecedor TEXT (50) NOT NULL, dtAquisicao TEXT (50) NOT NULL, dtGarantia TEXT (50) NOT NULL, status TEXT (50) NOT NULL, locacao TEXT (50), localizacao TEXT NOT NULL, operador TEXT (50), gestorResp TEXT (20), valor TEXT (30) NOT NULL, obs TEXT (300));
INSERT INTO patrimonios (id, descricaoPatri, nf, fornecedor, dtAquisicao, dtGarantia, status, locacao, localizacao, operador, gestorResp, valor, obs) VALUES (12, 'Calcualdora', '123456789', 'Casas Assunção', 'domingo, 28 de abril de 2024', 'domingo, 28 de abril de 2024', 'Em manutenção', 'Manutenção', 'Depósito', 'Manoel Ribeiro', 'Francisco Neves', '25', '');
INSERT INTO patrimonios (id, descricaoPatri, nf, fornecedor, dtAquisicao, dtGarantia, status, locacao, localizacao, operador, gestorResp, valor, obs) VALUES (13, 'Notebook Dell', '123456789', 'Terabyte', 'domingo, 28 de abril de 2024', 'domingo, 28 de abril de 2024', 'Perdido', '', 'Administração', '', '', '2000', '');
INSERT INTO patrimonios (id, descricaoPatri, nf, fornecedor, dtAquisicao, dtGarantia, status, locacao, localizacao, operador, gestorResp, valor, obs) VALUES (14, 'Notebook Dell', '123456789', 'Terabyte', 'domingo, 28 de abril de 2024', 'domingo, 28 de abril de 2024', 'Alocado', 'TI', 'TI', 'Francisco Thiago', 'Francisco Neves', '4000', 'Reposição');
INSERT INTO patrimonios (id, descricaoPatri, nf, fornecedor, dtAquisicao, dtGarantia, status, locacao, localizacao, operador, gestorResp, valor, obs) VALUES (15, 'Iphone', '1234', 'Apple', 'segunda-feira, 29 de abril de 2024', 'segunda-feira, 29 de abril de 2024', 'Em manutenção', 'Manutenção', 'Logística', 'Mauricio', 'Mauricio', '4500', 'Este equipamento foi adquirido com recursos externo');

-- Tabela: t_fornecedores
CREATE TABLE IF NOT EXISTS t_fornecedores (id_fornecedor INTEGER PRIMARY KEY AUTOINCREMENT, cnpj TEXT (30) UNIQUE NOT NULL, razaoSocial TEXT (100) NOT NULL, enderecoFornecedor TEXT (100) NOT NULL, contato TEXT (100) NOT NULL, obs TEXT (200));
INSERT INTO t_fornecedores (id_fornecedor, cnpj, razaoSocial, enderecoFornecedor, contato, obs) VALUES (1, '123', 'Mss', 'End 1', 'Mauricio', NULL);
INSERT INTO t_fornecedores (id_fornecedor, cnpj, razaoSocial, enderecoFornecedor, contato, obs) VALUES (2, '1234', '1', '1', '1', NULL);
INSERT INTO t_fornecedores (id_fornecedor, cnpj, razaoSocial, enderecoFornecedor, contato, obs) VALUES (3, '12345', 'q', 'q', 'q', NULL);
INSERT INTO t_fornecedores (id_fornecedor, cnpj, razaoSocial, enderecoFornecedor, contato, obs) VALUES (4, '123456789', 'Terabyte Shop', 'Rua 1223', '889922334455', 'Observacao 1');

-- Tabela: t_manutencao
CREATE TABLE IF NOT EXISTS t_manutencao (id_manutencao INTEGER PRIMARY KEY AUTOINCREMENT, id_patrimonio REFERENCES patrimonios (id), descPatri TEXT, previsao TEXT NOT NULL, motivo NOT NULL);
INSERT INTO t_manutencao (id_manutencao, id_patrimonio, descPatri, previsao, motivo) VALUES (16, 12, 'Calcualdora', 'domingo, 28 de abril de 2024', 'Display Queimado');
INSERT INTO t_manutencao (id_manutencao, id_patrimonio, descPatri, previsao, motivo) VALUES (17, 15, 'Iphone', 'quarta-feira, 29 de maio de 2024', 'Esse equipamento teve problemas na ativação');

-- Tabela: t_setor
CREATE TABLE IF NOT EXISTS t_setor (id INTEGER PRIMARY KEY AUTOINCREMENT, nome TEXT (30) NOT NULL, subDivisao TEXT (30));
INSERT INTO t_setor (id, nome, subDivisao) VALUES (1, 'Administração', 'Sala da Gerência');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (2, 'RH', '');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (3, 'Logística', 'Faturamento');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (5, 'Logística', 'Cobrança');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (6, 'Administração', 'Vendas');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (7, 'Administração', NULL);
INSERT INTO t_setor (id, nome, subDivisao) VALUES (8, 'Financeiro', NULL);
INSERT INTO t_setor (id, nome, subDivisao) VALUES (10, 'Depósito', '');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (11, 'Depósito', 'Rua 1');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (12, 'Logística', 'Sala Logística');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (13, 'TI', '');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (14, 'Teste 1', 'Teste');
INSERT INTO t_setor (id, nome, subDivisao) VALUES (15, 'Manutenção', NULL);

-- Tabela: t_usuario_patri
CREATE TABLE IF NOT EXISTS t_usuario_patri (id INTEGER PRIMARY KEY AUTOINCREMENT, nome TEXT (30) NOT NULL, responsavel TEXT (30) NOT NULL, cargo TEXT (30) NOT NULL, setor TEXT (30) NOT NULL, subdivisao TEXT (110));
INSERT INTO t_usuario_patri (id, nome, responsavel, cargo, setor, subdivisao) VALUES (1, 'Manoel Ribeiro', 'Mauricio', 'Aprendiz', 'Logística', 'Sala Logística');
INSERT INTO t_usuario_patri (id, nome, responsavel, cargo, setor, subdivisao) VALUES (2, 'Mauricio', 'Mauricio', 'Gestor', 'Logística', 'Logística');
INSERT INTO t_usuario_patri (id, nome, responsavel, cargo, setor, subdivisao) VALUES (3, 'Francisco Neves', 'Francisco Neves', 'Gestor de TI', 'Administração', 'Sala da Gerência');
INSERT INTO t_usuario_patri (id, nome, responsavel, cargo, setor, subdivisao) VALUES (4, 'Francisco Thiago', 'Francisco Neves', 'Técnico em TI', 'TI', 'TI');

-- Tabela: usuario_sis
CREATE TABLE IF NOT EXISTS usuario_sis (id INTEGER PRIMARY KEY AUTOINCREMENT, usuario TEXT (20) UNIQUE NOT NULL, senha TEXT (8) NOT NULL, adm INTEGER (1) NOT NULL, nome TEXT (110) NOT NULL);
INSERT INTO usuario_sis (id, usuario, senha, adm, nome) VALUES (1, 'manoelAdm', '1234', 1, 'Manoel Ribeiro');
INSERT INTO usuario_sis (id, usuario, senha, adm, nome) VALUES (5, 'mauricioAdm', '1234', 1, 'Mauricio');
INSERT INTO usuario_sis (id, usuario, senha, adm, nome) VALUES (6, 'Maureck', '1234', 1, 'Mauricio de Sousa');
INSERT INTO usuario_sis (id, usuario, senha, adm, nome) VALUES (7, 'Erick', '1234', 0, 'Erick Juan');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
