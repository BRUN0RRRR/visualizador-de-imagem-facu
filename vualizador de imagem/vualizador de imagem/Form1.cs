namespace vualizador_de_imagem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncarregar_Click(object sender, EventArgs e)
        {
            {
                // Cria uma caixa de diálogo para seleção de arquivos
                OpenFileDialog openFileDialog = new OpenFileDialog
                {
                    Filter = "Imagens|*.jpg;*.jpeg;*.png;*.bmp", // Filtra apenas arquivos de imagem
                    Title = "Selecione uma imagem"
                };

                // Verifica se o usuário selecionou um arquivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Carrega a imagem selecionada no PictureBox
                    pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajusta a imagem ao PictureBox
                }
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }
    }
}
