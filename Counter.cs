using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
   public class Counter
    {
        private int m_Counter { get; set; } = 0;

        public event Action<int, string> InfoHappend;

        private Counter()
        {

        }

        protected void NotifyAll(int i_Count, string i_Msg)
        {
            if (InfoHappend != null)
            {
                InfoHappend.Invoke(i_Count , i_Msg);
            }
        }

        public void OnInfoChanged(string i_Msg)
        {
            m_Counter++;
            NotifyAll(m_Counter , i_Msg);
        }
    }
}
