using System;
using System.Collections.Generic;

namespace ExerciseOneTests
{
    internal class NumberGenerator
    {
        public NumberGenerator()
        {
        }

        internal int getNumber()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }

        internal List<int> numberRange(int range)
        {
            List<int> results = new List<int>();
            for (int i = 0; i < range; i++)
            {
                results.Add(getNumber());
            }
            return results;
        }
    }
}