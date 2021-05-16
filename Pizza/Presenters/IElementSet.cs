using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Presenters
{
    interface IElementSet<T>
    {
        void SetElement(T elements );
    }
}
