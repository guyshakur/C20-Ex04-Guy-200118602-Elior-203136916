﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu : MenuItem
    {
        public MainMenu(string i_Title)
            :base(i_Title)
        {
            ExitTitle = "Exit";
        }

    }
}
