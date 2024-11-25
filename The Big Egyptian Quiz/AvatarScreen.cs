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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace The_Big_Egyptian_Quiz
{
    public partial class AvatarScreen : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        //Creates Player
        public static Player Player;
        int score;

        //Switches Avatar Parts
        string AvatarNo = "111";
        int HeadCount = 1;
        int BodyCount = 1;
        int FeetCount = 1;

        //Creates Back button Confirmation
        int BackTwice = 0;

        public AvatarScreen(string username, int score)
        {
            InitializeComponent();
            CenterToParent();

            //Creates new Player
            Player = new Player(username, score);
            Player.Username = username;

            //Ra calls player by name
            RaSpeechOnetxt.Text = "Welcome " + Player.Username + ",";

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

        private void Backbtn_Click(object sender, EventArgs e)
        {
            if (BackTwice == 0)
            {
                RaSpeechOnetxt.Text = "Careful " + Player.Username + ",";
                RaSpeechTwotxt.Text = "Are you sure about that?";
                RaSpeechThreetxt.Text = "Your look will be saved.";
                RaSpeechFourtxt.Text = "Hit it again to return.";
                BackTwice++;
            }
            else
            {
                //Saves the Avatar to Player
                AvatarNo = Convert.ToString(HeadCount) + Convert.ToString(BodyCount) + Convert.ToString(FeetCount);
                Player.Avatar = AvatarNo;

                Player.ResetPlayer();
                Hide();
                new RegisterScreen().Show();
            }
        }

        private void HeadLeftbtn_Click(object sender, EventArgs e)
        {
            //Stops it from picking an image that doesn't exist
            if (HeadCount != 1)
            {
                HeadCount--;
                //Uses Resource Sprites
                HeadPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_2_00" + HeadCount as string);
            }
        }

        private void HeadRightbtn_Click(object sender, EventArgs e)
        {
            //Stops it from picking an image that doesn't exist
            if (HeadCount != 4)
            {
                HeadCount++;
                //Uses Resource 'Sprites'
                HeadPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_2_00" + HeadCount as string);
            }
        }

        private void BodyLeftbtn_Click(object sender, EventArgs e)
        {
            //Stops it from picking an image that doesn't exist
            if (BodyCount != 1)
            {
                BodyCount--;
                //Uses Resource 'Sprites'
                BodyPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_1_00" + BodyCount as string);
            }
        }

        private void BodyRightbtn_Click(object sender, EventArgs e)
        {
            //Stops it from picking an image that doesn't exist
            if (BodyCount != 4)
            {
                BodyCount++;
                //Uses Resource 'Sprites'
                BodyPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_1_00" + BodyCount as string);
            }
        }

        private void FeetLeftbtn_Click(object sender, EventArgs e)
        {
            //Stops it from picking an image that doesn't exist
            if (FeetCount != 1)
            {
                FeetCount--;
                //Uses Resource 'Sprites'
                FeetPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_0_00" + FeetCount as string);
            }
        }

        private void FeetRightbtn_Click(object sender, EventArgs e)
        {
            //Stops it from picking an image that doesn't exist
            if (FeetCount != 4)
            {
                FeetCount++;
                //Uses Resource 'Sprites'
                FeetPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_0_00" + FeetCount as string);
            }
        }

        private void BEGINbtn_Click(object sender, EventArgs e)
        {
            //Saves the Avatar to Player
            AvatarNo = Convert.ToString(HeadCount) + Convert.ToString(BodyCount) + Convert.ToString(FeetCount);
            try
            {
                //Create a file path to the folder to hold the User details
                string filePath = @"avatars.txt";
                FileStream aFile;
                StreamWriter sWriter;

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
                string Avatar = AvatarNo;

                //Writes to File
                sWriter.WriteLine(Player.Username + '|' + Avatar);

                sWriter.Close();
                aFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("User failed to add", ex.ToString());
            }
            Hide();
            new TopicScreen(Player.Username, score, true).Show();
        }

        private void Randombtn_Click(object sender, EventArgs e)
        {
            //Creates random integer and assigns it to Counts
            Random random = new Random();
            int randHead = random.Next(1, 4);
            HeadCount = randHead;
            int randBody = random.Next(1, 4);
            BodyCount = randBody;
            int randFeet = random.Next(1, 4);
            FeetCount = randFeet;

            //Uses Resource 'Sprites'
            HeadPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_2_00" + randHead as string);
            BodyPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_1_00" + randBody as string);
            FeetPickimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_0_00" + randFeet as string);
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

        private void HeadPickimg_Click(object sender, EventArgs e)
        {

        }

        private void RaSpeechOnetxt_Click(object sender, EventArgs e)
        {

        }
    }
}
