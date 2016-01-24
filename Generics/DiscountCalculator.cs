using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class DiscountCalculator<TProduct> where TProduct : Product
    {

        public float CalculateDiscount(TProduct product)
        {
            //do something here  
            return 12f;
        }
    }
}
