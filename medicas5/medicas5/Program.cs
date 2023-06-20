using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace medicas5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4,total, media;
            Console.WriteLine("calcular médica ");
            Console.WriteLine("Digite a nota1 :");
            nota1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota2 :");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota3 :");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota4 :");
            nota4 = Convert.ToDouble(Console.ReadLine());
            total = nota1 + nota2 + nota3 + nota4;
            Console.WriteLine("O total é :" +total);
            media = total / 4;
            Console.WriteLine("A médica é :" + media);

            if(media >= 7) {
                Console.WriteLine("Aprovado!");
            }else{ 
                Console.WriteLine("Reprovado");
            }

        }
    }
}
