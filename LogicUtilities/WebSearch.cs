using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogicUtilities
{
    public class WebSearch
    {
        public Func<string> CurrentSearchEngine = () => @"http://www.google.com/search?q=";

        public string GetWebSearchEngine(string i_SelectedPlaceStr)
        {
            StringBuilder WebAddress = new StringBuilder();
            WebAddress.Append(CurrentSearchEngine.Invoke());
            WebAddress.Append(i_SelectedPlaceStr);

            return WebAddress.ToString();
        }
    }
}
