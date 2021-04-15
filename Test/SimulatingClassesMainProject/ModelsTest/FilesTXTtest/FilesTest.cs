using System.Collections.Generic;

using Pizza;

namespace Test
{
    internal abstract class FilesTest
    {
        protected List<Order> listOrder = new List<Order>();
        protected const string _path = @"c:\SQLTest\Konsola\sqlite\Historia zamówień.txt";
    }
}
