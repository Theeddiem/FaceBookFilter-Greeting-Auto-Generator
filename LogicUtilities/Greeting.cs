using System.Windows.Forms;

namespace LogicUtilities.Greetings
{
    public abstract class Greeting
    {
        protected string m_GreetingSubject;

        protected string m_ImagePath;

        public string ImagePath
        {
            get
            {
                return m_ImagePath;
            }

            set
            {
                m_ImagePath = value;
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