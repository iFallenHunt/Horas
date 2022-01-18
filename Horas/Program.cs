using System;
using System.Globalization;

namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            // se o comando apos a condicional for simples, ou seja, apenas uma condição, nao é necessario as chaves "{}"
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa Noite!");
            }
        }
    }
}
