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
            return double.TryParse(text, out double ignored);
          
        }
    }
}
