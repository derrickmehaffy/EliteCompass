namespace Elite_Compass
{
    partial class Compass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Compass));
            this.edCompassNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.edCompassMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setHeadingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compassTimer = new System.Windows.Forms.Timer(this.components);
            this.HeadingRight = new System.Windows.Forms.Label();
            this.bearingLabel = new System.Windows.Forms.Label();
            this.HeadingLeft = new System.Windows.Forms.Label();
            this.edCompassMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // edCompassNotify
            // 
            this.edCompassNotify.ContextMenuStrip = this.edCompassMenu;
            this.edCompassNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("edCompassNotify.Icon")));
            this.edCompassNotify.Text = "Elite Compass";
            this.edCompassNotify.Visible = true;
            this.edCompassNotify.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.edCompassNotify_MouseDoubleClick);
            // 
            // edCompassMenu
            // 
            this.edCompassMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewToolStripMenuItem,
            this.setHeadingToolStripMenuItem,
            this.toolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.exitToolStripMenuItem});
            this.edCompassMenu.Name = "edCompassMenu";
            this.edCompassMenu.Size = new System.Drawing.Size(232, 126);
            this.edCompassMenu.Opening += new System.ComponentModel.CancelEventHandler(this.edCompassMenu_Opening);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F9)));
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewToolStripMenuItem.Text = "&View";
            this.viewToolStripMenuItem.Click += new System.EventHandler(this.viewToolStripMenuItem_Click);
            // 
            // setHeadingToolStripMenuItem
            // 
            this.setHeadingToolStripMenuItem.Name = "setHeadingToolStripMenuItem";
            this.setHeadingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F9)));
            this.setHeadingToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.setHeadingToolStripMenuItem.Text = "Set &Destination";
            this.setHeadingToolStripMenuItem.Click += new System.EventHandler(this.setHeadingToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(228, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(228, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // compassTimer
            // 
            this.compassTimer.Interval = 1000;
            this.compassTimer.Tick += new System.EventHandler(this.compassTimer_Tick);
            // 
            // HeadingRight
            // 
            this.HeadingRight.AutoSize = true;
            this.HeadingRight.BackColor = System.Drawing.Color.Transparent;
            this.HeadingRight.Font = new System.Drawing.Font("Wingdings 3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.HeadingRight.ForeColor = System.Drawing.Color.White;
            this.HeadingRight.Image = ((System.Drawing.Image)(resources.GetObject("HeadingRight.Image")));
            this.HeadingRight.Location = new System.Drawing.Point(115, 4);
            this.HeadingRight.Name = "HeadingRight";
            this.HeadingRight.Size = new System.Drawing.Size(96, 73);
            this.HeadingRight.TabIndex = 0;
            this.HeadingRight.Text = " ";
            this.HeadingRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadingRight.Click += new System.EventHandler(this.HeadingRight_Click);
            this.HeadingRight.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingRight_MouseDown);
            // 
            // bearingLabel
            // 
            this.bearingLabel.BackColor = System.Drawing.Color.Transparent;
            this.bearingLabel.Font = new System.Drawing.Font("Courier Std", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bearingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(202)))), ((int)(((byte)(195)))));
            this.bearingLabel.Location = new System.Drawing.Point(70, 23);
            this.bearingLabel.Name = "bearingLabel";
            this.bearingLabel.Size = new System.Drawing.Size(74, 37);
            this.bearingLabel.TabIndex = 7;
            this.bearingLabel.Text = "000";
            this.bearingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bearingLabel.Click += new System.EventHandler(this.bearingLabel_Click);
            this.bearingLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bearingLabel_MouseDown);
            // 
            // HeadingLeft
            // 
            this.HeadingLeft.AutoSize = true;
            this.HeadingLeft.BackColor = System.Drawing.Color.Transparent;
            this.HeadingLeft.Font = new System.Drawing.Font("Wingdings 3", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.HeadingLeft.ForeColor = System.Drawing.Color.White;
            this.HeadingLeft.Image = ((System.Drawing.Image)(resources.GetObject("HeadingLeft.Image")));
            this.HeadingLeft.Location = new System.Drawing.Point(5, 4);
            this.HeadingLeft.Name = "HeadingLeft";
            this.HeadingLeft.Size = new System.Drawing.Size(96, 73);
            this.HeadingLeft.TabIndex = 8;
            this.HeadingLeft.Text = " ";
            this.HeadingLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HeadingLeft.Click += new System.EventHandler(this.HeadingLeft_Click);
            this.HeadingLeft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeadingLeft_MouseDown);
            // 
            // Compass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(215, 80);
            this.ControlBox = false;
            this.Controls.Add(this.bearingLabel);
            this.Controls.Add(this.HeadingRight);
            this.Controls.Add(this.HeadingLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Compass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compass";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Compass_FormClosing);
            this.Load += new System.EventHandler(this.Compass_Load);
            this.edCompassMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon edCompassNotify;
        private System.Windows.Forms.ContextMenuStrip edCompassMenu;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setHeadingToolStripMenuItem;
        private System.Windows.Forms.Timer compassTimer;
        private System.Windows.Forms.Label HeadingRight;
        private System.Windows.Forms.Label bearingLabel;
        private System.Windows.Forms.Label HeadingLeft;
    }
}

