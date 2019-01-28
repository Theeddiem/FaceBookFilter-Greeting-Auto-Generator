using System;
using System.IO;
using System.Windows.Forms;

namespace LogicUtilities
{
    public class SaveToTxt : SaveToBase
    {
        public SaveToTxt()
        {
            m_FileType = "txt";
        }

        protected override void saveAs(ListBox i_History, string path)
        {
            foreach (string line in i_History.Items)
            {
                File.AppendAllText(path, string.Format("{0} {1}", line, Environment.NewLine));
            }
        }
    }
}
