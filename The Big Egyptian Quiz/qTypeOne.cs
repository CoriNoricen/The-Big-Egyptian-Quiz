using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Big_Egyptian_Quiz;
using The_Big_Egyptian_Quiz.Properties;

namespace The_Big_Egyptian_Quiz
{
    public partial class qTypeOne : Form
    {
        //creates score
        private int Invisiscore = 0;
        private int score = 0;
        private int strike = 0;

        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        public qTypeOne()
        {
            InitializeComponent();
            CenterToParent();
            AllowDropping();

            //Runs topic Questions
            if (Question.Topic1 == true)
            {
                BackgroundImage = (Image)Resources.BG1;
                MythologyQuestionBank();
            }
            if (Question.Topic2 == true)
            {
                BackgroundImage = (Image)Resources.BG2;
                MummificationQuestionBank();
            }
            if (Question.Topic3 == true)
            {
                BackgroundImage = (Image)Resources.BG3;
                HistoryQuestionBank();
            }
            if (Question.Topic4 == true)
            {
                BackgroundImage = (Image)Resources.BG7;
                CultureQuestionBank();
            }

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

        //Creates List for Questions
        List<string> questions = new List<string>();
        private void MythologyQuestionBank()
        {
            List<string> list = new List<string> { "Oh no! The gods and I have", "lost our belongings! Can you", "return them to us?", "Horus", "Osiris",
                "Khepri", "Khnum", "Amulet", "Cartouche", "Djed", "Wadjet Eye", "Ankh", "Scarab Beetle", "Canopic Jar", "Eye" };
            //Adds quesitons to list
            for (int i = 0; i < list.Count; i++)
            {
                questions.Add(list[i]);
            }
            

            //Sets images to required boxes
            ImageOneimg.BackgroundImage = (Image)Resources.Amulet;
            ImageTwoimg.BackgroundImage = (Image)Resources.Cartouche;
            ImageTwoimg.BackColor = Color.White;
            ImageThreeimg.BackgroundImage = (Image)Resources.Djed;
            ImageThreeimg.BackColor = Color.White;
            ImageFourimg.BackgroundImage = (Image)Resources.Eye_of_Horus;
            ImageFourimg.BackColor = Color.White;
            ImageFiveimg.BackgroundImage = (Image)Resources.Ankh;
            ImageFiveimg.BackColor = Color.White;
            ImageSiximg.BackgroundImage = (Image)Resources.Beetle;
            ImageSevenimg.BackgroundImage = (Image)Resources.Canopic_Jars_1;
            ImageEightimg.BackgroundImage = (Image)Resources.Eye_of_Ra;
            ImageEightimg.BackColor = Color.White;

            ImageNineimg.BackgroundImage = (Image)Resources.Horus;
            ImageTenimg.BackgroundImage = (Image)Resources.Osiris;
            ImageElevenimg.BackgroundImage = (Image)Resources.Khepri;
            ImageElevenimg.BackColor = Color.White;
            ImageTwelveimg.BackgroundImage = (Image)Resources.Khnum;

            NextQuestion();
        }

        private void MummificationQuestionBank()
        {
            List<string> list = new List<string> { "Time to sort the mummy's remains!", "To be a god one must know how it's", "all sorted. So what goes where?", "Qebehsenuef", "Imsety",
                "Hapy", "Duamutef", "Liver", "Heart", "Intestines", "Lungs", "Brain", "", "", "Stomach" };
            //Adds quesitons to list
            for (int i = 0; i < list.Count; i++)
            {
                questions.Add(list[i]);
            }
            

            //Sets images to required boxes
            ImageOneimg.BackgroundImage = (Image)Resources.Liver;
            ImageTwoimg.BackgroundImage = (Image)Resources.Heart;
            ImageThreeimg.BackgroundImage = (Image)Resources.Intestines;
            ImageFourimg.BackgroundImage = (Image)Resources.Lungs;
            ImageFiveimg.BackgroundImage = (Image)Resources.Brain;
            ImageSiximg.Visible = false;
            ImageSixlbl.Visible = false;
            Invisiscore++;
            ImageSevenimg.Visible = false;
            ImageSevenlbl.Visible = false;
            Invisiscore++;
            ImageEightimg.BackgroundImage = (Image)Resources.Stomach;

            ImageNineimg.BackgroundImage = (Image)Resources.Canopic_Jars_1;
            ImageTenimg.BackgroundImage = (Image)Resources.Canopic_Jars_2;
            ImageElevenimg.BackgroundImage = (Image)Resources.Canopic_Jars_3;
            ImageTwelveimg.BackgroundImage = (Image)Resources.Canopic_Jars_4;

            NextQuestion();
        }

        private void HistoryQuestionBank()
        {
            //Items in tomb - match to room
            List<string> list = new List<string> { "When Carter discovered the tomb,", "he found many things. But", "where did he find them?", "Burial Chamber", "Annex",
                "Antechamber", "Treasury", "Canopic Jars", "Underwear", "Sarcophagus", "Scarf", "Watch", "Gold Dagger", "Golden Sandals", "Ur (game)" };
            //Adds quesitons to list
            for (int i = 0; i < list.Count; i++)
            {
                questions.Add(list[i]);
            }


            //Sets images to required boxes
            ImageOneimg.BackgroundImage = (Image)Resources.Canopic_Jars_3;
            ImageTwoimg.BackgroundImage = (Image)Resources.Underwear;
            ImageThreeimg.BackgroundImage = (Image)Resources.Sarcophagus;
            ImageFourimg.BackgroundImage = (Image)Resources.Scarf;
            ImageFiveimg.BackgroundImage = (Image)Resources.Watch;
            ImageSiximg.BackgroundImage = (Image)Resources.Dagger;
            ImageSevenimg.BackgroundImage = (Image)Resources.Sandals;
            ImageEightimg.BackgroundImage = (Image)Resources.Ur;

            ImageNineimg.BackgroundImage = (Image)Resources.mapBurial;
            ImageTenimg.BackgroundImage = (Image)Resources.mapAnnex;
            ImageElevenimg.BackgroundImage = (Image)Resources.mapAntechamber;
            ImageTwelveimg.BackgroundImage = (Image)Resources.mapTreasury;

            NextQuestion();
        }

        private void CultureQuestionBank()
        {
            List<string> list = new List<string> { "The Egyptians were a smart bunch,", "but what did they have in their time", "and what did they not?", "", "",
                "Egyptian", "", "Make-Up", "Chess", "Quills", "Rock Pillows", "Razor", "", "", "Wig" };
            //Adds quesitons to list
            for (int i = 0; i < list.Count; i++)
            {
                questions.Add(list[i]);
            }


            //Sets images to required boxes
            ImageOneimg.BackgroundImage = (Image)Resources.Rock;
            ImageTwoimg.BackgroundImage = (Image)Resources.chess;
            ImageThreeimg.BackgroundImage = (Image)Resources.Quill_pen_transparency;
            ImageFourimg.BackgroundImage = (Image)Resources.Rock_Pillow;
            ImageFiveimg.BackgroundImage = (Image)Resources.Razor;
            ImageSiximg.Visible = false;
            ImageSixlbl.Visible = false;
            Invisiscore++;
            ImageSevenimg.Visible = false;
            ImageSevenlbl.Visible = false;
            Invisiscore++;
            ImageEightimg.BackgroundImage = (Image)Resources.Wig;

            ImageNineimg.Visible = false;
            ImageTenimg.Visible = false;
            ImageElevenimg.BackgroundImage = (Image)Sprites.ResourceManager.GetObject("_" + TopicScreen.player.Avatar);
            ImageTwelveimg.Visible = false;

            NextQuestion();
        }
        

        //Creates random instance and list to prevent repeating questions
        List<int> ints = new List<int>();
        Random rnd = new Random();

        private void NextQuestion()
        {
            //adds everything to screen
            QuestionOnelbl.Text = questions[0];
            QuestionTwolbl.Text = questions[1];
            QuestionThreelbl.Text = questions[2];

            ImageNinelbl.Text = questions[3];
            ImageTenlbl.Text = questions[4];
            ImageElevenlbl.Text = questions[5];
            ImageTwelvelbl.Text = questions[6];

            ImageOnelbl.Text = questions[7];
            ImageTwolbl.Text = questions[8];
            ImageThreelbl.Text = questions[9];
            ImageFourlbl.Text = questions[10];
            ImageFivelbl.Text = questions[11];
            ImageSixlbl.Text = questions[12];
            ImageSevenlbl.Text = questions[13];
            ImageEightlbl.Text = questions[14];

        }

        private void ShowNextQuestion()
        {
            Hide();
            TopicScreen.player.IncreaseScore(score);
            //randomises next question type
            int i = Question.Randomiser(TopicScreen.qType);
            if (i == 1 || i == 5 || i == 8 || i == 11)
            {
                new qTypeTwo().Show();
            }
            else if (i == 2 || i == 6 || i == 9 || i == 12)
            {
                new qTypeThree().Show();
            }
            else if (i == 3)
            {
                new qTypeFour().Show();
            }
            else if (i == 4321)
            {
                new TopicScreen(TopicScreen.player.Username, TopicScreen.player.Score, TopicScreen.player.FirstTime).Show();
            }
            else if (i == 1234)
            {
                Hide();
                new EndScreen(TopicScreen.player.Topic1Score, TopicScreen.player.Topic2Score, TopicScreen.player.Topic3Score, TopicScreen.player.Topic4Score).Show();
            }
        }

        //allows drag and drop mechanics
        private void AllowDragDropCopy(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void LabelGrabbed(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Label selectedLabel = (System.Windows.Forms.Label)sender;
            selectedLabel.DoDragDrop(selectedLabel.Text, DragDropEffects.Copy);
        }

        private void AllowDropping()
        {
            ImageNineimg.AllowDrop = true;
            ImageTenimg.AllowDrop = true;
            ImageElevenimg.AllowDrop = true;
            ImageTwelveimg.AllowDrop = true;
            Trashimg.AllowDrop = true;
            Raimg.AllowDrop = true;
        }

        private void OneDragDrop(object sender, DragEventArgs e)
        {
            //Qebehsenuef holds intestines
            //Horus holds Wadjet Eye
            //Dagger in Burial Chamber
            //Sarcophagus in Burial Chamber
            string result = (string)e.Data.GetData(DataFormats.Text);
            if (result == "Intestines" || result == "Sarcophaus")
            {
                UpdateScoreAndLabel();
                ImageThreeimg.Visible = false;
                ImageThreelbl.Visible = false;
            }
            else if (result == "Wadjet Eye")
            {
                UpdateScoreAndLabel();
                ImageFourimg.Visible = false;
                ImageFourlbl.Visible = false;
            }
            else if (result == "Gold Dagger")
            {
                UpdateScoreAndLabel();
                ImageSevenimg.Visible = false;
                ImageSevenlbl.Visible = false;
            }
            else
            {
                score--;
                UpdateStrikeandLabel();
            }
        }

        private void TwoDragDrop(object sender, DragEventArgs e)
        { 
            //Imsety holds liver
            //Osiris holds the Djed
            //Underwear found in Annex
            //Scarf found in Annex
            //Golden Sandals found in Annex
            string result = (string)e.Data.GetData(DataFormats.Text);
            if (result == "Liver")
            {
                UpdateScoreAndLabel();
                ImageOneimg.Visible = false;
                ImageOnelbl.Visible = false;
            }
            else if (result == "Djed")
            {
                UpdateScoreAndLabel();
                ImageThreeimg.Visible = false;
                ImageThreelbl.Visible = false;
            }
            else if (result == "Underwear")
            {
                UpdateScoreAndLabel();
                ImageTwoimg.Visible = false;
                ImageTwolbl.Visible = false;
            }
            else if (result == "Scarf")
            {
                UpdateScoreAndLabel();
                ImageFourimg.Visible = false;
                ImageFourlbl.Visible = false;
            }
            else if (result == "Golden Sandals")
            {
                UpdateScoreAndLabel();
                ImageSevenimg.Visible = false;
                ImageSevenlbl.Visible = false;
            }
            else
            {
                score--;
                UpdateStrikeandLabel();
            }
        }

        private void ThreeDragDrop(object sender, DragEventArgs e)
        {
            //Hapy holds Lungs
            //Khepri holds Scarab Beetle
            //Egyptians use make-up, rock pillows, razors and wigs
            string result = (string)e.Data.GetData(DataFormats.Text);
            if (result == "Lungs" || result == "Rock Pillows")
            {
                UpdateScoreAndLabel();
                ImageFourimg.Visible = false;
                ImageFourlbl.Visible = false;
            }
            else if (result == "Scarab Beetle")
            {
                UpdateScoreAndLabel();
                ImageSiximg.Visible = false;
                ImageSixlbl.Visible = false;
            }
            else if (result == "Make-Up")
            {
                UpdateScoreAndLabel();
                ImageOneimg.Visible = false;
                ImageOnelbl.Visible = false;
            }
            else if (result == "Razor")
            {
                UpdateScoreAndLabel();
                ImageFiveimg.Visible = false;
                ImageFivelbl.Visible = false;
            }
            else if (result == "Wig")
            {
                UpdateScoreAndLabel();
                ImageEightimg.Visible = false;
                ImageEightlbl.Visible = false;
            }
            else
            {
                if (Question.Topic4 != true)
                {
                    score--;
                }
                else
                {
                    score -= 2;
                }
                UpdateStrikeandLabel();
            }
        }

        private void FourDragDrop(object sender, DragEventArgs e)
        {
            //Duamutef holds Stomach
            //Khnum holds Amulet
            //Canopic Jars found in Treasury
            string result = (string)e.Data.GetData(DataFormats.Text);
            if (result == "Stomach")
            {
                UpdateScoreAndLabel();
                ImageEightimg.Visible = false;
                ImageEightlbl.Visible = false;
            }
            else if (result == "Amulet" || result == "Canopic Jars")
            {
                UpdateScoreAndLabel();
                ImageOneimg.Visible = false;
                ImageOnelbl.Visible = false;
            }
            else
            {
                score--;
                UpdateStrikeandLabel();
            }
        }

        private void FiveDragDrop(object sender, DragEventArgs e)
        {
            //trash
            string result = (string)e.Data.GetData(DataFormats.Text);
            if (result == "Heart" || result == "Cartouche" || result == "Chess")
            {
                UpdateScoreAndLabel();
                ImageTwoimg.Visible = false;
                ImageTwolbl.Visible = false;
            }
            else if (result == "Brain" || result == "Ankh" || result == "Watch")
            {
                UpdateScoreAndLabel();
                ImageFiveimg.Visible = false;
                ImageFivelbl.Visible = false;
            }
            else if (result == "Canopic Jar")
            {
                UpdateScoreAndLabel();
                ImageSevenimg.Visible = false;
                ImageSevenlbl.Visible = false;
            }
            else if (result == "Quills")
            {
                UpdateScoreAndLabel();
                ImageThreeimg.Visible = false;
                ImageThreelbl.Visible = false;
            }
            else if (result == "Ur (game)")
            {
                UpdateScoreAndLabel();
                ImageEightimg.Visible = false;
                ImageEightlbl.Visible = false;
            }
            else
            {
                if (Question.Topic4 != true)
                {
                    score--;
                }
                else
                {
                    score -= 2;
                }
                UpdateStrikeandLabel();
            }
        }

        private void SixDragDrop(object sender, DragEventArgs e)
        {
            //Ra takes the eye and the ankh
            string result = (string)e.Data.GetData(DataFormats.Text);
            if (result == "Eye")
            {
                UpdateScoreAndLabel();
                QuestionOnelbl.Text = "Thank you " + TopicScreen.player.Username + ".";
                QuestionTwolbl.Text = "";
                QuestionThreelbl.Text = "";

                ImageEightimg.Visible = false;
                ImageEightlbl.Visible = false;
            }
            else if (result == "Ankh")
            {
                UpdateScoreAndLabel();
                QuestionOnelbl.Text = "Thank you " + TopicScreen.player.Username + ".";
                QuestionTwolbl.Text = "";
                QuestionThreelbl.Text = "";

                ImageFiveimg.Visible = false;
                ImageFivelbl.Visible = false;
            }
            else
            {
                score--;
                UpdateStrikeandLabel();
            }
        }

        private void UpdateScoreAndLabel()
        {
            //increases score and invisiscore
            score++;
            Invisiscore++;
            Scorelbl.Text = "SCORE: " + score;

            //Plays correct sound
            SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
            soundPlayer.Play();

            if (Invisiscore == 8 )
            {
                ShowNextQuestion();
            }
        }

        private void UpdateStrikeandLabel()
        {
            //increases strike count
            strike++;
            Strikelbl.Text = "STRIKE: " + strike + "/5";
            Scorelbl.Text = "SCORE: " + score;

            //Plays incorrect sound
            SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
            soundPlayer.Play();

            if (strike == 5)
            {
                ShowNextQuestion();
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

        private void qTypeOne_Load(object sender, EventArgs e)
        {

        }
    }               
}
                            