using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabicToRoman
{
    public class Roman
    {
        string roman = "";

        private string Hundred(int arabic)
        {
            if (arabic.ToString().Length == 3)
            {
                //Primer dígito
                string first_digit = arabic.ToString().Substring(0, 1);

                int first_number = Convert.ToInt16(first_digit + "00");

                if (first_number > 500)
                {
                    if (10 - (first_number / 100) == 1)
                    {
                        roman = "CM";
                    }
                    else if (10 - (first_number / 100) == 2)
                    {
                        roman = "DCCC";
                    }
                    else if (10 - (first_number / 100) == 3)
                    {
                        roman = "DCC";
                    }
                    else if (10 - (first_number / 100) == 4)
                    {
                        roman = "DC";
                    }
                }
                
                else if (first_number == 500)
                {
                    roman = "D";
                }
                else if (first_number < 500 && first_number > 100)
                {
                    if (5 - (first_number / 100) == 1)
                    {
                        roman = "CD";
                    }
                    else if (5 - (first_number / 100) == 2)
                    {
                        roman = "CCC";
                    }
                    else
                    {
                        roman = "CC";
                    }
                }
                else if (first_number == 100)
                {
                    roman = "C";
                }

                //Segundo dígito
                string second_digit = arabic.ToString().Substring(1, 1);

                first_number = Convert.ToInt16(second_digit + "0");

                if (first_number != 0)
                {
                    if (first_number > 50)
                    {
                        if (10 - (first_number / 10) == 1)
                        {
                            roman += "XC";
                        }
                        else if (10 - (first_number / 10) == 2)
                        {
                            roman += "LXXX";
                        }
                        else if (10 - (first_number / 10) == 3)
                        {
                            roman += "LXX";
                        }
                        else if (10 - (first_number / 10) == 4)
                        {
                            roman += "LX";
                        }
                    }
                
                    else if (first_number == 50)
                    {
                        roman += "L";
                    }
                    else if (first_number < 50 && first_number > 10)
                    {
                        if (5 - (first_number / 10) == 1)
                        {
                            roman += "XL";
                        }
                        else if (5 - (first_number / 10) == 2)
                        {
                            roman += "XXX";
                        }
                        else
                        {
                            roman += "XX";
                        }
                    }
                    else
                    {
                        roman += "X";
                    }
                }

                //Tercer dígito
                string third_digit = arabic.ToString().Substring(2, 1);

                first_number = Convert.ToInt16(third_digit);

                if (first_number != 0)
                {
                    if (first_number > 5)
                    {
                        if (10 - (first_number) == 1)
                        {
                            roman += "IX";
                        }
                        else if (10 - (first_number) == 2)
                        {
                            roman += "VIII";
                        }
                        else if (10 - (first_number) == 3)
                        {
                            roman += "VII";
                        }
                        else if (10 - (first_number) == 4)
                        {
                            roman += "VI";
                        }
                    }

                    else if (first_number == 5)
                    {
                        roman += "V";
                    }
                    else if (first_number < 5 && first_number > 1)
                    {
                        if (5 - (first_number) == 1)
                        {
                            roman += "IV";
                        }
                        else if (5 - (first_number) == 2)
                        {
                            roman += "III";
                        }
                        else
                        {
                            roman += "II";
                        }
                    }
                    else
                    {
                        roman += "I";
                    }
                }

            }

            return roman;
        }
        
        public string ToRoman(int arabic)
        {

            if (arabic.ToString().Length == 3)

                return this.Hundred(arabic);
            else
                return "";
        }
    }
}
