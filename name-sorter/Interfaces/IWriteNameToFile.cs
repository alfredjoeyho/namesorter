﻿using name_sorter.Models;
using System.Collections.Generic;

namespace name_sorter.Interfaces
{
    public interface IWriteNameToFile
    {
        void WriteName(List<Name> listName);
    }
}
