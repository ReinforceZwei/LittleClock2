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

        public string FontFamily { get; set; } = "Microsoft JhengHei UI";

        public FontStyle FontStyle { get; set; } = FontStyle.Regular;

        public float FontSize { get; set; } = 12;

        public int BottomPadding { get; set; } = 5;

        public int TextColorArgb { get; set; } = Color.Black.ToArgb();

        public int BackgrouldColorArgb { get; set; } = Color.White.ToArgb();

        public bool UseRoundedCorner { get; set; } = true;

        /// <summary>
        /// Force the window to always stay on top, overriding AlwaysOnTop
        /// </summary>
        public bool ForceAlwaysOnTop { get; set; } = false;

        public static Settings Clone(Settings settings)
        {
            return new Settings()
            {
                Location = settings.Location,
                AlwaysOnTop = settings.AlwaysOnTop,
                ForceAlwaysOnTop = settings.ForceAlwaysOnTop,
                Draggable = settings.Draggable,
                HideOnHover = settings.HideOnHover,
                ClickThrough = settings.ClickThrough,
                IdleOpacity = settings.IdleOpacity,
                IdleAfter = settings.IdleAfter,
                UsePresetLocation = settings.UsePresetLocation,
                TimeFormat = settings.TimeFormat,
                ActiveOpacity = settings.ActiveOpacity,
                PresetLocation = settings.PresetLocation,
                FontFamily = settings.FontFamily,
                FontStyle = settings.FontStyle,
                FontSize = settings.FontSize,
                BottomPadding = settings.BottomPadding,
                TextColorArgb = settings.TextColorArgb,
                BackgrouldColorArgb = settings.BackgrouldColorArgb,
                UseRoundedCorner = settings.UseRoundedCorner,
            };
        }

        public static readonly string SettingsFilePathAppData = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LittleClock2", "Settings.json");

        public static readonly string? ExeDir = AppContext.BaseDirectory;
        public static readonly string? SettingsFilePathExeDir = string.IsNullOrEmpty(ExeDir)
            ? null 
            : Path.Combine(ExeDir, "LittleClock2_Settings.json");
        public static readonly bool UsePortableSettings = !string.IsNullOrEmpty(SettingsFilePathExeDir) && File.Exists(SettingsFilePathExeDir);

        private static JsonSerializerOptions JsonOutputOptions = new()
        {
            WriteIndented = true,
        };

        public static string GetSettingFilePath()
        {
            return UsePortableSettings ? SettingsFilePathExeDir! : SettingsFilePathAppData;
        }

        public void SaveToDisk()
        {
            try
            {
                string path = GetSettingFilePath();
                SaveToPath(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail to save settings to disk");
            }
        }

        public static Settings LoadFromDisk()
        {
            try
            {
                string path = GetSettingFilePath();
                return LoadFromPath(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Fail to load settings from disk");
                return new Settings();
            }
        }

        private void SaveToPath(string path)
        {
            var json = JsonSerializer.Serialize(this, JsonOutputOptions);
            FileInfo file = new FileInfo(path);
            file.Directory.Create();
            File.WriteAllText(path, json);
        }

        private static Settings LoadFromPath(string path)
        {
            if (File.Exists(path))
            {
                var json = File.ReadAllText(path);

                // Check empty file, return default
                if (json is not null && json.Length == 0)
                {
                    return new Settings();
                }

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
