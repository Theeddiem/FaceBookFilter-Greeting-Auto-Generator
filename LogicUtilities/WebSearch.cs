using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LogicUtilities
{
    public class WebSearch
    {
        public Func<string> SiteDelegate = () => @"http://www.google.com/search?q=";

        public string GetWebSearchEngine(string i_SelectedPlaceStr)
        {
            StringBuilder WebAddress = new StringBuilder();

            WebAddress.Append(SiteDelegate.Invoke());
            WebAddress.Append(i_SelectedPlaceStr);

            return WebAddress.ToString();
        }
    }
}
