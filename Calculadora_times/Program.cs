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
            while (true)
            {

                List<string> historicoConta = new List<string>();

                Console.WriteLine("Digite o que deseja fazer:\n" +
                    "1. Somar\n" +
                    "2. Subtrair\n" +
                    "3. Multiplicar\n" +
                    "4. Divisao\n" +
                    "5. Visualizar historico");

                int operacao = Convert.ToInt32(Console.ReadLine());

                if (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5 && operacao != 6)
                {
                    Console.WriteLine("Operação inválida, tente novamente");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

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

                    case 2:
                        resultado = n1 - n2;
                        break;

                    case 3:
                        resultado = n1 * n2;
                        break;

                    case 4:
                        resultado = n1 / n2;
                        break;

                    case 5:
                        foreach (string conta in historicoConta)
                        {
                            Console.WriteLine(conta);
                            continue;
                        }
                        break;
                }

                string simboloOperacao = "";

                switch (operacao)
                {
                    case 1:
                        simboloOperacao = "+";
                        break;

                    case 2:
                        simboloOperacao = "-";
                        break;

                    case 3:
                        simboloOperacao = "*";
                        break;

                    case 4:
                        simboloOperacao = "/";
                        break;
                }

                string resultadoOperacao = $"{n1} {simboloOperacao} {n2} = {resultado}";

                historicoConta.Add(resultadoOperacao);

                Console.WriteLine($"O resultado é: {resultadoOperacao}");
                Console.ReadLine();
            }
        }
    }
}
