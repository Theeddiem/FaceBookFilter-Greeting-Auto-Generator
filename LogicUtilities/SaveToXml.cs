using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicUtilities
{
    public class SaveToXml : SaveToBase
    {
        protected override string saveAs()
        {
            return "xml";
        }
    }
}
