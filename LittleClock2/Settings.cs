using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace LittleClock2
{
    public class Settings
    {
        /// <summary>
        /// Location of the clock window
        /// </summary>
        public Point Location { get; set; } = new Point(0, 0);

        /// <summary>
        /// Clock window always on top
        /// </summary>
        public bool AlwaysOnTop { get; set; } = true;

        /// <summary>
        /// Clock window draggable
        /// </summary>
        public bool Draggable { get; set; } = true;

        /// <summary>
        /// Hide clock window on mouse hover
        /// </summary>
        public bool HideOnHover { get; set; } = true;

        /// <summary>
        /// Allow mouse click through the clock window
        /// </summary>
        public bool ClickThrough { get; set; } = false;

        /// <summary>
        /// Clock display format
        /// </summary>
        public string TimeFormat { get; set; } = "hh:mm:ss tt";

        /// <summary>
        /// Opacity when active (e.g. mouse hover)
        /// </summary>
        public float ActiveOpacity { get; set; } = 1.0f;

        /// <summary>
        /// Opacity when idle
        /// </summary>
        public float IdleOpacity { get; set; } = 0.7f;

        /// <summary>
        /// Idle after how many ms
        /// </summary>
        public int IdleAfter { get; set; } = 2000;

        public bool UsePresetLocation { get; set; } = false;

        public PresetLocation PresetLocation { get; set; } = PresetLocation.TopLeft;

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

        private static string SettingsFilePath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LittleClock2", "Settings.json");
        private static JsonSerializerOptions JsonOutputOptions = new()
        {
            WriteIndented = true,
        };

        public void SaveToApplicationData()
        {
            try
            {
                var json = JsonSerializer.Serialize(this, JsonOutputOptions);
                FileInfo file = new FileInfo(SettingsFilePath);
                file.Directory.Create();
                File.WriteAllText(SettingsFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail to save settings to disk");
            }
        }

        public static Settings LoadFromApplicationData()
        {
            try
            {
                if (File.Exists(SettingsFilePath))
                {
                    var json = File.ReadAllText(SettingsFilePath);
                    Settings? settings = JsonSerializer.Deserialize<Settings>(json);
                    if (settings is not null)
                    {
                        return settings;
                    }
                    else
                    {
                        throw new InvalidCastException("Cannot parse settings json");
                    }
                }
                else
                {
                    return new Settings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail to load settings from disk");
                return new Settings();
            }
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
