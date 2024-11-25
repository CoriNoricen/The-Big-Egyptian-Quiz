namespace The_Big_Egyptian_Quiz
{
    partial class RegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterScreen));
            this.Usernametxt = new System.Windows.Forms.TextBox();
            this.PasswordOnetxt = new System.Windows.Forms.TextBox();
            this.PasswordTwotxt = new System.Windows.Forms.TextBox();
            this.Usernamelbl = new System.Windows.Forms.Label();
            this.PasswordOnelbl = new System.Windows.Forms.Label();
            this.PasswordTwolbl = new System.Windows.Forms.Label();
            this.LoginLinklbl = new System.Windows.Forms.LinkLabel();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.ForLinklbl = new System.Windows.Forms.Label();
            this.cPasswordOnebtn = new System.Windows.Forms.Button();
            this.cPasswordTwobtn = new System.Windows.Forms.Button();
            this.Registerbtn = new System.Windows.Forms.Button();
            this.PasswordOneimg = new System.Windows.Forms.PictureBox();
            this.PasswordTwoimg = new System.Windows.Forms.PictureBox();
            this.MaxLengthtxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordOneimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTwoimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Usernametxt
            // 
            this.Usernametxt.BackColor = System.Drawing.Color.SandyBrown;
            this.Usernametxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernametxt.Location = new System.Drawing.Point(123, 151);
            this.Usernametxt.Name = "Usernametxt";
            this.Usernametxt.Size = new System.Drawing.Size(319, 40);
            this.Usernametxt.TabIndex = 0;
            // 
            // PasswordOnetxt
            // 
            this.PasswordOnetxt.BackColor = System.Drawing.Color.SandyBrown;
            this.PasswordOnetxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.PasswordOnetxt.Location = new System.Drawing.Point(123, 244);
            this.PasswordOnetxt.Name = "PasswordOnetxt";
            this.PasswordOnetxt.Size = new System.Drawing.Size(319, 40);
            this.PasswordOnetxt.TabIndex = 1;
            this.PasswordOnetxt.UseSystemPasswordChar = true;
            this.PasswordOnetxt.TextChanged += new System.EventHandler(this.PasswordOnetxt_TextChanged);
            // 
            // PasswordTwotxt
            // 
            this.PasswordTwotxt.BackColor = System.Drawing.Color.SandyBrown;
            this.PasswordTwotxt.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.PasswordTwotxt.Location = new System.Drawing.Point(123, 341);
            this.PasswordTwotxt.Name = "PasswordTwotxt";
            this.PasswordTwotxt.Size = new System.Drawing.Size(319, 40);
            this.PasswordTwotxt.TabIndex = 2;
            this.PasswordTwotxt.UseSystemPasswordChar = true;
            this.PasswordTwotxt.TextChanged += new System.EventHandler(this.PasswordTwotxt_TextChanged);
            // 
            // Usernamelbl
            // 
            this.Usernamelbl.AutoSize = true;
            this.Usernamelbl.BackColor = System.Drawing.Color.Transparent;
            this.Usernamelbl.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usernamelbl.Location = new System.Drawing.Point(118, 121);
            this.Usernamelbl.Name = "Usernamelbl";
            this.Usernamelbl.Size = new System.Drawing.Size(101, 27);
            this.Usernamelbl.TabIndex = 3;
            this.Usernamelbl.Text = "Username:";
            // 
            // PasswordOnelbl
            // 
            this.PasswordOnelbl.AutoSize = true;
            this.PasswordOnelbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordOnelbl.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordOnelbl.Location = new System.Drawing.Point(118, 214);
            this.PasswordOnelbl.Name = "PasswordOnelbl";
            this.PasswordOnelbl.Size = new System.Drawing.Size(94, 27);
            this.PasswordOnelbl.TabIndex = 4;
            this.PasswordOnelbl.Text = "Password:";
            // 
            // PasswordTwolbl
            // 
            this.PasswordTwolbl.AutoSize = true;
            this.PasswordTwolbl.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTwolbl.Font = new System.Drawing.Font("Papyrus", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTwolbl.Location = new System.Drawing.Point(115, 313);
            this.PasswordTwolbl.Name = "PasswordTwolbl";
            this.PasswordTwolbl.Size = new System.Drawing.Size(166, 27);
            this.PasswordTwolbl.TabIndex = 5;
            this.PasswordTwolbl.Text = "Confirm Password:";
            // 
            // LoginLinklbl
            // 
            this.LoginLinklbl.AutoSize = true;
            this.LoginLinklbl.BackColor = System.Drawing.Color.Transparent;
            this.LoginLinklbl.Location = new System.Drawing.Point(287, 384);
            this.LoginLinklbl.Name = "LoginLinklbl";
            this.LoginLinklbl.Size = new System.Drawing.Size(72, 16);
            this.LoginLinklbl.TabIndex = 7;
            this.LoginLinklbl.TabStop = true;
            this.LoginLinklbl.Text = "Click Here.";
            this.LoginLinklbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginLinklbl_LinkClicked);
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.Location = new System.Drawing.Point(85, 66);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(406, 55);
            this.Titlelbl.TabIndex = 10;
            this.Titlelbl.Text = "Create your Account!";
            // 
            // ForLinklbl
            // 
            this.ForLinklbl.AutoSize = true;
            this.ForLinklbl.BackColor = System.Drawing.Color.Transparent;
            this.ForLinklbl.Location = new System.Drawing.Point(180, 384);
            this.ForLinklbl.Name = "ForLinklbl";
            this.ForLinklbl.Size = new System.Drawing.Size(101, 16);
            this.ForLinklbl.TabIndex = 11;
            this.ForLinklbl.Text = "Already a user?";
            // 
            // cPasswordOnebtn
            // 
            this.cPasswordOnebtn.BackColor = System.Drawing.Color.Beige;
            this.cPasswordOnebtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Eye_of_Horus;
            this.cPasswordOnebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cPasswordOnebtn.Location = new System.Drawing.Point(448, 244);
            this.cPasswordOnebtn.Name = "cPasswordOnebtn";
            this.cPasswordOnebtn.Size = new System.Drawing.Size(43, 40);
            this.cPasswordOnebtn.TabIndex = 9;
            this.cPasswordOnebtn.UseVisualStyleBackColor = false;
            this.cPasswordOnebtn.Click += new System.EventHandler(this.cPasswordOnebtn_Click);
            // 
            // cPasswordTwobtn
            // 
            this.cPasswordTwobtn.BackColor = System.Drawing.Color.Beige;
            this.cPasswordTwobtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Eye_of_Horus;
            this.cPasswordTwobtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cPasswordTwobtn.Location = new System.Drawing.Point(448, 343);
            this.cPasswordTwobtn.Name = "cPasswordTwobtn";
            this.cPasswordTwobtn.Size = new System.Drawing.Size(43, 40);
            this.cPasswordTwobtn.TabIndex = 8;
            this.cPasswordTwobtn.UseVisualStyleBackColor = false;
            this.cPasswordTwobtn.Click += new System.EventHandler(this.cPasswordTwobtn_Click);
            // 
            // Registerbtn
            // 
            this.Registerbtn.BackColor = System.Drawing.Color.LemonChiffon;
            this.Registerbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbtn.Location = new System.Drawing.Point(191, 437);
            this.Registerbtn.Name = "Registerbtn";
            this.Registerbtn.Size = new System.Drawing.Size(176, 48);
            this.Registerbtn.TabIndex = 6;
            this.Registerbtn.Text = "Register!";
            this.Registerbtn.UseVisualStyleBackColor = false;
            this.Registerbtn.Click += new System.EventHandler(this.Registerbtn_Click);
            // 
            // PasswordOneimg
            // 
            this.PasswordOneimg.BackColor = System.Drawing.Color.Transparent;
            this.PasswordOneimg.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Cat_no_Wings;
            this.PasswordOneimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasswordOneimg.Location = new System.Drawing.Point(49, 214);
            this.PasswordOneimg.Name = "PasswordOneimg";
            this.PasswordOneimg.Size = new System.Drawing.Size(68, 70);
            this.PasswordOneimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordOneimg.TabIndex = 12;
            this.PasswordOneimg.TabStop = false;
            // 
            // PasswordTwoimg
            // 
            this.PasswordTwoimg.BackColor = System.Drawing.Color.Transparent;
            this.PasswordTwoimg.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Cat_no_Wings;
            this.PasswordTwoimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PasswordTwoimg.Location = new System.Drawing.Point(49, 313);
            this.PasswordTwoimg.Name = "PasswordTwoimg";
            this.PasswordTwoimg.Size = new System.Drawing.Size(68, 70);
            this.PasswordTwoimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PasswordTwoimg.TabIndex = 13;
            this.PasswordTwoimg.TabStop = false;
            // 
            // MaxLengthtxt
            // 
            this.MaxLengthtxt.AutoSize = true;
            this.MaxLengthtxt.BackColor = System.Drawing.Color.Transparent;
            this.MaxLengthtxt.Location = new System.Drawing.Point(321, 194);
            this.MaxLengthtxt.Name = "MaxLengthtxt";
            this.MaxLengthtxt.Size = new System.Drawing.Size(121, 16);
            this.MaxLengthtxt.TabIndex = 14;
            this.MaxLengthtxt.Text = "(Max. 8 Characters)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(192, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "(Must include 3 characters and a number)";
            // 
            // RegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Blank_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(574, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaxLengthtxt);
            this.Controls.Add(this.LoginLinklbl);
            this.Controls.Add(this.PasswordTwoimg);
            this.Controls.Add(this.PasswordOneimg);
            this.Controls.Add(this.ForLinklbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.cPasswordOnebtn);
            this.Controls.Add(this.cPasswordTwobtn);
            this.Controls.Add(this.Registerbtn);
            this.Controls.Add(this.PasswordTwolbl);
            this.Controls.Add(this.PasswordOnelbl);
            this.Controls.Add(this.Usernamelbl);
            this.Controls.Add(this.PasswordTwotxt);
            this.Controls.Add(this.PasswordOnetxt);
            this.Controls.Add(this.Usernametxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegisterScreen";
            this.Text = "RegisterScreen";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordOneimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTwoimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Usernametxt;
        private System.Windows.Forms.TextBox PasswordOnetxt;
        private System.Windows.Forms.TextBox PasswordTwotxt;
        private System.Windows.Forms.Label Usernamelbl;
        private System.Windows.Forms.Label PasswordOnelbl;
        private System.Windows.Forms.Label PasswordTwolbl;
        private System.Windows.Forms.Button Registerbtn;
        private System.Windows.Forms.LinkLabel LoginLinklbl;
        private System.Windows.Forms.Button cPasswordTwobtn;
        private System.Windows.Forms.Button cPasswordOnebtn;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label ForLinklbl;
        private System.Windows.Forms.PictureBox PasswordOneimg;
        private System.Windows.Forms.PictureBox PasswordTwoimg;
        private System.Windows.Forms.Label MaxLengthtxt;
        private System.Windows.Forms.Label label1;
    }
}