using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    public class RomanNumerals
    {
        public string Convert(int number)
        {
            string romanNumerals = "";
            string[] symbols = { "I", "V", "X", "L", "C", "D" };
            while (number != 0)
            {
                if (number >= 10)
                {
                    if (number >= 100)
                    {
                        if (number >= 500)
                        {
                            romanNumerals += symbols[5];
                            number = Decrease(number, 500);
                        }
                        else if (number >= 400 && number <= 499)
                        {
                            romanNumerals += symbols[4] + symbols[5];
                            number = Decrease(number, 400);
                        }
                        else
                        {
                            romanNumerals += symbols[4];
                            number = Decrease(number, 100);
                        }

                    }

                    else
                    {
                        if (number >= 90 && number <= 99)
                        {
                            romanNumerals += symbols[2] + symbols[4];
                            number = Decrease(number, 90);
                        }
                        else if (number >= 50 && number <= 89)
                        {
                            romanNumerals += symbols[3];
                            number = Decrease(number, 50);
                        }
                        else if (number >= 40 && number <= 49)
                        {
                            romanNumerals += symbols[2] + symbols[3];
                            number = Decrease(number, 40);
                        }
                        else
                        {
                            romanNumerals += symbols[2];
                            number = Decrease(number, 10);
                        }


                    }


                }


                else
                {
                    if (number == 9)
                    {
                        romanNumerals += symbols[0] + symbols[2];
                        number = Decrease(number, number);
                    }
                    else if (number >= 5 && number <= 8)
                    {
                        romanNumerals += symbols[1];
                        romanNumerals = AddRomanOnes(number - 5, romanNumerals, symbols);
                        number = Decrease(number, number);
                    }
                    else if (number == 4)
                    {
                        romanNumerals += symbols[0] + symbols[1];
                        number = Decrease(number, number);
                    }
                    if (number <= 3)
                    {
                        romanNumerals = AddRomanOnes(number, romanNumerals, symbols);
                        number = Decrease(number, number);
                    }
                }
            }
            return romanNumerals;
        }

        private static int Decrease(int number, int numberToDecreaseBy)
        {
            number -= numberToDecreaseBy;
            return number;
        }

        private static string AddRomanOnes(int number, string romanNumeral, string[] symbols)
        {
            for (int i = 0; i < number; i++)
            {
                romanNumeral += symbols[0];
            }
            return romanNumeral;
        }
    }
}
