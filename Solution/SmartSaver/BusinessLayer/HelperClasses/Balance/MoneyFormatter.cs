﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SmartSaver
{
    public class MoneyFormatter
    {
        public String FormatMoney(double value)
        {

            return String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("lt-LT"), "{0:C2}", value);
            
        }
    }
}
