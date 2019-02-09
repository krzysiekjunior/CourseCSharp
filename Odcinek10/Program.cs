using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();                  //zmienna typu referencyjnego nie przechowuje bezpośrednio obiektu,
            diary.AddRating(3);                         //tylko przechowuje wskaźnik do obiektu
            diary.AddRating(5);

            Diary diary2 = diary;
            diary2.AddRating(8);

            Diary diary3 = diary2;
            diary3.AddRating(1);

            int liczba = 1;                     // zmienna typu prostego "liczba" przechwuje wartość(liczbę)
        }
    }
}
