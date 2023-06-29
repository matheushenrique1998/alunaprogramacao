using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace alortmosdiversoscsharp
{
    internal class TrablhandoArray
    {
        static void Main()
        {

            int[] numero = { 10, 25, 30, 5, 50 };
            int[] numerosNotas = new int[5] { 10, 5, 8, 8, 5 };
            int[] notas = new int[4];
            notas[0] = 10;
            notas[1] = 8;
            notas[2] = 5;
            notas[3] = 10;

            foreach (int nota in numerosNotas)
            {
                Console.WriteLine(nota);
            }
           }
       }
}
