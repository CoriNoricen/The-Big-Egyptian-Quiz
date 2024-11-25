namespace The_Big_Egyptian_Quiz
{
    partial class qTypeTwo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(qTypeTwo));
            this.Answertxt = new System.Windows.Forms.TextBox();
            this.Questionlbl = new System.Windows.Forms.Label();
            this.Raimg = new System.Windows.Forms.PictureBox();
            this.Speechimg = new System.Windows.Forms.PictureBox();
            this.SetupOnelbl = new System.Windows.Forms.Label();
            this.SetupTwolbl = new System.Windows.Forms.Label();
            this.Forwardbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Raimg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speechimg)).BeginInit();
            this.SuspendLayout();
            // 
            // Answertxt
            // 
            this.Answertxt.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answertxt.Location = new System.Drawing.Point(772, 428);
            this.Answertxt.Name = "Answertxt";
            this.Answertxt.Size = new System.Drawing.Size(373, 48);
            this.Answertxt.TabIndex = 0;
            this.Answertxt.TextChanged += new System.EventHandler(this.Answertxt_TextChanged);
            // 
            // Questionlbl
            // 
            this.Questionlbl.AutoSize = true;
            this.Questionlbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Questionlbl.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Questionlbl.Location = new System.Drawing.Point(355, 104);
            this.Questionlbl.Name = "Questionlbl";
            this.Questionlbl.Size = new System.Drawing.Size(358, 45);
            this.Questionlbl.TabIndex = 4;
            this.Questionlbl.Text = "[Insert Question Here]";
            // 
            // Raimg
            // 
            this.Raimg.BackColor = System.Drawing.Color.Transparent;
            this.Raimg.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Ra_Flat_R_Head;
            this.Raimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Raimg.Location = new System.Drawing.Point(-14, 240);
            this.Raimg.Name = "Raimg";
            this.Raimg.Size = new System.Drawing.Size(369, 332);
            this.Raimg.TabIndex = 8;
            this.Raimg.TabStop = false;
            // 
            // Speechimg
            // 
            this.Speechimg.BackColor = System.Drawing.Color.Transparent;
            this.Speechimg.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.pixil_frame_0;
            this.Speechimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Speechimg.Location = new System.Drawing.Point(269, 48);
            this.Speechimg.Name = "Speechimg";
            this.Speechimg.Size = new System.Drawing.Size(1055, 392);
            this.Speechimg.TabIndex = 9;
            this.Speechimg.TabStop = false;
            // 
            // SetupOnelbl
            // 
            this.SetupOnelbl.AutoSize = true;
            this.SetupOnelbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SetupOnelbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupOnelbl.Location = new System.Drawing.Point(324, 176);
            this.SetupOnelbl.Name = "SetupOnelbl";
            this.SetupOnelbl.Size = new System.Drawing.Size(361, 48);
            this.SetupOnelbl.TabIndex = 11;
            this.SetupOnelbl.Text = "Beginning of Question...";
            // 
            // SetupTwolbl
            // 
            this.SetupTwolbl.AutoSize = true;
            this.SetupTwolbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SetupTwolbl.Font = new System.Drawing.Font("Papyrus", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetupTwolbl.Location = new System.Drawing.Point(394, 253);
            this.SetupTwolbl.Name = "SetupTwolbl";
            this.SetupTwolbl.Size = new System.Drawing.Size(361, 48);
            this.SetupTwolbl.TabIndex = 12;
            this.SetupTwolbl.Text = "Beginning of Question...";
            // 
            // Forwardbtn
            // 
            this.Forwardbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Forwardbtn.BackgroundImage = global::The_Big_Egyptian_Quiz.Properties.Resources.Blank_3;
            this.Forwardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Forwardbtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Forwardbtn.Location = new System.Drawing.Point(841, 496);
            this.Forwardbtn.Name = "Forwardbtn";
            this.Forwardbtn.Size = new System.Drawing.Size(238, 54);
            this.Forwardbtn.TabIndex = 13;
            this.Forwardbtn.Text = "SUBMIT";
            this.Forwardbtn.UseVisualStyleBackColor = false;
            this.Forwardbtn.Visible = false;
            this.Forwardbtn.Click += new System.EventHandler(this.Forwardbtn_Click);
            // 
            // qTypeTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1429, 576);
            this.Controls.Add(this.Forwardbtn);
            this.Controls.Add(this.SetupTwolbl);
            this.Controls.Add(this.SetupOnelbl);
            this.Controls.Add(this.Questionlbl);
            this.Controls.Add(this.Answertxt);
            this.Controls.Add(this.Speechimg);
            this.Controls.Add(this.Raimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "qTypeTwo";
            this.Text = "qTypeTwo";
            ((System.ComponentModel.ISupportInitialize)(this.Raimg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Speechimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Answertxt;
        private System.Windows.Forms.Label Questionlbl;
        private System.Windows.Forms.PictureBox Raimg;
        private System.Windows.Forms.PictureBox Speechimg;
        private System.Windows.Forms.Label SetupOnelbl;
        private System.Windows.Forms.Label SetupTwolbl;
        private System.Windows.Forms.Button Forwardbtn;
    }
}