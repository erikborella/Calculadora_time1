using System;
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
                Console.Clear();
                Console.WriteLine("Digite o que deseja fazer:\n" +
                    "1. Somar\n" +
                    "2. Subtrair\n" +
                    "3. Multiplicar\n" +
                    "4. Divisao");

                int operacao = Convert.ToInt32(Console.ReadLine());

                if (operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5 && operacao != 6)
                {
                    Console.WriteLine("Operação inválida, tente novamente");
                    Console.ReadKey();                    
                    continue;
                }

                double n1, n2;

                Console.WriteLine("Digite o primerio valor: ");
                n1 = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Digite o segundo valor: ");
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

                Console.WriteLine($"O resultado é: {n1} {simboloOperacao} {n2} = {resultado}");
                Console.ReadLine();

             }
            }
        }
    }
