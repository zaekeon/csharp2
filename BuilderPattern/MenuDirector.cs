using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class MenuDirector
    {

        public void Contruct (MenuBuilder builder)
        {
            builder.BuildBurgerOrSalad();
            builder.BuildFries();
            builder.BuildDessert();
            builder.BuildDrink();
            builder.BuildToy();
        }
    }
}
