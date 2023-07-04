using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OrintacaoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            livro.IdLivro = 1;
            livro.Titulo = "naruto";
            livro.Autor = "masashi kishimoto";
            livro.Preco = 30.26;
            livro.NumeroPaginas = 192;
            livro.ImprimirDetalhes();

            Livro livro2 = new Livro();
            livro2.IdLivro = 2;
            livro2.Titulo = "bleach";
            livro2.Autor = "tite kubo";
            livro2.Preco = 85.80;
            livro2.NumeroPaginas = 200;
            Console.WriteLine("Detalhes do Livro 2");
            livro2.ImprimirDetalhes();
            Livro livro3 = new Livro(3, "fairy Tail", "Hiro Mashima", 200, 21.93);
            Livro livro4 = new Livro(idLivro: 4, numeroPaginas: 184, titulo: "Black clover", autor: "Ataka Tanemura", preco: 19.90);
            livro3.ImprimirDetalhes();
            livro4.ImprimirDetalhes();
            Livro livro5 = new Livro()
            {
                IdLivro = 5,
                Titulo = "dragon ball",
                NumeroPaginas = 192,
                Preco = 26.78,
                Autor = "akira toriyama",


            };
            livro5.ImprimirDetalhes();
        }
    }
}
    

