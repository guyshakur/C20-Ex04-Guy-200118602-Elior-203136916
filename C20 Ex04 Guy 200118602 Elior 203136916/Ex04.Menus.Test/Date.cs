using Ex04.Menus.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class Date:IExecutable
    {
        public void execute()
        {
            PrintDateOfToday();
        }

        public void PrintDateOfToday()
        {
            Console.WriteLine("The date of today is: {0}", DateTime.Today.ToShortDateString());
        }
    }
}
