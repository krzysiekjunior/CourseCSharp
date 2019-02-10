using System.Collections.Generic;
using System.Linq;

namespace StudentDiaryOdc13
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        //Stan (zmienne - pola)
        private List<float> ratings;              //lista ocen

        //Zachowania

        public void AddRating(float rating)
        {
            if (rating >= 0 && rating <=10)
            {
                ratings.Add(rating);            //metoda dodaje ocenę do listy ocen
            }
        }

       
        internal DiaryStatistics ComputeStatistics()
        {
            DiaryStatistics stats = new DiaryStatistics();

            float sum = 0f;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            stats.AverageGrade = sum / ratings.Count();     //oblicza średnią
            stats.MaxGrade = ratings.Max();                 //najwyższa ocena
            stats.MinGrade = ratings.Min();                 //najniższa ocena

            return stats;
        }
    }
}
