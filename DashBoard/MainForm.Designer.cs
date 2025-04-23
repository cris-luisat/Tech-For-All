namespace DashBoard
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            btn = new Button();
            btnCARTEIRA = new Button();
            btnMenu = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Green;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn);
            panel1.Controls.Add(btnCARTEIRA);
            panel1.Controls.Add(btnMenu);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 701);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 184);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.Location = new Point(98, 651);
            button3.Name = "button3";
            button3.Size = new Size(75, 25);
            button3.TabIndex = 2;
            button3.Text = "Carrinho";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn
            // 
            btn.Location = new Point(70, 351);
            btn.Name = "btn";
            btn.Size = new Size(128, 23);
            btn.TabIndex = 1;
            btn.Text = "button2";
            btn.UseVisualStyleBackColor = true;
            // 
            // btnCARTEIRA
            // 
            btnCARTEIRA.Location = new Point(70, 310);
            btnCARTEIRA.Name = "btnCARTEIRA";
            btnCARTEIRA.Size = new Size(128, 23);
            btnCARTEIRA.TabIndex = 0;
            btnCARTEIRA.Text = "Carteira";
            btnCARTEIRA.UseVisualStyleBackColor = true;
            // 
            // btnMenu
            // 
            btnMenu.Location = new Point(70, 269);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(128, 23);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(270, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 701);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 701);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnMenu;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button button3;
        private Button btn;
        private Button btnCARTEIRA;
    }
}