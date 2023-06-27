using System;
using System.Diagnostics.Eventing.Reader;

 

class Program
{
    static bool ValidarCPF(string cpf)
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



    static void Main(string[] args)
    {
        bool validaCpf = false;



        while (!validaCpf)
        {
            Console.Write("Digite o CPF: ");
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
                    Console.WriteLine("CPF Inválido. Digite apenas números.");
                }
            }
            else
            {
                Console.WriteLine("CPF Inválido. O CPF deve conter 11 dígitos.");
            }
        }
    }
}