using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_Big_Egyptian_Quiz
{
    public partial class LoginScreen : Form
    {
        // Declare the ContextMenuStrip control.
        readonly private ContextMenuStrip HelpContextMenuStrip;

        //Used to Show/Hide password
        bool cPassword = false;
        int score = 0;

        public LoginScreen()
        {
            InitializeComponent();
            //Centers to Screen
            CenterToParent();

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
        }

        private void cPasswordbtn_Click(object sender, EventArgs e)
        {
            //Shows/Hides password when clicked
            if (cPassword == false)
            {
                cPassword = true;
                Passwordtxt.UseSystemPasswordChar = false;
                //Changes Eye of Horus Image
                cPasswordbtn.BackgroundImage = Properties.Resources.No_Eye;
            }
            else
            {
                cPassword = false;
                Passwordtxt.UseSystemPasswordChar = true;

                cPasswordbtn.BackgroundImage = Properties.Resources.Eye_of_Horus;
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string UserName = Usernametxt.Text;
            string Password = Passwordtxt.Text;

            //Checks fields are not empty
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                //Checks file has been created
                if (File.Exists("users.txt"))
                {
                    //Reads through file
                    string[] users = File.ReadLines("users.txt").ToArray();
                    bool userFound = false;
                    
                    //Searches for Username and Password
                    for (int i = 0; i < users.Length; i++)
                    {
                        string[] UserNameandPassword = users[i].Split('|');

                        //Finds user
                        if (UserName == UserNameandPassword[0] && Password == UserNameandPassword[1])
                        {
                            userFound = true;
                            break;
                        }
                    }

                    if (userFound)
                    {
                        MessageBox.Show("You're logged in! Welcome " + UserName + ".", "Logged in");
                        Hide();
                        new TopicScreen(UserName, score, true).Show();
                    }
                    else
                    {
                        MessageBox.Show("We can't find you! \nCheck your details!", "Are you sure the details are right?");
                    }
                }
                else
                {
                    MessageBox.Show("No-one has played this yet! \nYou should register and be the first!", "No Users found!");
                }
            }
            else
            {
                MessageBox.Show("You must protect your account from Seth!", "Username or Password missing!");
            }
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Hide();
            new RegisterScreen().Show();
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
            Application.Restart();
        }

        private void endAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
