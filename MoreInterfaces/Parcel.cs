using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreInterfaces
{
    class Parcel : IMexico, IJapan
    {
        decimal IJapan.Cost(decimal weight)
        {
            const decimal RATE = 2.54m;
            return weight * RATE;
        }

        decimal IMexico.Cost(decimal weight)
        {
            const decimal RATE = 1.84m;
            return weight * RATE;
        }
    }
}
