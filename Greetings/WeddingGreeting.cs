using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex02EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    internal class WeddingGreeting : Greeting 
    {
        public WeddingGreeting()
        {
            m_GreetingSubject = "Wedding Anniversary";
            m_ImageFileName = "happy_Wedding_greeting";
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.happy_Wedding_greeting };
        }
    }
}
