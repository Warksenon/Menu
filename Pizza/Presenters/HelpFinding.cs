using System;

namespace Pizza
{
    public static class HelpFinding
    {
        public static string CheckIsNotNull( string str )
        {
            if (string.IsNullOrEmpty( str ))
                return str = "";
            else
                return str;
        }

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

        public static string FindName( string nameAndPrice )
        {
            int index = nameAndPrice.IndexOf("-") - 1;
            if (index == -1)
            {
                return "";
            }
            else
            {
                string sdish = nameAndPrice.Substring(0, index);
                return sdish;
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
