using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class CountSpaces : IExecutable
    {
        public void execute()
        {
            PrintNumOfSpaces();
        }

        public void PrintNumOfSpaces()
        {
            Console.WriteLine("Please Enter sentence");
            string stringFromUser = Console.ReadLine();
            int counter = 0;

            foreach (char c in stringFromUser)
            {
                if (c.Equals(' '))
                {
                    counter++;
                }
            }

            Console.WriteLine("number of spaces in the sentence are: {0}", counter);
        }
    }
}
