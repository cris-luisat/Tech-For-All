using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teste_tela05.Views
{
    public partial class SenhaEsquecida : Form
    {
        public SenhaEsquecida()
        {
            InitializeComponent();
        }

        private bool VerificarUsuarioPorEmail(string email)
        {
            // Simulação de verificação de usuário por email
            // Substitua por lógica real de verificação no banco de dados
            return email == "usuario@exemplo.com";
        }

        private void AtualizarSenhaUsuario(string email, string novaSenha)
        {
            // Simulação de atualização de senha
            // Substitua por lógica real de atualização no banco de dados
        }

        private void btnResetarSenha_Click(object sender, EventArgs e)
        {
            string email = txtEmail3.Text;
            string novaSenha = txtNovaSenha8.Text;
            string confirmarSenha = txtConfirmarSenha4.Text;


            // Validação simples
            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            // Chamada do método VerificarUsuarioPorEmail
            bool usuarioExiste = VerificarUsuarioPorEmail(email);
            if (!usuarioExiste)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }

            AtualizarSenhaUsuario(email, novaSenha);
            MessageBox.Show("Senha redefinida com sucesso!");
            this.Close(); // Fecha o formulário
        }

        private void txtEmail3_TextChanged(object sender, EventArgs e)
        { }
        private bool EmailValido(string email)
        {
            string padraoEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, padraoEmail);

        }

        private void SenhaEsquecida_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar6_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
