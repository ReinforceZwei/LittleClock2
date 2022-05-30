using System.Diagnostics;
using System.Runtime.InteropServices;

namespace LittleClock2
{
    public partial class MainWin : Form
    {
        private Settings settings;

        // Dragging handle
        private bool isDragging = false;
        private Size mouseRelativePos;

        public MainWin()
        {
            settings = new Settings();

            InitializeComponent();

            FormBorderStyle = FormBorderStyle.None;
            ControlBox = false;
            ShowInTaskbar = false;
            TopMost = true;

            timeDisplayLabel.Text = DateTime.Now.ToString(settings.TimeFormat);

            Width = timeDisplayLabel.Width + 5;
            Height = 25;

            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, 25, 20, 20));

            //var initialStyle = GetWindowLong(this.Handle, -20);
            //SetWindowLong(this.Handle, -20, initialStyle | WS_EX_TOOLWINDOW);
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
            }
        }

        private void OnMouseLeave(object? sender, EventArgs e)
        {

        }

        private void MouseHoverCheckTimerTick(object? sender, EventArgs e)
        {
            if (!Bounds.Contains(Cursor.Position.X, Cursor.Position.Y))
            {
                mouseHoverTimer.Stop();
                Opacity = 1;
            }
        }

        private void OnClockTimerTick(object? sender, EventArgs e)
        {
            timeDisplayLabel.Text = DateTime.Now.ToString(settings.TimeFormat);
        }

        private void OnIconMenuClicked(object? sender, EventArgs e)
        {
            Activate();
        }

        private void OnSettingMenuClicked(object? sender, EventArgs e)
        {
            new SettingsWin(settings).ShowDialog();
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