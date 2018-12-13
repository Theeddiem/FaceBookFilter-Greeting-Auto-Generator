using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{

    class HolidayGreeting : Greeting
    {
        private const string k_GreetingSubjet = "Happy Holiday";
        private const string k_ImageFileName = "happy_holiday_greeting";

        public HolidayGreeting()
        {
            m_GreetingSubject = k_GreetingSubjet;
            m_ImageFileName = k_ImageFileName;
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.happy_holiday_greeting };
        }
    }
}
