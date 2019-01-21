using System;
using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public class FavoriteFriend : FriendDecorator , IComparable<FavoriteFriend>
    {
        public string FriendName { get; set; }

        public List<string> CommonPlaces { get; set; }

        public int AmountCommonPlaces { get; set; }

        public FavoriteFriend(User i_User):base(i_User)
        {
            FriendName = i_User.Name;
            CommonPlaces = new List<string>();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} common places", FriendName, AmountCommonPlaces);
        }

        public int CompareTo(FavoriteFriend i_OrderToCompare)
        {
           return i_OrderToCompare.AmountCommonPlaces - AmountCommonPlaces;
        }
    }
}
