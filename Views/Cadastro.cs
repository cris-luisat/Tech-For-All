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

namespace Teste_tela05
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Pega os valores digitados
            string usuario = txtUsuario.Text;
            string senha = txtCSenha.Text;
            string confirmarSenha = txtConfirmar.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;

            // Verifica campos obrigatórios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(confirmarSenha) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone))
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

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            // Validação de e-mail simples
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            // Validação de telefone (apenas números e no mínimo 10 dígitos)
            if (!Regex.IsMatch(telefone, @"^\d{10,11}$"))
            {
                MessageBox.Show("Telefone inválido. Digite apenas números (ex: 11912345678).");
                return;
            }

            // Se passou todas as validações
            MessageBox.Show("Cadastro realizado com sucesso!");

            // Aqui você poderia salvar em banco de dados, arquivo, etc.
            // Vamos apenas voltar para o Form1
            this.Hide(); // esconde o FormCadastro
            Form1 formLogin = new Form1();
            formLogin.Show();
        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataNascimento = dtpNascimento.Value;
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.Date < dataNascimento.AddYears(idade))
            {
                idade--;
            }

            lblIdade.Text = "Idade: " + idade.ToString();

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|Todos os arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Carregar a imagem selecionada no PictureBox
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar ao tamanho do PictureBox
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}");
                    }
                }

            }
        }
    }
}

