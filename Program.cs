using System;

namespace EvenOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;

            while (true)
            {
                Console.WriteLine("Podaj proszę swoją liczbę...");

                while (!int.TryParse(Console.ReadLine(), out input))
                {
                    Console.WriteLine("Podana przez Ciebie wartość NIE JEST LICZBĄ! Spróbuj ponownie.");
                }

                if (input == 0 || input < 0)
                {
                    Console.WriteLine("Liczba musi być większa od 0! Spróbuj ponownie.");
                    Console.WriteLine();
                }

                else if (input % 2 == 0)
                {
                    Console.WriteLine("Podana przez Ciebie liczba jest PARZYSTA!");
                    break;
                }                            

                else
                {
                    Console.WriteLine("Podana przez Ciebie liczba jest NIEPARZYSTA!");
                    break;
                }                
            }
        }
    }
}