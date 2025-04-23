namespace DashBoard
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
            panel1 = new Panel();
            lblCATEGORIA = new Label();
            pictureBox1 = new PictureBox();
            btnCARREGAR = new Button();
            comboBox1 = new ComboBox();
            btnSALVAR = new Button();
            panel3 = new Panel();
            lblPREÇO = new Label();
            lblDESCRICAO = new Label();
            lblINGREDIENTES = new Label();
            lblNOMEPIZZA = new Label();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblCATEGORIA);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(btnSALVAR);
            panel1.Controls.Add(lblPREÇO);
            panel1.Controls.Add(lblDESCRICAO);
            panel1.Controls.Add(lblINGREDIENTES);
            panel1.Controls.Add(lblNOMEPIZZA);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 701);
            panel1.TabIndex = 0;
            // 
            // lblCATEGORIA
            // 
            lblCATEGORIA.AutoSize = true;
            lblCATEGORIA.Font = new Font("ItalicT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCATEGORIA.Location = new Point(467, 476);
            lblCATEGORIA.Name = "lblCATEGORIA";
            lblCATEGORIA.Size = new Size(135, 29);
            lblCATEGORIA.TabIndex = 16;
            lblCATEGORIA.Text = "Categoria";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.Location = new Point(-159, 195);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 312);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnCARREGAR
            // 
            btnCARREGAR.Font = new Font("ItalicT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCARREGAR.Location = new Point(-81, 598);
            btnCARREGAR.Name = "btnCARREGAR";
            btnCARREGAR.Size = new Size(305, 57);
            btnCARREGAR.TabIndex = 14;
            btnCARREGAR.Text = "Carregar Imagem";
            btnCARREGAR.UseVisualStyleBackColor = true;
            btnCARREGAR.Click += btnCARREGAR_Click;
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.None;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tradicional", "Especial", "Vegetariana", "Focaccia", "Refrigerante", "Suco", "Sobremesa" });
            comboBox1.Location = new Point(464, 508);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(282, 23);
            comboBox1.TabIndex = 13;
            // 
            // btnSALVAR
            // 
            btnSALVAR.Anchor = AnchorStyles.None;
            btnSALVAR.Font = new Font("ItalicT", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSALVAR.Location = new Point(498, 589);
            btnSALVAR.Name = "btnSALVAR";
            btnSALVAR.Size = new Size(184, 75);
            btnSALVAR.TabIndex = 12;
            btnSALVAR.Text = "Salvar";
            btnSALVAR.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkGreen;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.RightToLeft = RightToLeft.No;
            panel3.Size = new Size(270, 701);
            panel3.TabIndex = 17;
            // 
            // lblPREÇO
            // 
            lblPREÇO.Anchor = AnchorStyles.None;
            lblPREÇO.AutoSize = true;
            lblPREÇO.Font = new Font("ItalicT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPREÇO.Location = new Point(109, 354);
            lblPREÇO.Name = "lblPREÇO";
            lblPREÇO.Size = new Size(103, 37);
            lblPREÇO.TabIndex = 8;
            lblPREÇO.Text = "Preço";
            // 
            // lblDESCRICAO
            // 
            lblDESCRICAO.Anchor = AnchorStyles.None;
            lblDESCRICAO.AutoSize = true;
            lblDESCRICAO.Font = new Font("ItalicT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDESCRICAO.Location = new Point(464, 354);
            lblDESCRICAO.Name = "lblDESCRICAO";
            lblDESCRICAO.Size = new Size(166, 37);
            lblDESCRICAO.TabIndex = 7;
            lblDESCRICAO.Text = "Descrição";
            // 
            // lblINGREDIENTES
            // 
            lblINGREDIENTES.Anchor = AnchorStyles.None;
            lblINGREDIENTES.AutoSize = true;
            lblINGREDIENTES.Font = new Font("ItalicT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblINGREDIENTES.Location = new Point(467, 195);
            lblINGREDIENTES.Name = "lblINGREDIENTES";
            lblINGREDIENTES.Size = new Size(215, 37);
            lblINGREDIENTES.TabIndex = 6;
            lblINGREDIENTES.Text = "Ingredientes";
            // 
            // lblNOMEPIZZA
            // 
            lblNOMEPIZZA.Anchor = AnchorStyles.None;
            lblNOMEPIZZA.AutoSize = true;
            lblNOMEPIZZA.BackColor = Color.Transparent;
            lblNOMEPIZZA.Font = new Font("ItalicT", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNOMEPIZZA.Location = new Point(109, 195);
            lblNOMEPIZZA.Name = "lblNOMEPIZZA";
            lblNOMEPIZZA.Size = new Size(105, 37);
            lblNOMEPIZZA.TabIndex = 5;
            lblNOMEPIZZA.Text = "Pizza";
            // 
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.None;
            textBox5.Location = new Point(467, 394);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(279, 44);
            textBox5.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Location = new Point(464, 235);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 44);
            textBox4.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Location = new Point(109, 394);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 44);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Location = new Point(109, 235);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 44);
            textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Red;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnCARREGAR);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(947, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(245, 701);
            panel2.TabIndex = 10;
            panel2.Paint += panel2_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 701);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblPREÇO;
        private Label lblDESCRICAO;
        private Label lblINGREDIENTES;
        private Label lblNOMEPIZZA;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button btnSALVAR;
        private Panel panel3;
        private Panel panel2;
        private ComboBox comboBox1;
        private Button btnCARREGAR;
        private PictureBox pictureBox1;
        private Label lblCATEGORIA;
    }
}
