namespace The_Big_Egyptian_Quiz
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.PasswordOnelbl = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.cPasswordbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Usernametxt
            // 
            this.Usernametxt.BackColor = System.Drawing.Color.SandyBrown;
            this.Usernametxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(130, 186);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(319, 40);
            this.Usernametxt.TabIndex = 1;
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.BackColor = System.Drawing.Color.SandyBrown;
            this.Passwordtxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.Passwordtxt.Location = new System.Drawing.Point(130, 282);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(319, 40);
            this.Passwordtxt.TabIndex = 2;
            this.Passwordtxt.UseSystemPasswordChar = true;
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Usernamelbl.Location = new System.Drawing.Point(125, 156);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(101, 27);
            this.Usernamelbl.TabIndex = 4;
            this.Usernamelbl.Text = "Username:";
            // 
            // PasswordOnelbl
            // 
            this.PasswordOnelbl.AutoSize = true;
            this.PasswordOnelbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordOnelbl.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordOnelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.PasswordOnelbl.Location = new System.Drawing.Point(125, 252);
            this.PasswordOnelbl.Name = "PasswordOnelbl";
            this.PasswordOnelbl.Size = new System.Drawing.Size(94, 27);
            this.PasswordOnelbl.TabIndex = 5;
            this.PasswordOnelbl.Text = "Password:";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.Loginbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.Location = new System.Drawing.Point(196, 366);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(176, 48);
            this.Loginbtn.TabIndex = 7;
            this.Loginbtn.Text = "Log-In!";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.ForeColor = System.Drawing.SystemColors.Control;
            this.Titlelbl.Location = new System.Drawing.Point(87, 43);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(425, 55);
            this.Titlelbl.TabIndex = 11;
            this.Titlelbl.Text = "Login to your Account!";
            // 
            // cPasswordbtn
            // 
            this.cPasswordbtn.BackColor = System.Drawing.Color.Beige;
            this.cPasswordbtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Eye_of_Horus;
            this.cPasswordbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cPasswordbtn.Location = new System.Drawing.Point(455, 282);
            this.cPasswordbtn.Name = "cPasswordbtn";
            this.cPasswordbtn.Size = new System.Drawing.Size(43, 40);
            this.cPasswordbtn.TabIndex = 12;
            this.cPasswordbtn.UseVisualStyleBackColor = false;
            this.cPasswordbtn.Click += new System.EventHandler(this.cPasswordbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.Backbtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Normal_Arrow___;
            this.Backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Backbtn.Location = new System.Drawing.Point(12, 43);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(58, 55);
            this.Backbtn.TabIndex = 13;
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.kisspng_ancient_egypt_scarab_jewellery_amulet_egyptian_scarab_beetle_5b411c4915c919_5764966215309937370893;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(490, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 233);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Heiroglyphs_7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 454);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.cPasswordbtn);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.PasswordOnelbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.Passwordtxt);
            this.Controls.Add(this.Usernametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginScreen";
            this.Text = "LoginScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label PasswordOnelbl;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Button cPasswordbtn;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}