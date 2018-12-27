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
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            //var t = new Thread(loginAndInit);
            //t.SetApartmentState(ApartmentState.STA);
            //t.Start();
            loginAndInit();
        }

        private void loginAndInit()
        {
                LoginResult result = FacebookService.Login(k_MyAppId,
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
                "user_photos");
  
            fetchUserConnection(result);
        }

        private void fetchUserConnection(LoginResult i_Result)
        {
            if (!string.IsNullOrEmpty(i_Result.AccessToken))
            {
                m_LoggedInUser = i_Result.LoggedInUser;
                updateLogInUi();
            }
            else
            {
                MessageBox.Show(i_Result.ErrorMessage);
            }
        }

        private void updateLogInUi()
        {
            //profilePictureBox.Invoke(new Action(() => profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL)));
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL);
            //this.Invoke(new Action(()=>this.Text = m_LoggedInUser.Name));
            this.Text = m_LoggedInUser.Name;
            nameLabel.Text = m_LoggedInUser.Name;

            if (m_LoggedInUser.Birthday != null)
            {
                userInfoLabel.Text = string.Format("Email: {0}{3}Gender: {1}{3}Birthday: {2} ", m_LoggedInUser.Email, m_LoggedInUser.Gender, m_LoggedInUser.Birthday, Environment.NewLine);
            }
            else
            {
                userInfoLabel.Text = string.Format("Email: {0}{2}Gender: {1}{2}Birthday: n/a ", m_LoggedInUser.Email, m_LoggedInUser.Gender, Environment.NewLine);
            }

            showLogInLabels();
            changeToLogInButton();
            enableButtons(true);
            fetchInfo();
        }

        private void changeToLogInButton()
        {
            loginButton.Hide();
            logOutButton.Show();
        }

        private void showLogInLabels()
        {
            nameLabel.Show();
            userInfoLabel.Show();
            amountFriendsLabel.Show();
        }

        private void fetchInfo()
        {
            //new Thread(getFriendsData).Start();
            //new Thread(getPosts).Start();
            getFriendsData();
            getPosts();
           // new Thread(getLikedPages).Start();
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
            //new Thread(getPosts).Start();
        }

        private void getPosts()
        {
            var allPosts = m_LoggedInUser.Posts;
            if (!postsListBox.InvokeRequired)
            {
                // binding the data source of the binding source, to our data source:
                postsBindingSource.DataSource = allPosts;
            }
            else
            {
                // In case of cross-thread operation, invoking the binding code on the listBox's thread:
                postsListBox.Invoke(new Action(() => postsBindingSource.DataSource = allPosts));
            }

            //amountFriendsLabel.Text = m_LoggedInUser.Friends.Count().ToString();

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
            friendLabel.Hide();
        }

        private void enableButtons(bool i_Enable)
        {
            findPlacesButton.Enabled = i_Enable;
            sendGreetingButton.Enabled = i_Enable;
            friendsButton.Enabled = i_Enable;
            photosButton.Enabled = i_Enable;
            getLikedPagesButton.Enabled = i_Enable;
            getPostsButton.Enabled = i_Enable;
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
            getLikedPages();
        }

        private void getLikedPages()
        {

      
        }

        private void friendsButton_Click(object sender, EventArgs e)
        {
            getFriendsData();
        }

        private void getFriendsData()
        {
            var allFriends = m_LoggedInUser.Friends;
            if (!friendsListBox.InvokeRequired)
            {
                // binding the data source of the binding source, to our data source:
                userBindingSource.DataSource = allFriends;
            }
            else
            {
                // In case of cross-thread operation, invoking the binding code on the listBox's thread:
                friendsListBox.Invoke(new Action(() => userBindingSource.DataSource = allFriends));
            }

            amountFriendsLabel.Text = m_LoggedInUser.Friends.Count().ToString();
            
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedFriend();
        }

        private void displaySelectedFriend()
        {
            if (friendsListBox.SelectedItems.Count == 1)
            {
                User selectedFriend = friendsListBox.SelectedItem as User;

                if (selectedFriend.PictureNormalURL != null)
                {
                    friendPictureBox.LoadAsync(selectedFriend.PictureNormalURL);
                }
                else
                {
                    friendPictureBox.Image = friendPictureBox.ErrorImage;
                }

                friendPictureBox.Show();

                if (selectedFriend.Birthday != null)
                {
                    friendLabel.Text = string.Format("Gender: {1}{2}Birthday: {0}", selectedFriend.Birthday.ToString(), selectedFriend.Gender, Environment.NewLine);
                }
                else
                {
                    friendLabel.Text = string.Format("Gender: {0}{1}Birthday: n/a", selectedFriend.Gender, Environment.NewLine);
                }

                friendLabel.Show();
            }
        }

        private void photosButton_Click(object sender, EventArgs e)
        {
            getPhotos();
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
                        photosFlowLayoutPanel.Controls.Add(picture);

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
            photosFlowLayoutPanel.Controls.Add(picture);
        }
    }
}
