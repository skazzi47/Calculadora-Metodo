using System;
using System.Threading;

namespace Mensagem
{
    class Inicializacao
    {
        public static string Menu()
        {
            Console.WriteLine("\n\t|---Calculadora---|\t\n");
            Console.WriteLine("Escolha uma das seguintes operações:");
            Console.WriteLine("(+) Adição");
            Console.WriteLine("(-) Subtração");
            Console.WriteLine("(*) Multiplicação");
            Console.WriteLine("(/) Divisão");
            Console.Write("Digite o símbolo da operação desejada.\t");
            string escolha = Console.ReadLine();
            if (escolha == "+" || escolha == "-" || escolha == "*" || escolha == "/")
            {
                return escolha;  // Retorna a escolha para ser utilizada em outro método
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nValor inválido");
                Thread.Sleep(1000);
                Console.Clear();
                return null;  // Retorna null se a escolha for inválida
            }
        }
    }
}

namespace A
{
    class D
    {
        public static void C(int x, int y)
        {
            int resultado = x + y;
            Console.WriteLine($"A soma de {x} + {y} é igual à {resultado}");
            FinalizarPrograma();
        }

        private static void FinalizarPrograma()
        {
            Console.Write("Programa Finalizado");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}

namespace S
{
    class U
    {
        public static void B(int x, int y)
        {
            int resultado = x - y;
            Console.WriteLine($"A subtração de {x} - {y} é igual à {resultado}");
            FinalizarPrograma();
        }

        private static void FinalizarPrograma()
        {
            Console.Write("Programa Finalizado");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}

namespace M
{
    class U
    {
        public static void L(int x, int y)
        {
            int resultado = x * y;
            Console.WriteLine($"A multiplicação de {x} * {y} é igual à {resultado}");
            FinalizarPrograma();
        }

        private static void FinalizarPrograma()
        {
            Console.Write("Programa Finalizado");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}

namespace D
{
    class I
    {
        public static void V(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Erro: Divisão por zero não é permitida.");
                return;
            }
            double resultado = (double)x / y;
            Console.WriteLine($"A divisão de {x} / {y} é igual à {resultado}");
            FinalizarPrograma();
        }

        private static void FinalizarPrograma()
        {
            Console.Write("Programa Finalizado");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }
}

namespace Requisicao
{
    class De
    {
        public static void Numeros()
        {
            Console.WriteLine("Informe o 1º número:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o 2º número:");
            int y = int.Parse(Console.ReadLine());

            string escolha = Mensagem.Inicializacao.Menu(); // Obtemos a escolha do usuário

            if (escolha == null)
            {
                return; // Se a escolha for inválida, retorna sem fazer nada
            }

            // Verifica a operação escolhida e executa o método correspondente
            switch (escolha)
            {
                case "+":
                    A.D.C(x, y);
                    break;
                case "-":
                    S.U.B(x, y);
                    break;
                case "*":
                    M.U.L(x, y);
                    break;
                case "/":
                    D.I.V(x, y);
                    break;
                default:
                    Console.WriteLine("Operação inválida.");
                    break;
            }
        }
    }
}

class Programs
{
    static void Main(string[] args)
    {
        Requisicao.De.Numeros(); // Chama o método para solicitar os números e a operação
    }
}
