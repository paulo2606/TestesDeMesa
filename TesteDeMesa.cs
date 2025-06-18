using System;

namespace TestesDeMesa
{
    public class TesteDeMesa
    {
        private int a;
        private int b;
        private int c;
        private int[] v;

        public TesteDeMesa()
        {
            a = 10;
            b = 20;
            c = (a+b) / 2;
            c = c - 40;
            v = new int[6];
        }

        public void Teste01()
        {
            Console.WriteLine("Valores em cada posição do vetor:");
            for (int i = 0; i < v.Length; i++)
            {
                if (i == 3)
                {
                    v[i] = a + b + c;
                    Console.WriteLine($"Vetor na posição {i} = {v[i]}");
                }
                else
                {
                    Console.WriteLine($"Vetor na posição: {i} = {v[i]}");
                }
            }
            Console.WriteLine("\nValores das variaveis:");
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
        }
    }
}