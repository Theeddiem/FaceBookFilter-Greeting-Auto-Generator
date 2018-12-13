using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    class RecruitmentGreeting : Greeting
    {
        private const string k_GreetingSubjet = "Easy Recruitment";
        private const string k_ImageFileName = "gious_kal";

        public RecruitmentGreeting()
        {
            m_GreetingSubject = k_GreetingSubjet;
            m_ImageFileName = k_ImageFileName;
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.gious_kal };
        }
    }
}
