using Microsoft.Win32;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Timers;

namespace LittleClock2
{
    delegate void InvokeUpdateSettings(Settings settings);

    public partial class MainWin : Form
    {
        private Settings settings;
        private SettingsWin? settingsWin = null;

        // Dragging handle
        private bool isDragging = false;
        private Size mouseRelativePos;

        private int initialStyle;

        private System.Timers.Timer clockUpdateTimer;
        private System.Windows.Forms.Timer topMostCheckTimer;

        public MainWin()
        {
            settings = Settings.LoadFromDisk();

            InitializeComponent();
            InitializeStyle();

            // Initialize topmost check timer
            topMostCheckTimer = new System.Windows.Forms.Timer();
            topMostCheckTimer.Interval = 10000; // 10 seconds
            topMostCheckTimer.Tick += OnTopMostCheckTick;
            if (settings.AlwaysOnTop && settings.ForceAlwaysOnTop)
            {
                topMostCheckTimer.Start();
            }

            clockUpdateTimer = new System.Timers.Timer();
            clockUpdateTimer.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds;
            clockUpdateTimer.AutoReset = true;
            clockUpdateTimer.Elapsed += OnClockTimerTick;
            clockUpdateTimer.Start();

            idleTimer.Interval = settings.IdleAfter;
            idleTimer.Enabled = true;
            idleTimer.Start();

            initialStyle = GetWindowLong(this.Handle, -20);

            //var initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | WS_EX_TOOLWINDOW);
            initialStyle = GetWindowLong(this.Handle, -20);
            //EnableClickThrough();
            ApplySettings();

            SystemEvents.DisplaySettingsChanged += OnDisplaySettingsChange;

            string debug = Environment.GetEnvironmentVariable("LITTLECLOCK_DEBUG") ?? "false";
            if (bool.Parse(debug))
            {
                OpenSettingsWindow();
            }
        }

        public void InitializeStyle()
        {
            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
        }

        public void ApplySettings(Settings newSettings)
        {
            if (InvokeRequired)
            {
                Invoke(new InvokeUpdateSettings(ApplySettings), newSettings);
                return;
            }
            settings = Settings.Clone(newSettings);
            ApplySettings();
        }

        public void ApplySettings()
        {
            TopMost = settings.AlwaysOnTop;
            alwaysOnTopToolStripMenuItem.Checked = settings.AlwaysOnTop;

            if (settings.AlwaysOnTop && settings.ForceAlwaysOnTop)
            {
                topMostCheckTimer.Enabled = true;
            }
            else
            {
                topMostCheckTimer.Enabled = false;
            }

            if (settings.ClickThrough)
                EnableClickThrough();
            else
                DisableClickThrough();

            var font = new Font(settings.FontFamily, settings.FontSize, settings.FontStyle);
            var size = TextRenderer.MeasureText(DateTime.Now.ToString(settings.TimeFormat), font);
            Debug.WriteLine($"Measured size: w{size.Width} x h{size.Height}");

            timeDisplayLabel.Font = font;
            BackColor = Color.FromArgb(settings.BackgrouldColorArgb);
            timeDisplayLabel.ForeColor = Color.FromArgb(settings.TextColorArgb);

            UpdateClockText();
            Width = size.Width + 6; //timeDisplayLabel.Width + 5;
            Height = size.Height + settings.BottomPadding;
            if (settings.UseRoundedCorner)
            {
                Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            }
            else
            {
                Region = null;
            }

            idleTimer.Interval = settings.IdleAfter;
            Opacity = settings.IdleOpacity;

            if (settings.UsePresetLocation)
            {
                UpdateWindowRelativeLocation();
            }
            else
            {
                Location = settings.Location;
            }

            settings.SaveToDisk();

            settingsWin?.NotifyMainWinLocationChange(Location);
        }

        public void TestSettings()
        {
            if (InvokeRequired)
            {
                Invoke(TestSettings);
                return;
            }
            //Region = null;
            Debug.WriteLine($"w{Width} x h{Height}");
        }

