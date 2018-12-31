using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    
    public partial class MainForm : Form
    {
        private const int k_PhotosAmountPerAlbum = 4;
        private User m_LoggedInUser;
        private string k_MyAppId = "1954908174562233";
        private string k_GuyAppId = "1450160541956417";

        
        public MainForm()
        {
            FacebookService.s_CollectionLimit = 10;
            FacebookService.s_FbApiVersion = 2.8f;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            loginAndInit();//new Thread(loginAndInit).Start();
        }

        private void loginAndInit()
        {
                LoginResult result = FacebookService.Login(k_GuyAppId,
                "public_profile",
                "user_birthday",
                "user_friends",
                "user_events",
                "user_hometown",
                "user_gender",
                "email",
                "user_likes",
                "user_posts",
                "user_tagged_places",
                "user_photos"
                );
  
            fetchUserConnection(result);
        }

        private void fetchUserConnection(LoginResult i_Result)
        {
            if (!string.IsNullOrEmpty(i_Result.AccessToken))
            {
                m_LoggedInUser = i_Result.LoggedInUser;
                new Thread(updateLogInUi).Start();
            }
            else
            {
                MessageBox.Show(i_Result.ErrorMessage);
            }
        }

        private void updateLogInUi()
        {
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            this.Invoke(new Action(() => this.Text = m_LoggedInUser.Name));
            nameLabel.Invoke(new Action(() => nameLabel.Text = m_LoggedInUser.Name));
            showLogInLabels();
            changeToLogInButton();
            enableButtons(true);
            fetchInfo();
        }

        private void changeToLogInButton()
        {
            loginButton.Invoke(new Action(() => loginButton.Hide()));
            logOutButton.Invoke(new Action(() => logOutButton.Show()));
        }

        private void showLogInLabels()
        {
            nameLabel.Invoke(new Action(() => nameLabel.Show() ));
            userInfoLabel.Invoke(new Action(() => userInfoLabel.Show()));
            amountFriendsLabel.Invoke(new Action(() => amountFriendsLabel.Show()));
            birthdayLabel.Invoke(new Action(() => birthdayLabel.Show()));
            friendBirthdayLabel.Invoke(new Action(() => friendBirthdayLabel.Show()));
        }

        private void fetchInfo()
        {
            new Thread(getFriendsData).Start();
            new Thread(getPosts).Start();
            new Thread(getLikedPages).Start();
            //new Thread(getPhotos).Start();
        }

        private void getPlacesFeatureButton_Click(object sender, EventArgs e)
        {
            PlacesForm placesForm = new PlacesForm(m_LoggedInUser, friendsListBox);
            placesForm.Show();
        }

        private void greetingFeatureButton_Click(object sender, EventArgs e)
        {
            GreetingsForm greetingsForm = new GreetingsForm(m_LoggedInUser, friendsListBox);
            greetingsForm.Show();
        }

        private void getPostsButton_Click(object sender, EventArgs e)
        {
            new Thread(getPosts).Start();
        }

        private void getPosts()
        {
            try
            {

                var allPosts = m_LoggedInUser.Posts;
                if (!postsListBox.InvokeRequired)
                {
                    postsBindingSource.DataSource = allPosts;
                }
                else
                {
                    postsListBox.Invoke(new Action(() => postsBindingSource.DataSource = allPosts));
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(new Action(logoutAction));
        }

        private void logoutAction()
        {
            changeToLogOutButton();
            profilePictureBox.Image = A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.unknow;
            this.Text = "Welcome to Facebook";
            hideLogOutLabels();
            eraseCurrentContent();
            enableButtons(false);
        }

        private void changeToLogOutButton()
        {
            loginButton.Show();
            logOutButton.Hide();
        }

        private void hideLogOutLabels()
        {
            nameLabel.Hide();
            userInfoLabel.Hide();
            amountFriendsLabel.Hide();
            friendPictureBox.Hide();
            birthdayLabel.Hide();
            friendBirthdayLabel.Hide();
        }

        private void enableButtons(bool i_Enable)
        {
            findPlacesButton.Invoke(new Action(() => findPlacesButton.Enabled = i_Enable ));
            sendGreetingButton.Invoke(new Action(() => sendGreetingButton.Enabled = i_Enable));
            friendsButton.Invoke(new Action(() => friendsButton.Enabled = i_Enable));
            photosButton.Invoke(new Action(() => photosButton.Enabled = i_Enable));
            getLikedPagesButton.Invoke(new Action(() => getLikedPagesButton.Enabled = i_Enable));
            getPostsButton.Invoke(new Action(() => getPostsButton.Enabled = i_Enable));
        }

        private void eraseCurrentContent()
        {
            friendsListBox.Items.Clear();
            likedPagesListBox.Items.Clear();
            postsListBox.Items.Clear();
            photosFlowLayoutPanel.Controls.Clear();
        }

        private void getLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(getLikedPages).Start();
        }

        private void getLikedPages()
        {
            try
            {
                var allLikedPages = m_LoggedInUser.LikedPages;
                if (!likedPagesListBox.InvokeRequired)
                {
                    likedPagesBindingSource.DataSource = allLikedPages;     
                }
                else
                {
                    likedPagesListBox.Invoke(new Action(() => likedPagesBindingSource.DataSource = allLikedPages));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            new Thread(getFriendsData).Start();
        }

        private void getFriendsData()
        {
            try
            {
                var allFriends = m_LoggedInUser.Friends;
                if (!friendsListBox.InvokeRequired)
                {
                    userBindingSource.DataSource = allFriends;
                }
                else
                {
                    friendsListBox.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
                }
            }
            catch {

            }

            amountFriendsLabel.Invoke(new Action(() => amountFriendsLabel.Text = m_LoggedInUser.Friends.Count().ToString()));
            
        }

        //private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    displaySelectedFriend();
        //}

        //private void displaySelectedFriend()
        //{
        //    if (friendsListBox.SelectedItems.Count == 1)
        //    {
        //        User selectedFriend = friendsListBox.SelectedItem as User;

        //        if (selectedFriend.PictureNormalURL != null)
        //        {
        //            friendPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
        //        }
        //        else
        //        {
        //            friendPictureBox.Image = friendPictureBox.ErrorImage;
        //        }

        //        friendPictureBox.Show();

        //        if (selectedFriend.Birthday != null)
        //        {
        //            birthdayLabel.Text = string.Format("{1}Birthday: {0}", Environment.NewLine);
        //        }
        //        //else
        //        //{
        //        //    birthdayLabel.Text = string.Format("Gend{1}Birthday: n/a", selectedFriend.Gender, Environment.NewLine);
        //        //}

        //        birthdayLabel.Show();
        //    }
        //}

        private void photosButton_Click(object sender, EventArgs e)
        {
            new Thread(getPhotos).Start();
        }

        private void getPhotos()
        {
            try
            {
                foreach (Album album in m_LoggedInUser.Albums)
                {
                    int amountOfPhotos = 1;
                    foreach (Photo photo in album.Photos)
                    {
                        PictureBox picture = new PictureBox { Image = photo.ImageNormal, SizeMode = PictureBoxSizeMode.StretchImage };
                        picture.Size = new Size(90, 80);
                        photosFlowLayoutPanel.Invoke(new Action(() => photosFlowLayoutPanel.Controls.Add(picture)));

                        if (amountOfPhotos++ == k_PhotosAmountPerAlbum)
                        {
                            break;
                        }
                    }
                }

                if (m_LoggedInUser.Albums.Count == 0)
                {
                    noPictureAvaillable();
                }
            }
            catch
            {
                noPictureAvaillable();
            }
        }

        private void noPictureAvaillable()
        {
            PictureBox picture = new PictureBox();
            picture.Size = new Size(photosFlowLayoutPanel.Width - 10, photosFlowLayoutPanel.Height - 10);
            picture.Image = A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Properties.Resources.not_available_;
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            photosFlowLayoutPanel.Invoke(new Action(() => photosFlowLayoutPanel.Controls.Add(picture)));
        }
    }
}
