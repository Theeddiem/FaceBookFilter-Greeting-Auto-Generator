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
        protected string m_FileType;

        public void SaveHisotry(ListBox i_History)
        {
            string currentDir = Directory.GetCurrentDirectory();
            string fileName = string.Format("History {0}", DateTime.Now.ToString("d-M-yyyy"));
            string path = string.Format(@"{0}\{1}.{2}", currentDir, fileName, m_FileType);

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

            saveAs(i_History,path);
        }

        protected abstract void saveAs(ListBox i_History,string path);

    }
}
