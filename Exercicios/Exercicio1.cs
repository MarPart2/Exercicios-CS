using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoC_
{
    internal class Exercicio1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 01");
            Console.WriteLine("digite um numero");
            int numero = Convert.ToInt32(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("numero é positivo");
            }
        }
    }
}
