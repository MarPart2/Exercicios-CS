using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoC_
{
    internal class Exercicio2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade < 18)
            {
                Console.WriteLine("Você é menor de idade");
            }
            else
            {
                Console.WriteLine("Você é maior de idade");
            }
        }
    }
}
