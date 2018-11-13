using name_sorter.Interfaces;
using System;
using System.Collections.Generic;

namespace name_sorter.Models
{
    class PrintName : IPrintName
    {
        public void PrintNameToScreen(List<Name> sortedList)
        {
            foreach (Name name in sortedList)
            {
                Console.WriteLine(name.FirstName + " " + name.LastName);
            }
        }
    }
}
