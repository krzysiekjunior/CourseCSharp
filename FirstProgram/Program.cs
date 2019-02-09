using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            ValueTypes();

            for (int i = 0; i < 3; i++)
            {
                WypiszImie();
                SprawdzWiek();
                DomyslneUstaw();
            }
        }

        ///<summary>
        ///maksymalny i minimalny wiek
        ///</summary>

        private static void ValueTypes()
        {
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            long minLong = long.MinValue;
            long maxLong = long.MinValue;
            Console.WriteLine("minInt = " + minInt + " maxInt = " + maxInt);
            Console.WriteLine("minLong = " + minLong + " maxLong = " + maxLong);
        }

        /// <summary>
        /// Wypisuje imie
        /// </summary>
        private static void WypiszImie()
        {
            Console.Write("Jak masz na imię: ");
            string name = Console.ReadLine();

            Console.WriteLine("Witaj, " + name);
        }

        /// <summary>
        /// Sprawdza wiek i wyświetla odpowiedni komunikat
        /// </summary>
        private static void SprawdzWiek()
        {
            Console.Write("Wpisz ile masz lat: ");
            int wiek;
            bool wynik = int.TryParse(Console.ReadLine(), out wiek);   //TryParse zabezpiecza przed nieprawidłową wartością,
                                                                       //gdy user wprowadzi litere, bool przyjmie wart 0 (false)
                                                                       //          Console.WriteLine("Masz " + wiek + " lat");

            if (wynik == false)
            {
                Console.WriteLine("Podaj prawidłowy wiek");
            }
            else if (wiek < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie masz 18 lat, napij się mleka");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Napij się piwa");
            }
        }

        /// <summary>
        /// Przywraca ustawienia domyślne
        /// </summary>
        private static void DomyslneUstaw()
        {
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }
    }
}