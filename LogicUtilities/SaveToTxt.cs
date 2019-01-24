using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicUtilities
{
    public class SaveToTxt : SaveToBase
    {
        protected override string saveAs()
        {
            return "txt";
        }
    }
}
