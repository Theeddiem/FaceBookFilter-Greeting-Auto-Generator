using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    internal class RecruitmentGreeting : Greeting
    {
        public RecruitmentGreeting()
        {
            m_GreetingSubject = "Easy Recruitment";
            m_ImageFileName = "gious_kal";
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.gious_kal };
        }
    }
}
