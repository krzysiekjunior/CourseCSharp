using System;

namespace StudentDiaryOdc13
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();                      // I dzienniczek

            diary.AddRating(5);
            diary.AddRating(8.5f);                          //litera f na koncu wartosci informuje
            diary.AddRating(4.7f);                          //kompilator ze to float a nie double
            diary.AddRating(11);

            DiaryStatistics stats = diary.ComputeStatistics();

            Console.WriteLine("Średnia wynosi: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);


            Diary diary2 = new Diary();                         // II dzienniczek

            diary2.AddRating(3);
            diary2.AddRating(7.3f);                             //litera f na koncu wartosci informuje
            diary2.AddRating(9.9f);

            stats = diary2.ComputeStatistics();

            Console.WriteLine("Średnia wynosi: " + stats.AverageGrade);
            Console.WriteLine("Maksymalna ocena: " + stats.MaxGrade);
            Console.WriteLine("Minimalna ocena: " + stats.MinGrade);

            Console.ReadKey();
        }
    }
}
