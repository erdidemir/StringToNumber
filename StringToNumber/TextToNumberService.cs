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
        string[] digits = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };

        //index +10
        string[] extendedDigits = { "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" }; 

        //index x 10
        string[] tensWords = { "", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

        // x 10000000
        string millions = "millions";

        // x 10000000000
        string billions = "billions";

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
                if(digits.Contains(item))
                {
                    str += item + " ";

                    digitNumber = Array.IndexOf(digits, item);
                }

                else if (extendedDigits.Contains(item))
                {
                    str += item + " ";

                    extendedDigitNumber = Array.IndexOf(extendedDigits, item);

                    extendedDigitNumber = extendedDigitNumber + 10;
                }

                else if (tensWords.Contains(item))
                {
                    tensWordNumber = Array.IndexOf(tensWords, item);

                    tensWordNumber = tensWordNumber * 10;
                }
                else if (tensWords.Contains(millions))
                {

                    number = GetNumber(digitNumber, extendedDigitNumber, tensWordNumber);
                    number = number * 10000000;
                }
                else if (tensWords.Contains(billions))
                {

                    number = GetNumber(digitNumber, extendedDigitNumber, tensWordNumber);
                    number = number * 10000000000;
                }
                else
                {
                    number = GetNumber(digitNumber, extendedDigitNumber, tensWordNumber);
                    if (number > 0)
                    {
                        result = result.Replace(str, number.ToString());
                        number = 0;
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
