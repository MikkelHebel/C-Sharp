using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppThing
{
    public delegate double BonusProvider(double amount);

    public class Bonuses
    {

        public static double TenPercent(double amount)
        {
            return amount * 0.1;
        }

        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            return amount > 5 ? 2.0 : 0.0;
        }

        public class BonusProvider
        {
        }
    }
}