        public void UpdateClockText()
        {
            timeDisplayLabel.Text = DateTime.Now.ToString(settings.TimeFormat);
        }

        public void UpdateWindowRelativeLocation()
        {
            var monitorSize = Screen.FromControl(this).Bounds.Size;
            var relativeSize = new Size(monitorSize.Width - this.Width, monitorSize.Height - this.Height);
            int locationX = settings.PresetLocation switch
            {
                PresetLocation.TopLeft or PresetLocation.Left or PresetLocation.BottomLeft => 0,
                PresetLocation.Top or PresetLocation.Center or PresetLocation.Bottom => relativeSize.Width / 2,
                PresetLocation.TopRight or PresetLocation.Right or PresetLocation.BottomRight => relativeSize.Width,
                _ => throw new InvalidOperationException("Invalid preset location")
            };
            var locationY = settings.PresetLocation switch
            {
                PresetLocation.TopLeft or PresetLocation.Top or PresetLocation.TopRight => 0,
                PresetLocation.Left or PresetLocation.Center or PresetLocation.Right => relativeSize.Height / 2,
                PresetLocation.BottomLeft or PresetLocation.Bottom or PresetLocation.BottomRight => relativeSize.Height,
                _ => throw new InvalidOperationException("Invalid preset location")
            };
            this.Location = new Point(locationX, locationY);
            settings.Location = Location;
            settings.SaveToDisk();
        }

        private void EnableClickThrough()
        {
            SetWindowLong(this.Handle, -20, initialStyle | WS_EX_LAYERED | WS_EX_TRANSPARENT);
        }

        private void DisableClickThrough()
        {
            SetWindowLong(this.Handle, -20, initialStyle | WS_EX_LAYERED);
        }

        private async void FadeIn(Form o, double opacity = 1, int interval = 80)
        {
            //Object is not fully invisible. Fade it in
            while (o.Opacity < opacity)
            {
                await Task.Delay(interval);
                o.Opacity += 0.05;
            }
            o.Opacity = opacity; //make fully visible
        }

        private async void FadeOut(Form o, double opacity = 0.1, int interval = 80)
        {
            //Object is fully visible. Fade it out
            while (o.Opacity > opacity)
            {
                await Task.Delay(interval);
                o.Opacity -= 0.05;
            }
            o.Opacity = opacity; //make fully invisible       
        }

        private void OpenSettingsWindow()
        {
            if (settingsWin is null)
            {
                settingsWin = new SettingsWin(settings, this);
                settingsWin.FormClosed += (o, a) =>
                {
                    settingsWin = null;
                };
                settingsWin.Show();
            }
            else
            {
                settingsWin.Activate();
            }
        }

        private void OnMouseDown(object? sender, MouseEventArgs e)
        {
            if (settings.Draggable)
            {
                if (e.Button == MouseButtons.Left)
                {
                    isDragging = true;
                    var cur = Cursor.Position;
                    mouseRelativePos = new Size(Location.X - cur.X, Location.Y - cur.Y);
                }
            }
        }

        private void OnMouseUp(object? sender, MouseEventArgs e)
        {
            if (settings.Draggable && isDragging)
            {
                isDragging = false;
                settings.Location = Location;
                settings.SaveToDisk();
                settingsWin?.NotifyMainWinLocationChange(Location);
            }
        }

        private void OnMouseMove(object? sender, MouseEventArgs e)
        {
            if (settings.Draggable && isDragging)
            {
                Location = Cursor.Position + mouseRelativePos;
            }
        }

