namespace WaveStacker
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorGithubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thirdPartyLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebuildWSYSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bxWaveGroups = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.wavesList = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lbSoundID = new System.Windows.Forms.Label();
            this.cbIsLoop = new System.Windows.Forms.CheckBox();
            this.nuLoopStart = new System.Windows.Forms.NumericUpDown();
            this.nuLoopEnd = new System.Windows.Forms.NumericUpDown();
            this.lbLoopStart = new System.Windows.Forms.Label();
            this.lbLoopEnd = new System.Windows.Forms.Label();
            this.lbSampleRate = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuLoopStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLoopEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openWSYSToolStripMenuItem,
            this.closeProjectToolStripMenuItem,
            this.rebuildWSYSToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // openWSYSToolStripMenuItem
            // 
            this.openWSYSToolStripMenuItem.Name = "openWSYSToolStripMenuItem";
            this.openWSYSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openWSYSToolStripMenuItem.Text = "Open WSYS";
            this.openWSYSToolStripMenuItem.Click += new System.EventHandler(this.openWSYSToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorGithubToolStripMenuItem,
            this.thirdPartyLicensesToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // authorGithubToolStripMenuItem
            // 
            this.authorGithubToolStripMenuItem.Name = "authorGithubToolStripMenuItem";
            this.authorGithubToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.authorGithubToolStripMenuItem.Text = "Author Github";
            // 
            // thirdPartyLicensesToolStripMenuItem
            // 
            this.thirdPartyLicensesToolStripMenuItem.Name = "thirdPartyLicensesToolStripMenuItem";
            this.thirdPartyLicensesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thirdPartyLicensesToolStripMenuItem.Text = "Third party licenses";
            // 
            // closeProjectToolStripMenuItem
            // 
            this.closeProjectToolStripMenuItem.Name = "closeProjectToolStripMenuItem";
            this.closeProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeProjectToolStripMenuItem.Text = "Close project";
            // 
            // rebuildWSYSToolStripMenuItem
            // 
            this.rebuildWSYSToolStripMenuItem.Name = "rebuildWSYSToolStripMenuItem";
            this.rebuildWSYSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rebuildWSYSToolStripMenuItem.Text = "Rebuild WSYS";
            this.rebuildWSYSToolStripMenuItem.Click += new System.EventHandler(this.rebuildWSYSToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "----";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // bxWaveGroups
            // 
            this.bxWaveGroups.Enabled = false;
            this.bxWaveGroups.FormattingEnabled = true;
            this.bxWaveGroups.Location = new System.Drawing.Point(12, 46);
            this.bxWaveGroups.Name = "bxWaveGroups";
            this.bxWaveGroups.Size = new System.Drawing.Size(315, 654);
            this.bxWaveGroups.TabIndex = 1;
            this.bxWaveGroups.SelectedIndexChanged += new System.EventHandler(this.bxWaveGroups_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Groups";
            // 
            // wavesList
            // 
            this.wavesList.FormattingEnabled = true;
            this.wavesList.Location = new System.Drawing.Point(333, 150);
            this.wavesList.Name = "wavesList";
            this.wavesList.Size = new System.Drawing.Size(350, 550);
            this.wavesList.TabIndex = 3;
            this.wavesList.SelectedIndexChanged += new System.EventHandler(this.wavesList_SelectedIndexChanged);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(689, 357);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(303, 44);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lbSoundID
            // 
            this.lbSoundID.AutoSize = true;
            this.lbSoundID.Location = new System.Drawing.Point(689, 191);
            this.lbSoundID.Name = "lbSoundID";
            this.lbSoundID.Size = new System.Drawing.Size(21, 13);
            this.lbSoundID.TabIndex = 5;
            this.lbSoundID.Text = "ID:";
            // 
            // cbIsLoop
            // 
            this.cbIsLoop.AutoSize = true;
            this.cbIsLoop.Location = new System.Drawing.Point(692, 253);
            this.cbIsLoop.Name = "cbIsLoop";
            this.cbIsLoop.Size = new System.Drawing.Size(50, 17);
            this.cbIsLoop.TabIndex = 6;
            this.cbIsLoop.Text = "Loop";
            this.cbIsLoop.UseVisualStyleBackColor = true;
            // 
            // nuLoopStart
            // 
            this.nuLoopStart.Location = new System.Drawing.Point(692, 276);
            this.nuLoopStart.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.nuLoopStart.Name = "nuLoopStart";
            this.nuLoopStart.Size = new System.Drawing.Size(82, 20);
            this.nuLoopStart.TabIndex = 7;
            // 
            // nuLoopEnd
            // 
            this.nuLoopEnd.Location = new System.Drawing.Point(692, 302);
            this.nuLoopEnd.Maximum = new decimal(new int[] {
            1316134911,
            2328,
            0,
            0});
            this.nuLoopEnd.Name = "nuLoopEnd";
            this.nuLoopEnd.Size = new System.Drawing.Size(82, 20);
            this.nuLoopEnd.TabIndex = 8;
            // 
            // lbLoopStart
            // 
            this.lbLoopStart.AutoSize = true;
            this.lbLoopStart.Location = new System.Drawing.Point(781, 282);
            this.lbLoopStart.Name = "lbLoopStart";
            this.lbLoopStart.Size = new System.Drawing.Size(56, 13);
            this.lbLoopStart.TabIndex = 9;
            this.lbLoopStart.Text = "Loop Start";
            // 
            // lbLoopEnd
            // 
            this.lbLoopEnd.AutoSize = true;
            this.lbLoopEnd.Location = new System.Drawing.Point(781, 304);
            this.lbLoopEnd.Name = "lbLoopEnd";
            this.lbLoopEnd.Size = new System.Drawing.Size(53, 13);
            this.lbLoopEnd.TabIndex = 10;
            this.lbLoopEnd.Text = "Loop End";
            // 
            // lbSampleRate
            // 
            this.lbSampleRate.AutoSize = true;
            this.lbSampleRate.Location = new System.Drawing.Point(689, 204);
            this.lbSampleRate.Name = "lbSampleRate";
            this.lbSampleRate.Size = new System.Drawing.Size(68, 13);
            this.lbSampleRate.TabIndex = 11;
            this.lbSampleRate.Text = "SampleRate:";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(689, 408);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(303, 47);
            this.btnReplace.TabIndex = 12;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 727);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.lbSampleRate);
            this.Controls.Add(this.lbLoopEnd);
            this.Controls.Add(this.lbLoopStart);
            this.Controls.Add(this.nuLoopEnd);
            this.Controls.Add(this.nuLoopStart);
            this.Controls.Add(this.cbIsLoop);
            this.Controls.Add(this.lbSoundID);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.wavesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bxWaveGroups);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "WaveStacker";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuLoopStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuLoopEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openWSYSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebuildWSYSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem authorGithubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thirdPartyLicensesToolStripMenuItem;
        private System.Windows.Forms.ListBox bxWaveGroups;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wavesList;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lbSoundID;
        private System.Windows.Forms.CheckBox cbIsLoop;
        private System.Windows.Forms.NumericUpDown nuLoopStart;
        private System.Windows.Forms.NumericUpDown nuLoopEnd;
        private System.Windows.Forms.Label lbLoopStart;
        private System.Windows.Forms.Label lbLoopEnd;
        private System.Windows.Forms.Label lbSampleRate;
        private System.Windows.Forms.Button btnReplace;
    }
}

