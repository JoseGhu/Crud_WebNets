using MySql.Data.MySqlClient;
using System.Drawing.Text;
using System.Windows.Forms;

namespace UsuariosGhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verifica se todos os campos foram preenchidos
                if (!string.IsNullOrWhiteSpace(txtNome.Text) &&
                    !string.IsNullOrWhiteSpace(txtTelefone.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios
                    {
                        Nome = txtNome.Text,
                        Telefone = txtTelefone.Text,
                        Email = txtEmail.Text,
                        Endereco = txtEndereco.Text
                    };

                    // Verifica se o cadastro foi bem-sucedido
                    if (cadFuncionarios.CadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcion�rio {cadFuncionarios.Nome} foi cadastrado com sucesso!");

                        // Limpa os campos e coloca o foco no campo Nome
                        txtNome.Clear();
                        txtTelefone.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("N�o foi poss�vel cadastrar o funcion�rio.");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha todos os campos corretamente!");

                    // Limpa os campos e coloca o foco no campo Nome
                    txtNome.Clear();
                    txtTelefone.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcion�rio: " + ex.Message);
            }
        }


        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (!txtTelefone.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Telefone = txtTelefone.Text;

                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();

                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblID.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();

                        }
                        else
                        {
                            MessageBox.Show("Funcion�rio n�o encontrado! ");
                            txtTelefone.Clear();
                            txtNome.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            txtTelefone.Focus();
                            lblID.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcion�rio n�o encontrado! ");
                        txtTelefone.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtTelefone.Focus();
                        lblID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor preecher o campo de telefone para a pesquisa!: ");
                    txtTelefone.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Focus();
                    lblID.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao pesquisar funcion�rio: " + ex.Message);
            }
        }


        private void btnAtulizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtTelefone.Text.Equals("") && !txtEmail.Text.Equals("") && !txtEndereco.Text.Equals("") && !txtNome.Text.Equals(""))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblID.Text);
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("os dados foram atualizadas com sucesso!");
                        txtTelefone.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtTelefone.Focus();
                        lblID.Text = "";

                    }
                    else
                    {
                        MessageBox.Show("N�o foi possivel atualizar as informa��es dos funcion�rios. ");
                        txtTelefone.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtTelefone.Focus();
                        lblID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcion�rio que deseja atualizar a informa��o");
                    txtTelefone.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Focus();
                    lblID.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados do Funcion�rio" + ex.Message);

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos est�o preenchidos
                if (!string.IsNullOrWhiteSpace(txtTelefone.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text) &&
                    !string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios
                    {
                        Id = int.Parse(lblID.Text) // Converte o ID corretamente
                    };

                    // Tenta excluir o funcion�rio
                    if (cadFuncionarios.deletarFuncionario())
                    {
                        MessageBox.Show("O Funcion�rio foi exclu�do com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("N�o � poss�vel excluir o funcion�rio.");

                        // Limpa os campos
                        txtTelefone.Clear();
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        lblID.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Pesquisar qual funcion�rio deseja excluir.");

                    // Limpa os campos e foca no campo de telefone
                    txtTelefone.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Focus();
                    lblID.Text = "";
                }
            }
            catch (Exception ex)
            {
                // Exibe a mensagem de erro com formata��o correta
                MessageBox.Show("Erro ao excluir Funcion�rio: " + ex.Message);
            }
        }
    }
}

