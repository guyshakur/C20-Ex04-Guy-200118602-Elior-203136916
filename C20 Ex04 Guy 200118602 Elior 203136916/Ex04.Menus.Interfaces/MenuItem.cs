using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem
    {
        private readonly List<MenuItem> r_Menus;
        private string m_ExitTitle;
        private string m_Title;
        private MenuItem m_Parent;

        public MenuItem(string i_Title)
        {
            r_Menus = new List<MenuItem>();
            Title = i_Title;
            ExitTitle = "Back";
        }

        public string ExitTitle
        {
            get
            {
                return m_ExitTitle;
            }

            set
            {
                m_ExitTitle = value;
            }
        }

        public MenuItem Parent
        {
            get
            {
                return m_Parent;
            }

            set
            {
                m_Parent = value;
            }
        }

        public string Title
        {
            get
            {
                return m_Title;
            }

            set
            {
                m_Title = value;
            }
        }

        public void AddSubMenu(MenuItem i_MenuItem)
        {
            r_Menus.Add(i_MenuItem);
            i_MenuItem.Parent = this;
        }

        public virtual void Show()
        {
            Console.Clear();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Title);
            int i = 1;

            foreach (MenuItem menu in r_Menus)
            {
                sb.AppendLine(i + ". " + menu.Title);
                i++;
            }

            sb.AppendLine("0. " + ExitTitle);
            Console.WriteLine(sb.ToString());
            int choice = getUserChoise();
            displayUserChoice(choice);
        }

        private int getUserChoise()
        {
            string userChoiseStr;
            int userChoice;

            do
            {
                userChoiseStr = Console.ReadLine();
                int.TryParse(userChoiseStr, out userChoice);
                if (!(int.TryParse(userChoiseStr, out userChoice) || userChoice < 0 || userChoice > r_Menus.Count))
                {
                    Console.WriteLine("Invalid input,please try again");
                }
            }
            while (!int.TryParse(userChoiseStr, out userChoice) || userChoice < 0 || userChoice > r_Menus.Count);

            return userChoice;
        }

        private void displayUserChoice(int i_UserChoice)
        {
            if (i_UserChoice != 0)
            {
                r_Menus.ElementAt(i_UserChoice - 1).Show();
            }
            else
            {
                if (Parent != null)
                {
                    Parent.Show();
                }
            }
        }
    }
}
