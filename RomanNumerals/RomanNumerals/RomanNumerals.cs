using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        public object Convert(int number)
        {
            string romanNumerals = "";
            while (number != 0) {
                if (number >= 10)
                {
                    romanNumerals += "X";
                    number -= 10;
                }
                if (number <= 3)
                {
                    romanNumerals = AddRomanOnes(number, romanNumerals);
                    number -= number;
                }

                if (number == 4)
                {
                    romanNumerals += "IV";
                    number -= number;
                }
                if (number >= 5 && number <= 8)
                {
                    romanNumerals += "V";
                    romanNumerals = AddRomanOnes(number - 5, romanNumerals);
                    number -= number;
                }
                if (number == 9)
                {
                    romanNumerals += "IX";
                    number -= number;
                }

            }

            return romanNumerals;
        }

        private static string AddRomanOnes(int number, string romanNumeral)
        {
            for (int i = 0; i < number; i++)
            {
                romanNumeral += "I";
            }

            return romanNumeral;
        }
    }
}
