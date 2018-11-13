using System.Collections.Generic;
using name_sorter.Models;

namespace name_sorter.Interfaces
{
    interface IReadLine
    {
        List<Name> ReadLine(string fileName);
    }
}
