using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    internal class Exercicioswitch1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 01");
            Console.WriteLine("digite um numero de 1 a 3:");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("Manhã");
                    break;
                case 2:
                    Console.WriteLine("Tarde");
                    break;
                case 3:
                    Console.WriteLine("Noite");
                    break;
                default:
                    Console.WriteLine("Período inválido");
                    break;
            }
        }
    }
}
