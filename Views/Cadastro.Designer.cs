namespace Teste_tela05
{
    partial class Cadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastro));
            txtUsuario = new TextBox();
            textBox2 = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            txtCSenha = new TextBox();
            dtpNascimento = new DateTimePicker();
            txtConfirmar = new TextBox();
            btnSalvar = new Button();
            pictureBox1 = new PictureBox();
            btnCancelar = new Button();
            lblIdade = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnUpload = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(26, 289);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Usuário:";
            txtUsuario.Size = new Size(297, 23);
            txtUsuario.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(26, 330);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "CPF:";
            textBox2.Size = new Size(297, 23);
            textBox2.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(26, 372);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "E-mail:";
            txtEmail.Size = new Size(297, 23);
            txtEmail.TabIndex = 2;
            txtEmail.TextChanged += textBox3_TextChanged;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(26, 415);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "Telefone:";
            txtTelefone.Size = new Size(297, 23);
            txtTelefone.TabIndex = 3;
            // 
            // txtCSenha
            // 
            txtCSenha.Location = new Point(26, 459);
            txtCSenha.Name = "txtCSenha";
            txtCSenha.PlaceholderText = "Crie sua Senha:";
            txtCSenha.Size = new Size(297, 23);
            txtCSenha.TabIndex = 4;
            txtCSenha.UseSystemPasswordChar = true;
            // 
            // dtpNascimento
            // 
            dtpNascimento.Location = new Point(26, 580);
            dtpNascimento.Name = "dtpNascimento";
            dtpNascimento.Size = new Size(297, 23);
            dtpNascimento.TabIndex = 5;
            dtpNascimento.ValueChanged += dtpNascimento_ValueChanged;
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(26, 551);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PlaceholderText = "Comfirme sua Senha:";
            txtConfirmar.Size = new Size(297, 23);
            txtConfirmar.TabIndex = 6;
            txtConfirmar.UseSystemPasswordChar = true;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(438, 600);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(191, 54);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(426, 289);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(221, 230);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(177, 666);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(329, 586);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(54, 15);
            lblIdade.TabIndex = 10;
            lblIdade.Text = "Idade:     ";
            lblIdade.Click += lblIdade_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 485);
            label1.Name = "label1";
            label1.Size = new Size(170, 60);
            label1.TabIndex = 11;
            label1.Text = "Uma letra maiúscula.\r\nUm número.\r\nMín, 6 caractéres.\r\nUm caractére espécial (@!/#$*)\r\n";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(264, 701);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(btnCancelar);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(928, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 701);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(btnUpload);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(txtConfirmar);
            panel3.Controls.Add(txtUsuario);
            panel3.Controls.Add(lblIdade);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtTelefone);
            panel3.Controls.Add(btnSalvar);
            panel3.Controls.Add(txtCSenha);
            panel3.Controls.Add(dtpNascimento);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(264, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(664, 701);
            panel3.TabIndex = 13;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(479, 525);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(113, 33);
            btnUpload.TabIndex = 13;
            btnUpload.Text = "Carregar foto";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 198);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 701);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Cadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadrastro";
            Load += Cadastro_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox textBox2;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private TextBox txtCSenha;
        private DateTimePicker dtpNascimento;
        private TextBox txtConfirmar;
        private Button btnSalvar;
        private PictureBox pictureBox1;
        private Button btnCancelar;
        private Label lblIdade;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox2;
        private Button btnUpload;
    }
}