using name_sorter.Interfaces;
using System.Collections.Generic;
using System.IO;

namespace name_sorter.Models
{
    class WriteNameToFile : IWriteNameToFile
    {
        public void WriteName(List<Name> sortedList)
        {
            string path = "./sorted-names-list.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (TextWriter tw = new StreamWriter("./sorted-names-list.txt"))
            {
                foreach (Name name in sortedList)
                    tw.WriteLine(name.FirstName + " " + name.LastName);
            }
        }
    }
}
