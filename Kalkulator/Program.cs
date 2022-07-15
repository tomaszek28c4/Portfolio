using System;

namespace Calculator.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)  //nie zwracająca metoda statyczna klasy
        {
            //1. Wyświetlenie nagłowka - opis aplikacji
            Console.WriteLine("Witaj w aplikacji KALKULATOR!");
            bool cont = true;
            
            for (int i =0 ; i < 5; i++ )      //warunek pętli FOR (   instrukcje zmiennej dla pętli ; warunek pętli dalszego działania albo jej przerwania ; instrukcje do wykonania po zakończeniu obejścia pętli     )
            {





                //2. Prośba o podanie 1 liczby
                Console.WriteLine("Podaj proszę 1 liczbę:");
                string userX = Console.ReadLine();
                //3. Pobranie liczby od użytkownika
                double number1 = double.Parse(userX);

                //4. Prośba o podanie działania
                Console.WriteLine("Jaką operację chcesz wykonać? Możliwe operacje to: '+', '-', '*', '/'.");

                //5. Pobranie wybranego działania od użytkownika
                var operation = Console.ReadLine();

                //6. Prośba o podanie 2 liczby
                Console.WriteLine("Podaj proszę 2 liczbę:");

                //7. Pobranie liczby od użytkownika
                string userY = Console.ReadLine();
                double number2 = double.Parse(userY);

                //8. Wykonanie obliczeń
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                    default:
                        throw new Exception("Wybrałeś złą operację!");
                }

                //9. Wyświetlenie wyniku użytkownikowi
                Console.WriteLine($"Wynik Twojego działania to: {result}.");

                //Czy chcesz wykonać następne działanie?
                Console.WriteLine("Czy chcesz wykonać następne działanie? t/n");
                string ifContinue = Console.ReadLine();
                if (ifContinue == "t")
                {
                    cont = true;
                    
                }
                if (ifContinue == "n") 
                {
                    cont = false;
                }
            }
        }
    }
}