namespace DashBoard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCARREGAR_Click(object sender, EventArgs e)
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


        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }
    }
}
