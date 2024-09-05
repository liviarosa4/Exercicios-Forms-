namespace Mercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Produto
        {
            public string CodigoBarras { get; set; }
            public int Quantidade { get; set; }
            public string Descricao { get; set; }
            public decimal PrecoUnitario { get; set; }

            public override string ToString()
            {
                return $"{Descricao} - {Quantidade} x {PrecoUnitario:C}";
            }
        }
        private decimal subTotal = 0;

        private void btnRemover_Click(object sender, EventArgs e)
        {
            string senha = Microsoft.VisualBasic.Interaction.InputBox("Digite a senha do gerente:", "Autenticação", "", -1, -1);
            if (senha == "1234")
            {
                if (listBoxCarrinho.SelectedItem != null)
                {
                    Produto produto = (Produto)listBoxCarrinho.SelectedItem;
                    subTotal -= produto.Quantidade * produto.PrecoUnitario;
                    btnFinalizar.Text = subTotal.ToString("C");
                    listBoxCarrinho.Items.Remove(produto);
                }
            }
            else
            {
                MessageBox.Show("Senha incorreta!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Produto produto = new Produto
                {
                    CodigoBarras = txtCodigoBarras.Text,
                    Quantidade = int.Parse(txtQuantidade.Text),
                    Descricao = txtDescricao.Text,
                    PrecoUnitario = decimal.Parse(txtPrecoUnitario.Text)
                };

                listBoxCarrinho.Items.Add(produto);
                subTotal += produto.Quantidade * produto.PrecoUnitario;
                txtSubtotal.Text = subTotal.ToString("C");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (rdbDinheiro.Checked)
            {
                decimal valorPago = decimal.Parse(Microsoft.VisualBasic.Interaction.InputBox("Digite o valor pago:", "Pagamento", "", -1, -1));
                decimal troco = valorPago - subTotal;
                MessageBox.Show($"Valor a pagar: {subTotal:C}\nValor pago: {valorPago:C}\nTroco: {troco:C}");
            }
            else if (rdbCredito.Checked || rdbDebito.Checked)
            {
                MessageBox.Show($"Valor a pagar: {subTotal:C}\nPagamento realizado com sucesso!");
            }

            listBoxCarrinho.Items.Clear();
            txtSubtotal.Clear();
            subTotal = 0;
            txtCodigoBarras.Clear();
            txtDescricao.Clear();
            txtPrecoUnitario.Clear();
            txtQuantidade.Clear();
            maskedTextBox1.Clear();
        }

        private void btnAbrirCupom_Click(object sender, EventArgs e)
        {
            string cupomFiscal = "Cupom Fiscal Paulista\n";
            cupomFiscal += $"CPF: {maskedTextBox1.Text}\n";
            cupomFiscal += "Produtos:\n";

            foreach (var item in listBoxCarrinho.Items)
            {
                cupomFiscal += item.ToString() + "\n";
            }

            cupomFiscal += $"Subtotal: {txtSubtotal.Text}\n";
            MessageBox.Show(cupomFiscal, "Cupom Fiscal");
        }
    }
    }

    

