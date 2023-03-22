using System;

namespace Power2Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // Chamamos método PowersOf2Until5()
            PowersOf2Until5();
            
        }
        // Criar método
        private static void PowersOf2Until5()
        {
           PowersOf2UntiLN(5);
        }
        // Criar método
        private static void PowersOf2UntiLN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
