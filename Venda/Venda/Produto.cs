using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda
{
    internal class Produto
    {
        public Produto() { }
        public Produto(Guid id) { }
        public Guid Id { get; set; }
        public string Pedido { get; set;
        }
    }
}
