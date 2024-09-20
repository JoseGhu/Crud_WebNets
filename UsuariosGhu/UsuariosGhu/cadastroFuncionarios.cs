using MySql.Data.MySqlClient;
using Mysqlx.Crud;

namespace UsuariosGhu
{
    internal class cadastroFuncionarios
    {
        private int id;
        private string nome;
        private string telefone;
        private string email;
        private string endereco;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        // Método para cadastrar funcionários.
        public bool CadastrarFuncionarios()

        {
            try
            {
                // Usando a instrução using para garantir o fechamento correto da conexão
                using (MySqlConnection mysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    mysqlConexaoBanco.Open();

                    // Definindo a query de inserção com parâmetros
                    string insert = "INSERT INTO funcionarios (nome, telefone, email, endereco) VALUES (@Nome, @Telefone, @Email, @Endereco)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, mysqlConexaoBanco))
                    {
                        // Adicionando os parâmetros à query
                        comandoSql.Parameters.AddWithValue("@Nome", Nome);
                        comandoSql.Parameters.AddWithValue("@Telefone", Telefone);
                        comandoSql.Parameters.AddWithValue("@Email", Email);
                        comandoSql.Parameters.AddWithValue("@Endereco", Endereco);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (MySqlException ex)
            {
                // Mostrando uma mensagem de erro mais segura, sem expor a query
                MessageBox.Show("Erro no Banco de Dados: " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                // Capturando outras exceções
                MessageBox.Show("Erro inesperado ao cadastrar funcionário: " + ex.Message);
                return false;
            }
        }

        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string select = $"select id, nome, telefone, email, endereco from funcionarios where telefone = '{Telefone}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro no banco de dados -  Metodo localizarFuncionário: "+ ex.Message);
                return null;
            } 
        }

        public bool atualizarFuncionario()
        {
            try
            {
                MySqlConnection MysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MysqlConexaoBanco.Open();

                string update = $"update funcionarios set email = '{Email}', endereco = '{Endereco}' where id = '{Id}';";
                MySqlCommand comandoSql = MysqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Erro no banco de dados -  Metodo atualizarFuncionario: " + ex.Message);
                return false;
            }
        }

        public bool deletarFuncionario()
        {
            try
            {
                // Usando 'using' para garantir que a conexão seja fechada corretamente
                using (MySqlConnection mysqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    mysqlConexaoBanco.Open();

                    // Query correta de DELETE com o uso de parâmetros
                    string delete = "DELETE FROM funcionarios WHERE id = @Id;";

                    using (MySqlCommand comandoSql = new MySqlCommand(delete, mysqlConexaoBanco))
                    {
                        // Adiciona o parâmetro para a query
                        comandoSql.Parameters.AddWithValue("@Id", Id);

                        comandoSql.ExecuteNonQuery();
                    }

                    return true;
                }
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro
                MessageBox.Show("Erro no banco de dados - Método deletarFuncionário: " + ex.Message);
                return false;
            }

        }

    }
}
