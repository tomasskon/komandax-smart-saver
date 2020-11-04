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
            if (!System.Text.RegularExpressions.Regex.IsMatch(text, "^[0-9]*$"))
                return false;
            else
                return true;
        }
        // REQUIREMENT: REGEX
    }
}
