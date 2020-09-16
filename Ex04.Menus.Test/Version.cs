using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Version : IExecutable
    {
        public void execute()
        {
            PrintVersion();
        }

        public void PrintVersion()
        {
            Console.WriteLine("Version: 20.3.4.8920");
        }
    }
}
