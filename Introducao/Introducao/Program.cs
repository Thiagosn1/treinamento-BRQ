using System;

namespace Introducao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Saída de Dados

            Console.Write("Digite seu nome:");

            // Entrada de Dados

            Console.ReadLine();

            /* --------------------------------------------------- */

            // Variáveis

            string nome = "Thiago"; // caractere
            int idade = 22; // inteiro
            float altura = 1.67f; // real
            bool estuda = true;

            // Constantes

            const int NumeroInscricao = 211;

            /* --------------------------------------------------- */

            // Vetores - Arrays

            string[] livros = { "Harry Potter", "1984", "A Revolução dos Bichos" };

            Console.WriteLine(livros[0]);

            /* --------------------------------------------------- */

            // Operadores Aritméticos

            Console.WriteLine();

            int num1 = 45;
            int num2 = 25;

            int soma = num1 + num2;
            int subtracao = num1 - num2;
            int multiplicacao = num1 * num2;
            int divisao = num1 / num2;

            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtração: " + subtracao);
            Console.WriteLine("Multiplicação: " + multiplicacao);
            Console.WriteLine("Divisão: " + divisao);

            // Operadores Relacionais

            // =   - Atribuição
            // ==  - Comparação - igual
            // !=  - Comparação - diferente
            // >   - Maior que
            // >   - Menor que
            // >=  - Maior ou igual
            // <=  - Menor ou igual

            // Operadores Lógicos

            // &&  - E
            // ||  - OU
            /* --------------------------------------------------- */

            // Estrutura Condicional - IF

            // Simples

            int num = 20;

            if (num > 0)
            {
                Console.WriteLine("O número é maior que zero");
            }
            else
            {
                Console.WriteLine("O número é menor que zero");
            }

            // Composta

            if (num > 0)
            {
                Console.WriteLine("O número é maior que zero");
            }
            else if(num == 0)
            {
                Console.WriteLine("O número é igual a zero");
            }
            else
            {
                Console.WriteLine("O número é menor que zero");
            }


            // Encadeada

            if (num1 > num2)
            {
                if (num1 == num2)
                {
                    Console.WriteLine("Num1 é igual a num2");
                }
                else
                {
                    Console.WriteLine("Num1 é diferente de num2");
                }
            }

            /* --------------------------------------------------- */

            // Estruturas de Repetição

            Console.Write("Digite seu nome:");
            string nomeUsuario = Console.ReadLine();

            // While

            while (nomeUsuario != "Thiago")
            {
                Console.WriteLine("Você não tem permissão para acessar");
                nomeUsuario = Console.ReadLine();
            }

            // Do While

            do
            {
                Console.WriteLine("Você não tem permissão para acessar");
                nomeUsuario = Console.ReadLine();
            } while (nomeUsuario != "Thiago");

            // Foreach

            foreach (string livro in livros)
            {
                Console.WriteLine(livro);
            }

            // For

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            /* --------------------------------------------------- */

            int a = 10;
            int b = 20;
            int c = 30;

            int d = a + b;

            // Concatenação - junção de variáveis do tipo string(texto) +

            Console.WriteLine("a + b = " + d);

            // Interpolação - junção de variáveis do tipo string(texto) $

            Console.WriteLine($"a, b, c = {a}, {b} + {c}");

            /* --------------------------------------------------- */

            // Funções / Métodos / Ações

            int Somar(int num1, int num2)
            {
                return num1 + num2;
            }

            Console.WriteLine( Somar(45, 63) );

            string MostraMensagemDeErro()
            {
                return "Houve um erro na aplicação";
            }

            Console.WriteLine( MostraMensagemDeErro() );

            void Mensagem()
            {
                Console.WriteLine("Hello World!");
            }

            Mensagem();
        }
    }
}
