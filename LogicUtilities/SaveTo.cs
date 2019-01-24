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

            string typeSave = saveAs();

            string fileName = string.Format("History {0}", DateTime.Now.ToString("d-M-yyyy"));
            string path = string.Format(@"c:\temp\{0}.{1}",fileName,typeSave);

            // string Text = string.Format("{0} {1}", i_msg, Environment.NewLine);
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

            //// Open the file to read from.
            //string readText = File.ReadAllText(path);
            //Console.WriteLine(readText);

        }

        protected abstract string saveAs();

    }
}
