namespace The_Big_Egyptian_Quiz
{
    partial class PasswordScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordScreen));
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Titlelbl = new System.Windows.Forms.Label();
            this.Text1lbl = new System.Windows.Forms.Label();
            this.Text2lbl = new System.Windows.Forms.Label();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Forwardbtn = new System.Windows.Forms.Button();
            this.cPasswordbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(161, 270);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.Size = new System.Drawing.Size(421, 52);
            this.Passwordtxt.TabIndex = 1;
            this.Passwordtxt.UseSystemPasswordChar = true;
            this.Passwordtxt.TextChanged += new System.EventHandler(this.Passwordtxt_TextChanged);
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.BackColor = System.Drawing.Color.Transparent;
            this.Titlelbl.Font = new System.Drawing.Font("Palatino Linotype", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Titlelbl.Location = new System.Drawing.Point(180, 30);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(441, 58);
            this.Titlelbl.TabIndex = 2;
            this.Titlelbl.Text = "Leaderboard Locked!";
            this.Titlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text1lbl
            // 
            this.Text1lbl.AutoSize = true;
            this.Text1lbl.BackColor = System.Drawing.Color.Transparent;
            this.Text1lbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Text1lbl.Location = new System.Drawing.Point(225, 130);
            this.Text1lbl.Name = "Text1lbl";
            this.Text1lbl.Size = new System.Drawing.Size(350, 48);
            this.Text1lbl.TabIndex = 3;
            this.Text1lbl.Text = "To access Leaderboard";
            this.Text1lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Text2lbl
            // 
            this.Text2lbl.AutoSize = true;
            this.Text2lbl.BackColor = System.Drawing.Color.Transparent;
            this.Text2lbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text2lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Text2lbl.Location = new System.Drawing.Point(276, 178);
            this.Text2lbl.Name = "Text2lbl";
            this.Text2lbl.Size = new System.Drawing.Size(248, 48);
            this.Text2lbl.TabIndex = 4;
            this.Text2lbl.Text = "Enter Password:";
            this.Text2lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.Backbtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Normal_Arrow___;
            this.Backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Backbtn.Location = new System.Drawing.Point(12, 11);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(59, 55);
            this.Backbtn.TabIndex = 15;
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Forwardbtn
            // 
            this.Forwardbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Forwardbtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Blank_3;
            this.Forwardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forwardbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forwardbtn.Location = new System.Drawing.Point(295, 357);
            this.Forwardbtn.Name = "Forwardbtn";
            this.Forwardbtn.Size = new System.Drawing.Size(210, 54);
            this.Forwardbtn.TabIndex = 16;
            this.Forwardbtn.Text = "SUBMIT";
            this.Forwardbtn.UseVisualStyleBackColor = false;
            this.Forwardbtn.Click += new System.EventHandler(this.Forwardbtn_Click);
            // 
            // cPasswordbtn
            // 
            this.cPasswordbtn.BackColor = System.Drawing.Color.Beige;
            this.cPasswordbtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Eye_of_Horus;
            this.cPasswordbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cPasswordbtn.Location = new System.Drawing.Point(588, 270);
            this.cPasswordbtn.Name = "cPasswordbtn";
            this.cPasswordbtn.Size = new System.Drawing.Size(52, 52);
            this.cPasswordbtn.TabIndex = 17;
            this.cPasswordbtn.UseVisualStyleBackColor = false;
            this.cPasswordbtn.Click += new System.EventHandler(this.cPasswordbtn_Click);
            // 
            // PasswordScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.BG4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cPasswordbtn);
            this.Controls.Add(this.Forwardbtn);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Text2lbl);
            this.Controls.Add(this.Text1lbl);
            this.Controls.Add(this.Titlelbl);
            this.Controls.Add(this.Passwordtxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordScreen";
            this.Text = "PasswordScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.Label Titlelbl;
        private System.Windows.Forms.Label Text1lbl;
        private System.Windows.Forms.Label Text2lbl;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Button Forwardbtn;
        private System.Windows.Forms.Button cPasswordbtn;
    }
}