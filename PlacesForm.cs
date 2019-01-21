using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public partial class PlacesForm : Form
    {
        private User m_LoggedInUser;
        private ListBox m_CurrentFriends;

        public event Action<string> m_ReportSiteSearchDelegates;

        private void notifyObservers(string i_SearchHistory)
        {
            if (m_ReportSiteSearchDelegates != null)
            {
                m_ReportSiteSearchDelegates.Invoke(i_SearchHistory);
            }
        }
        
        public Func<string> getSearchSite =  ()=> @"http://www.google.com/search?q=";

        public PlacesForm(User i_LoggedInUser, ListBox i_CurrentFriends)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            m_CurrentFriends = i_CurrentFriends;
            getFriends();
        }

        private void getFriends()                   
        {
            friendsListBox.Items.Clear();
            friendsListBox.DisplayMember = "Name";

            foreach (User friend in m_CurrentFriends.Items)
            {
                friendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }
        }


        private void getPopularPlacesButton_Click(object sender, EventArgs e)
        {
            getPopularPlaces();
        }

        private void getPopularPlaces()
        {
            popularPlacesListBox.Items.Clear();
            popularPlacesListBox.DisplayMember = "Name";
            List<FavoritePlace> places = updatePlacesRating();

            if (places.Count != 0)
            {
                showPlacesByPopularity(places);
            }
            else
            {
                popularPlacesListBox.Items.Add("No places to show");
            }
        }

        private List<FavoritePlace> updatePlacesRating()
        {
            List<FavoritePlace> places = new List<FavoritePlace>();
            bool exists = false;

            foreach (User currentFriend in friendsListBox.Items)
            {
                foreach (Checkin checkin in currentFriend.Checkins)
                {
                    if (checkin.Place != null)
                    {
                        exists = false;

                        foreach (FavoritePlace place in places)
                        {
                            if (place.Place.Name == checkin.Place.Name)
                            {
                                exists = true;
                                place.Rating++;
                                break;
                            }
                        }

                        if (!exists)
                        {
                            FavoritePlace newPlace = new FavoritePlace(checkin.Place);
                            places.Add(newPlace);
                        }
                    }
                }
            }

            return places;
        }

        private void showPlacesByPopularity(List<FavoritePlace> places)
        {
            places.Sort();

            foreach (FavoritePlace item in places)
            {
                popularPlacesListBox.Items.Add(item);
            }
        }

        private void displayFriendCommonPlaces()
        {
            if (friendsListBox.SelectedItems.Count == 1)
            {
                commonPlacesListBox.Items.Clear();
                commonPlacesListBox.DisplayMember = "Name";
                User selectedFriend = friendsListBox.SelectedItem as User;
                showFriendImage(selectedFriend);
                findCommonPlacesWithFriend(selectedFriend);
                checkForNoCommonPlaces();
            }
        }

        private void findCommonPlacesWithFriend(User i_SelectedFriend)
        {
            foreach (Checkin myCheckin in m_LoggedInUser.Checkins)
            {
                if (myCheckin.Place != null)
                {
                    foreach (Checkin checkinFriend in i_SelectedFriend.Checkins)
                    {
                        if (checkinFriend.Place != null)
                        {
                            if (myCheckin.Place.Name == checkinFriend.Place.Name)
                            {
                                if (!commonPlacesListBox.Items.Contains(checkinFriend.Place.Name))
                                {
                                    commonPlacesListBox.Items.Add(checkinFriend.Place.Name);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void checkForNoCommonPlaces()
        {
            if (commonPlacesListBox.Items.Count == 0)
            {
                commonPlacesListBox.Items.Add("A common place was not found");
            }
        }

        private void showFriendImage(User i_SelectedFriend)
        {
            if (i_SelectedFriend.PictureNormalURL != null)
            {
                friendPictureBox.LoadAsync(i_SelectedFriend.PictureNormalURL);
            }
            else
            {
                friendPictureBox.Image = friendPictureBox.ErrorImage;
            }
        }

        private void friendsListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            displayFriendCommonPlaces();
        }

        private void popularPlacesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedPlace(popularPlacesListBox);
        }

        private void displaySelectedPlace(ListBox i_CurrentListBox)
        {
            this.Size = new Size(1000, Size.Height);
            try
            {
                    string selectedPlaceStr = string.Empty;

                    if (i_CurrentListBox.SelectedItem is FavoritePlace)
                    {
                        FavoritePlace selectedPlace = i_CurrentListBox.SelectedItem as FavoritePlace;
                        selectedPlaceStr = selectedPlace.Place.Name;
                    }
                    else
                    {
                        selectedPlaceStr = i_CurrentListBox.Text;
                    }

                navigateToSearchEngine(selectedPlaceStr);
            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }

        private void navigateToSearchEngine(string i_SelectedPlaceStr)
        {
            StringBuilder addreas = new StringBuilder();

            addreas.Append(getSearchSite.Invoke());
            addreas.Append(i_SelectedPlaceStr);
            searchEngineWeb.Navigate(addreas.ToString());

            string msg = string.Format("{0:HH:mm:ss tt} | You have searched :  {1}", DateTime.Now, i_SelectedPlaceStr);
            notifyObservers(msg);

        }

        private void getPotentialFriendsButton_Click(object sender, EventArgs e)
        {
            fetchFriendsWithMostCommonPlaces();
        }

        private void fetchFriendsWithMostCommonPlaces()
        {
            friendsWithCommonPlacesListBox.Items.Clear();
            List<FavoriteFriend> friendsWithCommonPlaces = findFriendsWithCommonPlaces();

            if (friendsWithCommonPlaces.Count > 0)
            {
                showByPopularityFriendsWithCommonPlaces(friendsWithCommonPlaces);
            }
            else
            {
                friendsWithCommonPlacesListBox.Items.Add("No friends with common places");
            }
        }

        private List<FavoriteFriend> findFriendsWithCommonPlaces()
        {
            List<FavoriteFriend> friendsWithCommonPlaces = new List<FavoriteFriend>();
            
            foreach (User currentFriend in friendsListBox.Items)
            {
                FavoriteFriend currentFavFriend = new FavoriteFriend(currentFriend.Name);

                foreach (Checkin friendCheckIn in currentFriend.Checkins)
                {
                    if (friendCheckIn.Place != null)
                    {
                        foreach (Checkin userCheckIn in m_LoggedInUser.Checkins)
                        {
                            if (userCheckIn.Place != null)
                            {
                                if (userCheckIn.Place.Name.Equals(friendCheckIn.Place.Name))
                                {
                                    if (!currentFavFriend.CommonPlaces.Contains(userCheckIn.Place.Name))
                                    {
                                        currentFavFriend.CommonPlaces.Add(userCheckIn.Place.Name);
                                        currentFavFriend.AmountCommonPlaces++;
                                    }
                                }
                            }
                        }
                    }
                }

                if (currentFavFriend.AmountCommonPlaces > 0)
                {
                    friendsWithCommonPlaces.Add(currentFavFriend);
                }
            }

            return friendsWithCommonPlaces;
        }

        private void showByPopularityFriendsWithCommonPlaces(List<FavoriteFriend> i_FriendsWithCommonPlaces)
        {
            i_FriendsWithCommonPlaces.Sort();
            foreach (FavoriteFriend item in i_FriendsWithCommonPlaces)
            {
                friendsWithCommonPlacesListBox.Items.Add(item);
            }
        }

        private void commonPlacesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            displaySelectedPlace(commonPlacesListBox);
        }

        private void radioButtonSearch_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGoogle.Checked)
            {
                getSearchSite = () => @"http://www.google.com/search?q=";
            }
            else if (radioButtonBing.Checked)
            {
                getSearchSite = () => @"https://www.bing.com/search?q=";
            }
            else if (radioButtonDuckDuckGo.Checked)
            {
                getSearchSite = () => @"https://duckduckgo.com/?q=";

            }
  ]
   SADSADdsadsad322131c sadsa
            //(@"http://www.google.com/search?q=");
            //@"https://www.bing.com/search?q=");
        }
    }
}