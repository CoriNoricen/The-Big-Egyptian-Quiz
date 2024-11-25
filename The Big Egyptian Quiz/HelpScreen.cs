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
    public partial class HelpScreen : Form
    {
        readonly string[] HelpScreenHelpy = new string[24];

        public HelpScreen(int i)
        {
            InitializeComponent();
            CenterToParent();

            //Checks file has been created
            if (File.Exists("Help.txt"))
            {
                //Reads through file
                HelpScreenHelpy = File.ReadLines("Help.txt").ToArray();
            }
            else
            {
                MessageBox.Show("Oh no! Your guidance has gone!", "Hard-Mode Enabled");
            }


            switch (i)
            {
                case 0:
                    Titlelbl.Text = HelpScreenHelpy[0];
                    HelpOutputlst.Items.Clear();

                    string[] MultLine = HelpScreenHelpy[1].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 1:
                    Titlelbl.Text = HelpScreenHelpy[2];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[3].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 2:
                    Titlelbl.Text = HelpScreenHelpy[4];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[5].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 3:
                    Titlelbl.Text = HelpScreenHelpy[6];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[7].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 4:
                    Titlelbl.Text = HelpScreenHelpy[8];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[9].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 5:
                    Titlelbl.Text = HelpScreenHelpy[10];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[11].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 6:
                    Titlelbl.Text = HelpScreenHelpy[12];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[13].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 7:
                    Titlelbl.Text = HelpScreenHelpy[14];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[15].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 8:
                    Titlelbl.Text = HelpScreenHelpy[16];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[17].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 9:
                    Titlelbl.Text = HelpScreenHelpy[18];
                    HelpOutputlst.Items.Clear();
                   
                    MultLine = HelpScreenHelpy[19].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 10:
                    Titlelbl.Text = HelpScreenHelpy[20];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[21].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
                case 11:
                    Titlelbl.Text = HelpScreenHelpy[22];
                    HelpOutputlst.Items.Clear();

                    MultLine = HelpScreenHelpy[23].Split('#');
                    foreach (string line in MultLine)
                    {
                        HelpOutputlst.Items.Add($"{line}");
                    }
                    break;
            }
        }

        private void DragDropbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[0];
            HelpOutputlst.Items.Clear(); 
            string[] MultLine = HelpScreenHelpy[1].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void WriteInbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[2];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[3].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Multiplebtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[4];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[5].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Pickagodbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[6];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[7].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Mythologybtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[8];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[9].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Mummificationbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[10];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[11].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Historybtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[12];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[13].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Culturebtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[14];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[15].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Leaderboardbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[16];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[17].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Bonusbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[18];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[19].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[20];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[21].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Titlelbl.Text = HelpScreenHelpy[22];
            HelpOutputlst.Items.Clear();
            string[] MultLine = HelpScreenHelpy[23].Split('#');
            foreach (string line in MultLine)
            {
                HelpOutputlst.Items.Add($"{line}");
            }
        }
    }
}
