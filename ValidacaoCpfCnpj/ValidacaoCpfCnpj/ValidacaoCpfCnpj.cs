using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            if (radioButton1.Checked)
            {
                string numerostring = TextBox1.txt;
                int[]= new int[11];

            }
            if (letras(numeroSting))
            {
                MessageBox.Show("o cpf aceito apenas numero", "Aviso", MessageBox.OK, MessageBoxIcon.Error);
                return;
            }
            if (numeroSting.length >= 15)
            {
                MessageBox.Show("o  número de caract foi utrapassdo", "Error", MessageBox.OK, MessageBoxIcon.Error);
                return;


            }

            private void button1_Click(object sender, EventArgs e)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Campo em branco", "bug", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;

                }



            }

            private void Form1_Load(object sender, EventArgs e)
            {


                if (radioButton1.Checked)
                { radioButton1.Checked = true; }

                bool ValidarCPF(string cpf)
                {
                    cpf = cpf.Replace(".", "").Replace("-", "");



                    if (cpf.Length != 11)
                        return false;



                    // Verifica se todos os dígitos são iguais
                    bool todosDigitosIguais = true;
                    for (int i = 1; i < cpf.Length; i++)
                    {
                        if (cpf[i] != cpf[0])
                        {
                            todosDigitosIguais = false;
                            break;
                        }
                    }
                    if (todosDigitosIguais)
                        return false;



                    int[] multiplicadoresDigito1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                    int[] multiplicadoresDigito2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };



                    int soma = 0;
                    for (int i = 0; i < multiplicadoresDigito1.Length; i++)
                    {
                        soma += multiplicadoresDigito1[i] * int.Parse(cpf[i].ToString());
                    }



                    int resto = soma % 11;
                    int digito1 = (resto < 2) ? 0 : 11 - resto;



                    if (int.Parse(cpf[9].ToString()) != digito1)
                        return false;



                    soma = 0;
                    for (int i = 0; i < multiplicadoresDigito2.Length; i++)
                    {
                        soma += multiplicadoresDigito2[i] * int.Parse(cpf[i].ToString());
                    }



                    resto = soma % 11;
                    int digito2 = (resto < 2) ? 0 : 11 - resto;



                    return int.Parse(cpf[10].ToString()) == digito2;
                }



                {
                    bool validaCpf = false;



                    while (!validaCpf)
                    {
                        ("Digite o CPF: ");
                        string cpf = Console.ReadLine();



                        if (cpf.Length == 11)
                        {
                            bool contemLetras = false;
                            foreach (char c in cpf)
                            {
                                if (!char.IsDigit(c))
                                {
                                    contemLetras = true;
                                    break;
                                }
                            }



                            if (!contemLetras && ValidarCPF(cpf))
                            {
                                validaCpf = true;
                                cpf = cpf.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                                Console.WriteLine("CPF Válido: " + cpf);
                            }
                            else
                            {
                                ("CPF Inválido. Digite apenas números.");
                            }
                        }
                        else
                        {
                            ("CPF Inválido. O CPF deve conter 11 dígitos.");
                        } if (radioButton2.Checked)
                        { radioButton2.Checked = false; }



                    }


                }


            }
            private void radioButton2_CheckedChanged(object sender, EventArgs e)
            {



            }

            private void radioButton1_CheckedChanged_2(object sender, EventArgs e)
            {

            }
        }
    } }
    
        
    
    

