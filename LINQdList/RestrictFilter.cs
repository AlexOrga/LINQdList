using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQdList
{
    class RestrictFilter
    {
        public void ExerciseOne()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            IEnumerable<string> elFruits = from fruit in fruits
                                           where fruit.StartsWith("L")
                                           select fruit;
            foreach (string fruit in elFruits)
            {
                if (fruit == elFruits.Last())
                {
                    Console.WriteLine(fruit);
                }
                else
                {
                    Console.WriteLine($"{fruit}, ");
                }
                
            }
        }

        public void ExerciseTwo()
        {
            List<int> nums = new List<int>() { 15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96 };

            IEnumerable<int> fourMultiples = nums.Where(num => (num % 4) == 0);
            IEnumerable<int> fourSixMultiples = fourMultiples.Where(num => (num % 6) == 0);

            foreach (int num in fourSixMultiples)
            {
                if(num == fourSixMultiples.Last())
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine($"{num}, ");
                }
                
            }
        }
    }
}
