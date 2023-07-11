using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace alortmosdiversoscsharp
{
    internal class ListaDeCompras
    {
        static void Main()
        {
            List<string> listaDeCompra = new List<string>();
            Console.Write(":::::::: Programa de lista de Compras :::::::::");
            while (true)
            {
                Console.WriteLine("Digite um item para para adivionar á lista (ou 'parar' sair ): ");
                string item = Console.ReadLine();
                if (item.ToLower() == "parar")
                {
                    break;
                }
                listaDeCompra.Add(item);
                Console.WriteLine("Item adicionado com sucesso!");
            }

            Console.Write("-----sua lista de Compras -----");
            //imprimir a lista ,porem estaja o texto "lista está vazia",
            //caso contrario i,primir todo os tens na tela

            if (listaDeCompra.Count == 0)
            {
                Console.WriteLine("lista esta está vazia");
            }
            else
            {
                foreach (string lista in listaDeCompra)
                {

                    Console.WriteLine(lista);
                }
            }
        }
        
    }
}