using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public abstract class Greeting
    {
        protected string m_GreetingSubject;

        protected string m_ImageFileName;

        protected PictureBox m_GreetingPicture;

        public string ImageFileName
        {
            get
            {
                return m_ImageFileName;
            }
        }

        public PictureBox GreetingPicture
        {
            get
            {
                return m_GreetingPicture;
            }
        }

        public string GreetingSubject
        {
            get
            {
                return m_GreetingSubject;
            }
        }

        public override string ToString()
        {
            return m_GreetingSubject;
        }
    }
}