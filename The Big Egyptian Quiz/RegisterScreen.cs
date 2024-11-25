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
    public partial class RegisterScreen : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        //Used to Show/Hide password
        bool cPasswordOne = false;
        bool cPasswordTwo = false;

        //Checks for Number in Password
        int NumPresent = 0;

        //Checks for identicality
        string PasswordOneCheck = "";
        string PasswordTwoCheck = "";

        bool UserUsed = false;

        public RegisterScreen()
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

        //Password must be at least 3 characters and have a number
        private void Registerbtn_Click(object sender, EventArgs e)
        {
            UsernameExists();

            if (UserUsed != true)
            {
                //Checks Username and Password are not empty
                if (PasswordOnetxt.Text != string.Empty && Usernametxt.Text != string.Empty)
                {
                    //Checks both Password boxes are the same
                    if (PasswordOnetxt.Text == PasswordTwotxt.Text)
                    {
                        //Checks for a number
                        for (int i = 0; i <= 9; i++)
                        {
                            if (PasswordOnetxt.Text.Contains(Convert.ToString(i)))
                            {
                                NumPresent++;
                            }
                        }
                        //Checks for number and minimum length
                        if (PasswordOnetxt.TextLength >= 3 && Usernametxt.TextLength <= 8 && NumPresent > 0)
                        {
                            //Create a file path to the folder to hold the User details
                            string filePath = @"users.txt";
                            FileStream aFile;
                            StreamWriter sWriter;

                            //try-catch statement to prevent errors
                            try
                            {
                                if (!File.Exists(filePath))
                                {
                                    //Creates file
                                    aFile = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                                }
                                else
                                {
                                    //Appends file
                                    aFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                                }
                                sWriter = new StreamWriter(aFile);
                                string UserName = Usernametxt.Text;
                                string Password = PasswordOnetxt.Text;

                                //Writes to File
                                sWriter.WriteLine(UserName + "|" + Password);

                                sWriter.Close();
                                aFile.Close();

                                Usernametxt.Text = string.Empty;
                                PasswordOnetxt.Text = string.Empty;
                                PasswordTwotxt.Text = string.Empty;

                                MessageBox.Show("Welcome, " + UserName + ", to your recruitment!", "Welcome, " + UserName);

                                //Brings user to Avatar Screen
                                Hide();
                                new AvatarScreen(UserName, 0).Show();

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("User failed to add", ex.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("A good password should be at least 3 Letters and have a Number!" +
                                "\nAnd sometimes great names are not long!", "You need more Protection or a shorter Username!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Careful - Your passwords don't match!", "Passwords don't match");
                    }
                }
                else
                {
                    MessageBox.Show("You must protect your account from Seth!", "Username or Password missing!");
                }
            }
            else
            {
                MessageBox.Show("This Name is taken! No two\n gods should share the same name!", "Username already exists!");
            }
        }

        private void LoginLinklbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Brings user to LoginScreen
            Hide();
            new LoginScreen().Show();
        }

        private void cPasswordOnebtn_Click(object sender, EventArgs e)
        {
            //Shows/Hides password when clicked
            if (cPasswordOne == false)
            {
                cPasswordOne = true;
                PasswordOnetxt.UseSystemPasswordChar = false;
                //Changes Eye of Horus Image
                cPasswordOnebtn.BackgroundImage = Properties.Resources.No_Eye;
            }
            else
            {
                cPasswordOne = false;
                PasswordOnetxt.UseSystemPasswordChar = true;
                //Changes Eye of Horus Image
                cPasswordOnebtn.BackgroundImage = Properties.Resources.Eye_of_Horus;
            }
        }

        private void cPasswordTwobtn_Click(object sender, EventArgs e)
        {
            //Shows/Hides password when clicked
            if (cPasswordTwo == false)
            {
                cPasswordTwo = true;
                PasswordTwotxt.UseSystemPasswordChar = false;
                //Changes Eye of Horus Image
                cPasswordTwobtn.BackgroundImage = Properties.Resources.No_Eye;
            }
            else
            {
                cPasswordTwo = false;
                PasswordTwotxt.UseSystemPasswordChar = true;
                //Changes Eye of Horus Image
                cPasswordTwobtn.BackgroundImage = Properties.Resources.Eye_of_Horus;
            }
        }

        private void PasswordOnetxt_TextChanged(object sender, EventArgs e)
        {
            int Length = PasswordOnetxt.Text.Length;
            //Records password in variable
            PasswordOneCheck = PasswordOnetxt.Text;
            NumPresent = 0;

            //Checks for numbers 0-9
            for (int i = 0; i <= 9; i++)
            {
                if (PasswordOnetxt.Text.Contains(Convert.ToString(i)))
                {
                    NumPresent++;
                }
            }

            // Checks for number and minimum length
            if (Length >= 3 && NumPresent != 0)
            {
                PasswordOneimg.BackgroundImage = Properties.Resources.Cat_Wings;
                //Checks for identicality
                if (PasswordTwoCheck == PasswordOneCheck)
                {
                    PasswordTwoimg.BackgroundImage = Properties.Resources.Cat_Wings;
                }
            }
            else
            {
                PasswordOneimg.BackgroundImage = Properties.Resources.Cat_no_Wings;
            }
        }

        private void PasswordTwotxt_TextChanged(object sender, EventArgs e)
        {
            int Length = PasswordTwotxt.Text.Length;
            //Records Password in variable
            PasswordTwoCheck = PasswordTwotxt.Text;
            NumPresent = 0;

            //Checks for numbers 0-9
            for (int i = 0; i <= 9; i++)
            {
                if (PasswordTwotxt.Text.Contains(Convert.ToString(i)))
                {
                    NumPresent++;
                }
            }

            // Checks for number and minimum length
            if (Length >= 3 && NumPresent != 0)
            {
                //Checks for identicality
                if (PasswordTwoCheck == PasswordOneCheck)
                {
                    PasswordTwoimg.BackgroundImage = Properties.Resources.Cat_Wings;
                }
                else
                {
                    PasswordTwoimg.BackgroundImage = Properties.Resources.Cat_no_Wings;
                }
            }
            else
            {
                PasswordTwoimg.BackgroundImage = Properties.Resources.Cat_no_Wings;
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
            Application.Restart();
        }

        private void endAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void UsernameExists()
        {
            //checksif username is already taken
            if (File.Exists("users.txt"))
            {
                string Username = Usernametxt.Text;
                string[] users = File.ReadLines("users.txt").ToArray();

                for (int i = 0; i < users.Length; i++)
                {
                    string[] Details = users[i].Split('|');
                    if (Details[0] == Username) 
                    {
                        UserUsed = true;
                        break;
                    }
                    else
                    {
                        UserUsed = false;
                    }
                }
            }
        }
    }
}