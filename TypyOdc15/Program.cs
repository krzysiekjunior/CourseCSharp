using System;

namespace TypyOdc15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diary diary = new Diary();                      // I dzienniczek

            //diary.AddRating(5);
            //diary.AddRating(8.5f);                          //litera f na koncu wartosci informuje
            //diary.AddRating(4.7f);                          //kompilator ze to float a nie double
            //diary.AddRating(11);

            //Diary diary2 = new Diary();
            //Diary diary3 = new Diary();
            //Diary diary4 = new Diary();
            //Diary diary5 = new Diary();
            //Diary diary6 = new Diary();

            //DiaryStatistics stats = diary.ComputeStatistics();

            Diary d1 = new Diary();                             //Typy referencyjne - zawiera odniesienie, wskaźnik na obiekt
            Diary d2 = d1;                          
            Diary d3 = d2;

            d1.Name = "Dzienniczek";                            // W klasie Diary jest - public string Name;
            Console.WriteLine(d3.Name);

            d1 = new Diary();
            Console.WriteLine(d1.Name);                         // Nie zostaje wyświetlone, gdyż zostałutworzyny nowy obiekt


            int x1 = 4;                                         //Typy wartościowe przechowują wartość
            int x2 = x1;
            x1 = 100;
            Console.WriteLine(x2);


            Console.ReadKey();
        }
    }
}
