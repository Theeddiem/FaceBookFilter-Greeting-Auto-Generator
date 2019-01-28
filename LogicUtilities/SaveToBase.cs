using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LogicUtilities
{
    public abstract class SaveToBase
    {

        public void SaveHisotry(ListBox i_History)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string fileName = string.Format("History {0}", DateTime.Now.ToString("d-M-yyyy"));
            string path = string.Format(@"{0}\{1}.{2}", currentDir, fileName, saveAs());

            if (File.Exists(path))
            {
                try
                {
                    File.Delete(path);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            if(i_History.Items.Count == 0)
            {
                MessageBox.Show("No History to Save");
            }

            foreach (string line in i_History.Items)
            {
                File.AppendAllText(path, string.Format("{0} {1}", line, Environment.NewLine));
            }
        }

       protected abstract string saveAs();

        
    }
}
