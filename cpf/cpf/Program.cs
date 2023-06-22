using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace TRABLAHANDOCOMARRAY
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] cpf = { 7, 7, 7, 7, 7, 7, 7, 7, 7, 7, 7 };
            int[]mult1= { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma = 0;
            int resto;

       
            Console.WriteLine("Digitwe oCPF 10APENAS):");
            string Cpf= Console.ReadLine();

            char[] numerosCpF = Cpf.ToCharArray();
            for (int i = 0; i < numerosCpF.Length; i++)
            {
                Console.WriteLine(numerosCpF[i]);

            }
            soma = resto = (soma * 10) % 11
  ;
            if (resto != cpf[9])
            { 
                Console.WriteLine("cpf invalido");
            }
            soma = resto = (soma * 10) % 11
  ;
            if (resto != cpf[10])
            {
                Console.WriteLine("cpf invalido");
            }
            int[] numerosInteiro = numerosCpF.Select(numero => Convert.ToInt32(numero.ToString())).ToArray();
            Console.WriteLine(string.Join("-",numerosInteiro)) ;
        }
    }
}
