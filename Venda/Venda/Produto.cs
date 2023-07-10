using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda
{
    internal class Produto
    {
        public double Preco { get; set; }
        public Produto( double preco = 0.00)
        {
          
            Preco = preco;
        }

    }
}
