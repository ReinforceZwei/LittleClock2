using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleClock2
{
    public partial class SettingsWin : Form
    {
        private static readonly string githubLink = "https://github.com/ReinforceZwei/LittleClock2";

        Settings settings;
        Settings newSettings;
        MainWin mainWin;

        private static readonly string[] TimeFormat =
        {
            "hh:mm:ss tt",  // 0
            "hh:mm tt",     // 1
            "hh:mm:ss",     // 2
            "hh:mm",        // 3
            "HH:mm:ss",     // 4
            "HH:mm",        // 5
            "M/d ddd HH:mm"
        };

        public SettingsWin(Settings settings, MainWin win)
        {
            InitializeComponent();
            if (Settings.UsePortableSettings)
            {
                this.Text = $"{this.Text} (Portable)";
                settingModeLabel.Text = "Using portable settings";
            }
            this.settings = settings;
            this.newSettings = Settings.Clone(settings);
            this.mainWin = win;

            timeDisplayFormatComboBox.Items.AddRange(TimeFormat);

            fontSelectBox.Items.AddRange(FontFamily.Families.Select(f => f.Name).ToArray());
            fontStyleSelectBox.Items.Add(FontStyle.Regular);
            fontStyleSelectBox.Items.Add(FontStyle.Bold);
            fontStyleSelectBox.Items.Add(FontStyle.Italic);
            fontStyleSelectBox.Items.Add(FontStyle.Underline);

            ConfigurateSettings(this.settings);
        }

        private void ConfigurateSettings(Settings settings)
        {
            timeDisplayFormatComboBox.Text = settings.TimeFormat;

            alwaysOnTopCheckBox.Checked = settings.AlwaysOnTop;
            draggableCheckBox.Checked = settings.Draggable;
            hideOnHoverCheckBox.Checked = settings.HideOnHover;
            clickThroughCheckBox.Checked = settings.ClickThrough;

            locationXInput.Value = settings.Location.X;
            locationYInput.Value = settings.Location.Y;

            useAbsoluteLocationCheckbox.Checked = !settings.UsePresetLocation;
            locationXInput.Enabled = !settings.UsePresetLocation;
            locationYInput.Enabled = !settings.UsePresetLocation;

            RadioButton selectedPresetLocationButton = settings.PresetLocation switch
            {
                PresetLocation.TopLeft => topLeftLocationButton,
                PresetLocation.Top => topLocationButton,
                PresetLocation.TopRight => topRightLocationButton,
                PresetLocation.Left => leftLocationButton,
                PresetLocation.Center => centerLocationButton,
                PresetLocation.Right => rightLocationButton,
                PresetLocation.BottomLeft => bottomLeftLocation,
                PresetLocation.Bottom => bottomLocationButton,
                PresetLocation.BottomRight => bottomRightLocationButton,
            };
            selectedPresetLocationButton.Checked = true;

            idleOpacityInput.Value = (decimal)settings.IdleOpacity;
            idleTimeoutInput.Value = settings.IdleAfter;

            fontSelectBox.SelectedIndex = fontSelectBox.FindStringExact(settings.FontFamily);
            fontStyleSelectBox.SelectedIndex = fontStyleSelectBox.FindStringExact(settings.FontStyle.ToString());
            fontSizeInput.Value = (decimal)settings.FontSize;

            bottomPaddingInput.Value = settings.BottomPadding;

            textColorDisplay.BackColor = Color.FromArgb(settings.TextColorArgb);
            backgroundColorDisplay.BackColor = Color.FromArgb(settings.BackgrouldColorArgb);

            useRoundedCornerCheckbox.Checked = settings.UseRoundedCorner;
        }

        public void NotifyMainWinLocationChange(Point location)
        {
            newSettings.Location = location;
            locationXInput.Value = newSettings.Location.X;
            locationYInput.Value = newSettings.Location.Y;
        }

        public void NotifySettingsChange(Settings newSettings)
        {
            this.newSettings = newSettings;
            ConfigurateSettings(newSettings);
        }

        private void OnApplyButtonClicked(object? sender, EventArgs e)
        {
            var checkedLocation = locationGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (checkedLocation != null)
            {
                newSettings.PresetLocation = checkedLocation.Text switch
                {
                    "Top Left" => PresetLocation.TopLeft,
                    "Top" => PresetLocation.Top,
                    "Top Right" => PresetLocation.TopRight,
                    "Left" => PresetLocation.Left,
                    "Center" => PresetLocation.Center,
                    "Right" => PresetLocation.Right,
                    "Bottom Left" => PresetLocation.BottomLeft,
                    "Bottom" => PresetLocation.Bottom,
                    "Bottom Right" => PresetLocation.BottomRight,
                };
            }
            mainWin.ApplySettings(newSettings);
        }

        private void OnDoneButtonClicked(object? sender, EventArgs e)
        {
            Close();
        }

        private void alwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.AlwaysOnTop = alwaysOnTopCheckBox.Checked;
        }

        private void draggableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.Draggable = draggableCheckBox.Checked;
        }

        private void hideOnHoverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.HideOnHover = hideOnHoverCheckBox.Checked;
        }

        private void clickThroughCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.ClickThrough = clickThroughCheckBox.Checked;
        }

        private void locationXInput_ValueChanged(object sender, EventArgs e)
        {
            var l = newSettings.Location;
            l.X = Convert.ToInt32(locationXInput.Value);
            newSettings.Location = l;
        }

        private void locationYInput_ValueChanged(object sender, EventArgs e)
        {
            var l = newSettings.Location;
            l.Y = Convert.ToInt32(locationYInput.Value);
            newSettings.Location = l;
        }

        private void timeDisplayFormatComboBox_TextUpdate(object sender, EventArgs e)
        {
            newSettings.TimeFormat = timeDisplayFormatComboBox.Text;
        }

        private void useAbsoluteLocationCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool check = useAbsoluteLocationCheckbox.Checked;
            newSettings.UsePresetLocation = !check;
            locationXInput.Enabled = check;
            locationYInput.Enabled = check;
            foreach (var i in locationGroupBox.Controls.OfType<RadioButton>())
            {
                i.Enabled = !check;
            }
        }

        private void idleOpacityInput_ValueChanged(object sender, EventArgs e)
        {
            newSettings.IdleOpacity = (float)idleOpacityInput.Value;
        }

        private void idleTimeoutInput_ValueChanged(object sender, EventArgs e)
        {
            newSettings.IdleAfter = (int)idleTimeoutInput.Value;
        }

        private void fontSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSettings.FontFamily = fontSelectBox.Text;
        }

        private void fontStyleSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            newSettings.FontStyle = Enum.Parse<FontStyle>(fontStyleSelectBox.Text);
        }

        private void fontSizeInput_ValueChanged(object sender, EventArgs e)
        {
            newSettings.FontSize = (float)fontSizeInput.Value;
        }

        private void bottomPaddingInput_ValueChanged(object sender, EventArgs e)
        {
            newSettings.BottomPadding = (int)bottomPaddingInput.Value;
        }

        private void pickTextColorBtn_Click(object sender, EventArgs e)
        {
            var colorPicker = new ColorDialog()
            {
                FullOpen = true,
                Color = Color.FromArgb(newSettings.TextColorArgb),
            };
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                newSettings.TextColorArgb = colorPicker.Color.ToArgb();
                textColorDisplay.BackColor = colorPicker.Color;
            }
        }

        private void pickBackgroundColorBtn_Click(object sender, EventArgs e)
        {
            var colorPicker = new ColorDialog()
            {
                FullOpen = true,
                Color = Color.FromArgb(newSettings.BackgrouldColorArgb),
            };
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                newSettings.BackgrouldColorArgb = colorPicker.Color.ToArgb();
                backgroundColorDisplay.BackColor = colorPicker.Color;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                linkLabel1.LinkVisited = true;
                Process.Start(new ProcessStartInfo(githubLink) { UseShellExecute = true });
            }
            catch
            {
                MessageBox.Show("Fail to open URL");
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to reset all settings?", "Reset Settings", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.newSettings = new Settings();
                ConfigurateSettings(this.newSettings);
            }
        }

        private void useRoundedCornerCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            newSettings.UseRoundedCorner = useRoundedCornerCheckbox.Checked;
        }
    }
}
