using name_sorter.Interfaces;
using System;
using System.Collections.Generic;
using name_sorter.Models;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                if (args == null || args.Length <= 0)
                {
                    ILog log = new FileLog();
                    log.Log("The agrument is null");
                }
                else
                {
                    string fileName = string.Empty;

                    IGetFileName getFileName = new FileName();
                    fileName = getFileName.GetFileName(args[0]);

                    List<Name> nameList = new List<Name>();
                    IReadLine readline = new Readline();
                    nameList = readline.ReadLine(fileName);

                    List<Name> sortedNameList = new List<Name>();
                    ISortName sortName = new SortName();
                    sortedNameList = sortName.Sort(nameList);

                    IPrintName printName = new PrintName();
                    printName.PrintNameToScreen(sortedNameList);
           
                    IWriteNameToFile writeNameToFile = new WriteNameToFile();
                    writeNameToFile.WriteName(sortedNameList);

                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
