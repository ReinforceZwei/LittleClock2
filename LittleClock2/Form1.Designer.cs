namespace LittleClock2
{
    partial class MainWin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWin));
            this.timeDisplayLabel = new System.Windows.Forms.Label();
            this.clockUpdateTimer = new System.Windows.Forms.Timer(this.components);
            this.mouseHoverTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconContentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeDisplayLabel
            // 
            this.timeDisplayLabel.AutoSize = true;
            this.timeDisplayLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeDisplayLabel.Location = new System.Drawing.Point(3, 3);
            this.timeDisplayLabel.Name = "timeDisplayLabel";
            this.timeDisplayLabel.Size = new System.Drawing.Size(54, 20);
            this.timeDisplayLabel.TabIndex = 0;
            this.timeDisplayLabel.Text = "label1";
            this.timeDisplayLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.timeDisplayLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.timeDisplayLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.timeDisplayLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.timeDisplayLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            // 
            // clockUpdateTimer
            // 
            this.clockUpdateTimer.Enabled = true;
            this.clockUpdateTimer.Interval = 500;
            this.clockUpdateTimer.Tick += new System.EventHandler(this.OnClockTimerTick);
            // 
            // mouseHoverTimer
            // 
            this.mouseHoverTimer.Interval = 200;
            this.mouseHoverTimer.Tick += new System.EventHandler(this.MouseHoverCheckTimerTick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.iconContentMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon1";
            this.notifyIcon.Visible = true;
            // 
            // iconContentMenu
            // 
            this.iconContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.iconContentMenu.Name = "iconContentMenu";
            this.iconContentMenu.Size = new System.Drawing.Size(120, 48);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnSettingMenuClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 27);
            this.Controls.Add(this.timeDisplayLabel);
            this.Name = "MainWin";
            this.Text = "Form1";
            this.iconContentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timeDisplayLabel;
        private System.Windows.Forms.Timer clockUpdateTimer;
        private System.Windows.Forms.Timer mouseHoverTimer;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip iconContentMenu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}