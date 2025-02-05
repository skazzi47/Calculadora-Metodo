using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace MensagemInicio
{
    class Inicializacao
    {
        public static string? Menu()
        {
            Console.WriteLine("\t|---Calculadora---|\t");
            Console.WriteLine("Escolha uma das seguintes operações:");
            Console.WriteLine("(+) Adição");
            Console.WriteLine("(-) Subtração");
            Console.WriteLine("(*) Multiplicação");
            Console.WriteLine("(/) Divisão");
            Console.Write("Digite o símbolo da operação desejada.\t");
            string? escolha = Console.ReadLine();
            if(escolha == "+" || escolha == "-"  || escolha == "*"  || escolha == "/" )
            {
                return escolha;
            }else
            {
                Console.Clear();
                Console.WriteLine("\nValor inválido");
                Thread.Sleep(1000);
                Console.Clear();
                return null;
            }
        }
    }
}
namespace Requisicao
{
    class Valores
    {
        public static void ParaConta(char escolha)
        {
            Console.WriteLine("Informe 2 numeros para realizar a operação: ");
            Console.Write("Informe o 1º número:");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Informe o 2º número:");
            double n2 = Convert.ToDouble(Console.ReadLine());
       

            switch(escolha)
            {
                case '+':
                    Console.WriteLine($"Resultado: {n1 + n2}");
                    break;

                case '-':
                    Console.WriteLine($"Resultado: {n1 - n2}");
                    break;

                case '*':
                    Console.WriteLine($"Resultado: {n1 * n2}");
                    break;

                case '/':
                    // Verifica se o divisor é diferente de zero
                    if (n2 != 0)
                    {
                        Console.WriteLine($"Resultado: {n1 / n2}");
                    }
                    else
                    {
                        Console.WriteLine("Erro: Não é possível dividir por zero.");
                    }
                    break;

                default:
                    Console.WriteLine("Operação inválida. Por favor, escolha uma operação válida (+, -, *, /).");
                    break;
            }
        }
    }
}