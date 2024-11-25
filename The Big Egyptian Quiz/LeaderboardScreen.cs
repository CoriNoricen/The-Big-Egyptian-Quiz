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
using The_Big_Egyptian_Quiz.Properties;

namespace The_Big_Egyptian_Quiz
{
    public partial class LeaderboardScreen : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        int IntForm;
        int Score = TopicScreen.player.TotalTotalScore;
        int T1Score = TopicScreen.player.Topic1TotalScore;
        int T2Score = TopicScreen.player.Topic2TotalScore;
        int T3Score = TopicScreen.player.Topic3TotalScore;
        int T4Score = TopicScreen.player.Topic4TotalScore;

        public LeaderboardScreen(int INTFORM)
        {
            InitializeComponent();
            CenterToParent();
            IntForm = INTFORM;

            Overallrdb.Checked = true;
            Overallrdb_CheckedChanged(null, null);

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
            if (IntForm == 0)
            {
                Hide();
                new TopicScreen(TopicScreen.player.Username, TopicScreen.player.Score, TopicScreen.player.FirstTime).Show();
            }
            else if (IntForm == 1)
            {
                Hide();
                new EndScreen(TopicScreen.player.Topic1Score, TopicScreen.player.Topic2Score, TopicScreen.player.Topic3Score, TopicScreen.player.Topic4Score).Show();
            }
            else
            {
                MessageBox.Show("Even the gods aren't sure where you want to go\nReturning to the Topics!", "Invalid Direction");
                Hide();
                new TopicScreen(TopicScreen.player.Username, TopicScreen.player.Score, TopicScreen.player.FirstTime).Show();
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

        private void LeaderboardScreen_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Shinygif_Click(object sender, EventArgs e)
        {

        }

        private void Explain1lbl_Click(object sender, EventArgs e)
        {

        }

        private void Explain2lbl_Click(object sender, EventArgs e)
        {

        }

        private void Raimg_Click(object sender, EventArgs e)
        {

        }

        private void Overallrdb_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();
            //finds file and writes/reads to it
            string filePath = @"data.bin";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string userName = lines[i].Split('|')[0];
                string topic = lines[i].Split('|')[1];
                int score = Convert.ToInt32(lines[i].Split('|')[2]);
                //only shows total scores
                if (topic == "total")
                {
                    userScores.Add(new KeyValuePair<string, int>(userName, score));
                }

            }
            userScores = userScores.OrderByDescending(pair => pair.Value).ToList();
            int j = 0;
            foreach (var pair in userScores)
            {
                string rank = PercentageFinder(0, pair.Value);
                j++;
                var index = this.DataGridView.Rows.Add();
                this.DataGridView.Rows[index].Cells[j].Value = pair.Key;
                this.DataGridView.Rows[index].Cells[j + 1].Value = rank;
                j = 0;

                //Only shows image if score is correct
                if (pair.Value == TopicScreen.player.TotalTotalScore)
                {
                    DataGridView.Rows[index].Cells[0].Value = (Image)Resources.Shiny_gif;
                }
            }
        }

