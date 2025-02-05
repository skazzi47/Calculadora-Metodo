using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace MensagemInicio
{
    class Inicializacao
    {
        public static string? Menu()
        {
            Console.WriteLine("\n\t|---Calculadora---|\t\n");
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
    class De
    {
        public static void Numeros()
        {
            Console.WriteLine("Informe o 1º número:");
            int n1 = Console.ReadLine();
        }
    }
}
namespace A
{
    class D
    {
        public static void C()
        {
            Console.WriteLine($"A soma de {x} + {y} é igual à {resultado}");
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
        public static void B()
        {
            Console.WriteLine($"A subtração de {x} - {y} é igual à {resultado}");
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
        public static void L()
        {
            Console.WriteLine($"A multiplicação de {x} * {y} é igual à {resultado}");
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
        public static void V()
        {
            Console.WriteLine($"A divisão de {x} / {y} é igual à {resultado}");
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