using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{

    class HolidayGreeting : Greeting
    {
        public HolidayGreeting()
        {
            m_GreetingSubject = "Happy Holiday";
            m_ImageFileName = "happy_holiday_greeting";
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.happy_holiday_greeting };
        }
    }
}
