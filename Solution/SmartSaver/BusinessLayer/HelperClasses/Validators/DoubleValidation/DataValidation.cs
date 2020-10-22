using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace SmartSaver
{
    public class DataValidation
    {
        public Boolean ValidateMoneyInput(String text)
        {
            var valid = double.TryParse(text, out double ignored);
            return valid;
        }
    }
}
