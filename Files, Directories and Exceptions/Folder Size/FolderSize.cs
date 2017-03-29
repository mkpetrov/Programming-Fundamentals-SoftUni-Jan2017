﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Folder_Size
{
    class FolderSize
    {
        static void Main(string[] args)
        {
            string[] test = Directory.GetFiles("TestFolder");

            double sum = 0;

            foreach (var file in test)
            {
                FileInfo fileinfo = new FileInfo(file);
                sum += fileinfo.Length;
            }
            sum = sum / 1024 / 1024;

            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