        private void OnMouseEnter(object? sender, EventArgs e)
        {
            if (settings.HideOnHover)
            {
                mouseHoverTimer.Start();
                Opacity = 0;
            } else
            {
                if (Opacity != 1)
                {
                    FadeIn(this, interval: 10);
                }
            }
        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {
            if (!settings.HideOnHover)
            {
                idleTimer.Enabled = true;
                idleTimer.Start();
            }
        }

        private void MouseHoverCheckTimerTick(object? sender, EventArgs e)
        {
            if (!Bounds.Contains(Cursor.Position.X, Cursor.Position.Y))
            {
                mouseHoverTimer.Stop();
                Opacity = settings.IdleOpacity;
            } 
        }

        private void OnClockTimerTick(object? sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(() =>
                {
                    UpdateClockText();
                });
            }
        }

        private void idleTimer_Tick(object sender, EventArgs e)
        {
            idleTimer.Stop();
            idleTimer.Enabled = false;
            FadeOut(this, settings.IdleOpacity, 50);
        }

        private void OnIconMenuClicked(object? sender, EventArgs e)
        {
            Activate();
        }

        private void OnSettingMenuClicked(object? sender, EventArgs e)
        {
            settings.Location = Location;
            OpenSettingsWindow();
        }

        private void OnExitMenuClicked(object? sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnDisplaySettingsChange(object? sender, EventArgs e)
        {
            if (settings.UsePresetLocation)
            {
                UpdateWindowRelativeLocation();
            }
        }

        private void OnTopMostCheckTick(object? sender, EventArgs e)
        {
            if (IsWindowObscured())
            {
                Debug.WriteLine("Window is obscured, bringing to front");
                // Force window to top
                TopMost = false;
                TopMost = true;
                BringToFront();
                //Activate();
            }
        }

        private void MainWin_FormClosing(object sender, FormClosingEventArgs e)
        {
            SystemEvents.DisplaySettingsChanged -= OnDisplaySettingsChange;
            topMostCheckTimer.Stop();
            topMostCheckTimer.Dispose();
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings.AlwaysOnTop = !settings.AlwaysOnTop;
            ApplySettings();
            settingsWin?.NotifySettingsChange(Settings.Clone(settings));
        }

        #region DLL Imports

        const Int32 WS_EX_LAYERED = 0x80000;
        const Int32 HTCAPTION = 0x02;
        const Int32 WM_NCHITTEST = 0x84;
        const Int32 HTTRANSPARENT = -1;
        const Int32 WS_EX_TRANSPARENT = 0x20;
        const Int32 WS_EX_TOOLWINDOW = 0x80;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        internal static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowLong(IntPtr hWnd, int nIndex);

        [DllImport("user32.dll")]
        static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);

        [DllImport("user32.dll")]
        static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr WindowFromPoint(Point point);

        [DllImport("user32.dll")]
        static extern IntPtr GetAncestor(IntPtr hwnd, uint gaFlags);

        const uint GA_ROOT = 2;  // Retrieves the root window by walking the chain of parent windows

        #endregion

        private bool IsWindowObscured()
        {
            if (!settings.AlwaysOnTop) return false;
            
            // If window is not visible at all
            Debug.WriteLine($"IsWindowVisible: {IsWindowVisible(this.Handle)}");
            if (!IsWindowVisible(this.Handle)) return true;

            // Get the window bounds
            var bounds = this.Bounds;
            
            // Get the window at our center point
            var centerPoint = new Point(
                bounds.Left + bounds.Width / 2,
                bounds.Top + bounds.Height / 2
            );
            
            var windowAtPoint = WindowFromPoint(centerPoint);
            if (windowAtPoint == IntPtr.Zero) return false;

            // Get the top-level window that contains the point
            var topLevelWindow = GetAncestor(windowAtPoint, GA_ROOT);
            
            // Get our own top-level window handle
            var ourTopLevel = GetAncestor(this.Handle, GA_ROOT);

            Debug.WriteLine($"Window at point: ({windowAtPoint})");
            Debug.WriteLine($"Top level window: ({topLevelWindow})");
            Debug.WriteLine($"Our top level window: ({ourTopLevel})");

            return topLevelWindow != ourTopLevel;
        }
    }
}