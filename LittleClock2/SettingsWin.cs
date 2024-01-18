using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleClock2
{
    public partial class SettingsWin : Form
    {
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
            this.settings = settings;
            this.newSettings = Settings.Clone(settings);
            this.mainWin = win;

            timeDisplayFormatComboBox.Items.AddRange(TimeFormat);
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
        }

        public void NotifyMainWinLocationChange(Point location)
        {
            newSettings.Location = location;
            locationXInput.Value = newSettings.Location.X;
            locationYInput.Value = newSettings.Location.Y;
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

        private void timeDisplayFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
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
    }
}
