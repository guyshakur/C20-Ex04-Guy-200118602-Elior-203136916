using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    //public delegate void ExecuteChosenItem(string i_Button);
    public class ExecuteMethodItem : MenuItem
    {
        public event Action m_ExectuteSelectedItem;

        public ExecuteMethodItem(string i_Title)
            : base(i_Title)
        {
            ExitTitle = "press enter to back to the preview menu";
        }

        protected virtual void OnExectuteSelectedItem()
        {
            if (m_ExectuteSelectedItem != null)
            {
                m_ExectuteSelectedItem.Invoke();
            }
        }

        public override void Show()
        {
            Console.Clear();
            OnExectuteSelectedItem();
            Console.WriteLine();
            Console.WriteLine(ExitTitle);
            Console.ReadLine();
            Parent.Show();
        }
    }
}
