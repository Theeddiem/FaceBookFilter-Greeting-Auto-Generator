using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LogicUtilities
{
    public class SaveToXml : SaveToBase
    {
        public SaveToXml()
        {
            m_FileType = "xml";
        }

        protected override void saveAs(ListBox i_History, string path)
        {
            XmlTextWriter xmlWriter = new XmlTextWriter(path, Encoding.Unicode);
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("XMLFILE");
            xmlWriter.WriteStartElement("Title");
            xmlWriter.WriteString("History");
            xmlWriter.WriteEndElement();
            
            foreach (string line in i_History.Items)
            {
                xmlWriter.WriteStartElement("Item");
                xmlWriter.WriteString(string.Format("{0} {1}", line, Environment.NewLine));
                xmlWriter.WriteEndElement();
            }

            xmlWriter.WriteEndElement();
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }
    }
}
