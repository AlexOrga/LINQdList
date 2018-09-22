using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace LINQdList
{
    class PartitioningOperations
    {
        public void ExerciseEight()
        {
            List<int> wheresSquareDo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            IEnumerable<int> notDivisibleByTwo = wheresSquareDo.Take();
        }
        
    }
}
