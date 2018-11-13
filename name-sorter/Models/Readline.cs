using name_sorter.Interfaces;
using System;
using System.Collections.Generic;

namespace name_sorter.Models
{
    class Readline : IReadLine
    {
        public List<Name> ReadLine(string fileName)
        {
            try
            {
                string line;
                List<Name> nameList = new List<Name>();
                System.IO.StreamReader file = new System.IO.StreamReader(@"C:\NameSorter\" + fileName);
                while ((line = file.ReadLine()) != null)
                {
                    int spaceIndex = line.LastIndexOf(' ');
                    Name name = new Name();
                    name.LastName = line.Substring(spaceIndex + 1);

                    if (spaceIndex > 0)
                    {
                        name.FirstName = line.Substring(0, spaceIndex);
                        nameList.Add(name);
                    }
                }
                return nameList;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
