using DAL;
using Entidades;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace DAL
{
    public class AlunoDAL
    {
        public void Inserir(Aluno aluno)
        {
            MySqlConnection conexao = null;
            try
            {
                conexao = ConexaoBD.ObterConexao();
                conexao.Open();

                // 1. Inserir na tabela 'pessoa'
                string sqlPessoa = "INSERT INTO meutil_pessoa (Nome, CPF, DataNascimento, Telefone, Email) VALUES (@Nome, @CPF, @DataNascimento, @Telefone, @Email); SELECT LAST_INSERT_ID();";
                MySqlCommand cmdPessoa = new MySqlCommand(sqlPessoa, conexao);

                // Usar parâmetros previne SQL Injection
                cmdPessoa.Parameters.AddWithValue("@Nome", aluno.Nome);
                cmdPessoa.Parameters.AddWithValue("@CPF", aluno.CPF);
                cmdPessoa.Parameters.AddWithValue("@DataNascimento", aluno.DataNascimento);
                cmdPessoa.Parameters.AddWithValue("@Telefone", aluno.Telefone);
                cmdPessoa.Parameters.AddWithValue("@Email", aluno.Email);

                // Executa e obtém o ID da pessoa inserida
                int pessoaId = Convert.ToInt32(cmdPessoa.ExecuteScalar());

                // 2. Inserir na tabela 'aluno'
                string sqlAluno = "INSERT INTO meutil_aluno (Matricula, PessoaID) VALUES (@Matricula, @PessoaID);";
                MySqlCommand cmdAluno = new MySqlCommand(sqlAluno, conexao);
                cmdAluno.Parameters.AddWithValue("@Matricula", aluno.Matricula);
                cmdAluno.Parameters.AddWithValue("@PessoaID", pessoaId);

                cmdAluno.ExecuteNonQuery();
            }
            // TRATAMENTO DE EXCEÇÕES: Captura erros específicos do MySQL
            catch (MySqlException ex)
            {
                // Aqui você poderia logar o erro num arquivo, por exemplo.
                // Lançamos uma nova exceção para a camada de UI saber que algo deu errado.
                throw new Exception("Erro no banco de dados ao inserir aluno: " + ex.Message);
            }
            // Captura qualquer outro erro inesperado
            catch (Exception ex)
            {
                throw new Exception("Ocorreu um erro inesperado: " + ex.Message);
            }
            // O bloco finally é executado sempre, tendo dado erro ou não.
            finally
            {
                // Garante que a conexão seja fechada
                if (conexao != null && conexao.State == ConnectionState.Open)
                {
                    conexao.Close();
                }
            }
        }
    }
}