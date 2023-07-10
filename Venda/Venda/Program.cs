using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Venda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente();
            cliente.IdCliente = 1;
            cliente.Produto = "celular";
            cliente.Quantidade = 5;

            Produto produto = new Produto();
            produto.Preco = 2598.90;

            Venda venda = new Venda(cliente, produto);
            venda.Id = 1;
            double valorTotal = venda.ValorTotal;

            Console.WriteLine($"o cliente comprou o produto {cliente.Produto} com o valor de {produto.Preco:c} \n" +
                $"totalizando um valor de {valorTotal:c}");
        }
    }
}
