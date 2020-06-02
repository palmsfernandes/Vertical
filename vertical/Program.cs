using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vertical
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int tamanho;

            Console.Write("Escreva uma palavra: ");
            a = Console.ReadLine().ToUpper();
            tamanho = a.Length;

            for (int i = 0; i <= tamanho; i++)
            {
                Console.WriteLine(a.Substring(0, i));
            }

            for (int i = 0; i <= tamanho; i++)
            {
                Console.WriteLine(a.Substring(i));
            }

            Console.ReadLine();
        }
    }
}
