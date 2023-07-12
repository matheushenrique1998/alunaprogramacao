using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda
{
    internal class Venda
    {
        public Venda() { }

        private Cliente cliente;
        private Produto produto;

        public int Id { get; set; }
        public double ValorTotal { get { return cliente.Quantidade * produto.Preco; } }

        public Venda(Cliente quantidade, Produto valor, int id = 1)
        {
            cliente = quantidade;
            produto = valor;
            id = 1;

        }
    }
}
