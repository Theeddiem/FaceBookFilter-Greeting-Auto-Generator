using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    internal class AnniversaryGreeting : Greeting
    {
        public AnniversaryGreeting()
        {
            m_GreetingSubject = "Happy Anniversary";
            m_ImageFileName = "wedding_anniversary_greeting";
            m_GreetingPicture = new PictureBox { Image = Properties.Resources.wedding_anniversary_greeting };
        }
    }
}
