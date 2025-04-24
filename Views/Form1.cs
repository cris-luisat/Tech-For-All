using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;
using Teste_tela05.Views;

namespace Teste_tela05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnCadastar_Click(object sender, EventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string senha = txtSenha.Text;



            // Verifica campos obrigatórios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha) || string.IsNullOrWhiteSpace(usuario))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }


            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }

            // Validação da senha
            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                return;
            }

            //string usuario = txtUsuario.Text.Trim();
            //string senha = txtSenha.Text.Trim();

            //// Simulando usuários cadastrados
            //string usuarioCadastrado = "admin";
            //string senhaCadastrada = "1234";

            //if (usuario == usuarioCadastrado && senha == senhaCadastrada)
            //{
            //    MessageBox.Show("Login realizado com sucesso!");
            //    // Aqui você pode abrir outro formulário, por exemplo:
            //    // new TelaPrincipal().Show();
            //    // this.Hide(); // Esconde o formulário de login
            //    Menu menu = new Menu();
            //    menu.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("Usuário ou senha inválidos!");

            //}


        }


        private void btnADM_GER_Click(object sender, EventArgs e)
        {
            Adm_Gerente adm_Gerente = new Adm_Gerente();
            adm_Gerente.Show();
            this.Hide();
        }

        private void linkLabelEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SenhaEsquecida senhaEsquecida = new SenhaEsquecida();
            senhaEsquecida.Show();

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            

           
        }
    }
    }

