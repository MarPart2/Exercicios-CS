using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoC_
{
    internal class EstruturaDeDecisãoSimples
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Estrutura de decisão Simples");
            Console.WriteLine("digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            if (idade < 18)
            {
                Console.WriteLine("Você não pode dirigir");
            }
        }
    }
}
