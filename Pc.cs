namespace montagem_de_computadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Gabinete_Simples;
            if (radioButton1.Checked)
            {
                lblPrecoGabinete.Text = "R$ 395,00";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.Gabinete_Gamer;
            if (radioButton2.Checked)
            {
                lblPrecoGabinete.Text = "R$ 4.274,05";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.Placa_mae_Simples;
            if (radioButton5.Checked)
            {
                lblPrecoPlacaMae.Text = "R$ 200,00";
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = Properties.Resources.placa_mae_Gamer;
            if (radioButton6.Checked)
            {
                lblPrecoPlacaMae.Text = "R$ 1005,00";
            }

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.placa_de_video_simples;
            if (radioButton9.Checked)
            {
                lblPrecoPlacaVideo.Text = "R$ 360,00";
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.placa_de_video_gamer;
            if (radioButton12.Checked)
            {
                lblPrecoPlacaVideo.Text = "R$ 600,00";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Memoria_Simples;
            if (radioButton3.Checked)
            {
                lblPrecoMemoria.Text = "R$ 250,00";
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.Memoria_Gamer;
            if (radioButton4.Checked)
            {
                lblPrecoMemoria.Text = "R$ 370,00";
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.Processador_Simples;
            if (radioButton7.Checked)
            {
                lblPrecoProcessador.Text = "R$ 400,00";
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.Processador_gamer;
            if (radioButton8.Checked)
            {
                lblPrecoProcessador.Text = "R$ 1200,00";
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.disco_rigido_simples;
            if (radioButton11.Checked)
            {
                lblPrecoDisco.Text = "R$ 118,00";
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.Disco_Rigido_Gamer;
            if (radioButton10.Checked)
            {
                lblPrecoDisco.Text = "R$ 414,00";
            }
        }

        private void radioButton16_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Perifericos_Simples;
            if (radioButton16.Checked)
            {
                lblPrecoPerifericos.Text = "R$ 200,00";
            }
        }

        private void radioButton15_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.Perifericos_Gamer;
            if (radioButton15.Checked)
            {
                lblPrecoPerifericos.Text = "R$ 1000,00";
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.sistema_Operacional_simples;
            if (radioButton13.Checked)
            {
                lblPrecoSistema.Text = "R$ 75,00";

            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.sistema_operacional_gamer;
            if (radioButton14.Checked)
            {
                lblPrecoSistema.Text = "R$ 329,00";
            }
        }
    }
}