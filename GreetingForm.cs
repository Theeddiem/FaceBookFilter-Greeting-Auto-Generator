using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public partial class GreetingsForm : Form
    {
        private User m_LoggedInUser;
        private Greeting m_SelectedGreeting;

        public event Action<string> m_ReportGreetingSentDelegates;

     
        public GreetingsForm(User i_LoggedInUser, ListBox i_CurrentFriends)
        {
            InitializeComponent();
            m_LoggedInUser = i_LoggedInUser;
            getFriends(i_CurrentFriends);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            getGreetingList();
        }

        private void notifyObservers(string i_HistoryMsg)
        {
            if (m_ReportGreetingSentDelegates != null)
            {
                m_ReportGreetingSentDelegates.Invoke(i_HistoryMsg);

            }
        }

        private void getGreetingList()
        {
            foreach (string item in Enum.GetNames(typeof(EgreetingType)))
            {
                greetingsListBox.Items.Add(GreetingFactory.Create(item));
            }
        }

        private void greetingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_SelectedGreeting = greetingsListBox.SelectedItem as Greeting;
            greetingPictureBox.Image = m_SelectedGreeting.GreetingPicture.Image;

            if (friendsListBox.SelectedItems.Count > 0)
            {
                sendEmailButton.Enabled = true;
            }
        }

        private void sendEmailButton_Click(object sender, EventArgs e)
        {
            new Thread(sendEmailGreeting).Start();
        }

        private void sendEmailGreeting()
        {
            friendsListBox.Invoke(new Action(() =>
            {
                if (friendsListBox.SelectedItems.Count > 0 && greetingsListBox.SelectedItem != null)
                {
                    string currentFriendName = null;
                    try
                    {
                        foreach (User selectedFriend in friendsListBox.SelectedItems)
                        {
                            currentFriendName = selectedFriend.Name;
                            sendEmail(msgTextBox.Text, m_LoggedInUser.Name, selectedFriend);
                            string msg = string.Format("{0:HH:mm:ss}| Sent Mail to : {1}", DateTime.Now, currentFriendName);
                            notifyObservers(msg);
                        }
                    MessageBox.Show("Sent");
                }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    string msg = string.Format("{0:HH:mm:ss}| Failed to send mail to : {1}", DateTime.Now, currentFriendName);
                    notifyObservers(msg);
                    }
            }
            }));
        }

        private void sendEmail(string i_MsgBody, string i_FromName, User i_SelectedFriend)
        {
            string name = i_SelectedFriend.Name;
            string toAddress = i_SelectedFriend.Email; 
            string fromAddress = "greetingscsharp@gmail.com";
            string msgSubject = string.Format($"{m_SelectedGreeting.GreetingSubject} from {i_FromName}");
            string imagePath = string.Format("{0}\\Resources\\{1}.jpg", Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, m_SelectedGreeting.ImageFileName);
            Mail.SendEmailMessage(toAddress, fromAddress, msgSubject, i_MsgBody, imagePath);
        }

        private void friendsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (greetingsListBox.SelectedItem != null && friendsListBox.SelectedItems.Count > 0)
            {
                sendEmailButton.Enabled = true;
            }
            else
            {
                sendEmailButton.Enabled = false;
            }
        }

        private void getFriends(ListBox i_CurrentFriends)
        {
            friendsListBox.Items.Clear();
            friendsListBox.DisplayMember = "Name";
            foreach (User friend in i_CurrentFriends.Items)
            {
                friendsListBox.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            }

            if (i_CurrentFriends.Items.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve :(");
            }
        }

        private void addMsgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (addMsgCheckBox.Checked)
            {
                msgTextBox.Enabled = true;
            }
            else
            {
                msgTextBox.Enabled = false;
                msgTextBox.Text = string.Empty;
            }
        }
    }
}