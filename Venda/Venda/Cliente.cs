using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda
{
    internal class Cliente
    {
        
        public int IdCliente { get; set; }

        public string Produto { get; set; }
        private int quantidade { get; set; }


        public Cliente ( string produto ="")
        {
            Produto = produto;        
        }

        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if(value >= 0)
                {
                    quantidade = value;
                }
                else
                {
                    return;
                }
            }
        }
    }
}
