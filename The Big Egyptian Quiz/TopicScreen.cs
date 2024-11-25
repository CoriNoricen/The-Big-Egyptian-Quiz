
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace The_Big_Egyptian_Quiz
{
    public partial class TopicScreen : Form
    {

        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        //Creates player
        public static Player player;
        string AvatarNo = "111";

        //Calls instance of Random
        Random rnd = new Random();
        public static int qType;
        int i;

        public TopicScreen(string username, int score, bool FirstTime)
        {
            InitializeComponent();
            CenterToParent();

            //finds avatar from file
            if (File.Exists("avatars.txt"))
            {
                //Reads through file
                string[] avatars = File.ReadLines("avatars.txt").ToArray();

                //Searches for Username
                for (int i = 0; i < avatars.Length; i++)
                {
                    string[] UserNameandAvatar = avatars[i].Split('|');

                    //Finds user
                    if (username == UserNameandAvatar[0])
                    {
                        AvatarNo = UserNameandAvatar[1];
                        break;
                    }
                }
            }
            //shows avatar on-screen
            Avatarimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_" + AvatarNo);

            if (FirstTime == true)
            {
                //creates player values
                player = new Player(username, score);
                player.FirstTime = false;
                FirstTime = player.FirstTime;
            }
            player.Username = username;
            playerNametxt.Text = username + "!";

            player.Avatar = AvatarNo;

            scoreCountertxt.Text = "Score: " + player.Score as string;


            //Create a new ContextMenuStrip
            HelpContextMenuStrip = new ContextMenuStrip();

            //Create a new MenuStrip and adds a ToolStripMenuITem
            MenuStrip ms = new MenuStrip();

            //All ToolStripMenuItems
            ToolStripMenuItem HelpToolStripMenuItem = new ToolStripMenuItem("Help!", null, null, "");
            ms.Items.Add(HelpToolStripMenuItem);
            ToolStripMenuItem AnswerStripMenuItem = new ToolStripMenuItem("How to Answer", null, null, "");
            HelpToolStripMenuItem.DropDownItems.Add(AnswerStripMenuItem);
            ToolStripMenuItem DragDropStripMenuItem = new ToolStripMenuItem("Drag and Drop", null, dragandDropToolStripMenuItem_Click, "");
            AnswerStripMenuItem.DropDownItems.Add(DragDropStripMenuItem);
            ToolStripMenuItem WriteStripMenuItem = new ToolStripMenuItem("Write-In", null, writeInToolStripMenuItem_Click, "");
            AnswerStripMenuItem.DropDownItems.Add(WriteStripMenuItem);
            ToolStripMenuItem MultipleChoiceStripMenuItem = new ToolStripMenuItem("Multiple Choice", null, multipleChoiceToolStripMenuItem_Click, "");
            AnswerStripMenuItem.DropDownItems.Add(MultipleChoiceStripMenuItem);
            ToolStripMenuItem PickagodStripMenuItem = new ToolStripMenuItem("Pick-a-god", null, pickagodToolStripMenuItem_Click, "");
            AnswerStripMenuItem.DropDownItems.Add(PickagodStripMenuItem);
            ToolStripMenuItem TopicStripMenuItem = new ToolStripMenuItem("Topics", null, null, "");
            HelpToolStripMenuItem.DropDownItems.Add(TopicStripMenuItem);
            ToolStripMenuItem MythologyStripMenuItem = new ToolStripMenuItem("Mythology", null, mythologyToolStripMenuItem_Click, "");
            TopicStripMenuItem.DropDownItems.Add(MythologyStripMenuItem);
            ToolStripMenuItem MummificationStripMenuItem = new ToolStripMenuItem("Mummification", null, mummificationToolStripMenuItem_Click, "");
            TopicStripMenuItem.DropDownItems.Add(MummificationStripMenuItem);
            ToolStripMenuItem HistoryStripMenuItem = new ToolStripMenuItem("History", null, historyToolStripMenuItem_Click, "");
            TopicStripMenuItem.DropDownItems.Add(HistoryStripMenuItem);
            ToolStripMenuItem CultureStripMenuItem = new ToolStripMenuItem("Culture", null, cultureToolStripMenuItem_Click, "");
            TopicStripMenuItem.DropDownItems.Add(CultureStripMenuItem);
            ToolStripMenuItem OtherStripMenuItem = new ToolStripMenuItem("Other", null, null, "");
            HelpToolStripMenuItem.DropDownItems.Add(OtherStripMenuItem);
            ToolStripMenuItem LoginStripMenuItem = new ToolStripMenuItem("How to Log-in", null, howToLoginToolStripMenuItem_Click, "");
            OtherStripMenuItem.DropDownItems.Add(LoginStripMenuItem);
            ToolStripMenuItem RegisterStripMenuItem = new ToolStripMenuItem("How to Register", null, howToRegisterToolStripMenuItem_Click, "");
            OtherStripMenuItem.DropDownItems.Add(RegisterStripMenuItem);
            ToolStripMenuItem BonusStripMenuItem = new ToolStripMenuItem("Bonus Game", null, bonusGameToolStripMenuItem_Click, "");
            OtherStripMenuItem.DropDownItems.Add(BonusStripMenuItem);
            ToolStripMenuItem LeaderboardStripMenuItem = new ToolStripMenuItem("Leaderboard", null, leaderboardToolStripMenuItem_Click, "");
            OtherStripMenuItem.DropDownItems.Add(LeaderboardStripMenuItem);

            ToolStripMenuItem GlitchedStripMenuItem = new ToolStripMenuItem("Glitched?", null, null, "");
            ms.Items.Add(GlitchedStripMenuItem);
            ToolStripMenuItem RestartStripMenuItem = new ToolStripMenuItem("Restart App", null, restartAppToolStripMenuItem_Click, "");
            GlitchedStripMenuItem.DropDownItems.Add(RestartStripMenuItem);
            ToolStripMenuItem EndStripMenuItem = new ToolStripMenuItem("End App", null, endAppToolStripMenuItem_Click, "");
            GlitchedStripMenuItem.DropDownItems.Add(EndStripMenuItem);

            //Docks the MenuStrip to the top of the form.
            ms.Dock = DockStyle.Top;

            //Adds MenuStrip controls
            this.Controls.Add(ms);

            //Locks topics once completed
            if (Question.Topic1C == true)
            {
                Mythologybtn.Enabled = false;
                Mythologybtn.Text = "🔒";
            }
            if (Question.Topic2C == true)
            {
                Mummificationbtn.Enabled = false;
                Mummificationbtn.Text = "🔒";
            }
            if (Question.Topic3C == true) 
            {
                Historybtn.Enabled = false;
                Historybtn.Text = "🔒";
            }
            if (Question.Topic4C == true)
            {
                Culturebtn.Enabled = false;
                Culturebtn.Text = "🔒";
            }

            if ((Question.Topic1C == true) && (Question.Topic2C == true) && (Question.Topic3C == true) && (Question.Topic4C == true))
            {
                Endbtn.Visible = true;
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            TopicScreen.player.ResetPlayer();
            Hide();
            new RegisterScreen().Show();
        }

        private void Mythologybtn_Click(object sender, EventArgs e)
        {
            Hide();
            Question.Topic1 = true; Question.Topic2 = false; Question.Topic3 = false; Question.Topic4 = false;
            qType = 1;
            //randomises question types
            i = Question.Randomiser(qType);
            switch (i)
            {
                case 0:
                    new qTypeOne().Show();
                    break;
                case 1:
                    new qTypeTwo().Show();
                    break;
                case 2:
                    new qTypeThree().Show();
                    break;
                case 3:
                    new qTypeFour().Show();
                    break;
            }
            
        }

        private void Mummificationbtn_Click(object sender, EventArgs e)
        {
            Hide();
            Question.Topic2 = true; Question.Topic1 = false; Question.Topic3 = false; Question.Topic4 = false;
            qType = 2;
            //randomises question types
            i = Question.Randomiser(qType);
            switch (i)
            {
                case 4:
                    new qTypeOne().Show();
                    break;
                case 5:
                    new qTypeTwo().Show();
                    break;
                case 6:
                    new qTypeThree().Show();
                    break;
            }
        }

        private void Historybtn_Click(object sender, EventArgs e)
        {
            Hide();
            Question.Topic3 = true; Question.Topic1 = false; Question.Topic2 = false; Question.Topic4 = false;
            qType = 3;
            //randomises question types
            i = Question.Randomiser(qType);
            switch (i)
            {
                case 7:
                    new qTypeOne().Show();
                    break;
                case 8:
                    new qTypeTwo().Show();
                    break;
                case 9:
                    new qTypeThree().Show();
                    break;
            }
        }

        private void Culturebtn_Click(object sender, EventArgs e)
        {
            Hide();
            Question.Topic4 = true; Question.Topic1 = false; Question.Topic2 = false; Question.Topic3 = false;
            qType = 4;
            //randomises question types
            i = Question.Randomiser(qType);
            switch (i)
            {
                case 10:
                    new qTypeOne().Show();
                    break;
                case 11:
                    new qTypeTwo().Show();
                    break;
                case 12:
                    new qTypeThree().Show();
                    break;
            }
        }
        

        //cms methods
        private void dragandDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(0).Show();
        }

        private void writeInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(1).Show();
        }

        private void multipleChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(2).Show();
        }

        private void pickagodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(3).Show();
        }

        private void mythologyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(4).Show();
        }

        private void mummificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(5).Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(6).Show();
        }

        private void cultureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(7).Show();
        }

        private void leaderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(8).Show();
        }

        private void bonusGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(9).Show();
        }

        private void howToRegisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(10).Show();
        }

        private void howToLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HelpScreen(11).Show();
        }

        private void restartAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopicScreen.player.ResetPlayer();
            Application.Restart();
        }

        private void endAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopicScreen.player.ResetPlayer();
            Application.Exit();
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            if (PasswordScreen.PasswordCompleted == true)
            {
                Hide();
                new LeaderboardScreen(0).Show();
            }
            else if (PasswordScreen.LeaderAccessible != false)
            {
                Hide();
                new PasswordScreen(0).Show();
            }
            else
            {
                MessageBox.Show("You have tried too many times. You can \nno longer access the leaderboard.", "BANISHED FROM THE BOARD");
            }
        }

        private void Endbtn_Click(object sender, EventArgs e)
        {
            Hide();
            new EndScreen(TopicScreen.player.Topic1Score, TopicScreen.player.Topic2Score, TopicScreen.player.Topic3Score, TopicScreen.player.Topic4Score).Show();
        }
    }
    //MAKE CUSTOM EXCEPTION CLASS
}
