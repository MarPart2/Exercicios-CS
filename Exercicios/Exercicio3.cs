using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoC_
{
    internal class Exercicio3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("digite a nota do aluno:");
            int nota = Convert.ToInt32(Console.ReadLine());
            if (nota < 5)
            {
                Console.WriteLine("Reprovado");
            }
            else if (nota > 10)
            {
                Console.WriteLine("nota invalida");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Recuperação");
            }
           
        }
    }
}
