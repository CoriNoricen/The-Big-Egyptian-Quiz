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
    public partial class qTypeTwo : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        private int score = 0;
        private string CurrentAnswer;
        private int cQuestion = 0;
        private int cQuest = 0;

        public qTypeTwo()
        {
            InitializeComponent();
            CenterToParent();

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

            //Creates question list instance
        private readonly List<Question> questions = new List<Question>();

        private void MythologyQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("Question:",
                new[] { "Bastet is the god of protection.", "She has the head of which animal?" }, 0, "Cat"));
            questions.Add(new Question("Question:",
                new[] { "Egyptians believed that their what", "was weighed against a feather?" }, 0, "Heart"));
            questions.Add(new Question("Question:",
                new[] { "Osiris, the god of the underworld,", "was married to which god?" }, 0, "Isis"));
            questions.Add(new Question("Question:",
                new[] { "Which Egyptian god was regarded", "as the most important?" }, 0, "Ra"));

            //Keeps track of total questions
            TopicScreen.player.Topic1TotalScore += questions.Count;
            NextQuestion();
        }

        private void MummificationQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("Question:",
                new[] { "Mummification involved drying the", "body. What did they use?" }, 0, "Natron Salt"));
            questions.Add(new Question("Question:",
                new[] { "The body was sealed after ", "mummification. What did they use?" }, 0, "Resin"));
            questions.Add(new Question("Question:",
                new[] { "When wrapping the body, what", "was added between the bandages?" }, 0, "Amulets"));
            questions.Add(new Question("Question:",
                new[] { "The sarcophagus was made", "from which material?" }, 0, "Wood"));

            //Keeps track of total questions
            TopicScreen.player.Topic2TotalScore += questions.Count;
            NextQuestion();
        }

        private void HistoryQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("Question:",
                new[] { "Tutankhamun's tomb was a huge", "discovery! In what year was it found?" }, 0, "1922"));
            questions.Add(new Question("Question:",
                new[] { "How many steps were uncovered", "leading down to the tomb?" }, 3, "12"));
            questions.Add(new Question("Question:",
                new[] { "Lord Carnarvon was told about the tomb.", "How long was it before he arrived?" }, 3, "2 Weeks"));
            questions.Add(new Question("Question:",
                new[] { "When Carter saw the treasure,", "What two words did he say?" }, 3, "Wonderful Things"));
            questions.Add(new Question("Question:",
                new[] { "How many years did the tomb lay", "untouched, before Carter found it?" }, 3, "3000"));

            //Keeps track of total questions
            TopicScreen.player.Topic3TotalScore += questions.Count;
            NextQuestion();
        }

        private void CultureQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("Question:",
                new[] { "What is the capital of Egypt?", "" }, 0, "Cairo"));
            questions.Add(new Question("Question:",
                new[] { "Tutankhamun loved games.", "What game was found in his tomb?" }, 0, "Senet"));
            questions.Add(new Question("Question:",
                new[] { "Paper was very common in Egypt,", "but what was it made of?" }, 0, "Papyrus"));
            questions.Add(new Question("Question:",
                new[] { "How old was Tutankhamun", "when he died?" }, 0, "18"));
            questions.Add(new Question("Question:",
                new[] { "The Nile splits into smaller rivers", "and flows into the sea. This is a..." }, 0, "Delta"));


            //Keeps track of total questions
            TopicScreen.player.Topic4TotalScore += questions.Count;
            NextQuestion();
        }

        private void Forwardbtn_Click(object sender, EventArgs e)
        {
            if (CurrentAnswer != string.Empty)
            {
                cQuestion++;

                //Checks score and resets it
                CheckAnswer(CurrentAnswer);
                CurrentAnswer = string.Empty;

                //Checks if it needs to go to Next Area
                if (cQuestion == questions.Count)
                {
                    TopicScreen.player.IncreaseScore(score);
                    int i = Question.Randomiser(TopicScreen.qType);
                    if (i == 0 || i == 4 || i == 7 || i == 10)
                    {
                        Hide();
                        new qTypeOne().Show();
                    }
                    else if (i == 2 || i == 6 || i == 9 || i == 12)
                    {
                        Hide();
                        new qTypeThree().Show();
                    }
                    else if (i == 3)
                    {
                        Hide();
                        new qTypeFour().Show();
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
                else
                {
                    Answertxt.Text = string.Empty;
                    NextQuestion();
                }
            }
        }

        //Creates random instance and list to prevent repeating questions
        List<int> ints = new List<int>();
        Random rnd = new Random();

        private void NextQuestion()
        {
            //Ensures quesiton has not been used before
            while (true)
            {
                cQuest = rnd.Next(questions.Count);
                if (!ints.Contains(cQuest))
                {
                    break;
                }
            }

            // Mark the question as used
            ints.Add(cQuest);

            //get Question Text
            string[] QuestionText = questions[cQuest].GetPossibleAnswers();

            //Shows questions to user
            Questionlbl.Text = questions[cQuest].GetQuestionText();
            SetupOnelbl.Text = QuestionText[0];
            SetupTwolbl.Text = QuestionText[1];
            Forwardbtn.Visible = false;
        }


        private void CheckAnswer(string answer)
        {
            if (answer.ToLower() == questions[cQuest].GetAnswerText().ToLower())
            {
                //Plays correct sound
                SoundPlayer soundPlayer = new SoundPlayer(Resources.Right);
                soundPlayer.Play();
                MessageBox.Show("Well Done!", "Correct!");
                score++;
            }
            else
            {
                //Plays incorrect sound
                SoundPlayer soundPlayer = new SoundPlayer(Resources.Wrong);
                soundPlayer.Play();
                MessageBox.Show("Close, but not quite right!\nThe right answer was " + questions[cQuest].GetAnswerText() + ".", "Better luck next time!");
            }
        }

        private void Answertxt_TextChanged(object sender, EventArgs e)
        {
            CurrentAnswer = Answertxt.Text;
            if (CurrentAnswer != string.Empty)
            {
                Forwardbtn.Visible = true;
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
