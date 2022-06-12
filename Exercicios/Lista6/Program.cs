using System;
using System.Linq;

namespace Lista6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 6");
            Console.WriteLine();

            static void Ex1()
            {
                int[] vetor = new int[8];

                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = (int)Math.Pow(i, 3);
                    Console.WriteLine($" Vetor[{i}] = {vetor[i]}");
                }
            }

            //Ex1();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex2()
            {
                int[] vetor1 = { 5, 1, 4, 2, 7, 8, 3, 6 };
                int[] vetor2 = new int[vetor1.Length];

                for (int i = 0; i < vetor1.Length; i++)
                {
                    vetor2[i] = vetor1[i] * 2;

                    Console.WriteLine($"Vetor1[{i}] = {vetor1[i]} | Vetor2[{i}] = {vetor2[i]}");
                }
            }

            //Ex2();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex3()
            {
                int[] vetorA = new int [10];
                int[] vetorM = new int [vetorA.Length];

                Console.WriteLine("Digite os números do Vetor A: ");

                for (int i = 0; i < 10; i++)
                {
                    vetorA[i] = int.Parse(Console.ReadLine());
                }

                Console.WriteLine("Digite um número:");
                int x = int.Parse(Console.ReadLine());

                for (int i = 0; i < vetorA.Length; i++)
                {
                    vetorM[i] = vetorA[i] * x;
                    Console.WriteLine($"VetorA[{i}] = {vetorA[i]} | VetorM[{i}] = {vetorM[i]}");
                }
            }

            //Ex3();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex4()
            {
                string[] nomes = new string[5];

                Console.WriteLine("Insira o nome de 5 Pessoas:");

                for (int i = 0; i < nomes.Length; i++)
                {
                    nomes[i] = Console.ReadLine();
                }

                Console.Write("Qual nome deseja Procurar: ");
                string nomePessoa = Console.ReadLine();

                var existe = nomes.Any(t => t.ToUpper() == nomePessoa.ToString().ToUpper());
                Console.WriteLine(existe ? "ACHEI" : "NÃO ACHEI");
            }

            //Ex4();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex5()
            {
                int[] vetorQ = new int[10];
                int maior = 0;
                int posicao = 0;

                for (int i = 0; i < vetorQ.Length; i++)
                {
                    Console.WriteLine($"Digite um valor par para a Posição {i}:"); 
                    vetorQ[i] = int.Parse(Console.ReadLine());
                    while (vetorQ[i] % 2 != 0) 
                    {
                        Console.WriteLine("Valor não aceito, digite um valor par!");
                        Console.WriteLine();

                        Console.WriteLine($"Digite um valor par para a Posição {i}:");
                        vetorQ[i] = int.Parse(Console.ReadLine());
                    }
      
                    if (maior < vetorQ[i])
                    {
                        maior = vetorQ[i];
                        posicao = i;
                    }
                }

                Console.WriteLine($"O maior valor é {maior} na posição {posicao}");
            }  

            //Ex5();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex6()
            {
                int[] temp = new int[7];
                int maiorTemp = 0, menorTemp = 0, mediaSemanal = 0;
                int qtd = 0;
         
                for(int i = 0; i < 7; i++)
                {
                    Console.WriteLine($"Digite a temperatura do dia {i+1}:");
                    temp[i] = int.Parse(Console.ReadLine());

                    if(i == 1)
                    {
                        maiorTemp = temp[i];
                        menorTemp = temp[i];
                    }

                    if(temp[i] > maiorTemp)
                    {
                        maiorTemp = temp[i];
                    }

                    if (temp[i] < menorTemp)
                    {
                        menorTemp = temp[i];
                    }

                    mediaSemanal = mediaSemanal + temp[i];
                }

                mediaSemanal = mediaSemanal / 7;

                for (int i = 0; i < 7; i++)
                {
                    if (temp[i] < mediaSemanal)
                    {
                        qtd = qtd + 1;
                    }
                }

                Console.WriteLine("Menor temperatura do ano: " + menorTemp);
                Console.WriteLine("Maior temperatura do ano: " + maiorTemp);
                Console.WriteLine("Temperatura média semanal: " + mediaSemanal);
                Console.WriteLine("Número de dias com temperatura foi inferior a média semanal: " + qtd);
            }

            //Ex6();
            
            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex7()
            {
                int[] vetor = new int[10];
                int i = 0, j = 0, aux;

                for (i = 0; i < 10; i++)
                {
                    Console.WriteLine($"Digite o {i + 1}º número: ");
                    vetor[i] = int.Parse(Console.ReadLine());
                }

                for (i = 0; i < vetor.Length; i++)
                {
                    for (j = 0; j < vetor.Length; j++)
                    {
                        if (vetor[i] < vetor[j])
                        {
                            aux = vetor[i];
                            vetor[i] = vetor[j];
                            vetor[j] = aux;
                        }
                    }
                }

                Console.WriteLine();

                Console.WriteLine("Vetor Ordenado");

                Console.WriteLine();

                for (i = 0; i < vetor.Length; i++)
                {
                    Console.WriteLine($"[{i + 1}] = {vetor[i]}");
                }

            }

            //Ex7();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex8()
            {
                static int Soma (int num1, int num2, int num3)
                {
                    return num1 + num2 + num3;
                }

                static int Media(int num1, int num2, int num3)
                {
                    return Soma(num1, num2, num3) / 3;
                }

                Console.WriteLine("Digite um número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Digite um número: ");
                int num2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("Digite um número: ");
                int num3 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine($"Soma: {Soma(num1, num2, num3)}");
                Console.WriteLine($"Média: {Media(num1, num2, num3)}");
            }

            //Ex8();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static string Ex9(int num)
            {
                if (num > 0)
                {
                    Console.WriteLine("P");
                    return "P";
                } 
                else
                {
                    Console.WriteLine("N");
                    return "N";
                }
            }
                
            //Ex9(5); // Digitar o número

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex10(int num)
            {
                Console.WriteLine(num.ToString().Length);
            }

            Ex10(14534345);
        }
    }
}
