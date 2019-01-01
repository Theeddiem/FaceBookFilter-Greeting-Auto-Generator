using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex02EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    public class BirthdayGreeting : Greeting
    {
        public BirthdayGreeting()
        {
            m_GreetingSubject = "Happy Birthday";
            m_ImageFileName = "Happy_birthday_greeting1";
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.Happy_birthday_greeting1 };
        }
    }
}
