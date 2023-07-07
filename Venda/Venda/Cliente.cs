using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Venda
{
    internal class Cliente
    {
        public int ID { get; set; }
        public int idCliente { get; set; }

        public string Produto { get; set; }
        public Cliente ( string produto ="0"){
            Produto = produto;
}

    }
}
