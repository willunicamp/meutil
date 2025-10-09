using MySql.Data.MySqlClient;

namespace DAL
{
    public static class ConexaoBD
    {
        // Coloque a sua string de conexão aqui
        private static readonly string connectionString = "";

        public static MySqlConnection ObterConexao()
        {
            return new MySqlConnection(connectionString);
        }
    }
}