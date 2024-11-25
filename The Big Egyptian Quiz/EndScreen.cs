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

namespace The_Big_Egyptian_Quiz
{
    public partial class EndScreen : Form
    {
        // Declare the ContextMenuStrip control.
        private ContextMenuStrip HelpContextMenuStrip;

        public EndScreen(int topic1score, int topic2score, int topic3score, int topic4score)
        {
            InitializeComponent();
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

            int Score = TopicScreen.player.Score;
            int T1Score = topic1score;
            int T2Score = topic2score;
            int T3Score = topic3score;
            int T4Score = topic4score;

            Scorelbl.Text = "Score: " + Score + "/" + TopicScreen.player.TotalTotalScore as string;

            bool found = false;
            try
            {
                string TempFile = Path.GetTempFileName();
                using (var sr = new StreamReader("data.bin"))
                using (var sw = new StreamWriter(TempFile))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //reads from file 
                        string[] parts = line.Split('|');
                        if (parts[0] == TopicScreen.player.Username)
                        {
                            if (parts[1] == "topic1")
                            {
                                parts[2] = T1Score.ToString();
                            }
                            if (parts[1] == "topic2")
                            {
                                parts[2] = T2Score.ToString();
                            }
                            if (parts[1] == "topic3")
                            {
                                parts[2] = T3Score.ToString();
                            }
                            if (parts[1] == "topic4")
                            {
                                parts[2] = T4Score.ToString();
                            }
                            if (parts[1] == "total")
                            {
                                parts[2] = Score.ToString();
                            }
                            line = string.Join("|", parts);
                            found = true;
                        }
                        sw.WriteLine(line);
                    }
                    if (!found)
                    {
                        //writes data to file
                        sw.WriteLine(TopicScreen.player.Username + "|" + "topic1" + "|" + T1Score);
                        sw.WriteLine(TopicScreen.player.Username + "|" + "topic2" + "|" + T2Score);
                        sw.WriteLine(TopicScreen.player.Username + "|" + "topic3" + "|" + T3Score);
                        sw.WriteLine(TopicScreen.player.Username + "|" + "topic4" + "|" + T4Score);
                        sw.WriteLine(TopicScreen.player.Username + "|" + "total" + "|" + Score);
                    }
                }
                File.Delete("data.bin");
                File.Move(TempFile, "data.bin");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR");
            }
        }

        private void Endbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            try
            { 
                string filePath = @"data.bin";
                string tempFile = Path.GetTempFileName();
                List<string> fileLines = File.ReadAllLines(filePath).ToList();
                for (int i = 0; i < fileLines.Count; i++)
                {
                    string line = fileLines[i];
                    string[] parts = line.Split('|');
                    if (parts[0] == TopicScreen.player.Username)
                    {
                        fileLines.RemoveAt(i);
                        i--;
                    }
                }
                File.WriteAllLines(tempFile, fileLines);
                File.Delete(filePath);
                File.Move(tempFile, filePath);
                MessageBox.Show("Line removed successfully!");
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR");
            }
            TopicScreen.player.ResetPlayer();
            Hide();
            new RegisterScreen().Show();
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            if (PasswordScreen.PasswordCompleted == true)
            {
                Hide();
                new LeaderboardScreen(1).Show();
            }
            else if (PasswordScreen.LeaderAccessible != false)
            {
                Hide();
                new PasswordScreen(1).Show();
            }
            else
            {
                MessageBox.Show("You have tried too many times. You can \nno longer access the leaderboard.", "BANISHED FROM THE BOARD");
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

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            TopicScreen.player.ResetPlayer();
            Hide();
            new RegisterScreen().Show();
        }
    }
}
