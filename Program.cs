using LogicUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {

            //SaveToBase[] saves = new SaveToBase[] { new SaveToTxt(), new SaveToXml() };
            //saves[0].SaveHisotry("hesssllo");




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());

        }
    }
}
