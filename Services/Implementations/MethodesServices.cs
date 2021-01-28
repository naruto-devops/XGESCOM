using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.Implementations
{
  public static class MethodesServices
    {        

        public static string IncrementCode(this string intCode)
        {
            char[] intCodeArray = intCode.ToCharArray();

            int length = intCodeArray.Length - 1;
            bool inc = true;

            while (length >= 0 && inc)
            {
                if (Char.IsDigit(intCodeArray[length]))
                {
                    if (intCodeArray[length] == '9')
                    {
                        intCodeArray[length] = '0';
                        length--;
                    }
                    else
                    {
                        intCodeArray[length] = Convert.ToChar(
                            Convert.ToInt32(intCodeArray[length]) + 1);
                        inc = false;
                    }
                }
                else
                {
                    if (intCodeArray[length] == 'Z')
                    {
                        intCodeArray[length] = 'A';
                        length--;
                    }
                    else
                    {
                        if (intCodeArray[length] >= 'A' && intCodeArray[length] <= 'Z')
                        {
                            intCodeArray[length] = Convert.ToChar(
                                Convert.ToInt32(intCodeArray[length]) + 1);
                        }

                        inc = false;
                    }
                }
            }

            intCode = string.Empty;

            for (int i = 0; i < intCodeArray.Length; i++)
                intCode += intCodeArray[i];

            int x = 0;
            if (int.TryParse(intCode, out x))
            {
                if (x == 0)
                    intCode = "1" + intCode;
            }

            return intCode;
        }
    }
}
