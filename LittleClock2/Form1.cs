using System.Diagnostics;
using System.Runtime.InteropServices;
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

        public MainWin()
        {
            settings = new Settings();

            InitializeComponent();
            InitializeStyle();

            clockUpdateTimer = new System.Timers.Timer();
            clockUpdateTimer.Interval = TimeSpan.FromSeconds(1).TotalMilliseconds;
            clockUpdateTimer.AutoReset = true;
            clockUpdateTimer.Elapsed += OnClockTimerTick;
            clockUpdateTimer.Start();

            idleTimer.Interval = settings.IdleAfter;
            idleTimer.Enabled = true;
            idleTimer.Start();

            TopMost = settings.AlwaysOnTop;
            Location = settings.Location;

            timeDisplayLabel.Text = DateTime.Now.ToString(settings.TimeFormat);

            Width = timeDisplayLabel.Width + 5;
            Height = 25;

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, 25, 20, 20));

            initialStyle = GetWindowLong(this.Handle, -20);

            //var initialStyle = GetWindowLong(this.Handle, -20);
            SetWindowLong(this.Handle, -20, initialStyle | WS_EX_TOOLWINDOW);
            initialStyle = GetWindowLong(this.Handle, -20);
            //EnableClickThrough();
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

            if (settings.UsePresetLocation)
            {
                UpdateWindowRelativeLocation();
            }
            else
            {
                Location = settings.Location;
            }

            TopMost = settings.AlwaysOnTop;

            if (settings.ClickThrough)
                EnableClickThrough();
            else
                DisableClickThrough();

            UpdateClockText();
            Width = timeDisplayLabel.Width + 5;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, 25, 20, 20));

            idleTimer.Interval = settings.IdleAfter;
            Opacity = settings.IdleOpacity;

            settingsWin?.NotifyMainWinLocationChange(Location);
        }

        public void UpdateClockText()
        {
            timeDisplayLabel.Text = DateTime.Now.ToString(settings.TimeFormat);
        }

        public void UpdateWindowRelativeLocation()
        {
            var monitorSize = Screen.FromControl(this).Bounds.Size;
            var relativeSize = new Size(monitorSize.Width - this.Width, monitorSize.Height - this.Height + 15);
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
            settingsWin = new SettingsWin(settings, this);
            settingsWin.Show();
        }

        private void OnExitMenuClicked(object? sender, EventArgs e)
        {
            Application.Exit();
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

        #endregion
    }
}