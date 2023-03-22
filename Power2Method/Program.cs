using System;

namespace Power2Method
{
    /// <summary>
    /// Programa que calcula as potências de 2
    /// </summary>
    class Program
    {
        /// <summary>
        /// Chama o método
        /// </summary>
        /// <param name="args">Lê da consola</param>
        static void Main(string[] args)
        {
            PowersOf2Until5();  
        }
        /// <summary>
        /// Calcula as potências de 2 dos números 1 a 5 e imprime na consola
        /// </summary>
        private static void PowersOf2Until5()
        {
           PowersOf2UntiLN(5);
        }
        /// <summary>
        /// Calcula as potências de 2 dos números 1 a n e imprime na consola
        /// </summary>
        /// <param name="n">último número a calcular a potência</param>
        private static void PowersOf2UntiLN(int n)
        {
            for (int i = 1; i <= (1 << n); i = i << 1)
            {
                Console.WriteLine(i);
            }
        }
    }
}
