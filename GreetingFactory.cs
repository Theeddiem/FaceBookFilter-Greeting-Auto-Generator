using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings
{
    public static class GreetingFactory
    {
        public static Greeting Create(string i_Type)
        {
            Greeting greeting = null;

            if(i_Type.Equals("AnniversaryGreeting"))
            {
                greeting  = new AnniversaryGreeting();
            }
            else if(i_Type.Equals("BirthdayGreeting"))
            {
                greeting = new BirthdayGreeting();
            }
            else if(i_Type.Equals("HolidayGreeting"))
            {
                greeting = new HolidayGreeting();
            }
            else if (i_Type.Equals("NewYearGreeting"))
            {
               // greeting = new NewYearGreeting();
            }
            else if (i_Type.Equals("RecruitmentGreeting"))
            {
                greeting = new RecruitmentGreeting();
            }
            else if (i_Type.Equals("WeddingGreeting"))
            {
                greeting = new WeddingGreeting();
            }

            return greeting;
        }
    }
}
