using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    class AnniversaryGreeting : Greeting
    {
        public AnniversaryGreeting()
        {
            m_GreetingSubject = "Happy Anniversary";
            m_ImageFileName = "wedding_anniversary_greeting";
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.wedding_anniversary_greeting };
        }
    }
}
