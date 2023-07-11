using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrintacaoObjeto
{
    internal class Livro
    {
        public string nome;
        
        public double Preco;
        public Livro( string nome= "", double preco = 0.0)
        {
            nome=nome
            preco = preco;

        }


        public void ImprimirDetalhes()
        {
            Console.WriteLine("----");
            Console.WriteLine("nome : {0}", nome);
           
          Console.WriteLine("Preço : {0:C}", Preco);
            Console.WriteLine("----");


        }

    }
}