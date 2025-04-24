namespace Teste_tela05.Views
{
    partial class SenhaEsquecida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SenhaEsquecida));
            txtEmail3 = new TextBox();
            txtNovaSenha8 = new TextBox();
            txtConfirmarSenha4 = new TextBox();
            btnSalvar = new Button();
            pictureBox1 = new PictureBox();
            btnCancelar6 = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtEmail3
            // 
            txtEmail3.Location = new Point(494, 419);
            txtEmail3.Name = "txtEmail3";
            txtEmail3.PlaceholderText = "E-Mail:";
            txtEmail3.Size = new Size(212, 23);
            txtEmail3.TabIndex = 0;
            txtEmail3.TextChanged += txtEmail3_TextChanged;
            // 
            // txtNovaSenha8
            // 
            txtNovaSenha8.Location = new Point(494, 448);
            txtNovaSenha8.Name = "txtNovaSenha8";
            txtNovaSenha8.PlaceholderText = "Nova Senha:";
            txtNovaSenha8.Size = new Size(212, 23);
            txtNovaSenha8.TabIndex = 1;
            // 
            // txtConfirmarSenha4
            // 
            txtConfirmarSenha4.Location = new Point(494, 477);
            txtConfirmarSenha4.Name = "txtConfirmarSenha4";
            txtConfirmarSenha4.PlaceholderText = "Confirmar Senha:";
            txtConfirmarSenha4.Size = new Size(212, 23);
            txtConfirmarSenha4.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(510, 538);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(151, 50);
            btnSalvar.TabIndex = 3;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnResetarSenha_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(494, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 231);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnCancelar6
            // 
            btnCancelar6.Font = new Font("ItalicT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar6.Location = new Point(1032, 654);
            btnCancelar6.Name = "btnCancelar6";
            btnCancelar6.Size = new Size(148, 35);
            btnCancelar6.TabIndex = 6;
            btnCancelar6.Text = "Cancelar";
            btnCancelar6.UseVisualStyleBackColor = true;
            btnCancelar6.Click += btnCancelar6_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 701);
            panel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnSalvar);
            panel2.Controls.Add(txtEmail3);
            panel2.Controls.Add(txtNovaSenha8);
            panel2.Controls.Add(txtConfirmarSenha4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1192, 701);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(922, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(270, 701);
            panel3.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(157, 660);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // SenhaEsquecida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 701);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(btnCancelar6);
            Controls.Add(panel2);
            Name = "SenhaEsquecida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SenhaEsquecida";
            Load += SenhaEsquecida_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtEmail3;
        private TextBox txtNovaSenha8;
        private TextBox txtConfirmarSenha4;
        private Button btnSalvar;
        private PictureBox pictureBox1;
        private Button btnCancelar6;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button button1;
    }
}