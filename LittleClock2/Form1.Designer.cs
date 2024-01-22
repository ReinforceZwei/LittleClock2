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
            this.mouseHoverTimer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.iconContentMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idleTimer = new System.Windows.Forms.Timer(this.components);
            this.alwaysOnTopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iconContentMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timeDisplayLabel
            // 
            this.timeDisplayLabel.AutoSize = true;
            this.timeDisplayLabel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.timeDisplayLabel.Location = new System.Drawing.Point(3, 2);
            this.timeDisplayLabel.Name = "timeDisplayLabel";
            this.timeDisplayLabel.Size = new System.Drawing.Size(54, 20);
            this.timeDisplayLabel.TabIndex = 0;
            this.timeDisplayLabel.Text = "label1";
            this.timeDisplayLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.timeDisplayLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.timeDisplayLabel.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.timeDisplayLabel.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.timeDisplayLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.timeDisplayLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
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
            this.notifyIcon.Text = "Little Clock 2";
            this.notifyIcon.Visible = true;
            // 
            // iconContentMenu
            // 
            this.iconContentMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alwaysOnTopToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.iconContentMenu.Name = "iconContentMenu";
            this.iconContentMenu.Size = new System.Drawing.Size(181, 92);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.OnSettingMenuClicked);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitMenuClicked);
            // 
            // idleTimer
            // 
            this.idleTimer.Tick += new System.EventHandler(this.idleTimer_Tick);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            this.alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            this.alwaysOnTopToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alwaysOnTopToolStripMenuItem.Text = "Always On Top";
            this.alwaysOnTopToolStripMenuItem.Click += new System.EventHandler(this.alwaysOnTopToolStripMenuItem_Click);
            // 
            // MainWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 27);
            this.Controls.Add(this.timeDisplayLabel);
            this.Name = "MainWin";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWin_FormClosing);
            this.iconContentMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label timeDisplayLabel;
        private System.Windows.Forms.Timer mouseHoverTimer;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip iconContentMenu;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer idleTimer;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
    }
}