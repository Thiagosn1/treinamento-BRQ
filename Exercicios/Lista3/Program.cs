using System;

namespace Lista3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 3");
            Console.WriteLine();

            static void Ex1()
            {
                double nota1 = 6.0;
                double nota2 = 7.0;
                double nota3 = 8.0;

                double media = (nota1 + nota2 + nota3) / 3.0;

                Console.WriteLine($"Média = {media}");

                if (media >= 6.0)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }

            Ex1();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex2()
            {
                int A = 11;
                int B = 5;
                int C = 2;

                if (A > B)
                {
                    if (B > C)
                    {
                        Console.WriteLine($"{A} é o maior número.");
                    }
                    else
                    {
                        Console.WriteLine($"{C} é o maior número.");
                    }
                }
                else if (B > C)
                {
                    Console.WriteLine($"{B} é o maior número.");
                }
                else
                {
                    Console.WriteLine($"{C} é o maior número.");
                }
            }


            Ex2();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex3()
            {
                int A = 10;
                int B = 1;

                if (A % B == 0 || B % A == 0)
                {
                    Console.WriteLine("São múltiplos");
                }
                else
                {
                    Console.WriteLine("Não são múltiplos");
                }
            }

            Ex3();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex4()
            {
                float altura = 1.80f;
                int sexo = 1;

                if (sexo == 0)
                {
                    float imc = (72.7f * altura) - 58;
                    Console.WriteLine($"Seu IMC é {imc}");
                }
                else if (sexo == 1)
                {
                    float imc = (62.1f * altura) - 44.7f;
                    Console.WriteLine($"Seu IMC é {imc}");
                }
                else
                {
                    Console.WriteLine("Números inválidos.");
                }
            }

            Ex4();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex5()
            {
                int num1 = 7;
                int num2 = 2;

                if (num1 == num2)
                {
                    Console.WriteLine("Números iguais.");
                }
                else if (num1 > num2)
                {
                    Console.WriteLine("O Primeiro número é maior.");
                }
                else if (num1 < num2)
                {
                    Console.WriteLine("O Segundo número é maior.");
                }
            }

            Ex5();

            Console.WriteLine();
            /* ------------------------------------------------ */
            
            static void Ex6()
            {
                for (int i = 10; i > 0; i--)
                {
                    Console.WriteLine($"{i}");
                }
            }

            Ex6();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex7()
            {
                for (int i = 1; i < 51; i++)
                {
                    if (i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Ex7();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex8()
            {
                int num = 11;

                for (int i = 1; i < num + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Ex8();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex9()
            {
                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine($"5 X {i} = {i * 5}");
                }
            }

            Ex9();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static int fibbo(int num)
            {
                if (num < 2)
                {
                    return num;
                }
                else
                {
                    return fibbo(num - 1) + fibbo(num - 2);
                }
            }

            static void Ex10()
            {
                for (int i = 1; i < 16; i++)
                {
                    Console.WriteLine($"(número {i}): {fibbo(i)}");
                }
            }

            Ex10();
        }
    }
}
