
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.id = 1;
            livro.titulo = "Harry Potter";
            livro.Ano = 2021;
            livro.NumroPagina = 20;
            livro.MostrarDetale();


            Console.WriteLine("==========");
            LivroDigital livrodigital = new LivroDigital();
            livrodigital.id = 2;
            livrodigital.titulo = "Harry Potter 2";
            livrodigital.Ano = 2023;
            livrodigital.NumroPagina = 23;
            livrodigital.tipoarquivo = "PDF";
            livrodigital.TamanhoMB =258;
            livrodigital.MostrarDetale();





        }
      


    }
}
