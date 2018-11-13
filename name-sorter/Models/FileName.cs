using name_sorter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace name_sorter.Models
{
    class FileName : IGetFileName
    {
        public string GetFileName(string argLine)
        {
            string fileName = argLine.Substring(argLine.LastIndexOf('/') + 1);
            return fileName;
        }
    }
}
