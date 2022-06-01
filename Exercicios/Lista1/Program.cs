using System;

namespace Lista1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista 1");
            Console.WriteLine();

            static void A()
            {
                Console.WriteLine("A:");
                Console.WriteLine();
                int x = 15;
                int y = 20;

                Console.WriteLine(x);

                int b = 3;

                Console.WriteLine($"{x}, {y}");
            }

            A();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void B()
            {
                Console.WriteLine("B:");
                Console.WriteLine();

                int a = 15;
                int b = 3;
                int c = a * b;

                Console.WriteLine(c);

                b = 10;

                c = a - b;

                Console.WriteLine($"{a}, {b}, {c}");
            }

            B();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void C()
            {
                Console.WriteLine("C:");
                Console.WriteLine();

                int x = 10;
                int y = 12;
                int z = x;

                y = z;
                x = y;

                Console.WriteLine($"{x}, {y}, {z}");
            }
            
            C();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void D()
            {
                Console.WriteLine("D:");
                Console.WriteLine();

                int a = 10;
                int b = a + 2;

                a = b + 1;
                b = a + 1;

                Console.WriteLine(a);

                a = b + 1;

                Console.WriteLine($"{a}, {b}");
            }
            
            D();

            Console.WriteLine();
            /* ------------------------------------------------ */

            static void E()
            {
                Console.WriteLine("E:");
                Console.WriteLine();

                int x = 12;
                int y = x;
                int z = x + y;

                x = 20;
                y = 10;

                Console.WriteLine($"{x}, {y}, {z}");
            }

            E();

            Console.WriteLine();
            /* ------------------------------------------------ */
            
            static void F()
            {
                Console.WriteLine("F:");
                Console.WriteLine();

                int a = 2;
                int b = 3;

                a = a + b;

                int c = a - b;
                Console.WriteLine(c);

                b = 5;
                Console.WriteLine($"{a}, {b}, {c}");
            }

            F();
        }
    }
}
