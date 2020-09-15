using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegateSolution
    {
        public static void ShowDelegateSolution()
        {
            MenuItem mainMenu = new MainMenu("Delegate version:");
            MenuItem VersionAndSpacesMenu = new MenuItem("Version and Spaces");
            mainMenu.AddSubMenu(VersionAndSpacesMenu);
            ExecuteMethodItem countSpacesItem = new ExecuteMethodItem("Count Spaces");
            countSpacesItem.m_ExectuteSelectedItem += new CountSpaces().PrintNumOfSpaces;
            ExecuteMethodItem showVersionItem = new ExecuteMethodItem("Show Version");
            showVersionItem.m_ExectuteSelectedItem += new Version().PrintVersion;
            VersionAndSpacesMenu.AddSubMenu(countSpacesItem);
            VersionAndSpacesMenu.AddSubMenu(showVersionItem);
            MenuItem showDateAndTimeMenu = new MenuItem("Show Date/Time");
            mainMenu.AddSubMenu(showDateAndTimeMenu);
            ExecuteMethodItem ShowDateItem = new ExecuteMethodItem("Show Date");
            ShowDateItem.m_ExectuteSelectedItem += new Date().PrintDateOfToday;
            showDateAndTimeMenu.AddSubMenu(ShowDateItem);
            ExecuteMethodItem showTimeItem = new ExecuteMethodItem("Show Time");
            showTimeItem.m_ExectuteSelectedItem += new Time().PrintTheTime;
            showDateAndTimeMenu.AddSubMenu(showTimeItem);
            mainMenu.Show();
        }
    }
}
