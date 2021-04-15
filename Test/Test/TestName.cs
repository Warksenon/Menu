using NUnit.Framework;

using Pizza;

namespace Test
{
    [TestFixture]
    public class TestName
    {
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
        public void TestNameGeterForSqlNameColumns( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }


        [TestCase( "priceForDish", "# Cenna za danie: " )]
        [TestCase( "hashSigns51", "###################################################" )]
        [TestCase( "commentsMessag", "Uwagi do zamówienia: " )]
        public void TestNameGeterForMessage( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "marghPrice", "Margheritta -20zł" )]
        [TestCase( "vegetPrice", "Vegetariana -22zł" )]
        [TestCase( "toscaPrice", "Tosca -25zł" )]
        [TestCase( "venecPrice", "Venecia -25zł" )]
        public void TestNameGeterPizzaWithPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "margh", "Margheritta" )]
        [TestCase( "veget", "Vegetariana" )]
        [TestCase( "tosca", "Tosca" )]
        [TestCase( "venec", "Venecia" )]
        public void TestNameGeterPizzaWithoutPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "doubelCheese", "Podwójny Ser" )]
        [TestCase( "salami", "Salami" )]
        [TestCase( "ham", "Szynka" )]
        [TestCase( "mushrooms", "Pieczarki" )]
        public void TestNameGeterPizzaSidesWithoutPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "doubelCheesePrice", "Podwójny Ser -2zł" )]
        [TestCase( "salamiPrice", "Salami -2zł" )]
        [TestCase( "hamPrice", "Szynka -2zł" )]
        [TestCase( "mushroomsPrice", "Pieczarki -2zł" )]
        public void TestNameGeterPizzaSidesWithPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "schnitzel", "Schabowy z frytkami/ryżem/ziemniakami" )]
        [TestCase( "fish", "Ryba z frytkami" )]
        [TestCase( "potato", "Placek po węgiersku" )]
        public void TestNameGeterMainDishesWithoutPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "schnitzelPrice", "Schabowy z frytkami/ryżem/ziemniakami -30zł" )]
        [TestCase( "fishPrice", "Ryba z frytkami -28zł" )]
        [TestCase( "potatoPrice", "Placek po węgiersku -27zł" )]
        public void TestNameGeterMainDishesWithPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "bar", "Bar sałatkowy" )]
        [TestCase( "setOfSauces", "Zestaw sosów" )]
        public void TestNameGeterMainDishesSidesWithoutPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "barPrice", "Bar sałatkowy -5zł" )]
        [TestCase( "setOfSaucesPrice", "Zestaw sosów -6zł" )]
        public void TestNameGeterMainDishesSidesWithPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "tomato", "Pomidorowa" )]
        [TestCase( "chickenSoup", "Rosół" )]
        public void TestNameGeterSoupsWithoutPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "tomatoPrice", "Pomidorowa -12zł" )]
        [TestCase( "chickenSoupPrice", "Rosół -10zł" )]
        public void TestNameGeterSoupWithPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "coffee", "Kawa" )]
        [TestCase( "tea", "Herbata" )]
        [TestCase( "cola", "Cola" )]
        public void TestNameGeterDrinksWithoutPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "coffeePrice", "Kawa -5zł" )]
        [TestCase( "teaPrice", "Herbata -5zł" )]
        [TestCase( "colaPrice", "Cola -5zł" )]
        public void TestNameGeterDrinksWithPrice( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

        [TestCase( "sender", "nadacwca" )]
        [TestCase( "password", "hasło" )]
        [TestCase( "smtp", "smtp" )]
        [TestCase( "port", "port" )]
        [TestCase( "recipient", "odbiorca" )]
        public void TestNameGeterEmailData( string key, string expectationsName )
        {
            var name = Name.GetNameConfig(key);
            Assert.AreEqual( expectationsName, name );
        }

    }
}
