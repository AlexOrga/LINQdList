using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQdList
{
    class OrderingOperations
    {
        public void ExerciseThree()
        {
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            IEnumerable<string> descending = names.OrderByDescending(n => n);

            foreach(string name in descending)
            {
                Console.WriteLine(name);
            }
        }

        public void ExerciseFour()
        {
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> ascending = numbers.OrderBy(num => num);

            foreach(int num in ascending)
            {
                Console.WriteLine(num);
            }
        }
    }
}
