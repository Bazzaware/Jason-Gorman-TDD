using System;
using System.Collections.Generic;
using System.Linq;

namespace ExerciseOneTests
{
    internal class RomanNumeral
    {
        public RomanNumeral()
        {
        }

        private static Dictionary<int,string>  romanUnit = new Dictionary<int, string>()
        {
            [0] = "",
            [1] = "I",
            [2] = "II",
            [3] = "III",
            [4] = "IV",
            [5] = "V",
            [6] = "VI",
            [7] = "VII",
            [8] = "VIII",
            [9] = "IX",
            [10] = "X",
            [20] = "XX",
            [30] = "XXX",
            [40] = "XL",
            [50] = "L",
            [60] = "LX",
            [70] = "LXX",
            [80] = "LXXX",
            [90] = "XC",
            [100] = "C",
            [200] = "CC",
            [300] = "CCC",
            [400] = "CD",
            [500] = "D",
            [600] = "DC",
            [700] = "DCC",
            [800] = "DCCC",
            [900] = "CM",
            [1000] = "M",
            [2000] = "MM",
            [3000] = "MMM",
            [4000] = "MMMM",
        };
        
        internal string ConvertIntToRoman(int interger)
        {

            char[] intToString = interger.ToString().ToArray();
            int decimalPlaces;
            string result = null;
            string value = "";
            for (int i = 0; i < intToString.Length; i++)
            {
                decimalPlaces = intToString.Length - i;
                var itemAsString = int.Parse((intToString[i]).ToString().PadRight((int)decimalPlaces, '0'));
                if (romanUnit.TryGetValue(itemAsString, out value))
                {
                    result += value;
                }
                else
                {
                    throw new KeyNotFoundException($"{itemAsString} not found.");
                }
            }
            return result;
        }

        //TODO:  This was me trying something out.
        internal int ReversInterger(int interger)
        {
            int reminder, reverse = 0;
            while (interger > 0)
            {
                //Get the remainder by dividing the number with 10  
                reminder = interger % 10;
                //multiply the sum with 10 and then add the reminder
                reverse = (reverse * 10) + reminder;
                //Get the quotient by dividing the number with 10 
                interger = interger / 10;
            }
            return reverse;

        }
    }
}