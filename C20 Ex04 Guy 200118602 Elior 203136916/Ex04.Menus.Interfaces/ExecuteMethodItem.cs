using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces

{
    public class ExecuteMethodItem :MenuItem
    {
        private IExecutable m_Executable;


        public ExecuteMethodItem(string i_Title)
            : base(i_Title)
        {
            ExitTitle = "press enter to back to the preview menu";
        }

        public IExecutable Executable
        {
            set
            {
                m_Executable = value;
            }
            get
            {
                return m_Executable;
            }
        }

        public override void Show()
        {
            Console.Clear();
            Executable.execute();
            Console.WriteLine();
            Console.WriteLine(ExitTitle);
            Console.ReadLine();
            Parent.Show();
        }
    }
}
