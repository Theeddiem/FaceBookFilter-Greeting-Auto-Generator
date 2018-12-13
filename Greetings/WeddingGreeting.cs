using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    class WeddingGreeting : Greeting 
    {
        private const string k_GreetingSubjet = "Wedding Anniversary";
        private const string k_ImageFileName = "happy_Wedding_greeting";

        public WeddingGreeting()
        {
            m_GreetingSubject = k_GreetingSubjet;
            m_ImageFileName = k_ImageFileName;
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.happy_Wedding_greeting };
        }
    }
}
