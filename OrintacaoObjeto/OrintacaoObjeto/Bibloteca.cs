using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrintacaoObjeto
{
    internal class Bibloteca
    {
        public string nome;
        public List<Livro> catalogo;
        public Bibloteca() {
            catalogo = new List<Livro>();
        }
        public void Cadastrarlivro(Livro livro)
        {
            catalogo.Add(livro);
        }
        public void MostrarCatalogo()
        {
            Console.WriteLine("Catalogo de Livrros da Biblioteca :{0}", nome);
            Console.WriteLine("=====");
            foreach(var livro in catalogo)
            {
                Console.WriteLine("Identificação: {0}| {1}|Preço:{2:c}", livro.IdLivro,livro.Titulo,livro.Preco);
            }
            Console.WriteLine("=====");
            Console.WriteLine("Total de Livros :{0}",catalogo.Count);
        }
    }
}


