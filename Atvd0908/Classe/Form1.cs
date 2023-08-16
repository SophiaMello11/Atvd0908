using System.Drawing;

namespace Atvd0908
{
    public partial class Form1 : Form

    {
        public string Nome { get; set; }
        public int ID { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDataNascimento_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (txtCpf.Text == string.Empty || txtNascimento.Text == string.Empty || txtId.Text == string.Empty || txtNome.Text == string.Empty || txtRenda.Text == string.Empty)
            {
                MessageBox.Show("Há alguma caixa vazia!");
            }
            else
            {
                if (double.TryParse(txtCpf.Text, out double res) == false || txtCpf.TextLength < 11)
                {
                    MessageBox.Show("Cpf inválido!");
                }
                else
                {
                    MessageBox.Show("Cadastrado!");
                    Form1 dados = new Form1();
                    string nome = txtNome.Text;


                }
                bool Id = true;
                foreach (char c in txtId.Text)
                {
                    if (!char.IsDigit(c) || c == 0)
                    {
                        Id = false; break;
                    }

                }
                if (Id)
                {
                    Console.WriteLine("ID válido!");

                }
                else
                {
                    Console.WriteLine("ID inválido. Deve conter apenas digitos não nulos");

                }
            }
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}