using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Models.OrderComposition
{
    public abstract class Verifier
    {
        protected string CheckIsNotNull( string str )
        {
            if (string.IsNullOrEmpty( str ))
                return str = "";
            else
                return str;
        }
    }
}
