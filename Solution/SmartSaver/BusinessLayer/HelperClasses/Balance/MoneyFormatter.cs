using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver
{
    public static class MoneyFormatter
    {
        public static String FormatMoney(this double value)
        {
            return String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("lt-LT"), "{0:C2}", value);
        }
    }

    //REQUIREMENT: EXTENSION METHODS
}
