using System;
using System.Text;

namespace Pizza
{
    public static class HelpFinding
    {

        public static bool CheckStringIsNotEmpty( string text )
        {
            if (string.IsNullOrEmpty( text ))
                return false;
            else
                return true;
        }

        public static bool CheckStringIsEmpty( string text )
        {
            if (string.IsNullOrEmpty( text ))
                return true;
            else
                return false;
        }

        public static string FindPrice( string nameAndPrice )
        {
            int index = nameAndPrice.IndexOf("-") + 1;
            if (index == -1)
            {
                return "";
            }
            else
            {
                string price = nameAndPrice.Substring(index);
                return price;
            }
        }

        public static int ConvertTextToInt( string textNumber )
        {
            int number;
            try
            {
                number = Convert.ToUInt16( textNumber );
            }
            catch
            {
                number = -1;
            }
            return number;
        }
    }
}
