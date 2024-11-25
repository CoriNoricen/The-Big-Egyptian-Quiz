using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Big_Egyptian_Quiz.Properties;

namespace The_Big_Egyptian_Quiz
{
    public partial class qTypeFour : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        private int score = 0;
        private int wrongScore = 0;

        //lists to hold options for picking
        string[] imgNames = { "opt1img", "opt2img", "opt3img", "opt4img", "opt5img", "opt6img" };
        string[] imgPick = new string[3];

        private bool clickable = true;

        public qTypeFour()
        {
            InitializeComponent();
            CenterToParent();

            //Keeps track of total questions
            TopicScreen.player.Topic1TotalScore += 3;

            //Creates random instance and list to prevent repeating questions
            List<int> ints = new List<int>();
            Random rnd = new Random();
            int j = 0;

            string[] godNames = { "Anubis", "Ma-at", "Ba-Bird", "Ammit", "Horus", "Thoth" };
            string[] pick = new string[3];

            for (int i = 0; i < 3; i++)
            {
                //Ensures quesiton has not been used before
                while (true)
                {
                    j = rnd.Next(0, 6);
                    if (!ints.Contains(j))
                    {
                        break;
                    }
                }

                //Mark the question as used
                ints.Add(j);
                pick[i] = godNames[j];
                imgPick[i] = imgNames[j];
            }
            Questionlbl.Text = "Which god is Which? Pick: " + pick[0] + ", " + pick[1] + " and " + pick[2];

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

        private void opt1img_Click(object sender, EventArgs e)
        {
            //only allows clicking when question is active
            if (clickable == true)
            {
                //calculates score or strike
                opt1img.Visible = false;
                for (int i = 0; i < 3; i++) 
                {
                    if (imgPick[i] == "opt1img")
                    {
                        //Plays correct sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
                        soundPlayer.Play();
                        score++;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        if (score == 3)
                        {
                            VisibleAgain();
                        }
                        wrongScore = (wrongScore / 3) * 3;
                    }
                    else
                    {
                        wrongScore++;
                    }
                }
                switch (wrongScore)
                {
                    
                    case 3:
                        //Plays incorrect sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 1/3";
                        break;
                    case 6:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 2/3";
                        break;
                    case 9:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat; Life3.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 3/3";
                        VisibleAgain();
                        break;
                    default:
                        wrongScore = (wrongScore / 3) * 3;
                        break;
                }
            }
        }

        private void opt2img_Click(object sender, EventArgs e)
        {
            //only allows clicking when question is active
            if (clickable == true)
            {
                //calculates score or strike
                opt2img.Visible = false;
                for (int i = 0; i < 3; i++)
                {
                    if (imgPick[i] == "opt2img")
                    {
                        //Plays correct sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
                        soundPlayer.Play();
                        score++;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        if (score == 3)
                        {
                            VisibleAgain();
                        }
                        wrongScore = (wrongScore / 3) * 3;
                    }
                    else
                    {
                        wrongScore++;
                    }
                }
                switch (wrongScore)
                {
                    case 3:
                        //Plays incorrect sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 1/3";
                        break;
                    case 6:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 2/3";
                        break;
                    case 9:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat; Life3.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 3/3";
                        VisibleAgain();
                        break;
                    default:
                        wrongScore = (wrongScore / 3) * 3;
                        break;
                }
            }
        }

        private void opt3img_Click(object sender, EventArgs e)
        {
            //only allows clicking when question is active
            if (clickable == true)
            {
                //calculates score or strike
                opt3img.Visible = false;
                for (int i = 0; i < 3; i++)
                {
                    if (imgPick[i] == "opt3img")
                    {
                        //Plays correct sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
                        soundPlayer.Play();
                        score++;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        if (score == 3)
                        {
                            VisibleAgain();
                        }
                        wrongScore = (wrongScore / 3) * 3;
                    }
                    else
                    {
                        wrongScore++;
                    }
                }
                switch (wrongScore)
                {
                    case 3:
                        //Plays incorrect sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 1/3";
                        break;
                    case 6:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 2/3";
                        break;
                    case 9:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat; Life3.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 3/3";
                        VisibleAgain();
                        break;
                    default:
                        wrongScore = (wrongScore / 3) * 3;
                        break;
                }
            }
        }

        private void opt4img_Click(object sender, EventArgs e)
        {
            //only allows clicking when question is active
            if (clickable == true)
            {
                //calculates score or strike
                opt4img.Visible = false;
                for (int i = 0; i < 3; i++)
                {
                    if (imgPick[i] == "opt4img")
                    {
                        //Plays correct sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
                        soundPlayer.Play();
                        score++;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        if (score == 3)
                        {
                            VisibleAgain();
                        }
                        wrongScore = (wrongScore / 3) * 3;
                    }
                    else
                    {
                        wrongScore++;
                    }
                }
                switch (wrongScore)
                {
                    case 3:
                        //Plays incorrect sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 1/3";
                        break;
                    case 6:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 2/3";
                        break;
                    case 9:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat; Life3.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 3/3";
                        VisibleAgain();
                        break;
                    default:
                        wrongScore = (wrongScore / 3) * 3;
                        break;
                }
            }
        }

        private void opt5img_Click(object sender, EventArgs e)
        {
            //only allows clicking when question is active
            if (clickable == true)
            {
                //calculates score or strike
                opt5img.Visible = false;
                for (int i = 0; i < 3; i++)
                {
                    if (imgPick[i] == "opt5img")
                    {
                        //Plays correct sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
                        soundPlayer.Play();
                        score++;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        if (score == 3)
                        {
                            VisibleAgain();
                        }
                        wrongScore = (wrongScore / 3) * 3;
                    }
                    else
                    {
                        wrongScore++;
                    }
                }
                switch (wrongScore)
                {
                    case 3:
                        //Plays incorrect sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 1/3";
                        break;
                    case 6:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 2/3";
                        break;
                    case 9:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat; Life3.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 3/3";
                        VisibleAgain();
                        break;
                    default:
                        wrongScore = (wrongScore / 3) * 3;
                        break;
                }
            }
        }

        private void opt6img_Click(object sender, EventArgs e)
        {
            //only allows clicking when question is activev
            if (clickable == true)
            {
                //calculates score or strike
                opt6img.Visible = false;
                for (int i = 0; i < 3; i++)
                {
                    if (imgPick[i] == "opt6img")
                    {
                        //Plays correct sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
                        soundPlayer.Play();
                        score++;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        if (score == 3)
                        {
                            VisibleAgain();
                        }
                        wrongScore = (wrongScore / 3) * 3;
                    }
                    else
                    {
                        wrongScore++;
                    }
                }
                switch (wrongScore)
                {
                    case 3:
                        //Plays incorrect sound
                        SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 1/3";
                        break;
                    case 6:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 2/3";
                        break;
                    case 9:
                        //Plays incorrect sound
                        soundPlayer = new SoundPlayer(Resources.Wrong);
                        soundPlayer.Play();
                        Life1.BackgroundImage = (Image)Resources.mummy_cat; Life2.BackgroundImage = (Image)Resources.mummy_cat; Life3.BackgroundImage = (Image)Resources.mummy_cat;
                        score--;
                        Scorelbl.Text = "Score: " + score as string + "/3";
                        Strikelbl.Text = "Strike: 3/3";
                        VisibleAgain();
                        break;
                    default:
                        wrongScore = (wrongScore / 3) * 3;
                        break;
                }
            }
        }

        private void Forwardbtn_Click(object sender, EventArgs e)
        {
            //randomises next question type
            TopicScreen.player.IncreaseScore(score);
            int i = Question.Randomiser(TopicScreen.qType);
            if (i == 0 || i == 4 || i == 7 || i == 10)
            {
                Hide();
                new qTypeOne().Show();
            }
            else if (i == 1 || i == 5 || i == 8 || i == 11)
            {
                Hide();
                new qTypeTwo().Show();
            }
            else if (i == 2 || i == 6 || i == 9 || i == 12)
            {
                Hide();
                new qTypeThree().Show();
            }
            else if (i == 4321)
            {
                Hide();
                new TopicScreen(TopicScreen.player.Username, TopicScreen.player.Score, TopicScreen.player.FirstTime).Show();
            }
            else if (i == 1234)
            {
                Hide();
                new EndScreen(TopicScreen.player.Topic1Score, TopicScreen.player.Topic2Score, TopicScreen.player.Topic3Score, TopicScreen.player.Topic4Score).Show();
            }
        }

        private void VisibleAgain()
        { 
            //shows names of gods and stops everything from being enabled
            clickable = false;
            Name1lbl.Visible = true; opt1img.Visible = true;
            Name2lbl.Visible = true; opt2img.Visible = true;
            Name3lbl.Visible = true; opt3img.Visible = true;
            Name4lbl.Visible = true; opt4img.Visible = true;
            Name5lbl.Visible = true; opt5img.Visible = true;
            Name6lbl.Visible = true; opt6img.Visible = true;

            Forwardbtn.Visible = true;
            Forwardlbl.Visible = true;
            
            //shows message based on if they were correct of not
            if (score == 3)
            {
                MessageBox.Show("Congrats! You got them all!", "Ra would be proud!");
            }
            else
            {
                MessageBox.Show("Close! Here are the names of your co-workers!", "Better luck next time!");
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
    }
}
