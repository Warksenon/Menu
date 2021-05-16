
using NUnit.Framework;

using Pizza;

namespace Test.Menu.Sides
{
    [TestFixture]
    public class TestSidesPizza
    {
        [TestCase( "Podwójny Ser -2zł", "0" )]
        [TestCase( "Salami -2zł", "1" )]
        [TestCase( "Szynka -2zł", "2" )]
        [TestCase( "Pieczarki -2zł", "3" )]
        public void TestGetListSidesPizza( string expectationsName, int index )
        {
            Pizza.IListGet<string> list = new ListSidesPizza();

            var listSides = list.GetList();
            var currentName = listSides [index];

            Assert.AreEqual( expectationsName, currentName );
        }
    }
}
