using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alortmosdiversoscsharp
{
    internal class TrabalhadoLista
    {
        static void ImprimeListra(List<int> lista,string  titulo = "====")
        {
            Console.WriteLine("====" + titulo+ "====");
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

        }
        static void Main()
        {
            //add:adiconado elemento na lista
            List<int> lista = new List<int>();
            lista.Add(1);
            lista.Add(90);
            lista.Add(50);
            lista.Add(10);
            lista.Add(40);
            lista.Add(70);
            ImprimeListra(lista, "adiconado elemento na lista");

            //remove:remove a primeira ociirrêncis de um  elemento da lista
            lista.Remove(10);
            foreach (int num in lista)
            {
                Console.WriteLine(num);
            }

            ImprimeListra(lista, " Remove a ptimeira de um elemento da lista ");
            //RemovAt:remove o elemento de um indice
            lista.RemoveAt(0);

            ImprimeListra(lista, "Remove  o elemento de um indice ");
            ImprimeListra(lista);
            //Sort:Ordernar os elementos em oddem cresecento
            lista.Sort();
            ImprimeListra(lista,"orderna Crescente");
            //Reverse:Ordernar os elementos em oddem cresecento
            lista.Reverse();
            ImprimeListra(lista, "orderna Decresecente");
            //count:Retorna a quantidade de elementos na lista
            int numeroItem=lista.Count;
            Console.WriteLine("existe {0} itens na lista",numeroItem);
            //contains : verfifica se o lista contém determinado elemento
            if (lista.Contains(40))
            {
                Console.WriteLine("Foi encontrado o item na lista");
            }
            else
            {
                Console.WriteLine("Não encontrado o item na lista");
            }
            //Insert:Insersre um elemento em um determinado indice da lista
            lista.Insert(2, 45);
            ImprimeListra(lista, "Inseresre um elemento emum deterinado indice da lista");

            //Clear;limpar os itens da lista
            lista.Clear();

        }
    }
        }
