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
            List<string> historicoConta = new List<string>();
            while (true)
            {
                MenuPrincipal();

                int operacao;

                try
                {
                    operacao = RecebeOperação();
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um numero!");
                    Console.ReadLine();
                    continue;
                }

                if (VerificarOpçõesDeOperação(operacao))
                {
                    ApresentarMensagem("Operação inválida, tente novamente");
                    continue;
                }

                if (VerificarOpçãoHistórico(operacao))
                {
                    ApresentarHistórico(historicoConta);

                    ApresentarMensagem("Digite qualquer coisa para continuar: ");
                    continue;
                }

                if (VerificarOpçãoSaída(operacao))
                {
                    break;
                }

                double n1, n2;

                n1 = ReceberPrimeiroNumero();

                n2 = ReceberSegundoNumero(operacao);

                double resultado = CalcularResultado(operacao, n1, n2);

                string simboloOperacao = DefinirSimboloOperação(operacao);

                string resultadoOperacao = AdicionarOperaçãoAoHistorico(historicoConta, n1, n2, resultado, simboloOperacao);
               
                ApresentarResultadoOperação(resultadoOperacao);
            }
        }

        private static void ApresentarResultadoOperação(string resultadoOperacao)
        {
            Console.WriteLine($"O resultado é: {resultadoOperacao}");
            Console.ReadLine();
        }

        private static string AdicionarOperaçãoAoHistorico(List<string> historicoConta, double n1, double n2, double resultado, string simboloOperacao)
        {
            string resultadoOperacao = $"{n1} {simboloOperacao} {n2} = {resultado}";

            historicoConta.Add(resultadoOperacao);
            return resultadoOperacao;
        }

        private static string DefinirSimboloOperação(int operacao)
        {
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

            return simboloOperacao;
        }

        private static double CalcularResultado(int operacao, double n1, double n2)
        {
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

            return resultado;
        }

        private static double ReceberSegundoNumero(int operacao)
        {
            double n2;
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
            return n2;
        }

        private static double ReceberPrimeiroNumero()
        {
            double n1;
            Console.WriteLine("Digite o primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            return n1;
        }

        private static bool VerificarOpçãoSaída(int operacao)
        {
            return operacao == 6;
        }

        private static bool VerificarOpçãoHistórico(int operacao)
        {
            return operacao == 5;
        }

        private static void ApresentarHistórico(List<string> historicoConta)
        {
            foreach (string conta in historicoConta)
            {
                Console.WriteLine(conta);
            }
        }

        private static void ApresentarMensagem(string mensagem)
        {
            Console.WriteLine(mensagem);
            Console.ReadLine();
        }

        private static bool VerificarOpçõesDeOperação(int operacao)
        {
            return operacao != 1 && operacao != 2 && operacao != 3 && operacao != 4 && operacao != 5 && operacao != 6;
        }

        private static int RecebeOperação()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine(
                "1. Somar\n" +
                "2. Subtrair\n" +
                "3. Multiplicar\n" +
                "4. Divisao\n" +
                "5. Visualizar historico\n" +
                "6. Encerrar o programa\n\n" +
                "Digite o que deseja fazer: ");
        }
    }
}
