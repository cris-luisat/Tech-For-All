namespace Teste_tela05.Views
{
    partial class Adm_Gerente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adm_Gerente));
            panel1 = new Panel();
            btnCancelar_Adm = new Button();
            textBox3 = new TextBox();
            lblEmail_Adm = new Label();
            lblSenha_Adm = new Label();
            btnUsuario_Adm = new Label();
            pictureBox1 = new PictureBox();
            btnLogin_Adm = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btnCancelar_Adm);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(lblEmail_Adm);
            panel1.Controls.Add(lblSenha_Adm);
            panel1.Controls.Add(btnUsuario_Adm);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLogin_Adm);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 701);
            panel1.TabIndex = 0;
            // 
            // btnCancelar_Adm
            // 
            btnCancelar_Adm.Cursor = Cursors.AppStarting;
            btnCancelar_Adm.Location = new Point(1105, 666);
            btnCancelar_Adm.Name = "btnCancelar_Adm";
            btnCancelar_Adm.Size = new Size(75, 23);
            btnCancelar_Adm.TabIndex = 10;
            btnCancelar_Adm.Text = "Cancelar";
            btnCancelar_Adm.UseVisualStyleBackColor = true;
            btnCancelar_Adm.Click += btnCancelar_Adm_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(477, 466);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(255, 23);
            textBox3.TabIndex = 9;
            // 
            // lblEmail_Adm
            // 
            lblEmail_Adm.AutoSize = true;
            lblEmail_Adm.Location = new Point(477, 448);
            lblEmail_Adm.Name = "lblEmail_Adm";
            lblEmail_Adm.Size = new Size(44, 15);
            lblEmail_Adm.TabIndex = 8;
            lblEmail_Adm.Text = "E-mail:";
            // 
            // lblSenha_Adm
            // 
            lblSenha_Adm.AutoSize = true;
            lblSenha_Adm.Location = new Point(477, 408);
            lblSenha_Adm.Name = "lblSenha_Adm";
            lblSenha_Adm.Size = new Size(42, 15);
            lblSenha_Adm.TabIndex = 7;
            lblSenha_Adm.Text = "Senha:";
            // 
            // btnUsuario_Adm
            // 
            btnUsuario_Adm.AutoSize = true;
            btnUsuario_Adm.Location = new Point(477, 364);
            btnUsuario_Adm.Name = "btnUsuario_Adm";
            btnUsuario_Adm.Size = new Size(50, 15);
            btnUsuario_Adm.TabIndex = 6;
            btnUsuario_Adm.Text = "Usuário:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(500, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(232, 224);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnLogin_Adm
            // 
            btnLogin_Adm.Location = new Point(528, 510);
            btnLogin_Adm.Name = "btnLogin_Adm";
            btnLogin_Adm.Size = new Size(110, 32);
            btnLogin_Adm.TabIndex = 4;
            btnLogin_Adm.Text = "Login";
            btnLogin_Adm.UseVisualStyleBackColor = true;
            btnLogin_Adm.Click += btnLogin_Adm_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(477, 423);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(255, 23);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(477, 382);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(255, 23);
            textBox1.TabIndex = 2;
            // 
            // Adm_Gerente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 701);
            Controls.Add(panel1);
            Name = "Adm_Gerente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adm_Gerente";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnLogin_Adm;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblEmail_Adm;
        private Label lblSenha_Adm;
        private Label btnUsuario_Adm;
        private TextBox textBox3;
        private Button btnCancelar_Adm;
    }
}