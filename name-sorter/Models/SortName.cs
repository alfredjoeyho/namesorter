using name_sorter.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter.Models
{
    class SortName : ISortName
    {
        public List<Name> Sort(List<Name> nameList)
        {
            var sortedList = nameList.OrderBy(s => s.LastName).ThenBy(s => s.FirstName).ToList();
            return sortedList;
        }
    }
}
