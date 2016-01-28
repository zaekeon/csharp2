using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class BurgerMenuBuilder : MenuBuilder
    {
        private Menu _menu = new Menu();
        public override void BuildBurgerOrSalad()
        {
            _menu.Add("Burger");
        }

        public override void BuildDessert()
        {
            _menu.Add("Dessert");
        }

        public override void BuildDrink()
        {
            _menu.Add("Drink");
        }

        public override void BuildFries()
        {
            _menu.Add("Fries");
        }

        public override void BuildToy()
        {
            _menu.Add("Toy");
        }

        public override Menu GetResult()
        {
            return _menu;
        }
    }
}
