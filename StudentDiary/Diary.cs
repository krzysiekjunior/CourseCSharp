using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Diary
    {
        public Diary()
        {
            ratings = new List<float>();
        }

        //Stan (zmienne - pola)
        List<float> ratings;              //lista ocen


        //Zachowania

        public void AddRating(float rating)
        {
            ratings.Add(rating);            //metoda dodaje ocenę do listy ocen
        }

        public float CalculateAverage()
        {
            float sum = 0, avg = 0;
            foreach (var rating in ratings)
            {
                sum += rating;
            }
            avg = sum / ratings.Count();    //oblicza średnią

            return avg;
        }

        public float GiveMaxRating()
        {
            return ratings.Max();           //najwyższa ocena
        }

        public float GiveMinRating()
        {
            return ratings.Min();           //najniższa ocena
        }
    }
}
