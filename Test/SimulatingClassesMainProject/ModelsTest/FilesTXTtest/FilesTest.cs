using System.Collections.Generic;

using Pizza;

namespace Test
{
    internal abstract class FilesTest
    {
        protected List<Order> listOrder = new List<Order>();
        protected const string path = @"c:\SQLTest2\Konsola\sqlite";
        protected const string fileName = path+@"\Historia zamówień.txt";

        protected void CreateFolder()
        {
            if (!System.IO.File.Exists( path ))
            {
                System.IO.Directory.CreateDirectory( path );
            }
            else
            {
                return;
            }
        }
    }
}
