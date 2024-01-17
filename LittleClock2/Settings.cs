using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleClock2
{
    public class Settings
    {
        /// <summary>
        /// Location of the clock window
        /// </summary>
        public Point Location = new Point(0, 0);

        /// <summary>
        /// Clock window always on top
        /// </summary>
        public bool AlwaysOnTop = true;

        /// <summary>
        /// Clock window draggable
        /// </summary>
        public bool Draggable = true;

        /// <summary>
        /// Hide clock window on mouse hover
        /// </summary>
        public bool HideOnHover = true;

        /// <summary>
        /// Allow mouse click through the clock window
        /// </summary>
        public bool ClickThrough = false;

        /// <summary>
        /// Clock display format
        /// </summary>
        public string TimeFormat = "hh:mm:ss tt";

        /// <summary>
        /// Opacity when active (e.g. mouse hover)
        /// </summary>
        public float ActiveOpacity = 1.0f;

        /// <summary>
        /// Opacity when idle
        /// </summary>
        public float IdleOpacity = 0.7f;

        /// <summary>
        /// Idle after how many ms
        /// </summary>
        public int IdleAfter = 2000;

        public bool UsePresetLocation = false;

        public PresetLocation PresetLocation = PresetLocation.TopLeft;

        public static Settings Clone(Settings settings)
        {
            return new Settings()
            {
                Location = settings.Location,
                AlwaysOnTop = settings.AlwaysOnTop,
                Draggable = settings.Draggable,
                HideOnHover = settings.HideOnHover,
                ClickThrough = settings.ClickThrough,
                IdleOpacity = settings.IdleOpacity,
                IdleAfter = settings.IdleAfter,
                UsePresetLocation = settings.UsePresetLocation,
                TimeFormat = settings.TimeFormat,
                ActiveOpacity = settings.ActiveOpacity,
                PresetLocation = settings.PresetLocation,
            };
        }
    }

    public enum PresetLocation
    {
        TopLeft,
        Top,
        TopRight,
        Left,
        Center,
        Right,
        BottomLeft,
        Bottom,
        BottomRight,
    }
}
