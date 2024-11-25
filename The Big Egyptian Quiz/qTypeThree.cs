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
    public partial class qTypeThree : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        private int score = 0;
        private int CurrentAnswer = 0;
        private int cQuestion = 0;
        private int cQuest = 0;

        public qTypeThree()
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
        List<Question> questions = new List<Question>();

        private void MythologyQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("Anubis was...",
                new[] { "the guide to the underworld", "god of treasures", "teacher of building tombs", "god of cats and dogs" }, 0, ""));
            questions.Add(new Question("Who was god of the moon?",
                new[] { "Ra", "Bastet", "Khonsu", "Anubis" }, 2, ""));
            questions.Add(new Question("Which of these is NOT true?",
                new[] { "Amun - god of the air", "Set - god of stars", "Ptah - god of craftsmen", "Sekhmet - goddess of war" }, 1, ""));
            questions.Add(new Question("The sky and earth gods were...",
                new[] { "Get and Nub", "Gut and Neb", "Nut and Geb", "Net and Gub" }, 2, ""));

            //Keeps track of total questions
            TopicScreen.player.Topic1TotalScore += questions.Count;
            NextQuestion();
        }

        private void MummificationQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("How long did the mummification" + Environment.NewLine + "process take?",
                new[] { "40 days", "50 days", "60 days", "70 days" }, 3, ""));
            questions.Add(new Question("Which organs were left inside the body?",
                new[] { "Heart and Lungs", "Heart and Kidneys", "Lungs and Instestines", "Kidneys and Stomach" }, 1, ""));
            questions.Add(new Question("What room, in the tomb, was the" + Environment.NewLine + "sarcophagus left in?",
                new[] { "Burial Chamber", "Annex", "Antechamber", "Treasury" }, 0, ""));
            questions.Add(new Question("Where did the mummification process" + Environment.NewLine + "take place?",
                new[] { "The Palace", "A Tent", "In the Tomb", "In the Desert" }, 1, ""));

            //Keeps track of total questions
            TopicScreen.player.Topic2TotalScore += questions.Count;
            NextQuestion();
        }

        private void HistoryQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("Why was Tutankhamun buried " + Environment.NewLine + "underground?",
                new[] { "To keep him cool", "It was his dying wish", "To hide the smell", "To avoid graverobbing" }, 3, ""));
            questions.Add(new Question("What job did the boy who" + Environment.NewLine + "discovered the steps do?",
                new[] { "Digger", "He had no Job", "Water Carrier", "Camel Carer" }, 2, ""));
            questions.Add(new Question("How did they know the tomb was" + Environment.NewLine + "unopened?",
                new[] { "Closed sign on the door", "The royal seal", "It was buried", "Picture of a Scarab Beetle" }, 1, ""));
            questions.Add(new Question("What was Carnarvon's daughter called?",
                new[] { "Evelyn", "Emma", "Emily", "Sophie" }, 0, ""));
            questions.Add(new Question("Who told the Egyptians about Carter " + Environment.NewLine + "sneaking into the tomb?",
                new[] { "An Egyptian", "Lady Evelyn", "Lord Carnarvon", "The Boy" }, 1, ""));

            //Keeps track of total questions
            TopicScreen.player.Topic3TotalScore += questions.Count;
            NextQuestion();
        }

        private void CultureQuestionBank()
        {
            //Adds quesitons to list
            questions.Add(new Question("People carved their name into stone." + Environment.NewLine + "What was this called?",
                new[] { "Cartouche", "Amulet", "Natron", "karnak" }, 0, ""));
            questions.Add(new Question("Why was the Eye of Horus put" + Environment.NewLine + "on the sarcophagus?",
                new[] { "So they could see the afterlife", "It looked nice", "So the pharaoh could look out", "So Horus would watch over them" }, 2, ""));
            questions.Add(new Question("The tallest pyramid was...",
                new[] { "The Great Pyramid of Giza", "The Pyramid of khafre", "The Pyramid of Djoser", "The Step Pyramid" }, 0, ""));
            questions.Add(new Question("How was the sphynx built?",
                new[] { "Built out of stones", "They used a kit", "It was a gift from Ra", "It wasn't built, it was carved" }, 3, ""));

            //Keeps track of total questions
            TopicScreen.player.Topic4TotalScore += questions.Count;
            NextQuestion();
        }

        private void Forwardbtn_Click(object sender, EventArgs e)
        {
            if (CurrentAnswer != -1)
            {
                cQuestion++;

                //Checks score and resets it
                CheckAnswer(CurrentAnswer);
                CurrentAnswer = -1;

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
                    else if (i == 1 || i == 5 || i == 8 || i == 11)
                    {
                        Hide();
                        new qTypeTwo().Show();
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
                    Abtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Bbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1;
                    Cbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Dbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1;
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

            //get answers
            string[] answers = questions[cQuest].GetPossibleAnswers();

            //Shows questions and answers to user
            Questionlbl.Text = questions[cQuest].GetQuestionText();
            Abtn.Text = answers[0];
            Bbtn.Text = answers[1];
            Cbtn.Text = answers[2];
            Dbtn.Text = answers[3];
            Forwardbtn.Visible = false;
        }


        private void CheckAnswer(int answer)
        {
            if (answer == questions[cQuest].GetAnswerPosition())
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
                MessageBox.Show("Close, but not quite right!\nThe right answer was " + questions[cQuest].GetPossibleAnswers()[questions[cQuest].GetAnswerPosition()] + "." ,
                    "Better luck next time!");
            }
        }

        private void Abtn_Click(object sender, EventArgs e)
        {
            //Shows which answer has been selected
            Bbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Cbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Dbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1;
            Abtn.BackgroundImage = (Image)Resources.Wings_Woman_1;
            Forwardbtn.Visible = true;
            CurrentAnswer = 0;
        }

        private void Bbtn_Click(object sender, EventArgs e)
        {
            //Shows which answer has been selected
            Abtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Cbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Dbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1;
            Bbtn.BackgroundImage = (Image)Resources.Wings_Woman_1;
            Forwardbtn.Visible = true;
            CurrentAnswer = 1;

        }

        private void Cbtn_Click(object sender, EventArgs e)
        {
            //Shows which answer has been selected
            Abtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Bbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Dbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1;
            Cbtn.BackgroundImage = (Image)Resources.Wings_Woman_1;
            Forwardbtn.Visible = true;
            CurrentAnswer = 2;
        }

        private void Dbtn_Click(object sender, EventArgs e)
        {
            //Shows which answer has been selected
            Abtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Bbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1; Cbtn.BackgroundImage = (Image)Resources.No_Wings_Woman_1;
            Dbtn.BackgroundImage = (Image)Resources.Wings_Woman_1;
            Forwardbtn.Visible = true;
            CurrentAnswer = 3;
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

        private void Questionlbl_Click(object sender, EventArgs e)
        {

        }

        private void questionTypelbl_Click(object sender, EventArgs e)
        {

        }

        private void qTypeThree_Load(object sender, EventArgs e)
        {

        }
    }
}
