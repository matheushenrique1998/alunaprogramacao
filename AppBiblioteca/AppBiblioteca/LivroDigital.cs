using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class LivroDigital : Livro
    {
        public string tipoarquivo;
        private int tamanhoMB;
        public int TamanhoMB
        {
            get { return tamanhoMB; }
            set
            {
                if (value > 0)
                {
                    tamanhoMB = value;

                }
                else
                {
                    Console.WriteLine("Tamanho do arquivo Inválido");
                }
            }
           
        }
        public override void MostrarDetale()
        {
            base.MostrarDetale();
            Console.WriteLine("Tamanho MB:{0}Mb", tamanhoMB);
            Console.WriteLine("Tipo Arquivo{0}", tipoarquivo);
        }
    }
}
    
    

