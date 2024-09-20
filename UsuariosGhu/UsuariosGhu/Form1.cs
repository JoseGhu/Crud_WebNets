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
                        MessageBox.Show($"O funcionário {cadFuncionarios.Nome} foi cadastrado com sucesso!");

                        // Limpa os campos e coloca o foco no campo Nome
                        txtNome.Clear();
                        txtTelefone.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o funcionário.");
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
                MessageBox.Show("Erro ao cadastrar funcionário: " + ex.Message);
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
                            MessageBox.Show("Funcionário não encontrado! ");
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
                        MessageBox.Show("Funcionário não encontrado! ");
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
                MessageBox.Show("Erro ao pesquisar funcionário: " + ex.Message);
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
                        MessageBox.Show("Não foi possivel atualizar as informações dos funcionários. ");
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
                    MessageBox.Show("Favor localizar o funcionário que deseja atualizar a informação");
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
                MessageBox.Show("Erro ao atualizar dados do Funcionário" + ex.Message);

            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se os campos estão preenchidos
                if (!string.IsNullOrWhiteSpace(txtTelefone.Text) &&
                    !string.IsNullOrWhiteSpace(txtEmail.Text) &&
                    !string.IsNullOrWhiteSpace(txtEndereco.Text) &&
                    !string.IsNullOrWhiteSpace(txtNome.Text))
                {
                    cadastroFuncionarios cadFuncionarios = new cadastroFuncionarios
                    {
                        Id = int.Parse(lblID.Text) // Converte o ID corretamente
                    };

                    // Tenta excluir o funcionário
                    if (cadFuncionarios.deletarFuncionario())
                    {
                        MessageBox.Show("O Funcionário foi excluído com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não é possível excluir o funcionário.");

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
                    MessageBox.Show("Pesquisar qual funcionário deseja excluir.");

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
                // Exibe a mensagem de erro com formatação correta
                MessageBox.Show("Erro ao excluir Funcionário: " + ex.Message);
            }
        }
    }
}

