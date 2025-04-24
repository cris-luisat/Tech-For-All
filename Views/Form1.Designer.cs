namespace Teste_tela05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            btnADM_GER = new Button();
            btnCadrastar = new Button();
            btnEntrar = new Button();
            linkLabelEsqueciSenha = new LinkLabel();
            lblSenha = new Label();
            lblUsuario = new Label();
            txtSenha = new TextBox();
            txtUsuario = new TextBox();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnADM_GER);
            panel1.Controls.Add(btnCadrastar);
            panel1.Controls.Add(btnEntrar);
            panel1.Controls.Add(linkLabelEsqueciSenha);
            panel1.Controls.Add(lblSenha);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtSenha);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 701);
            panel1.TabIndex = 0;
            // 
            // btnADM_GER
            // 
            btnADM_GER.Cursor = Cursors.Hand;
            btnADM_GER.Location = new Point(829, 12);
            btnADM_GER.Name = "btnADM_GER";
            btnADM_GER.Size = new Size(82, 33);
            btnADM_GER.TabIndex = 10;
            btnADM_GER.Text = "ADM";
            btnADM_GER.UseVisualStyleBackColor = true;
            btnADM_GER.Click += btnADM_GER_Click;
            // 
            // btnCadrastar
            // 
            btnCadrastar.Cursor = Cursors.Hand;
            btnCadrastar.Location = new Point(500, 601);
            btnCadrastar.Name = "btnCadrastar";
            btnCadrastar.Size = new Size(155, 37);
            btnCadrastar.TabIndex = 9;
            btnCadrastar.Text = "Cadastrar";
            btnCadrastar.UseVisualStyleBackColor = true;
            btnCadrastar.Click += btnCadastar_Click;
            // 
            // btnEntrar
            // 
            btnEntrar.Cursor = Cursors.Hand;
            btnEntrar.Location = new Point(500, 556);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(155, 39);
            btnEntrar.TabIndex = 8;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // linkLabelEsqueciSenha
            // 
            linkLabelEsqueciSenha.AutoSize = true;
            linkLabelEsqueciSenha.Location = new Point(460, 500);
            linkLabelEsqueciSenha.Name = "linkLabelEsqueciSenha";
            linkLabelEsqueciSenha.Size = new Size(85, 15);
            linkLabelEsqueciSenha.TabIndex = 7;
            linkLabelEsqueciSenha.TabStop = true;
            linkLabelEsqueciSenha.Text = "Esqueci  Senha";
            linkLabelEsqueciSenha.LinkClicked += linkLabelEsqueciSenha_LinkClicked;
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(459, 458);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(42, 15);
            lblSenha.TabIndex = 6;
            lblSenha.Text = "Senha:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(459, 402);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Usuário:";
            // 
            // txtSenha
            // 
            txtSenha.Cursor = Cursors.Hand;
            txtSenha.Location = new Point(459, 476);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(248, 23);
            txtSenha.TabIndex = 4;
            txtSenha.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            txtUsuario.Cursor = Cursors.Hand;
            txtUsuario.Location = new Point(459, 420);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(248, 23);
            txtUsuario.TabIndex = 3;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(481, 146);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(207, 198);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(928, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(264, 701);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(264, 701);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 701);
            Controls.Add(panel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delicias da Itália";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtSenha;
        private TextBox txtUsuario;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private Button btnCadrastar;
        private Button btnEntrar;
        private LinkLabel linkLabelEsqueciSenha;
        private Label lblSenha;
        private Label lblUsuario;
        private Button btnADM_GER;
    }
}
