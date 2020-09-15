using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class InterfaceSolution
    {
        public static void ShowIntefaceSolution()
        {
            MainMenu mainMenu = new MainMenu("Interface Solution: ");
            MenuItem versionAndSpacesItem = new MenuItem("Version And Spaces");
            MenuItem showDateAndTimeItem = new MenuItem("Show Date / Time");
            mainMenu.AddSubMenu(versionAndSpacesItem);
            mainMenu.AddSubMenu(showDateAndTimeItem);
            ExecuteMethodItem countSpacesItem = new ExecuteMethodItem("Count Spaces");
            countSpacesItem.Executable = new CountSpaces();
            versionAndSpacesItem.AddSubMenu(countSpacesItem);
            ExecuteMethodItem versionItem = new ExecuteMethodItem("Show Version");
            versionItem.Executable = new Version();
            versionAndSpacesItem.AddSubMenu(versionItem);
            ExecuteMethodItem showDateItem = new ExecuteMethodItem("Show Date");
            showDateItem.Executable = new Date();
            showDateAndTimeItem.AddSubMenu(showDateItem);
            ExecuteMethodItem showTimeItem = new ExecuteMethodItem("Show Time");
            showTimeItem.Executable = new Time();
            showDateAndTimeItem.AddSubMenu(showTimeItem);
            mainMenu.Show();




        }
        
        
    }
}
