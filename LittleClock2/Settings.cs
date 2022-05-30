using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LittleClock2
{
    public class Settings
    {
        public Point Location = new Point(0, 0);
        public bool Draggable = true;
        public bool HideOnHover = true;
        public string TimeFormat = "hh:mm:ss tt";
    }
}
