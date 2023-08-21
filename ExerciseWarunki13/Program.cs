using System;
using System.ComponentModel.Design;

namespace ExerciseWarunki12
{
    class Program
    {
        private static void Main(string[] args)
        {
            float a = 0;
            float b = 0;
            float wynik = 0;
            int wybor = 0;
            bool parseresult;
            //Operation choose
            do
            {
                Console.WriteLine("Wybierz operację:\n" +
                    "1 - Dodawanie\n" +
                    "2 - Odejmowanie\n" +
                    "3 - Mnożenie\n" +
                    "4 - Dzielenie");
                parseresult = Int32.TryParse(Console.ReadLine(), out wybor);
            }
            while (!parseresult || wybor < 1 || wybor > 4);
            //Numbers read
            do
            {
                Console.WriteLine("Podaj pierwsza liczbę");
                parseresult = float.TryParse(Console.ReadLine(), out a);
            }
            while (!parseresult);

            do
            {
                if (wybor == 4)
                {
                    Console.WriteLine("Podaj druga liczbę różną od zera");
                }
                else
                {
                    Console.WriteLine("Podaj druga liczbę");
                }                  
                parseresult = float.TryParse(Console.ReadLine(), out b);
            }
            while (!parseresult || (wybor == 4 && b == 0));

            //Calculation
            switch (wybor)
            {
                case 1:
                    wynik = a + b;
                    Console.WriteLine($"Wynik dodawania to:{wynik}");
                    break;
                case 2:
                    wynik = a - b;
                    Console.WriteLine($"Wynik odejmowania to:{wynik}");
                    break;
                case 3:
                    wynik = a * b;
                    Console.WriteLine($"Wynik mnożenia to:{wynik}");
                    break;
                case 4:
                    wynik = a / b;
                    Console.WriteLine($"Wynik dzielenia to:{wynik}");
                    break;                
                default:
                    Console.WriteLine($"Niepoprawne dane");
                    break;
            }
        }
    }
}

