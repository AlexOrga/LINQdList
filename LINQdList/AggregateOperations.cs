using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQdList
{
    class AggregateOperations
    {
        public void ExerciseFive()
        {
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            int howMany = numbers.Count();

            Console.WriteLine(howMany);
        }

        public void ExerciseSix()
        {
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            double datMoney = purchases.Sum();

            Console.WriteLine(datMoney);
        }

        public void ExerciseSeven()
        {
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            double mosSpensive = prices.Max();

            Console.WriteLine(mosSpensive);
        }
    }
}
