using name_sorter.Models;
using System.Collections.Generic;

namespace name_sorter.Interfaces
{
    public interface ISortName
    {
        List<Name> Sort(List<Name> listName);
    }
}
