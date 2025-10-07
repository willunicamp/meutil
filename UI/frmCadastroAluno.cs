using DAL;
using Entidades;

namespace UI
{
    public partial class frmCadastroAluno : Form
    {
        public frmCadastroAluno()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Criando o OBJETO Aluno a partir dos dados do formulário
                Aluno novoAluno = new Aluno(
                    nome: txtNome.Text,
                    cpf: txtCpf.Text,
                    dataNascimento: dtpDataNascimento.Value,
                    matricula: txtMatricula.Text
                );
                // Preenchendo o resto das propriedades
                novoAluno.Email = txtEmail.Text;
                novoAluno.Telefone = txtTelefone.Text;


                // 2. Instanciando a classe de acesso a dados
                AlunoDAL alunoDAL = new AlunoDAL();

                // 3. Chamando o método para inserir no banco
                alunoDAL.Inserir(novoAluno);

                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
            }
            // Captura as exceções que podem vir da camada DAL
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar aluno: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


            private void LimparCampos()
            {
                txtNome.Clear();
                txtCpf.Clear();
                txtMatricula.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                dtpDataNascimento.Value = DateTime.Now;
            }
        
    }
}
