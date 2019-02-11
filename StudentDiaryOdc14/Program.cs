using System;

namespace StudentDiaryOdc14
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


            Console.WriteLine(Diary.MaxGrade);

            Diary diary2 = new Diary();
            Diary diary3 = new Diary();
            Diary diary4 = new Diary();
            Diary diary5 = new Diary();
            Diary diary6 = new Diary();

            Console.WriteLine(Diary.Count);                 //Dzięki zmiennej STATIC z klasy Diary np. możemy się dowiedzieć 
                                                            //ile mamy obiektów danej klasy Diary. 
                                                            //Dzięki temu że zmienna count jest statyczna licznik jest jeden 
                                                            //dla wszystkich obiektów


            DiaryStatistics stats = diary.ComputeStatistics();

            Console.ReadKey();
        }
    }
}
