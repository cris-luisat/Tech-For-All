namespace DashBoard.UserControls
{
    partial class Menu
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel1 = new Panel();
            lblVALOR = new Label();
            button1 = new Button();
            lblPIZZA = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(lblPIZZA);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(lblVALOR);
            panel1.Location = new Point(14, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(952, 283);
            panel1.TabIndex = 0;
            // 
            // lblVALOR
            // 
            lblVALOR.AutoSize = true;
            lblVALOR.Location = new Point(819, 259);
            lblVALOR.Name = "lblVALOR";
            lblVALOR.Size = new Size(39, 15);
            lblVALOR.TabIndex = 0;
            lblVALOR.Text = "Valor :";
            lblVALOR.Click += label1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(863, 255);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // lblPIZZA
            // 
            lblPIZZA.AutoSize = true;
            lblPIZZA.Font = new Font("ItalicT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPIZZA.Location = new Point(348, 12);
            lblPIZZA.Name = "lblPIZZA";
            lblPIZZA.Size = new Size(265, 32);
            lblPIZZA.TabIndex = 3;
            lblPIZZA.Text = "Pizza Marguerita";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(296, 253);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panel1);
            Name = "Menu";
            Size = new Size(984, 661);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblVALOR;
        private Label lblPIZZA;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
