﻿using name_sorter.Interfaces;
using System.IO;

namespace name_sorter.Models
{
    class FileLog : ILog
    {
        public void Log(string msgToPrint)
        {
            File.AppendText("./Log.txt").Write(msgToPrint);
        }
    }
}
