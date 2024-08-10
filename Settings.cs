using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HCI_Lab_Poject
{
    class Settings
    {
        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 13;
            Height = 13;
            directions = "left";
        }
    }
}
