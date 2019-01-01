using System;
using System.Collections.Generic;

namespace A19Ex02EddieKnyazhinsky311354047HadasFoox205651060
{
    public class FavoriteFriend : IComparable<FavoriteFriend>
    {
        public string FriendName { get; set; }

        public List<string> CommonPlaces { get; set; }

        public int AmountCommonPlaces { get; set; }

        public FavoriteFriend(string i_FriendName)
        {
            FriendName = i_FriendName;
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
