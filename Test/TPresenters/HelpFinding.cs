namespace Test
{
    public static class HelpFinding
    {
        public static string FindingCommaOrPeriodAndCuttingCharacters(string sideDishes)
        {
            int index = FindIndexCommaOrPeriod(sideDishes);
            return ReturningCutWord(index, sideDishes);
        }

        private static int FindIndexCommaOrPeriod(string sideDishes)
        {
            int index = sideDishes.IndexOf(",");
            if (index == -1)
            {
                index = sideDishes.IndexOf(".");
            }
            return index;
        }

        private static string ReturningCutWord(int index, string sideDishes)
        {
            if (index == -1)
            {
                return "";
            }
            else
            {
                return sideDishes.Substring(0, index);
            }
        }

        public static string RemoveSideDishAndWhiteSigns(string sideDish)
        {
            int index = FindIndexCommaOrPeriod(sideDish);
            sideDish = sideDish.Remove(0, index + 1);
            return sideDish.Trim();
        }

        public static string CheckIsNotNull(string str)
        {
            if (string.IsNullOrEmpty(str)) return str = "";
            else return str;
        }

        public static bool CheckStringIsNotEmpty(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;
            else return true;
        }

        public static bool CheckStringIsEmpty(string text)
        {
            if (string.IsNullOrEmpty(text)) return true;
            else return false;
        }

        public static string FindPrice(string nameAndPrice)
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

        public static string FindName(string nameAndPrice)
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
    }
}
