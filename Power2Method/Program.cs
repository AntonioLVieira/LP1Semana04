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
            PowersOf2UntilN(2, 4);  
        }
        /// <summary>
        /// Calcula as potências de 2 dos números 1 a 5 e imprime na consola
        /// </summary>
        private static void PowersOf2Until5()
        {
           PowersOf2UntilN(5);
        }
        /// <summary>
        /// Calcula as potências de 2 dos números 1 a n e imprime na consola
        /// </summary>
        /// <param name="n">último número a calcular a potência</param>
        private static void PowersOf2UntilN(int n)
        {
            for (int i = 1; i <= (1 << n); i <<= 1)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Calcula as potências do número n1 até ao n2
        /// </summary>
        /// <param name="n1">número inicial</param>
        /// <param name="n2">número final</param>
        private static void PowersOf2UntilN(int n1, int n2)
        {
            for (int i = n1; i <= (n1 << n2); i <<= n1)
            {
                Console.WriteLine(i);
            }
        }

    }
}
