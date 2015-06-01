namespace ConsoleBot
{
    partial class TalkingHeadApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkingHeadApp));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newChatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talkToAtlasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talkToAliceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAIMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAtlasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheTeamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configurePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.volumeBar = new System.Windows.Forms.TrackBar();
            this.volumelbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rateBar = new System.Windows.Forms.TrackBar();
            this.ratelbl = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.configurePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(12, 487);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(635, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(653, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(12, 28);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(214, 453);
            this.textBox2.TabIndex = 4;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configuresToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 25);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newChatToolStripMenuItem,
            this.talkToAtlasToolStripMenuItem,
            this.talkToAliceToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.fileToolStripMenuItem.Text = "I want to...";
            // 
            // newChatToolStripMenuItem
            // 
            this.newChatToolStripMenuItem.Name = "newChatToolStripMenuItem";
            this.newChatToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.newChatToolStripMenuItem.Text = "Start a new chat";
            this.newChatToolStripMenuItem.Click += new System.EventHandler(this.newChatToolStripMenuItem_Click);
            // 
            // talkToAtlasToolStripMenuItem
            // 
            this.talkToAtlasToolStripMenuItem.Name = "talkToAtlasToolStripMenuItem";
            this.talkToAtlasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.talkToAtlasToolStripMenuItem.Text = "Talk to Atlas";
            this.talkToAtlasToolStripMenuItem.Click += new System.EventHandler(this.talkToAtlasToolStripMenuItem_Click);
            // 
            // talkToAliceToolStripMenuItem
            // 
            this.talkToAliceToolStripMenuItem.Name = "talkToAliceToolStripMenuItem";
            this.talkToAliceToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.talkToAliceToolStripMenuItem.Text = "Talk to Alice";
            this.talkToAliceToolStripMenuItem.Click += new System.EventHandler(this.talkToAliceToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // configuresToolStripMenuItem
            // 
            this.configuresToolStripMenuItem.Name = "configuresToolStripMenuItem";
            this.configuresToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.configuresToolStripMenuItem.Text = "Configures";
            this.configuresToolStripMenuItem.Click += new System.EventHandler(this.configuresToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAIMLToolStripMenuItem,
            this.aboutAtlasToolStripMenuItem,
            this.aboutTheTeamToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutAIMLToolStripMenuItem
            // 
            this.aboutAIMLToolStripMenuItem.Name = "aboutAIMLToolStripMenuItem";
            this.aboutAIMLToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutAIMLToolStripMenuItem.Text = "About AIML";
            this.aboutAIMLToolStripMenuItem.Click += new System.EventHandler(this.aboutAIMLToolStripMenuItem_Click);
            // 
            // aboutAtlasToolStripMenuItem
            // 
            this.aboutAtlasToolStripMenuItem.Name = "aboutAtlasToolStripMenuItem";
            this.aboutAtlasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutAtlasToolStripMenuItem.Text = "About Atlas";
            this.aboutAtlasToolStripMenuItem.Click += new System.EventHandler(this.aboutAtlasToolStripMenuItem_Click);
            // 
            // aboutTheTeamToolStripMenuItem
            // 
            this.aboutTheTeamToolStripMenuItem.Name = "aboutTheTeamToolStripMenuItem";
            this.aboutTheTeamToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.aboutTheTeamToolStripMenuItem.Text = "About the Team";
            this.aboutTheTeamToolStripMenuItem.Click += new System.EventHandler(this.aboutTheTeamToolStripMenuItem_Click);
            // 
            // configurePanel
            // 
            this.configurePanel.BackColor = System.Drawing.Color.Transparent;
            this.configurePanel.Controls.Add(this.pictureBox2);
            this.configurePanel.Controls.Add(this.volumeBar);
            this.configurePanel.Controls.Add(this.volumelbl);
            this.configurePanel.Controls.Add(this.button3);
            this.configurePanel.Controls.Add(this.rateBar);
            this.configurePanel.Controls.Add(this.ratelbl);
            this.configurePanel.Controls.Add(this.button2);
            this.configurePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.configurePanel.Location = new System.Drawing.Point(0, 25);
            this.configurePanel.Name = "configurePanel";
            this.configurePanel.Size = new System.Drawing.Size(740, 55);
            this.configurePanel.TabIndex = 6;
            this.configurePanel.Visible = false;
            this.configurePanel.MouseLeave += new System.EventHandler(this.configurePanel_MouseLeave);
            this.configurePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.configurePanel_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ConsoleBot.Properties.Resources.volume_on;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(472, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(27, 26);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // volumeBar
            // 
            this.volumeBar.Location = new System.Drawing.Point(262, 23);
            this.volumeBar.Maximum = 100;
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(213, 45);
            this.volumeBar.TabIndex = 5;
            this.volumeBar.Value = 80;
            this.volumeBar.Scroll += new System.EventHandler(this.volumeBar_Scroll);
            // 
            // volumelbl
            // 
            this.volumelbl.AutoSize = true;
            this.volumelbl.Location = new System.Drawing.Point(269, 8);
            this.volumelbl.Name = "volumelbl";
            this.volumelbl.Size = new System.Drawing.Size(47, 12);
            this.volumelbl.TabIndex = 4;
            this.volumelbl.Text = "Volume:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(653, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 3;
            this.button3.Text = "Default";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button3_MouseMove);
            // 
            // rateBar
            // 
            this.rateBar.Location = new System.Drawing.Point(15, 23);
            this.rateBar.Minimum = -10;
            this.rateBar.Name = "rateBar";
            this.rateBar.Size = new System.Drawing.Size(213, 45);
            this.rateBar.TabIndex = 2;
            this.rateBar.Scroll += new System.EventHandler(this.rateBar_Scroll);
            // 
            // ratelbl
            // 
            this.ratelbl.AutoSize = true;
            this.ratelbl.Location = new System.Drawing.Point(21, 8);
            this.ratelbl.Name = "ratelbl";
            this.ratelbl.Size = new System.Drawing.Size(89, 12);
            this.ratelbl.TabIndex = 1;
            this.ratelbl.Text = "Talking Speed:";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(653, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 0;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button2_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(232, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 452);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.textBox2_Click);
            // 
            // TalkingHeadApp
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 533);
            this.Controls.Add(this.configurePanel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TalkingHeadApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Talking Head Application - Team Atlas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Enter += new System.EventHandler(this.button1_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.configurePanel.ResumeLayout(false);
            this.configurePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.volumeBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rateBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newChatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAIMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAtlasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheTeamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talkToAtlasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talkToAliceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuresToolStripMenuItem;
        private System.Windows.Forms.Panel configurePanel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label ratelbl;
        private System.Windows.Forms.TrackBar rateBar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TrackBar volumeBar;
        private System.Windows.Forms.Label volumelbl;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}