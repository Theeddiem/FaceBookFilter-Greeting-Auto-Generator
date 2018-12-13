using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    public class BirthdayGreeting : Greeting
    {
        private const string k_GreetingSubjet = "Happy Birthday";
        private const string k_ImageFileName = "Happy_birthday_greeting1";

        public BirthdayGreeting()
        {
            m_GreetingSubject = k_GreetingSubjet;
            m_ImageFileName = k_ImageFileName;
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.Happy_birthday_greeting1 };
        }
    }
}
