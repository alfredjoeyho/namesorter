using name_sorter.Interfaces;
using System;
using System.IO;

namespace name_sorter.Models
{
    class FileLog : ILog
    {
        public void Log(string msgToPrint)
        {
            try
            {
                File.AppendText("./Log.txt").Write(msgToPrint);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
