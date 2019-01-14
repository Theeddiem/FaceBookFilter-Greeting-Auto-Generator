using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public class ButtonCommand : Button
    {
        protected Action m_CommandDelegate;
        public string Text { get; set; }

        public ButtonCommand(Action m_CommandDelegate, string text) : base()
        {
            this.m_CommandDelegate = m_CommandDelegate;
            Text = text;
        }



        public virtual void Selected()
        {
            if (m_CommandDelegate != null)
            {
                m_CommandDelegate.Invoke();
            }
        }
      }
    
}
