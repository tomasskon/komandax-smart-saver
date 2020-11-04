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
            return System.Text.RegularExpressions.Regex.IsMatch(text, "^[0-9]*$");
        }
        // REQUIREMENT: REGEX
    }
}
