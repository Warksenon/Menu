using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters
{
    public static class HelperConvert
    {
        public static int ConvertTextToInt ( string textNumber )
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
