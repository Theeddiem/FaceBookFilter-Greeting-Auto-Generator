using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public class FriendDecorator : User
    {
        public User User { get; set; }

        public FriendDecorator(User i_User)
        {
            User = i_User;
        }

    }
}
