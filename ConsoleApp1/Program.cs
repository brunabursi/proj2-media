using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, soma, cont;
            double media;

            soma = 0;
            cont = 0;
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma = soma + idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }

            media = soma / cont;

            Console.WriteLine(media.ToString("F2"));
            Console.ReadLine();

        }
    }
}
