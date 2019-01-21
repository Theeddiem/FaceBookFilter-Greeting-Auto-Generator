using System;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public class FavoritePlace : IComparable<FavoritePlace>
    {
        public Page Place { get; set; }

        public int Rating { get; set; }

        public FavoritePlace(Page i_Place)
        {
            Place = i_Place;
            Rating = 1;
        }

        public override string ToString()
        {
            return string.Format("{0} , Rated: {1}", Place.Name, Rating);
        }

        public int CompareTo(FavoritePlace i_OrderToCompare)
        {
           return i_OrderToCompare.Rating - Rating;
        }
    }
}
