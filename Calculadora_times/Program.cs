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
            List<string> historicoConta = new List<string>();
            while (true)
            {
                Console.Clear();
                Console.Write(
                    "1. Somar\n" +
                    "2. Subtrair\n" +
                    "3. Multiplicar\n" +
                    "4. Divisao\n" +
                    "5. Visualizar historico\n" +
                    "6. Encerrar o programa\n\n" +
                    "Digite o que deseja fazer: ");

                int operacao;

                try
                {
                    operacao = Convert.ToInt32(Console.ReadLine());
                } 
                catch (Exception)
                {
                    Console.WriteLine("Digite um numero!");
                    Console.ReadLine();
                    continue;
                }

                if (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5 && operacao != 6)
                {
                    Console.WriteLine("Operação inválida, tente novamente");
                    Console.ReadLine();                    
                    continue;
                }

                if (operacao == 5)
                {
                    foreach (string conta in historicoConta)
                    {
                        Console.WriteLine(conta);
                    }

                    Console.Write("Digite qualquer coisa para continuar: ");
                    Console.ReadLine();
                    continue;
                }

                if (operacao == 6)
                {
                    break;
                }

                double n1, n2;

                Console.Write("Digite o primeiro valor: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.Write("Digite o segundo valor: ");
                    n2 = Convert.ToDouble(Console.ReadLine());

                    if (operacao == 4 && n2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;

                        Console.WriteLine("Segundo número inválido! Tente novamente");

                        Console.ResetColor();

                        Console.ReadLine();
                    }

                } while (operacao == 4 && n2 == 0);


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
