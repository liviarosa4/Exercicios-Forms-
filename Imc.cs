namespace WinFormsApp18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = Convert.ToDouble(txtPeso.Text);
            double altura = Convert.ToDouble(txtAltura.Text);
            double imc = peso / (altura * altura);
            lblResultado.Text = $"IMC: {imc:F2}";
            double pesoIdealMin = 18.5 * (altura * altura);
            double pesoIdealMax = 24.9 * (altura * altura);
            lblPesoIdeal.Text = $"Peso ideal: {pesoIdealMin:F2}kg - {pesoIdealMax:F2}kg";
            if (imc < 18.5)
            {

            }
            else if (imc < 24.9)
            {

            }
            else if (imc < 29.9)
            {

            }
            else
            {

            }
        }

        private void rbdMasculino_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ImcHomem;
        }

        private void rbdFeminino_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.ImcMulher;
        }

        private void lblPesoIdeal_Click(object sender, EventArgs e)
        {

        }
    }
}
