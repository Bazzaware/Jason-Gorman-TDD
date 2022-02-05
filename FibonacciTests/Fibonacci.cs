using System;
using System.Collections.Generic;

namespace FibonacciTests
{
    internal class Fibonacci
    {
        public Fibonacci()
        {
        }
        
        internal int getNumber(int index)
        {
            if (index < 0)
            {
                throw new ArgumentOutOfRangeException("index");
            }
            int[] sequence = new int[index+1];
            for (int i = 0; i < sequence.Length; i++)
            {
                if (i < 2)
                {
                    sequence[i] = i;
                }
                else
                {
                    sequence[i] = sequence[i - 1] + sequence[i - 2];
                }
            }
            return sequence[index];
        }

    }
}