using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Livro
    {
        public int id { get; set; }
        public string titulo;
        private int numeroPagina;
        private int ano;
        public int Ano
        {
            get { return Ano; }
            set
            {
                if (value > 0)
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano de pulicação Inálido");
                }
            }
        }


        public int NumroPagina
        {
            get { return numeroPagina; }
            set
            {
                if (value > 0)
                {
                    numeroPagina = value;
                }
                else
                {
                    Console.WriteLine("Ano de pulicação Inálido");
                }
            }
        }
        public virtual void MostrarDetale()
        {
            Console.WriteLine("Id:{0}", id);
            Console.WriteLine("Título:{0}", titulo);
            Console.WriteLine("Ano:{0}", ano);
            Console.WriteLine("Número de Página{0} :", numeroPagina);
        }
    }
            }
        
           
        
    

