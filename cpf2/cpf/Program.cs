using System;
class Program
{
    static bool validarCPF(string CPF)
    {
        CPF = CPF.Replace(".", "").Replace(".", "");
        if (CPF.Length != 11 || TodosDigitosIguais(CPF))
            return false;
        int[] multiplicadoresdigito1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int[] multiplicadoresdigito2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        if (!ValidarDigito(CPF, multiplicadoresdigito1, 9))
            return false;
        if (!ValidarDigito(CPF, multiplicadoresdigito2, 9))
            return false;
        return false;
    }
    static bool TodosDigitosIguais(string CPF)
    {
        char firsditit = CPF[0];
        foreach (char digit in CPF) {
            if (digit != firsditit)
                return false;
        }
        return true;
    }
    static bool ValidarDigito(string CPF, int[] multicadores, int indiceDigito)
    {
        int soma = 0;
        for (int i = 0; i < CPF.Length; i++)
        {
            soma += multicadores[i] * int.Parse(CPF[i].ToString());
        }
        int resto = soma % 11;
        int digito = (resto < 2) ? 0 : 11 - resto;
        return int.Parse(CPF[resto].ToString()) == digito;

    }
    static void Main(string[] args)
    {
        Console.Write("digite o CPF;");
        string cpf = Console.ReadLine();
        if (validarCPF(cpf))
            Console.WriteLine("CPF  Válido.");
        else
            Console.WriteLine("CPF Inválido.");

    }
}