using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace StringToNumber
{
    public class TextToNumberService
    {
        string[] digits = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //index +10
        string[] extendedDigits = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" }; 

        //index x 10
        string[] tensWords = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        // x 1000
        string[] thousands = { "thousand", "thousands" };

        // x 10000000
        string[] millions = { "million", "millions" }; 

        // x 10000000000
        string[] billions = { "billion", "billions" };

        public string ConvertTextToNumber(string p)
        {
            string result = p;
            string str = "";

            int digitNumber = 0;
            int extendedDigitNumber = 0;
            int tensWordNumber = 0;

            long number = 0;


            foreach (var item in p.Split( ))
            {
              
                if (digits.Contains(item.ToLower()))
                {
                    str += item + " ";

                    digitNumber = Array.IndexOf(digits, item);

                    number = digitNumber;
                }

                else if (extendedDigits.Contains(item.ToLower()))
                {
                    str += item + " ";

                    extendedDigitNumber = Array.IndexOf(extendedDigits, item);

                    extendedDigitNumber = extendedDigitNumber + 10;

                    number = extendedDigitNumber;
                }

                else if (tensWords.Contains(item.ToLower()))
                {
                    str += item + " ";

                    tensWordNumber = Array.IndexOf(tensWords, item);

                    tensWordNumber = tensWordNumber * 10;

                    number = tensWordNumber;
                }
                else if (thousands.Contains(item.ToLower()))
                {
                    str += item + " ";
                    number = GetNumber(digitNumber, extendedDigitNumber, tensWordNumber);
                    number = number * 1000;
                }
                else if (millions.Contains(item.ToLower()))
                {
                    str += item + " ";
                    number = GetNumber(digitNumber, extendedDigitNumber, tensWordNumber);
                    number = number * 1000000;
                }
                else if (billions.Contains(item.ToLower()))
                {
                    str += item + " ";
                    number = GetNumber(digitNumber, extendedDigitNumber, tensWordNumber);
                    number = number * 1000000000;
                }
                else
                {
                    if (number > 0)
                    {
                        str = str.Remove(str.Length - 1);
                        result = result.Replace(str, number.ToString());
                        digitNumber = 0;
                        extendedDigitNumber = 0;
                        tensWordNumber = 0;
                        number = 0;
                        str = "";
                    }
                }
            }


            return result;
        }

        public int GetNumber(int digitNumber, int extendedDigitNumber, int tensWordNumber)
        {
            int result = 0;

            if (digitNumber > 0)
            {
                result = digitNumber;
            }
            else if (extendedDigitNumber > 0)
            {
                result = extendedDigitNumber;
            }
            else if (tensWordNumber > 0)
            {
                result = tensWordNumber;
            }

            return result;

        }
    }
}
