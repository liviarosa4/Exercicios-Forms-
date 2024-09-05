namespace WinFormsApp32
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSobre_Click(object sender, EventArgs e)


        {
            if (double.TryParse(txtMoedas.Text, out double valor) && txtEscolha.SelectedItem != null)
            {
                double valorConvertido = 0;
                string moeda = txtEscolha.SelectedItem.ToString();
                switch (moeda)
                {
                    case "Euro":
                        valorConvertido = valor * 0.16;
                        lblResultados.Text = $"Valor em Euro: € {valorConvertido:F2}";
                        pictureBox1.Visible = true;
                        pictureBox1.Image = Properties.Resources.euro;
                        break;
                    case "Dólar":
                        valorConvertido = valor * 0.25;
                        lblResultados.Text = $"Valor em Dolar: $ {valorConvertido:F2}";
                        pictureBox1.Image = Properties.Resources.dolar;
                        pictureBox1.Visible = true;
                        break;
                    case "Yuan":
                        valorConvertido = valor * 1.28;
                        lblResultados.Text = $"Valor em Yuan: ¥ {valorConvertido:F2}";
                        pictureBox1.Image = Properties.Resources.yuan;
                        pictureBox1.Visible = true;
                        break;
                    case "Iene":
                        valorConvertido = valor * 26.16;
                        lblResultados.Text = $"Valor em Iene: ¥ {valorConvertido:F2}";
                        pictureBox1.Image = Properties.Resources._2iene;
                        pictureBox1.Visible = true;
                        break;
                    case "Libra Esterlina":
                        valorConvertido = valor * 0.14;
                        lblResultados.Text = $"Valor em Libra: £ · p {valorConvertido:F2}";
                        pictureBox1.Image = Properties.Resources.libra;
                        pictureBox1.Visible = true;
                        break;
                    default:
                        MessageBox.Show("Selecione uma moeda válida.");
                        break;
                }

            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido e selecione uma moeda.");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}