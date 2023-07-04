using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrintacaoObjeto
{
    internal class AppBibliitoteca
    {
        static void Main()
        {
            Bibloteca bibloteca = new Bibloteca();
            bibloteca.nome = "Senac Marilia";
            Livro livro = new Livro();

            livro.IdLivro = 1;
            livro.Titulo = "naruto";
            livro.Autor = "masashi kishimoto";
            livro.Preco = 30.26;
            livro.NumeroPaginas = 192;
         
            bibloteca.Cadastrarlivro(livro);
            Livro livro2 = new Livro();
            livro2.IdLivro = 2;
            livro2.Titulo = "bleach";
            livro2.Autor = "tite kubo";
            livro2.Preco = 85.80;
            livro2.NumeroPaginas = 200;
            bibloteca.Cadastrarlivro(livro2);
            bibloteca.MostrarCatalogo();
        }
    }
}
