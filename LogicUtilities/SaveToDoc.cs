using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogicUtilities
{
    public class SaveToDoc : SaveToBase
    {
        protected override string saveAs()
        {
            return "doc";
        }
    }
}
