using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Big_Egyptian_Quiz
{
    public partial class PasswordScreen : Form
    {
        public static bool LeaderAccessible = true;
        public static bool PasswordCompleted = false;

        //Password to enter leaderboard
        string LeaderPassword = "AdminRa4321";
        string CurrentPassword = "";

        //Keeps number passed through
        int intForm;
        int TriesRemaining = 3;
        bool cPassword = false;

        public PasswordScreen(int Int)
        {
            //Allows int to be used throughout form
            intForm = Int;
            InitializeComponent();
            CenterToParent();
        }

        private void Passwordtxt_TextChanged(object sender, EventArgs e)
        {
            CurrentPassword = Passwordtxt.Text;
        }

        private void Forwardbtn_Click(object sender, EventArgs e)
        {
            //checks input against admin password
            if (CurrentPassword == LeaderPassword && intForm == 0)
            {
                PasswordCompleted = true;
                Hide();
                new LeaderboardScreen(0).Show();
            }
            else if (CurrentPassword == LeaderPassword && intForm == 1)
            {
                PasswordCompleted = true;
                Hide();
                new LeaderboardScreen(1).Show();
            }
            else
            {
                //shows tries remaining
                MessageBox.Show("Password Incorrect. " + TriesRemaining as string + " tries remaining.", "Try again!");
                if (TriesRemaining == 0 && intForm == 0)
                {
                    //prevents access to the leaderboard
                    LeaderAccessible = false;
                    Hide();
                    new TopicScreen(TopicScreen.player.Username, TopicScreen.player.Score, TopicScreen.player.FirstTime).Show();
                }
                else if (TriesRemaining == 0 && intForm == 1)
                {
                    //prevents access to the leaderboard
                    LeaderAccessible = false;
                    Hide();
                    new EndScreen(TopicScreen.player.Topic1Score, TopicScreen.player.Topic2Score, TopicScreen.player.Topic3Score, TopicScreen.player.Topic4Score).Show();
                }
                TriesRemaining--;
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            //prevents access to the leaderboard
            LeaderAccessible = false;
            MessageBox.Show("You can no longer access the leaderboard.", "BANISHED FROM THE BOARD");
            Hide();
            if (intForm == 0)
            {
                new TopicScreen(TopicScreen.player.Username, TopicScreen.player.Score, TopicScreen.player.FirstTime).Show();
            }
            else if (intForm == 1)
            {
                new EndScreen(TopicScreen.player.Topic1Score, TopicScreen.player.Topic2Score, TopicScreen.player.Topic3Score, TopicScreen.player.Topic4Score).Show();
            }
        }

        private void cPasswordbtn_Click(object sender, EventArgs e)
        {
            if (cPassword == false)
            {
                cPassword = true;
                Passwordtxt.UseSystemPasswordChar = false;
            }
            else
            {
                cPassword = false;
                Passwordtxt.UseSystemPasswordChar = true;
            }
        }
    }
}
