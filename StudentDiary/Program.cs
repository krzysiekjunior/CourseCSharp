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
            diary.AddRating(5);
            Console.WriteLine(diary.CalculateAverage());
            Console.WriteLine(diary.CalculateAverage());
            Console.WriteLine(diary.GiveMaxRating());
            Console.WriteLine(diary.GiveMinRating());
        }
    }
}
