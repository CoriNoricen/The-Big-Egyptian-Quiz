namespace The_Big_Egyptian_Quiz
{
    partial class LeaderboardScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LeaderboardScreen));
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Perfect = new System.Windows.Forms.DataGridViewImageColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Raimg = new System.Windows.Forms.PictureBox();
            this.Shinygif = new System.Windows.Forms.PictureBox();
            this.Explain1lbl = new System.Windows.Forms.Label();
            this.Explain2lbl = new System.Windows.Forms.Label();
            this.Overallrdb = new System.Windows.Forms.RadioButton();
            this.Topic1rdb = new System.Windows.Forms.RadioButton();
            this.Mummificationrdb = new System.Windows.Forms.RadioButton();
            this.Historyrdb = new System.Windows.Forms.RadioButton();
            this.Culturerdb = new System.Windows.Forms.RadioButton();
            this.Specialrdb = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shinygif)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.BackgroundColor = System.Drawing.Color.PeachPuff;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Perfect,
            this.Username,
            this.Rank});
            this.DataGridView.Location = new System.Drawing.Point(258, 37);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(628, 505);
            this.DataGridView.TabIndex = 16;
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // Perfect
            // 
            this.Perfect.HeaderText = "Perfect";
            this.Perfect.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Perfect.MinimumWidth = 6;
            this.Perfect.Name = "Perfect";
            this.Perfect.Width = 75;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.Width = 250;
            // 
            // Rank
            // 
            this.Rank.HeaderText = "Rank";
            this.Rank.MinimumWidth = 6;
            this.Rank.Name = "Rank";
            this.Rank.Width = 250;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Perfect";
            this.dataGridViewImageColumn1.Image = global::The_Big_Egyptian_Quiz.Properties.Resources.Shiny_gif;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.DarkKhaki;
            this.Backbtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Normal_Arrow___;
            this.Backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Backbtn.Location = new System.Drawing.Point(16, 36);
            this.Backbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(59, 55);
            this.Backbtn.TabIndex = 15;
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Raimg
            // 
            this.Raimg.BackColor = System.Drawing.Color.Transparent;
            this.Raimg.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Ra_Flat_L;
            this.Raimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Raimg.Location = new System.Drawing.Point(893, 36);
            this.Raimg.Name = "Raimg";
            this.Raimg.Size = new System.Drawing.Size(240, 506);
            this.Raimg.TabIndex = 23;
            this.Raimg.TabStop = false;
            this.Raimg.Click += new System.EventHandler(this.Raimg_Click);
            // 
            // Shinygif
            // 
            this.Shinygif.BackColor = System.Drawing.Color.Transparent;
            this.Shinygif.Image = global::The_Big_Egyptian_Quiz.Properties.Resources.Shiny_gif;
            this.Shinygif.Location = new System.Drawing.Point(17, 398);
            this.Shinygif.Name = "Shinygif";
            this.Shinygif.Size = new System.Drawing.Size(235, 92);
            this.Shinygif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Shinygif.TabIndex = 24;
            this.Shinygif.TabStop = false;
            this.Shinygif.Click += new System.EventHandler(this.Shinygif_Click);
            // 
            // Explain1lbl
            // 
            this.Explain1lbl.AutoSize = true;
            this.Explain1lbl.BackColor = System.Drawing.Color.Transparent;
            this.Explain1lbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Explain1lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Explain1lbl.Location = new System.Drawing.Point(12, 493);
            this.Explain1lbl.Name = "Explain1lbl";
            this.Explain1lbl.Size = new System.Drawing.Size(211, 21);
            this.Explain1lbl.TabIndex = 25;
            this.Explain1lbl.Text = "This is a gift from Ra. Those ";
            this.Explain1lbl.Click += new System.EventHandler(this.Explain1lbl_Click);
            // 
            // Explain2lbl
            // 
            this.Explain2lbl.AutoSize = true;
            this.Explain2lbl.BackColor = System.Drawing.Color.Transparent;
            this.Explain2lbl.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Explain2lbl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Explain2lbl.Location = new System.Drawing.Point(12, 519);
            this.Explain2lbl.Name = "Explain2lbl";
            this.Explain2lbl.Size = new System.Drawing.Size(224, 21);
            this.Explain2lbl.TabIndex = 26;
            this.Explain2lbl.Text = "with a perfect score is given it.";
            this.Explain2lbl.Click += new System.EventHandler(this.Explain2lbl_Click);
            // 
            // Overallrdb
            // 
            this.Overallrdb.AutoSize = true;
            this.Overallrdb.BackColor = System.Drawing.Color.Transparent;
            this.Overallrdb.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Overallrdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Overallrdb.Location = new System.Drawing.Point(96, 46);
            this.Overallrdb.Name = "Overallrdb";
            this.Overallrdb.Size = new System.Drawing.Size(140, 45);
            this.Overallrdb.TabIndex = 27;
            this.Overallrdb.TabStop = true;
            this.Overallrdb.Text = "Overall";
            this.Overallrdb.UseVisualStyleBackColor = false;
            this.Overallrdb.CheckedChanged += new System.EventHandler(this.Overallrdb_CheckedChanged);
            // 
            // Topic1rdb
            // 
            this.Topic1rdb.AutoSize = true;
            this.Topic1rdb.BackColor = System.Drawing.Color.Transparent;
            this.Topic1rdb.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Topic1rdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Topic1rdb.Location = new System.Drawing.Point(17, 106);
            this.Topic1rdb.Name = "Topic1rdb";
            this.Topic1rdb.Size = new System.Drawing.Size(191, 45);
            this.Topic1rdb.TabIndex = 28;
            this.Topic1rdb.TabStop = true;
            this.Topic1rdb.Text = "Mythology";
            this.Topic1rdb.UseVisualStyleBackColor = false;
            this.Topic1rdb.CheckedChanged += new System.EventHandler(this.Topic1rdb_CheckedChanged);
            // 
            // Mummificationrdb
            // 
            this.Mummificationrdb.AutoSize = true;
            this.Mummificationrdb.BackColor = System.Drawing.Color.Transparent;
            this.Mummificationrdb.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mummificationrdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mummificationrdb.Location = new System.Drawing.Point(16, 166);
            this.Mummificationrdb.Name = "Mummificationrdb";
            this.Mummificationrdb.Size = new System.Drawing.Size(250, 45);
            this.Mummificationrdb.TabIndex = 29;
            this.Mummificationrdb.TabStop = true;
            this.Mummificationrdb.Text = "Mummification";
            this.Mummificationrdb.UseVisualStyleBackColor = false;
            this.Mummificationrdb.CheckedChanged += new System.EventHandler(this.Mummificationrdb_CheckedChanged);
            // 
            // Historyrdb
            // 
            this.Historyrdb.AutoSize = true;
            this.Historyrdb.BackColor = System.Drawing.Color.Transparent;
            this.Historyrdb.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Historyrdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Historyrdb.Location = new System.Drawing.Point(16, 226);
            this.Historyrdb.Name = "Historyrdb";
            this.Historyrdb.Size = new System.Drawing.Size(141, 45);
            this.Historyrdb.TabIndex = 30;
            this.Historyrdb.TabStop = true;
            this.Historyrdb.Text = "History";
            this.Historyrdb.UseVisualStyleBackColor = false;
            this.Historyrdb.CheckedChanged += new System.EventHandler(this.Historyrdb_CheckedChanged);
            // 
            // Culturerdb
            // 
            this.Culturerdb.AutoSize = true;
            this.Culturerdb.BackColor = System.Drawing.Color.Transparent;
            this.Culturerdb.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Culturerdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Culturerdb.Location = new System.Drawing.Point(17, 286);
            this.Culturerdb.Name = "Culturerdb";
            this.Culturerdb.Size = new System.Drawing.Size(143, 45);
            this.Culturerdb.TabIndex = 31;
            this.Culturerdb.TabStop = true;
            this.Culturerdb.Text = "Culture";
            this.Culturerdb.UseVisualStyleBackColor = false;
            this.Culturerdb.CheckedChanged += new System.EventHandler(this.Culturerdb_CheckedChanged);
            // 
            // Specialrdb
            // 
            this.Specialrdb.AutoSize = true;
            this.Specialrdb.BackColor = System.Drawing.Color.Transparent;
            this.Specialrdb.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Specialrdb.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Specialrdb.Location = new System.Drawing.Point(17, 347);
            this.Specialrdb.Name = "Specialrdb";
            this.Specialrdb.Size = new System.Drawing.Size(171, 45);
            this.Specialrdb.TabIndex = 32;
            this.Specialrdb.TabStop = true;
            this.Specialrdb.Text = "Amun-Ra";
            this.Specialrdb.UseVisualStyleBackColor = false;
            this.Specialrdb.CheckedChanged += new System.EventHandler(this.Specialrdb_CheckedChanged);
            // 
            // LeaderboardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.BG6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1144, 554);
            this.Controls.Add(this.Specialrdb);
            this.Controls.Add(this.Culturerdb);
            this.Controls.Add(this.Historyrdb);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.Mummificationrdb);
            this.Controls.Add(this.Topic1rdb);
            this.Controls.Add(this.Overallrdb);
            this.Controls.Add(this.Explain2lbl);
            this.Controls.Add(this.Explain1lbl);
            this.Controls.Add(this.Shinygif);
            this.Controls.Add(this.Raimg);
            this.Controls.Add(this.Backbtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LeaderboardScreen";
            this.Text = "LeaderboardScreen";
            this.Load += new System.EventHandler(this.LeaderboardScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Shinygif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.PictureBox Raimg;
        private System.Windows.Forms.PictureBox Shinygif;
        private System.Windows.Forms.Label Explain1lbl;
        private System.Windows.Forms.Label Explain2lbl;
        private System.Windows.Forms.DataGridViewImageColumn Perfect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.RadioButton Overallrdb;
        private System.Windows.Forms.RadioButton Topic1rdb;
        private System.Windows.Forms.RadioButton Mummificationrdb;
        private System.Windows.Forms.RadioButton Historyrdb;
        private System.Windows.Forms.RadioButton Culturerdb;
        private System.Windows.Forms.RadioButton Specialrdb;
    }
}