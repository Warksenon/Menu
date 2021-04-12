using System.Collections.Generic;

namespace Pizza.Models.FilesTXT
{
    abstract class Files
    {
        protected List<Order> listOrder;
        protected const string _path = @"c:\SQL\Konsola\sqlite\Historia zamówień.txt";
    }
}
