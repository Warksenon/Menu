using System.Collections.Generic;

namespace Pizza.Models.FilesTXT
{
    internal abstract class Files
    {
        protected List<Order> listOrder = new List<Order>();
        protected const string _path = @"c:\SQL\Konsola\sqlite\Historia zamówień.txt";
    }
}
