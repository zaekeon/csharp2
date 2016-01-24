using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Product
    {
        private int _productID;

        public int ProductID
        {

            get
            {
                return _productID;
            }

            set
            {
                _productID = value;
            }
        }



        public Product(int productID)
        {
            _productID = productID;
        }
    }
}
