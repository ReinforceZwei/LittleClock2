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

        public SettingsWin(Settings settings)
        {
            InitializeComponent();
            this.settings = settings;
        }

        private void OnDoneButtonClicked(object? sender, EventArgs e)
        {
            Close();
        }
    }
}
