using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex02EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    internal class NewYearGreeting : Greeting
    {
        public NewYearGreeting()
        {
            m_GreetingSubject = "Happy New-Year";
            m_ImageFileName = "happy_newYear_greeting";
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.happy_newYear_greeting };
        }
    }
}
