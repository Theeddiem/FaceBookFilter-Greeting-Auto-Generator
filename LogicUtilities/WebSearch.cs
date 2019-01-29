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
            StringBuilder addreas = new StringBuilder();

            addreas.Append(SiteDelegate.Invoke());
            addreas.Append(i_SelectedPlaceStr);

            return addreas.ToString();
        }
    }
}
