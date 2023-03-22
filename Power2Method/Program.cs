using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamamos 2 vezes o método PowersOf2UntilN()
            PowersOf2UntiLN(3);
            PowersOf2UntiLN(6);
            
        }
        // Criar método
        private static void PowersOf2Until5()
        {
            for (int i = 1; i <= (1 << 5); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
        private static void PowersOf2UntiLN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
