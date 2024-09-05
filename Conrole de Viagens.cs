namespace Km
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Digite seu Nome");
                return;
            }

            if (cbOrigem.SelectedIndex == -1 || cbDestino.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione duas cidades.");
                return;
            }

            int[,] distancias = {
        { 0, 357, 882, 489 },
        { 357, 0, 521, 339 },
        { 882, 521, 0, 378 },
        { 489, 339, 378, 0 }
    };
            int km = distancias[cbOrigem.SelectedIndex, cbDestino.SelectedIndex];


            if (rbIdaVolta.Checked)
            {
                km *= 2;
            }

            lblKmPercorridos.Text = $"Km a Percorrer: {km}Km";


            double valorKm = 0;
            if (rbOperacional.Checked)
            {
                valorKm = 2.00;
            }
            else if (rbGerente.Checked)
            {
                valorKm = 2.50;
            }
            else if (rbDiretor.Checked)
            {
                valorKm = 3.00;
            }
            double totalPagar = km * valorKm;
            lblTotalPagar.Text = $"Total a pagar: R$ {totalPagar:F2}";

            DialogResult dialogResult = MessageBox.Show("Deseja fazer outra operação?", "Continuar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) ;



        }

        private void pictureBoxEstados1_Click(object sender, EventArgs e)
        {
            string selectedText = cbOrigem.Text;

            if (selectedText == "NULO" || string.IsNullOrEmpty(selectedText))
            {
                pictureBoxEstados1.Image = null;
            }
            else if (selectedText == "Espírito Santo")
            {
                pictureBoxEstados1.Image = Properties.Resources.Espirito_Santo;
            }
            else if (selectedText == "Minas Gerais")
            {
                pictureBoxEstados1.Image = Properties.Resources.MinasGerais;
            }
            else if (selectedText == "Rio de Janeiro")
            {
                pictureBoxEstados1.Image = Properties.Resources.RioDeJaneiro;
            }
            else if (selectedText == "São Paulo")
            {
                pictureBoxEstados1.Image = Properties.Resources.SaoPaulo;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBoxEstados2_Click(object sender, EventArgs e)
        {
            string selectedText = cbDestino.Text;

            if (selectedText == "NULO" || string.IsNullOrEmpty(selectedText))
            {
                pictureBoxEstados2.Image = null;
            }
            else if (selectedText == "Espírito Santo")
            {
                pictureBoxEstados2.Image = Properties.Resources.Espirito_Santo;
            }
            else if (selectedText == "Minas Gerais")
            {
                pictureBoxEstados2.Image = Properties.Resources.MinasGerais;
            }
            else if (selectedText == "Rio de Janeiro")
            {
                pictureBoxEstados2.Image = Properties.Resources.RioDeJaneiro;
            }
            else if (selectedText == "São Paulo")
            {
                pictureBoxEstados2.Image = Properties.Resources.SaoPaulo;
            }
        }

        private void rbIdaVolta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            cbOrigem.SelectedIndex = -1;
            cbDestino.SelectedIndex = -1;
            rbIda.Checked = true;
            rbOperacional.Checked = true;
            lblKmPercorridos.Text = "";
            lblTotalPagar.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}