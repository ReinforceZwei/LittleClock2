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
            this.mainWin = win;

            timeDisplayFormatComboBox.Items.AddRange(TimeFormat);
            timeDisplayFormatComboBox.Text = settings.TimeFormat;

            alwaysOnTopCheckBox.Checked = settings.AlwaysOnTop;
            draggableCheckBox.Checked = settings.Draggable;
            hideOnHoverCheckBox.Checked = settings.HideOnHover;
            clickThroughCheckBox.Checked = settings.ClickThrough;

            locationXInput.Value = settings.Location.X;
            locationYInput.Value = settings.Location.Y;
        }

        private void OnApplyButtonClicked(object? sender, EventArgs e)
        {
            mainWin.UpdateSettings(settings);
        }

        private void OnDoneButtonClicked(object? sender, EventArgs e)
        {
            Close();
        }

        private void alwaysOnTopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.AlwaysOnTop = alwaysOnTopCheckBox.Checked;
        }

        private void draggableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.Draggable = draggableCheckBox.Checked;
        }

        private void hideOnHoverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.HideOnHover = hideOnHoverCheckBox.Checked;
        }

        private void clickThroughCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            settings.ClickThrough = clickThroughCheckBox.Checked;
        }

        private void locationXInput_ValueChanged(object sender, EventArgs e)
        {
            settings.Location.X = Convert.ToInt32(locationXInput.Value);
        }

        private void locationYInput_ValueChanged(object sender, EventArgs e)
        {
            settings.Location.Y = Convert.ToInt32(locationYInput.Value);
        }

        private void timeDisplayFormatComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.TimeFormat = timeDisplayFormatComboBox.Text;
        }
    }
}
