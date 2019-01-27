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
        private const int k_PhotosAmountPerAlbum = 3;
        private User m_LoggedInUser;
        private string k_MyAppId = "1954908174562233";

        public MainForm()
        {
            FacebookService.s_CollectionLimit = 15;
            FacebookService.s_FbApiVersion = 2.8f;
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(loginAndInit);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
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
                "user_photos"
                );

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
            profilePictureBox.Invoke(new Action(() => profilePictureBox.LoadAsync(m_LoggedInUser.PictureNormalURL)));
            this.Invoke(new Action(() => this.Text = m_LoggedInUser.Name));
            nameLabel.Invoke(new Action(() => nameLabel.Text = m_LoggedInUser.Name));
            userInfoLabel.Invoke(new Action(() => userInfoLabel.Text = string.Format("Gender : {0} {1}Birthday: {2} {1}Email: {3}{1}", m_LoggedInUser.Gender, Environment.NewLine, m_LoggedInUser.Birthday, m_LoggedInUser.Email)));
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
            friendPictureBox.Invoke(new Action(() => friendPictureBox.Show()));
            friendsListBox.Invoke(new Action(() => friendsListBox.Show()));
            postsListBox.Invoke(new Action(() => postsListBox.Show()));
            likedPagesListBox.Invoke(new Action(() => likedPagesListBox.Show()));
            photosFlowLayoutPanel.Invoke(new Action(() => photosFlowLayoutPanel.Show()));

            friendsListBox2.Invoke(new Action(() => friendsListBox2.Hide()));
            postsListBox2.Invoke(new Action(() => postsListBox2.Hide()));
            likedPagesListBox2.Invoke(new Action(() => likedPagesListBox2.Hide()));
            photosFlowLayoutPanel2.Invoke(new Action(() => photosFlowLayoutPanel2.Hide()));
        }

        private void fetchInfo()
        {
            new Thread(getFriendsData).Start();
           // new Thread(getPosts).Start();
           // new Thread(getLikedPages).Start();
            //new Thread(getPhotos).Start();
        }



        private void getPlacesFeatureButton_Click(object sender, EventArgs e)
        {
            PlacesForm placesForm = new PlacesForm(m_LoggedInUser, friendsListBox);
          //  placesForm.m_ReportSiteSearchDelegates += new Action<string>(this.upDateListBoxListener);
            placesForm.m_ReportSiteSearchDelegates += (this.upDateListBoxListener);

            placesForm.Show();
        }

        private void greetingFeatureButton_Click(object sender, EventArgs e)
        {
            GreetingsForm greetingsForm = new GreetingsForm(m_LoggedInUser, friendsListBox);


            greetingsForm.m_ReportGreetingSentDelegates += new Action<string>(this.upDateListBoxListener);

            greetingsForm.Show();
        }

        private void upDateListBoxListener(string i_Msg)
        {
            HistoryListBox.Items.Add(i_Msg + "\n");
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
            hideLogOut();
            enableButtons(false);
        }

        private void changeToLogOutButton()
        {
            loginButton.Show();
            logOutButton.Hide();
        }

        private void hideLogOut()
        {
            nameLabel.Hide();
            userInfoLabel.Hide();
            amountFriendsLabel.Hide();
            friendPictureBox.Hide();
            birthdayLabel.Hide();
            friendBirthdayLabel.Hide();
            catchPageLabel.Hide();
            friendsListBox.Hide();
            postsListBox.Hide();
            likedPagesListBox.Hide();
            photosFlowLayoutPanel.Hide();
            photosFlowLayoutPanel.Controls.Clear();
            friendsListBox2.Show();
            postsListBox2.Show();
            likedPagesListBox2.Show();
            photosFlowLayoutPanel2.Show();
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
            catch 
            {
                catchPageLabel.Invoke(new Action(() => catchPageLabel.Text = "N/A"));
                catchPageLabel.Invoke(new Action(() => catchPageLabel.Visible = true));
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
            catch
            {
            }

            amountFriendsLabel.Invoke(new Action(() => amountFriendsLabel.Text = m_LoggedInUser.Friends.Count().ToString()));
        }

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