        private void Topic1rdb_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();
            //finds file and writes/reads to it
            string filePath = @"data.bin";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string userName = lines[i].Split('|')[0];
                string topic = lines[i].Split('|')[1];
                int score = Convert.ToInt32(lines[i].Split('|')[2]);
                //only shows topic scores
                if (topic == "topic1")
                {
                    userScores.Add(new KeyValuePair<string, int>(userName, score));
                }

            }
            userScores = userScores.OrderByDescending(pair => pair.Value).ToList();
            int j = 0;
            foreach (var pair in userScores)
            {
                string rank = PercentageFinder(1, pair.Value);
                j++;
                var index = this.DataGridView.Rows.Add();
                this.DataGridView.Rows[index].Cells[j].Value = pair.Key;
                this.DataGridView.Rows[index].Cells[j + 1].Value = rank;
                j = 0;

                //Only shows image if score is correct
                if (pair.Value == T1Score)
                {
                    DataGridView.Rows[index].Cells[0].Value = (Image)Resources.Shiny_gif;
                }
            }
        }

        private void Mummificationrdb_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();
            //finds file and writes/reads to it
            string filePath = @"data.bin";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string userName = lines[i].Split('|')[0];
                string topic = lines[i].Split('|')[1];
                int score = Convert.ToInt32(lines[i].Split('|')[2]);
                //only shows topic scores
                if (topic == "topic2")
                {
                    userScores.Add(new KeyValuePair<string, int>(userName, score));
                }

            }
            userScores = userScores.OrderByDescending(pair => pair.Value).ToList();
            int j = 0;
            foreach (var pair in userScores)
            {
                string rank = PercentageFinder(2, pair.Value);
                j++;
                var index = this.DataGridView.Rows.Add();
                this.DataGridView.Rows[index].Cells[j].Value = pair.Key;
                this.DataGridView.Rows[index].Cells[j + 1].Value = rank;
                j = 0;

                //Only shows image if score is correct
                if (pair.Value == T2Score)
                {
                    DataGridView.Rows[index].Cells[0].Value = (Image)Resources.Shiny_gif;
                }
            }
        }

        private void Specialrdb_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();
            //finds file and writes/reads to it
            string filePath = @"data.bin";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string userName = lines[i].Split('|')[0];
                string topic = lines[i].Split('|')[1];
                int score = Convert.ToInt32(lines[i].Split('|')[2]);
                //only shows top scores
                if (score == TopicScreen.player.TotalTotalScore)
                {
                    userScores.Add(new KeyValuePair<string, int>(userName, score));
                }
            }
            userScores = userScores.OrderByDescending(pair => pair.Value).ToList();
            int j = 0;
            foreach (var pair in userScores)
            {
                string rank = PercentageFinder(5, pair.Value);
                j++;
                var index = this.DataGridView.Rows.Add();
                this.DataGridView.Rows[index].Cells[j].Value = pair.Key;
                this.DataGridView.Rows[index].Cells[j + 1].Value = rank;
                j = 0;

                //Only shows image if score is correct
                if (pair.Value == TopicScreen.player.TotalTotalScore)
                {
                    DataGridView.Rows[index].Cells[0].Value = (Image)Resources.Shiny_gif;
                }
            }
        }

        private void Culturerdb_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();
            //finds file and writes/reads to it
            string filePath = @"data.bin";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string userName = lines[i].Split('|')[0];
                string topic = lines[i].Split('|')[1];
                int score = Convert.ToInt32(lines[i].Split('|')[2]);
                if (topic == "topic4")
                {
                    userScores.Add(new KeyValuePair<string, int>(userName, score));
                }

            }
            userScores = userScores.OrderByDescending(pair => pair.Value).ToList();
            int j = 0;
            foreach (var pair in userScores)
            {
                string rank = PercentageFinder(4, pair.Value);
                j++;
                var index = this.DataGridView.Rows.Add();
                this.DataGridView.Rows[index].Cells[j].Value = pair.Key;
                this.DataGridView.Rows[index].Cells[j + 1].Value = rank;
                j = 0;

                //Only shows image if score is correct
                if (pair.Value == T4Score)
                {
                    DataGridView.Rows[index].Cells[0].Value = (Image)Resources.Shiny_gif;
                }
            }
        }

        private void Historyrdb_CheckedChanged(object sender, EventArgs e)
        {
            DataGridView.Rows.Clear();
            DataGridView.Refresh();
            //finds file and writes/reads to it
            string filePath = @"data.bin";
            string[] lines = File.ReadAllLines(filePath);
            List<KeyValuePair<string, int>> userScores = new List<KeyValuePair<string, int>>();
            for (int i = 0; i < lines.Length; i++)
            {
                string userName = lines[i].Split('|')[0];
                string topic = lines[i].Split('|')[1];
                int score = Convert.ToInt32(lines[i].Split('|')[2]);
                if (topic == "topic3")
                {
                    userScores.Add(new KeyValuePair<string, int>(userName, score));
                }

            }
            userScores = userScores.OrderByDescending(pair => pair.Value).ToList();
            int j = 0;
            foreach (var pair in userScores)
            {
                string rank = PercentageFinder(3, pair.Value);
                j++;
                var index = this.DataGridView.Rows.Add();
                this.DataGridView.Rows[index].Cells[j].Value = pair.Key;
                this.DataGridView.Rows[index].Cells[j + 1].Value = rank;
                j = 0;

                //Only shows image if score is correct
                if (pair.Value == T3Score)
                {
                    DataGridView.Rows[index].Cells[0].Value = (Image)Resources.Shiny_gif;
                }
            }
        }

        private string PercentageFinder(int LeaderScreenNo, double Score)
        {
            string rank;
            double percentage;

            //switch/case to find percentage
            switch(LeaderScreenNo)
            {
                case 0:
                    percentage = (Score / TopicScreen.player.TotalTotalScore) * 100;
                    break;
                case 1:
                    percentage = (Score / TopicScreen.player.Topic1TotalScore) * 100;
                    break;
                case 2:
                    percentage = (Score / TopicScreen.player.Topic2TotalScore) * 100;
                    break;
                case 3:
                    percentage = (Score / TopicScreen.player.Topic3TotalScore) * 100;
                    break;
                case 4:
                    percentage = (Score / TopicScreen.player.Topic4TotalScore) * 100;
                    break;
                case 5:
                    percentage = (Score / TopicScreen.player.TotalTotalScore) * 100;
                    break;
                default:
                    percentage = 0;
                    break;
            } 
                
            if (percentage >= 90) { rank = "Egyptian god"; }
            else if (percentage >= 70) { rank = "Egyptian Pharaoh"; }
            else if (percentage >= 50) { rank = "Egyptian Noble"; }
            else if (percentage >= 40) { rank = "lowly Citizen"; }
            else { rank = "Slave"; }

            //returns rank of player for DataGridView
            return rank;
        }
    }
}
