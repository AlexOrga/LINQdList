using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQdList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 1 --------------------");
            var restrictFilter = new RestrictFilter();
            restrictFilter.ExerciseOne();
            Console.WriteLine("Exercise 2 --------------------");
            restrictFilter.ExerciseTwo();
            Console.WriteLine("Exercise 3 --------------------");

            var orderingOperations = new OrderingOperations();
            orderingOperations.ExerciseThree();
            Console.WriteLine("Exercise 4 --------------------");
            orderingOperations.ExerciseFour();
            Console.WriteLine("Exercise 5 --------------------");

            var aggregateOperations = new AggregateOperations();
            aggregateOperations.ExerciseFive();
            Console.WriteLine("Exercise 6 --------------------");
            aggregateOperations.ExerciseSix();
            Console.WriteLine("Exercise 7 --------------------");
            aggregateOperations.ExerciseSeven();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}
