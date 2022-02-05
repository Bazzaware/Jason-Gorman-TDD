using System;
using System.Collections.Generic;

namespace ExerciseOneTests
{
    internal class RomanNumeral
    {
        public RomanNumeral()
        {
        }

        private static Dictionary<int,string>  romanUnit = new Dictionary<int, string>()
        {
            [1] = "I",
            [2] = "II",
            [3] = "III",
            [4] = "IV",
            [5] = "V",
            [6] = "VI",
            [7] = "VII",
            [8] = "VIII",
            [9] = "IX"
        };

        internal string convertIntToRoman(int interger)
        {
            string value = "";
            if (romanUnit.TryGetValue(interger,out value))
            {
                return value;
            }
            else
            {
                throw new KeyNotFoundException($"{interger} not found."); 
            }
        }
    }
}