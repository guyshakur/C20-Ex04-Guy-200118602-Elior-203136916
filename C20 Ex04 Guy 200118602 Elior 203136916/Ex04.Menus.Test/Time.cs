using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Time:IExecutable
    {
        public void execute()
        {
            PrintTheTime();
        }

      

        public void PrintTheTime()
        {
            Console.WriteLine("The time is: {0}", DateTime.Now.ToString("HH:mm:ss"));

        }
    }
}
