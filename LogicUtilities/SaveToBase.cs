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
                string fileName = string.Format("History {0}", DateTime.Now.ToString("d-M-yyyy"));
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Title = "Save History";
                saveFileDialog.FileName = fileName;
                saveFileDialog.Filter = string.Format("{0} file (*.{0})|*.{0}", m_FileType);
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.ShowDialog();

                string path = saveFileDialog.FileName;

                saveAs(i_History, path);    
        }

        protected abstract void saveAs(ListBox i_History, string path);
    }
}
