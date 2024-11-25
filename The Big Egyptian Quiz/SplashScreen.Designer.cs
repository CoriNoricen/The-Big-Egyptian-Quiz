namespace The_Big_Egyptian_Quiz
{
    partial class SplashScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.LoadingBar = new System.Windows.Forms.ProgressBar();
            this.Loadinglbl = new System.Windows.Forms.Label();
            this.TitleOnelbl = new System.Windows.Forms.Label();
            this.LoadTime = new System.Windows.Forms.Timer(this.components);
            this.Progresslbl = new System.Windows.Forms.Label();
            this.TitleThreelbl = new System.Windows.Forms.Label();
            this.TitleTwolbl = new System.Windows.Forms.Label();
            this.BackgroundGif = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundGif)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadingBar
            // 
            this.LoadingBar.BackColor = System.Drawing.SystemColors.Control;
            this.LoadingBar.Location = new System.Drawing.Point(69, 324);
            this.LoadingBar.Name = "LoadingBar";
            this.LoadingBar.Size = new System.Drawing.Size(734, 42);
            this.LoadingBar.TabIndex = 0;
            // 
            // Loadinglbl
            // 
            this.Loadinglbl.AutoSize = true;
            this.Loadinglbl.BackColor = System.Drawing.Color.Transparent;
            this.Loadinglbl.Font = new System.Drawing.Font("Papyrus", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loadinglbl.ForeColor = System.Drawing.Color.White;
            this.Loadinglbl.Location = new System.Drawing.Point(61, 277);
            this.Loadinglbl.Name = "Loadinglbl";
            this.Loadinglbl.Size = new System.Drawing.Size(126, 44);
            this.Loadinglbl.TabIndex = 1;
            this.Loadinglbl.Text = "Loading";
            // 
            // TitleOnelbl
            // 
            this.TitleOnelbl.AutoSize = true;
            this.TitleOnelbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleOnelbl.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleOnelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleOnelbl.Location = new System.Drawing.Point(95, 66);
            this.TitleOnelbl.Name = "TitleOnelbl";
            this.TitleOnelbl.Size = new System.Drawing.Size(221, 49);
            this.TitleOnelbl.TabIndex = 2;
            this.TitleOnelbl.Text = "Welcome To";
            // 
            // LoadTime
            // 
            this.LoadTime.Tick += new System.EventHandler(this.LoadTime_Tick);
            // 
            // Progresslbl
            // 
            this.Progresslbl.AutoSize = true;
            this.Progresslbl.BackColor = System.Drawing.Color.Transparent;
            this.Progresslbl.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Progresslbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Progresslbl.Location = new System.Drawing.Point(758, 369);
            this.Progresslbl.Name = "Progresslbl";
            this.Progresslbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Progresslbl.Size = new System.Drawing.Size(38, 31);
            this.Progresslbl.TabIndex = 3;
            this.Progresslbl.Text = "0%";
            this.Progresslbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TitleThreelbl
            // 
            this.TitleThreelbl.AutoSize = true;
            this.TitleThreelbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleThreelbl.Font = new System.Drawing.Font("Palatino Linotype", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleThreelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleThreelbl.Location = new System.Drawing.Point(273, 400);
            this.TitleThreelbl.Name = "TitleThreelbl";
            this.TitleThreelbl.Size = new System.Drawing.Size(504, 50);
            this.TitleThreelbl.TabIndex = 4;
            this.TitleThreelbl.Text = "Do You Have What it Takes?";
            // 
            // TitleTwolbl
            // 
            this.TitleTwolbl.AutoSize = true;
            this.TitleTwolbl.BackColor = System.Drawing.Color.Transparent;
            this.TitleTwolbl.Font = new System.Drawing.Font("Papyrus", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleTwolbl.ForeColor = System.Drawing.SystemColors.Control;
            this.TitleTwolbl.Location = new System.Drawing.Point(0, 152);
            this.TitleTwolbl.Name = "TitleTwolbl";
            this.TitleTwolbl.Size = new System.Drawing.Size(803, 74);
            this.TitleTwolbl.TabIndex = 5;
            this.TitleTwolbl.Text = "THE BIG EGYPTIAN QUIZ!";
            // 
            // BackgroundGif
            // 
            this.BackgroundGif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundGif.Image = global::The_Big_Egyptian_Quiz.Properties.Resources._8_Bit_Gif;
            this.BackgroundGif.Location = new System.Drawing.Point(0, 0);
            this.BackgroundGif.Name = "BackgroundGif";
            this.BackgroundGif.Size = new System.Drawing.Size(864, 450);
            this.BackgroundGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BackgroundGif.TabIndex = 6;
            this.BackgroundGif.TabStop = false;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources._8_Bit_Gif;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 449);
            this.Controls.Add(this.Loadinglbl);
            this.Controls.Add(this.TitleTwolbl);
            this.Controls.Add(this.TitleThreelbl);
            this.Controls.Add(this.Progresslbl);
            this.Controls.Add(this.TitleOnelbl);
            this.Controls.Add(this.LoadingBar);
            this.Controls.Add(this.BackgroundGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SplashScreen";
            this.Text = "SplashScreen";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackgroundGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar LoadingBar;
        private System.Windows.Forms.Label Loadinglbl;
        private System.Windows.Forms.Label TitleOnelbl;
        private System.Windows.Forms.Timer LoadTime;
        private System.Windows.Forms.Label Progresslbl;
        private System.Windows.Forms.Label TitleThreelbl;
        private System.Windows.Forms.Label TitleTwolbl;
        private System.Windows.Forms.PictureBox BackgroundGif;
    }
}