using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace The_Big_Egyptian_Quiz
{
    public partial class SplashScreen : Form
    {
        //Counts to change loading text
        private int LoadingDots = 0;
        //Counts to show percentage
        private int LoadingProg = 0;

        public SplashScreen()
        {
            InitializeComponent();
            //Centers the Form
            CenterToScreen();
            //Starts the timer and changes the interval at which it ticks
            LoadTime.Start();
            LoadTime.Interval = 150;
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadTime_Tick(object sender, EventArgs e)
        {
            //Changes Text above progress bar from "Loading" to "Loading..."
            if (LoadingDots == 0)
            {
                Loadinglbl.Text = "Loading.";
                LoadingDots++;
            }
            else if (LoadingDots == 1)
            {
                Loadinglbl.Text = "Loading..";
                LoadingDots++;
            }
            else if (LoadingDots == 2)
            {
                Loadinglbl.Text = "Loading...";
                LoadingDots++;
            }
            else
            {
                LoadingDots = 0;
                Loadinglbl.Text = "Loading";
            }

            //Creates random integer between zero and five
            Random random = new Random();
            int Percentage = random.Next(0, 5);

            //Increase bar value by 5
            LoadingBar.Increment(Percentage);

            //Counts percentage
            LoadingProg += Percentage;
            //Show percentage complete
            Progresslbl.Text = Convert.ToString(LoadingProg) + "%";

            //Moves onto RegisterScreen once value of Loading Bar exceeds 100%
            if (LoadingProg >= 100)
            {
                LoadTime.Stop();
                Hide();
                new RegisterScreen().Show();
            }
        }
    }
}
