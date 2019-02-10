using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odcinek10
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
        
        /// <summary>
        /// Dodawanie oceny
        /// </summary>
        /// <param name="rating"></param>
        public void AddRating(float rating)
        {
            ratings.Add(rating);            //metoda dodaje ocenę do listy ocen
        }

        /// <summary>
        /// Obliczanie średniej
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Pobiera najwyższą ocenę
        /// </summary>
        /// <returns></returns>
        public float GiveMaxRating()
        {
            return ratings.Max();           //najwyższa ocena
        }

        /// <summary>
        /// Pobiera najniższą ocenę
        /// </summary>
        /// <returns></returns>
        public float GiveMinRating()
        {
            return ratings.Min();           //najniższa ocena
        }
    }
}
