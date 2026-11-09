using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    internal class Exercicioswitch5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 05");
            Console.WriteLine("atendimento ao cliente digite um numero de 1 a 5: 1 - financeiro, 2 - suporte tecnico, 3 - recursos humanos, 4 - vendas, 5 - cancelamento");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("selecionou financeiro");
                    break;
                case 2:
                    Console.WriteLine("selecionou suporte técnico");
                    break;
                case 3:
                    Console.WriteLine("selecionou recursos humanos");
                    break;
                case 4:
                    Console.WriteLine("selecionou vendas");
                    break;
                case 5:
                    Console.WriteLine("selecionou cancelamento");
                    break;

                default:
                    Console.WriteLine("departamento não encontrado");
                    break;
            }
        }
    }
}
