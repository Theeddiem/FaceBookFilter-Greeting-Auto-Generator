using System.Windows.Forms;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public class Greeting
    {
        public string GreetingSubject { get; set; }

        public string ImageFileName { get; set; }

        public PictureBox GreetingPicture { get; }

        public Greeting(string i_GreetingSubject, PictureBox i_GreetingPicture, string i_ImageFileName)
        {
            GreetingSubject = i_GreetingSubject;
            ImageFileName = i_ImageFileName;
            GreetingPicture = i_GreetingPicture;
        }

        public override string ToString()
        {
            return GreetingSubject;
        }
    }
}
