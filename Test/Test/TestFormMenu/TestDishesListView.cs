using System.Collections.Generic;

using NUnit.Framework;

using Pizza;
using Pizza.Presenters.PresenterFormMenu;

namespace Test.Test.TestFormMenu
{
    [TestFixture]
    public class TestDishesListView
    {
        [TestCase( "0", "dish1", "11zl" )]
        [TestCase( "1", "dish2", "22zl" )]
        public void SetList_SimulationSetListDiehes_ReturnDish (int index, string expectedName, string expectedPrice)
        {
            var form = FormTest.CreateFormMenu();
            DishesListView lvDishes = new DishesListView(form);
            var list =  FekaDishesList.GetDishes();
            lvDishes.SetList( list );

            var currentName = form.ListViewDishes.Items[index].SubItems[0].Text;
            var currentPrice =  form.ListViewDishes.Items[index].SubItems[1].Text;

            Assert.AreEqual( expectedName, currentName );
            Assert.AreEqual( expectedPrice, currentPrice );
        }
    }

    internal class FekaDishesList
    {
       static public List<Dish> GetDishes ()
        {
            var dish1 = new Dish
                        {
                            Name = "dish1",
                            Price = "11zl"
                        };

            var dish2 = new Dish
                        {
                            Name = "dish2",
                            Price = "22zl"
                        };

            var list = new List<Dish>();
            list.Add( dish1 );
            list.Add( dish2 );
            return list;
        }
    }
}
