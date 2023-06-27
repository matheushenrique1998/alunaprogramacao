using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alortmosdiversoscsharp
{
    internal class EstruruturaCondicional
    {
        static void Main()
        {
            Console.WriteLine("======== Esturutura Condicional ========");
            int nota = 8;
            //Estruta simples
            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aproado");
            }
            
             Console.WriteLine("================");
           
            //estrutra composta
            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aproado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }
            Console.WriteLine("================");

            if (nota >= 9)
            {
                Console.WriteLine("Aluno nota A");
            }else if (nota >= 7)
            {
                Console.WriteLine("Aluno nota B");
            }else if (nota >= 5)
            {
                Console.WriteLine("Aluno nota C");
            } else if (nota >= 3)
            {
                Console.WriteLine("Aluno nota D");
            }
            else
            {
                Console.WriteLine("AlunoNOTA e");
            }
            Console.WriteLine("================");
            string cor = "Vermelho";
            switch(cor.ToLower())
            {
                case "verde":
                    Console.WriteLine("A cor e Verde");
                    break;
                case "vermelho":
                    Console.WriteLine("A cor e Vermelho");
                    break;
                case "azul":
                    Console.WriteLine("A cor e azul");
                    break;
                default:
                    Console.WriteLine("A cor não foi reconhecida");
                    break;
            }
        }
    }
}

