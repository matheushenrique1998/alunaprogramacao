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
            Console.WriteLine("Digitwe oCPF 9APENAS):");
            string cpf = Console.ReadLine();

            char[] numerosCpF = cpf.ToCharArray();
            for (int i = 0; i < numerosCpF.Length; i++)
            {
                Console.WriteLine(numerosCpF[i]);

            }
            Console.WriteLine("======");
            foreach (char numero  in numerosCpF) {
                Console.WriteLine(numero);
            }
            int[]numerosInteirp = numerosCpF.Select (numero=> Convert.ToInt32(numero.ToString())).ToArray();
        }
    }
}
