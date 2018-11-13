using name_sorter.Models;
using System.Collections.Generic;

namespace name_sorter.Interfaces
{
    interface IPrintName
    {
        void PrintNameToScreen(List<Name> sortedName);
    }
}
