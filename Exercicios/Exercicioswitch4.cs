using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios
{
    internal class Exercicioswitch4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 04");
            Console.WriteLine("digite um numero de 1 a 4 para calcular: 1 - soma, 2 - subtração, 3 - multiplicação, 4 - divisão");
            int numero = Convert.ToInt32(Console.ReadLine());
            switch (numero)
            {
                case 1:
                    Console.WriteLine("digite o primeiro numero:");
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("digite o segundo numero:");
                    int num2 = Convert.ToInt32(Console.ReadLine());
                    int soma = num1 + num2;
                    Console.WriteLine("A soma é: " + soma);
                    break;
                case 2:
                    Console.WriteLine("digite o primeiro numero:");
                    int num3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("digite o segundo numero:");
                    int num4 = Convert.ToInt32(Console.ReadLine());
                    int subtracao = num3 - num4;
                    Console.WriteLine("A subtração é: " + subtracao);
                    break;
                case 3:
                    Console.WriteLine("digite o primeiro numero:");
                    int num5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("digite o segundo numero:");
                    int num6 = Convert.ToInt32(Console.ReadLine());
                    int multiplicacao = num5 * num6;
                    Console.WriteLine("A multiplicação é: " + multiplicacao);
                    break;
                case 4:
                    Console.WriteLine("digite o primeiro numero:");
                    int num7 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("digite o segundo numero:");
                    int num8 = Convert.ToInt32(Console.ReadLine());
                    double divisao = (double)num7 / num8;
                    Console.WriteLine("A divisão é: " + divisao);
                    break;
                default:
                    Console.WriteLine("método inválido");
                    break;
            }
        }
    }
}
