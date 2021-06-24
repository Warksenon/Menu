using System.Collections.Generic;
using NUnit.Framework;

using Pizza;


namespace Test
{
    [TestFixture]
    public class TestMenuDishes
    {

        static FakeListDishes  fakeLD = new FakeListDishes();
        static FakeListSides  fakeLS = new FakeListSides();
        MenuDishes<FakeListDishes,FakeListSides> menu = new MenuDishes<FakeListDishes,FakeListSides>( fakeLD, fakeLS);
        DishesListView dishesList = new DishesListView ();
        SidesCheckListBox sidesList =new  SidesCheckListBox ();

        [TestCase( "marghPrice", "1", "0" )]
        [TestCase( "vegetPrice", "2", "1" )]
        [TestCase( "toscaPrice", "3", "2" )]
        [TestCase( "venecPrice", "4", "3" )]

        public void CreateMenuPizza_CheckData_ReturnListDish( string expectationsName, string expectationsPrice, int index )
        {
            menu.CreateMenuPizza( dishesList, sidesList );
            var list = dishesList.GetList();

            var  currentName  = list [index].Name;
            var  currentPrice = list [index].Price;

            Assert.AreEqual( expectationsName, currentName );
            Assert.AreEqual( expectationsPrice, currentPrice );
        }

        //[TestCase( "Schabowy z frytkami/ryżem/ziemniakami", "30zł", "0" )]
        //[TestCase( "Ryba z frytkami", "28zł", "1" )]
        //[TestCase( "Placek po węgiersku", "27zł", "2" )]
        //public void TestGetListMainDishesFromListViewDishes( string expectationsName, string price, int index )
        //{
        //    onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.MainDishes ) );
        //    var  currentName  = form.ListViewDishes.Items [index].SubItems [0].Text;
        //    var  currentPrice = form.ListViewDishes.Items [index].SubItems [1].Text;

        //    Assert.AreEqual( expectationsName, currentName );
        //    Assert.AreEqual( price, currentPrice );
        //}

        //[TestCase( "Kawa", "0" )]
        //[TestCase( "Herbata", "1" )]
        //[TestCase( "Cola", "2" )]
        //public void TestGetListDrinksFromListViewDishes( string expectationsName, int index )
        //{
        //    onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Drinks ) );
        //    var  currentName  = form.ListViewDishes.Items [index].SubItems [0].Text;
        //    var  currentPrice = form.ListViewDishes.Items [index].SubItems [1].Text;

        //    Assert.AreEqual( expectationsName, currentName );
        //    Assert.AreEqual( "5zł", currentPrice );
        //}

        //[TestCase( "Pomidorowa", "12zł", "0" )]
        //[TestCase( "Rosół", "10zł", "1" )]
        //public void TestGetListSoupsFromListViewDishes( string expectationsName, string expectationsPrice, int index )
        //{
        //    onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Soups ) );
        //    var  currentName  = form.ListViewDishes.Items [index].SubItems [0].Text;
        //    var  currentPrice = form.ListViewDishes.Items [index].SubItems [1].Text;

        //    Assert.AreEqual( expectationsName, currentName );
        //    Assert.AreEqual( expectationsPrice, currentPrice );
        //}

        //[TestCase( "Bar sałatkowy -5zł", "0" )]
        //[TestCase( "Zestaw sosów -6zł", "1" )]
        //public void TestGetListSidesFromMainDishes( string expectationsName, int index )
        //{
        //    onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.MainDishes ) );
        //    var  currentName  = form.CheckedListBoxSide.Items [index].ToString();

        //    Assert.AreEqual( expectationsName, currentName );
        //}

        //[TestCase( "Podwójny Ser -2zł", "0" )]
        //[TestCase( "Salami -2zł", "1" )]
        //[TestCase( "Szynka -2zł", "2" )]
        //[TestCase( "Pieczarki -2zł", "3" )]
        //public void TestGetListSidesFromPizzas( string expectationsName, int index )
        //{
        //    onEvent.SetLogic( new LogicMenuButtonTest( form, ButtonLoadMenu.Pizza ) );
        //    var  currentName  = form.CheckedListBoxSide.Items [index].ToString();

        //    Assert.AreEqual( expectationsName, currentName );
        //}
    }

    public class FakeListDishes :  IListGet<Dish>, IListSet<string>
    {
        private List<Dish> listDisches = new List<Dish>();
        private Dish disch = new Dish();

        private void AddDishesToList ( List<string> key )
        {
            listDisches = new List<Dish>();
            int i =1;
            foreach (var k in key)
            {
                disch = new Dish();
                disch.Name = k;
                disch.Price = i.ToString();
                listDisches.Add( disch );
                i++;
            }
        }

        public List<Dish> GetList ()
        {
            return listDisches;
        }

        public void SetList ( List<string> key )
        {
            AddDishesToList( key );
        }
    }

    public class FakeListSides:  IListGet<string>, IListSet<string>
    {
        private readonly List<string>  listSides = new List<string>();

        public void SetList ( List<string> listKey )
        {
            listSides.Clear();
            foreach (var k in listKey)
            {
                listSides.Add( k );
            }
        }

        public List<string> GetList ()
        {
            var list = listSides;
            return list;
        }
    }

    internal class DishesListView : IElementGet<Dish>, IListSet<Dish>
    {
        private List<Dish> _listDisch = new List<Dish>();       
        public DishesListView () { }
       
        public List<Dish> GetList() 
        {
                return _listDisch;  
        }

        public Dish GetElement ()
        {
            return _listDisch[0];
        }

        public void SetList ( List<Dish> listDisch )
        {
            _listDisch = listDisch;
        }
    }

    internal class SidesCheckListBox : IListSet<string>, IListGet<string>
    {
        List<string> sides = new List<string>();
        public SidesCheckListBox () { }

        public List<string> GetList ()
        {
            return sides;
        }

        public void SetList ( List<string> elements )
        {
            sides = elements;
        }
    }
}

namespace Pizza
{

}
