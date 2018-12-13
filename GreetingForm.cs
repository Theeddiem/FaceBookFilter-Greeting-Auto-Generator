using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using A19Ex01EddieKnyazhinsky311354047HadasFoox205651060.Greetings;
using FacebookWrapper.ObjectModel;

namespace A19Ex01EddieKnyazhinsky311354047HadasFoox205651060
{
    public partial class GreetingsForm : Form
    {
        private User m_LoggedInUser;
        private Greeting m_SelectedGreeting;

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

        private void getGreetingList()
        {
            foreach (var item in Enum.GetNames(typeof(Greeting.GreetingType)))
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
            sendEmailGreeting();
        }

        private void sendEmailGreeting()
        {
            if (friendsListBox.SelectedItems.Count > 0 && greetingsListBox.SelectedItem != null)
            {
                try
                {
                    foreach (User selectedFriend in friendsListBox.SelectedItems)
                    {
                        sendEmail(msgTextBox.Text, m_LoggedInUser.Name, selectedFriend);
                    }

                    MessageBox.Show("Sent");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
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