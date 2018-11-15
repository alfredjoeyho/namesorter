using System.Collections.Generic;
using name_sorter.Models;

namespace name_sorter.Interfaces
{
    public interface IReadLine
    {
        List<Name> ReadLine(string fileName);
    }
}
