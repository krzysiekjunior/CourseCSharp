using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();

            //diary.AddRating(5);
            //diary.AddRating(8.5f);                          //litera f na koncu wartosci informuje
            //diary.AddRating(4.7f);                          //kompilator ze to float a nie double

            //float avg = diary.CalculateAverage();
            //float max = diary.GiveMaxRating();
            //float min = diary.GiveMinRating();

            Console.WriteLine("Aby przerwać działanie pętli wpisz 11");

            for (; ; )                                          //nieskończona pętla
            {
                Console.WriteLine("Podaj ocenę z przedziału 1 - 10: ");

                float rating;
                bool result = float.TryParse(Console.ReadLine(), out rating);   //spr. czy nie litera
                
                if (rating == 11)                                //gdy 11 przerywa działanie pętli
                {
                    break;
                }

                if (result == true)
                {
                    if (rating > 0 && rating <= 10)
                    {
                        diary.AddRating(rating);
                    }
                    else
                    {
                        Console.WriteLine("Nie podałeś oceny z przedziału 1 - 10");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Nie wprowadzaj liter !!!");
                }
                
            }

            Console.WriteLine("Średnia ocen: " + diary.CalculateAverage());
            Console.WriteLine("Maksymalna ocena: " + diary.GiveMaxRating());
            Console.WriteLine("Minimalna ocena: " + diary.GiveMinRating());
            Console.ReadKey();
        }
    }
}
