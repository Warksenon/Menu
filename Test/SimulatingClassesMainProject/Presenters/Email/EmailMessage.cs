using Pizza;
using System;
using System.Collections.Generic;

namespace Test
{
     class EmailMessage
    {
        readonly List<Dish> listDishes;
        readonly PriceAll priceAll;


        public EmailMessage(Order order)
        {
            this.listDishes = order.ListDishes;
            this.priceAll = order.PriceAll;
        }

        public string WriteBill()
        {
            string bill;
            bill = WritePriceAll(priceAll);
            bill += WriteDischesAll();
            bill += Name.CommentsMessag + "\n" + priceAll.Comments;
            return bill;
        }

        string WritePriceAll(PriceAll priceAll)
        {
            string priceAllEmail = "";
            priceAllEmail += LinesHashAndNewLines() + OneHashAndNewLine();
            priceAllEmail += Data(priceAll);
            priceAllEmail += NamePrice();
            priceAllEmail += OneHashAndNewLine();
            priceAllEmail += LinesHashAndNewLines();
            return priceAllEmail;
        }
        string LinesHashAndNewLines()
        {
            return Name.HashSigns51 + "\n";
        }

        string Data(PriceAll priceAll)
        {
            string data = String.Format("# {0,33}{1,16}", priceAll.Date, " ") + "\n";
            return data;
        }

        string NamePrice()
        {
            return "#" + String.Format("{0,27}{1,-22}", Name.NPrice + ": ", priceAll.Price) + "\n";
        }


        string WriteDischesAll()
        {
            string dischesAll = "";
            foreach (var item in listDishes)
            {
                dischesAll += WriteDisch(item);
            }
            return dischesAll;
        }

        string OneHashAndNewLine()
        {
            string st = "#" + "\n";
            return st;
        }

        string WriteDisch(Dish disch)
        {
            string wirteDisch = "";
            wirteDisch += LinesHashAndNewLines();
            wirteDisch += OneHashAndNewLine();
            wirteDisch += TextPlusNewLines(disch.Name);
            if (CheckingAddOns(disch))
            {
                string sidesDishes = disch.Sides;
                string oneSideDish;
                string newSidesDishes = "";
                while (SideDishesIsEmpty(sidesDishes))
                {                  
                    oneSideDish = HelpFinding.FindingCommaOrPeriodAndCuttingCharacters(sidesDishes);
                    sidesDishes = HelpFinding.RemoveSideDishAndWhiteSigns(sidesDishes);
                    newSidesDishes += TextPlusNewLines(oneSideDish);
                }
                wirteDisch += newSidesDishes;
            }
            string price = Name.PriceForDish + disch.Price + "\n";
            wirteDisch += price;
            wirteDisch += OneHashAndNewLine();
            wirteDisch += LinesHashAndNewLines();
            return wirteDisch;
        }

        private bool CheckingAddOns(Dish disch)
        {
            if (disch.Sides.Equals("")) return false;
            else return true;
        }
        private bool SideDishesIsEmpty(string sideDishes)
        {
            if (sideDishes.Equals("")) return false;
            else return true;

        }
        private string TextPlusNewLines(string text)
        {
            return "# " + text + "\n";
        }

    }
}
