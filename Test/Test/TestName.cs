using NUnit.Framework;
using Pizza;


namespace Test
{
    [TestFixture]
    public class TestName
    {

        [TestCase( "pizza", "Pizza" )]
        [TestCase( "denmark", "Dania główne" )]
        [TestCase( "soups", "Zupy" )]
        [TestCase( "drinks", "Napoje -5zł" )]
        public void TestNameGeter( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "lMenuInfoPizza", "Pizza" )]
        [TestCase( "lMenuInfoMainDish", "Dania główne" )]
        [TestCase( "lMenuInfoSoups", "Zupy" )]
        [TestCase( "lMenuInfoDrinks", "Napoje" )]
        public void TestNameGeterForlMenuInfo( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "priceAll", "PriceAll" )]
        [TestCase( "dishes", "Dishes" )]
        [TestCase( "idPrice", "idPrice" )]
        [TestCase( "comments", "Comments" )]
        [TestCase( "id", "id" )]
        [TestCase( "sidesDishes", "SidesDishes" )]
        [TestCase( "date", "Data" )]
        [TestCase( "price", "Price" )]
        [TestCase( "dish", "Dish" )]
        public void TestNameGeterForlSqlNameColumns( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }
    }
}
