namespace GameBoyEmulator {
  partial class GameForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.catridgeInfoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.copyImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveImageAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x6ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x7ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.x8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.maxFramesSkippedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.skip0 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip1 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip2 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip4 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip6 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip8 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip10 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip20 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip50 = new System.Windows.Forms.ToolStripMenuItem();
      this.skip100 = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(292, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.catridgeInfoMenuItem,
            this.toolStripSeparator2,
            this.copyImageMenuItem,
            this.saveImageAsMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openToolStripMenuItem
      // 
      this.openToolStripMenuItem.Name = "openToolStripMenuItem";
      this.openToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.openToolStripMenuItem.Text = "Open...";
      this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
      // 
      // catridgeInfoMenuItem
      // 
      this.catridgeInfoMenuItem.Enabled = false;
      this.catridgeInfoMenuItem.Name = "catridgeInfoMenuItem";
      this.catridgeInfoMenuItem.Size = new System.Drawing.Size(169, 22);
      this.catridgeInfoMenuItem.Text = "Cartridge Info";
      this.catridgeInfoMenuItem.Click += new System.EventHandler(this.catridgeInfoMenuItem_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
      // 
      // copyImageMenuItem
      // 
      this.copyImageMenuItem.Name = "copyImageMenuItem";
      this.copyImageMenuItem.Size = new System.Drawing.Size(169, 22);
      this.copyImageMenuItem.Text = "Copy Image";
      this.copyImageMenuItem.Click += new System.EventHandler(this.copyImageMenuItem_Click);
      // 
      // saveImageAsMenuItem
      // 
      this.saveImageAsMenuItem.Name = "saveImageAsMenuItem";
      this.saveImageAsMenuItem.Size = new System.Drawing.Size(169, 22);
      this.saveImageAsMenuItem.Text = "Save Image As...";
      this.saveImageAsMenuItem.Click += new System.EventHandler(this.saveImageAsMenuItem_Click_1);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(166, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.videoToolStripMenuItem,
            this.maxFramesSkippedToolStripMenuItem});
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
      this.optionsToolStripMenuItem.Text = "Options";
      // 
      // videoToolStripMenuItem
      // 
      this.videoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x1ToolStripMenuItem,
            this.x2ToolStripMenuItem,
            this.x3ToolStripMenuItem,
            this.x4ToolStripMenuItem,
            this.x5ToolStripMenuItem,
            this.x6ToolStripMenuItem,
            this.x7ToolStripMenuItem,
            this.x8ToolStripMenuItem});
      this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
      this.videoToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
      this.videoToolStripMenuItem.Text = "Video";
      // 
      // x1ToolStripMenuItem
      // 
      this.x1ToolStripMenuItem.Name = "x1ToolStripMenuItem";
      this.x1ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x1ToolStripMenuItem.Tag = "1";
      this.x1ToolStripMenuItem.Text = "x1";
      this.x1ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // x2ToolStripMenuItem
      // 
      this.x2ToolStripMenuItem.Checked = true;
      this.x2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.x2ToolStripMenuItem.Name = "x2ToolStripMenuItem";
      this.x2ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x2ToolStripMenuItem.Tag = "2";
      this.x2ToolStripMenuItem.Text = "x2";
      this.x2ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // x3ToolStripMenuItem
      // 
      this.x3ToolStripMenuItem.Name = "x3ToolStripMenuItem";
      this.x3ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x3ToolStripMenuItem.Tag = "3";
      this.x3ToolStripMenuItem.Text = "x3";
      this.x3ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // x4ToolStripMenuItem
      // 
      this.x4ToolStripMenuItem.Name = "x4ToolStripMenuItem";
      this.x4ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x4ToolStripMenuItem.Tag = "4";
      this.x4ToolStripMenuItem.Text = "x4";
      this.x4ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // x5ToolStripMenuItem
      // 
      this.x5ToolStripMenuItem.Name = "x5ToolStripMenuItem";
      this.x5ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x5ToolStripMenuItem.Tag = "5";
      this.x5ToolStripMenuItem.Text = "x5";
      this.x5ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // x6ToolStripMenuItem
      // 
      this.x6ToolStripMenuItem.Name = "x6ToolStripMenuItem";
      this.x6ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x6ToolStripMenuItem.Tag = "6";
      this.x6ToolStripMenuItem.Text = "x6";
      this.x6ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // x7ToolStripMenuItem
      // 
      this.x7ToolStripMenuItem.Name = "x7ToolStripMenuItem";
      this.x7ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x7ToolStripMenuItem.Tag = "7";
      this.x7ToolStripMenuItem.Text = "x7";
      this.x7ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // x8ToolStripMenuItem
      // 
      this.x8ToolStripMenuItem.Name = "x8ToolStripMenuItem";
      this.x8ToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
      this.x8ToolStripMenuItem.Tag = "8";
      this.x8ToolStripMenuItem.Text = "x8";
      this.x8ToolStripMenuItem.Click += new System.EventHandler(this.videoSizeMenuItemClicked);
      // 
      // maxFramesSkippedToolStripMenuItem
      // 
      this.maxFramesSkippedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.skip0,
            this.skip1,
            this.skip2,
            this.skip4,
            this.skip6,
            this.skip8,
            this.skip10,
            this.skip20,
            this.skip50,
            this.skip100});
      this.maxFramesSkippedToolStripMenuItem.Name = "maxFramesSkippedToolStripMenuItem";
      this.maxFramesSkippedToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
      this.maxFramesSkippedToolStripMenuItem.Text = "Max Frames Skipped";
      // 
      // skip0
      // 
      this.skip0.Name = "skip0";
      this.skip0.Size = new System.Drawing.Size(103, 22);
      this.skip0.Tag = "0";
      this.skip0.Text = "0";
      this.skip0.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip1
      // 
      this.skip1.Name = "skip1";
      this.skip1.Size = new System.Drawing.Size(103, 22);
      this.skip1.Tag = "1";
      this.skip1.Text = "1";
      this.skip1.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip2
      // 
      this.skip2.Name = "skip2";
      this.skip2.Size = new System.Drawing.Size(103, 22);
      this.skip2.Tag = "2";
      this.skip2.Text = "2";
      this.skip2.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip4
      // 
      this.skip4.Name = "skip4";
      this.skip4.Size = new System.Drawing.Size(103, 22);
      this.skip4.Tag = "4";
      this.skip4.Text = "4";
      this.skip4.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip6
      // 
      this.skip6.Name = "skip6";
      this.skip6.Size = new System.Drawing.Size(103, 22);
      this.skip6.Tag = "6";
      this.skip6.Text = "6";
      this.skip6.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip8
      // 
      this.skip8.Name = "skip8";
      this.skip8.Size = new System.Drawing.Size(103, 22);
      this.skip8.Tag = "8";
      this.skip8.Text = "8";
      this.skip8.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip10
      // 
      this.skip10.Checked = true;
      this.skip10.CheckState = System.Windows.Forms.CheckState.Checked;
      this.skip10.Name = "skip10";
      this.skip10.Size = new System.Drawing.Size(103, 22);
      this.skip10.Tag = "10";
      this.skip10.Text = "10";
      this.skip10.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip20
      // 
      this.skip20.Name = "skip20";
      this.skip20.Size = new System.Drawing.Size(103, 22);
      this.skip20.Tag = "20";
      this.skip20.Text = "20";
      this.skip20.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip50
      // 
      this.skip50.Name = "skip50";
      this.skip50.Size = new System.Drawing.Size(103, 22);
      this.skip50.Tag = "50";
      this.skip50.Text = "50";
      this.skip50.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // skip100
      // 
      this.skip100.Name = "skip100";
      this.skip100.Size = new System.Drawing.Size(103, 22);
      this.skip100.Tag = "100";
      this.skip100.Text = "100";
      this.skip100.Click += new System.EventHandler(this.maxFramesSkippedMenuItemClicked);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // openFileDialog
      // 
      this.openFileDialog.AddExtension = false;
      this.openFileDialog.Filter = "Game Boy files|*.gb|All files|*.*";
      this.openFileDialog.Title = "Select ROM";
      // 
      // GameForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(292, 266);
      this.Controls.Add(this.menuStrip1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "GameForm";
      this.Text = "Game Boy Emulator";
      this.Load += new System.EventHandler(this.GameForm_Load);
      this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameForm_Paint);
      this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyUp);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameForm_KeyDown);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x1ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x2ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x3ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x4ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x5ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x6ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x7ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem x8ToolStripMenuItem;
    private System.Windows.Forms.OpenFileDialog openFileDialog;
    private System.Windows.Forms.ToolStripMenuItem maxFramesSkippedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem skip0;
    private System.Windows.Forms.ToolStripMenuItem skip1;
    private System.Windows.Forms.ToolStripMenuItem skip2;
    private System.Windows.Forms.ToolStripMenuItem skip4;
    private System.Windows.Forms.ToolStripMenuItem skip6;
    private System.Windows.Forms.ToolStripMenuItem skip8;
    private System.Windows.Forms.ToolStripMenuItem skip10;
    private System.Windows.Forms.ToolStripMenuItem skip20;
    private System.Windows.Forms.ToolStripMenuItem skip50;
    private System.Windows.Forms.ToolStripMenuItem skip100;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem catridgeInfoMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripMenuItem copyImageMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveImageAsMenuItem;

  }
}