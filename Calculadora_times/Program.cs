﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_times
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o que deseja fazer:\n" +
                "1. Somar\n" +
                "2. Subtrair\n" +
                "3. Multiplicar\n" +
                "4. Divisao");

            int operacao = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o primerio valor: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            double resultado = 0;

            switch (operacao)
            {
                case 1:
                    resultado = n1 + n2;
                    break;
            }

            Console.WriteLine($"O resultado é: {resultado}");
        }
    }
}