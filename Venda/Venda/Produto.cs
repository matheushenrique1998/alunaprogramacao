using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda
{
    internal class Produto
    {
        public string nome { get; set; }
        public double Preco { get; set; }
        public Produto(string nome = "0", double preco = 0.00)
        {
            nome = nome;
            Preco = preco;
        }

    }
}
