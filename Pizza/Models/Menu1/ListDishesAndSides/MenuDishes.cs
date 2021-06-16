using System.Collections.Generic;

namespace Pizza
{
    public class MenuDishes
    {
        static MenuDishes menu = new MenuDishes();
       
        public static void CreateMenuPizza ( IListSet<Dish> dishes, IListSet<string> sides )
        {     
            List<string> keySides = new List<string> { "doubelCheesePrice", "salamiPrice", "hamPrice", "mushroomsPrice" };
            var listSides= menu.CreateSidesList( keySides );
            sides.SetList( listSides );

            List<string> keyDishes = new List<string> { "marghPrice", "vegetPrice", "toscaPrice", "venecPrice" };
            var listDishes= menu.CreateDishesList( keyDishes );
            dishes.SetList( listDishes );           
        }

        public static void CreateMenuMainDishes ( IListSet<Dish> dishes, IListSet<string> sides )
        {
            List<string> keySides = new List<string> { "barPrice", "setOfSaucesPrice" };
            var listSides= menu.CreateSidesList( keySides );
            sides.SetList( listSides );

            List<string> keyDishes = new List<string> { "schnitzelPrice", "fishPrice", "potatoPrice" };
            var listDishes= menu.CreateDishesList( keyDishes );
            dishes.SetList( listDishes );      
        }

        public static void CreateMenuSoups ( IListSet<Dish> dishes, IListSet<string> sides )
        {
            sides.SetList( new List<string>() );

            List<string> keyDishes = new List<string> { "marghPrice", "vegetPrice", "toscaPrice", "venecPrice" };
            var listDishes= menu.CreateDishesList( keyDishes );
            dishes.SetList( listDishes );
        }

        public static void CreateMenuDrinks ( IListSet<Dish> dishes, IListSet<string> sides )
        {
            sides.SetList( new List<string>() );

            List<string> keyDishes = new List<string> { "coffeePrice", "teaPrice", "colaPrice" };
            var listDishes= menu.CreateDishesList( keyDishes );
            dishes.SetList( listDishes );
        }

        private List<string> CreateSidesList ( List<string> listKey )
        {
            var sides =  new ListSides();
            sides.SetList( listKey );
            return sides.GetList();
        }

        private List<Dish>  CreateDishesList ( List<string> listKey )
        {
            var dishes = new ListDishes();
            dishes.SetList( listKey );
            return dishes.GetList();
        }

    }
}
