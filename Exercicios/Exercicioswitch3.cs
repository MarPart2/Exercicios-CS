using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    internal class Exercicioswitch3
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 03");
            Console.WriteLine("Cardapio");
            Console.WriteLine("1 - hamburguer R$ 15,00");
            Console.WriteLine("2 - Pizza R$ 20,00");
            Console.WriteLine("3 - Refrigerante R$ 16,00");
            Console.WriteLine("4 - Suco R$ 8,00");
            Console.WriteLine("digite um numero de 1 a 4:");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("hamburguer R$ 15,00");
                    break;
                case 2:
                    Console.WriteLine("Pizza R$ 20,00");
                    break;
                case 3:
                    Console.WriteLine("Refrigerante R$ 16,00");
                    break;
                case 4:
                    Console.WriteLine("Suco R$ 8,00");
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }
}
