using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    class AnniversaryGreeting : Greeting
    {
        private const string k_GreetingSubjet = "Happy Anniversary";
        private const string k_ImageFileName = "wedding_anniversary_greeting";

        public AnniversaryGreeting()
        {
            m_GreetingSubject = k_GreetingSubjet;
            m_ImageFileName = k_ImageFileName;
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.wedding_anniversary_greeting };
        }
    }
}
