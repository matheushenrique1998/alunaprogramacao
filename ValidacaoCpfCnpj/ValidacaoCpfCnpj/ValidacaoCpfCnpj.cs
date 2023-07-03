using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ValidacaoCpfCnpj
{
    public partial class ValidacaoCpfCnpj : Form
    {
        public ValidacaoCpfCnpj()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
  
        }
        private void button1_Click(object sender, EventArgs e) //Quando apertar OK
        {
            if (txtvalidacao.Text == "" && !rbcpf.Checked && !rbcnpj.Checked)
            {
                MessageBox.Show("Campo em branco", "bug", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtvalidacao.Text == "" && rbcpf.Checked)
            {
                MessageBox.Show("coloque o número do seu cpf", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtvalidacao.Text == "" && rbcnpj.Checked)
            {
                MessageBox.Show("coloque o número do seu cnpj","error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (rbcpf.Checked)
            {
                if(txtvalidacao.Text.Length < 11)
                {
                    MessageBox.Show("coloque todos os digitos do seu cpf", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string numerostring = txtvalidacao.Text;
                int[] cpf = numerostring.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();

                int[] multiplicadoresDigito1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicadoresDigito2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

                int soma = 0;
             
                for (int i = 0; i < multiplicadoresDigito1.Length; i++)
                {
                    soma += cpf[i] * multiplicadoresDigito1[i];
                }
                int resto = soma % 11;
                int digito1 = (resto < 2) ? 0 : 11 - resto;

                int soma2 = 0;
                for (int i = 0; i < multiplicadoresDigito2.Length; i++)
                {
                    soma2 +=cpf[i] * multiplicadoresDigito2[i];
                }
                int resto2 = soma2 % 11;
                int digito2 = (resto2 < 2) ? 0 : 11 - resto2;

                string cpfFormatado = $"{numerostring.Substring(0, 3)}.{numerostring.Substring(3, 3)}.{numerostring.Substring(6, 3)}-{numerostring.Substring(9, 2)}";

                if (cpf[9] == digito1 && cpf[10] == digito2)
                {
                    MessageBox.Show($"o cpf: {cpfFormatado} é valido","valido", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"o cpf: {cpfFormatado} é invalido","invalido", MessageBoxButtons.OK);
                }
            }
            else if (rbcnpj.Checked)
            {
                if (txtvalidacao.Text.Length < 14)
                {
                    MessageBox.Show("coloque todos os digitos do seu cnpj", "error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                string cnpjString = txtvalidacao.Text;
                int[] cnpj = cnpjString.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();

                int[] multiplicadoresDigito1 = {5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};
                int[] multiplicadoresDigito2 = {6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2};

                int soma = 0;
                for (int i = 0; i < multiplicadoresDigito1.Length; i++)
                {
                    soma += cnpj[i] * multiplicadoresDigito1[i];
                }
                int resto = soma % 11;
                int digito1 = (resto < 2) ? 0 : 11 - resto;

                int soma2 = 0;
                for (int i = 0; i < multiplicadoresDigito2.Length; i++)
                {
                    soma2 += cnpj[i] * multiplicadoresDigito2[i];
                }
                int resto2 = soma2 % 11;
                int digito2 = (resto2 < 2) ? 0 : 11 - resto2;

                string cnpjFormatado = $"{cnpjString.Substring(0, 2)}.{cnpjString.Substring(2, 3)}.{cnpjString.Substring(5, 3)}/{cnpjString.Substring(8, 4)}-{cnpjString.Substring(12, 2)}";

                if (cnpj[12] == digito1 && cnpj[13] == digito2)
                {
                    MessageBox.Show($"o cnpj: {cnpjFormatado} é valido", "valido", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show($"o cnpj: {cnpjFormatado} é invalido", "invalido", MessageBoxButtons.OK);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                                       
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ValidacaoCpfCnpj_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void numero_click(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Impede a digitação de caracteres não numéricos
            }
            int maxLength = 0;

            if (rbcpf.Checked) //se o botão de cpf está ativo
            {
                maxLength = 11;
            }
            else if (rbcnpj.Checked) //se o botão de cnpj está ativo
            {
                maxLength = 14;
            }
            else
            {
                return; // Nenhum RadioButton está marcado, não faz nada
            }
            if (txtvalidacao.Text.Length >= maxLength && e.KeyChar != '\b') // Verifica se atingiu o limite e a tecla pressionada não é "Backspace"
            {
                txtvalidacao.SelectionStart = txtvalidacao.Text.Length; // Mantém o cursor no final do texto
                e.Handled = true; // Impede que o caractere seja digitado
                MessageBox.Show("O limite de caracteres foi excedido!", "Erro!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
    
        
    
    

