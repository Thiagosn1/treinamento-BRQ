using System;

namespace Lista4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 3");
            Console.WriteLine();

            static void Ex1()
            {
                int A = 5;
                int B = 10;
                int C = 15;

                double X = A + B / C;

                Console.WriteLine($"{X} = {A} + {B} / {C}");
            }

            Ex1();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex2()
            {
                float nota1 = 6.0f;
                float nota2 = 5.0f;
                float nota3 = 9.0f;

                float media = ((nota1 * 2) + (nota2 * 3) + (nota3 * 5)) / 10;

                Console.WriteLine($"Média: {media}");
            }

            Ex2();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex3()
            {
                double segundo = 3920;

                double minuto = segundo / 60;
                double hora = segundo / 3600;

                Console.WriteLine($"{hora} horas equivale a {minuto} minutos que equivale a {segundo} segundos.");
            }

            Ex3();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex4()
            {
                float baseT = 34f;
                float alturaT = 55f;

                float areaT = baseT * alturaT / 2;

                Console.WriteLine($"A área de um triângulo equilátero de base {baseT} e altura {alturaT} equivale a {areaT}");
            }

            Ex4();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex5()
            {
                int A = 2;
                int B = 7;
                int C = 1;

                double equacao = Math.Pow((A + B), 2) + C;

                Console.WriteLine($"Resultado: {equacao}");
            }

            Ex5();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex6()
            {
                int num = 7;

                int dobroAntecessor = (num - 1) * 2;

                Console.WriteLine($"O dobro do antecessor de {num} é {dobroAntecessor}");
            }

            Ex6();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex7()
            {
                int votos = 45000;
                int votosBranco = 10000;
                int votosNulo = 5000;
                int votosValidos = 30000;

                float votosBrancoPorcent = 100 / (votos / votosBranco);
                float votosNuloPorcent = 100 / (votos / votosNulo);
                float votosValidosPorcent = 100 / (votos / votosValidos);

                Console.WriteLine($"Votos Totais: {votos}\nVotos Brancos: {votosBranco} ({votosBrancoPorcent}%)\nVotos Nulos: {votosNulo} ({votosNuloPorcent}%)\nVotos Válidos: {votosValidos} ({votosValidosPorcent}%)");
            }

            Ex7();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void Ex8()
            {
                float precoFabrica = 45000f;

                float porcentDistribuidora = (precoFabrica * 30) / 100;
                float taxas = (precoFabrica * 45) / 100;

                float precoFinal = precoFabrica + porcentDistribuidora + taxas;

                Console.WriteLine($"Preço final: R${precoFinal}");
            }

            Ex8();
        }
    }
}
