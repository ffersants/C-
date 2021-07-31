using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Single_Responsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //separate concerns
            Journal dearDiary = new Journal();
            //separate concerns
            Persistence persistence = new Persistence();
            string path = @"c:\users\dheyes\documents\dearDiary.txt";

            dearDiary.addEntry("I wanna a beer!");
            dearDiary.addEntry("Just do it.");
            dearDiary.addEntry("Today I woke up.");
           
            dearDiary.removeEntry(0);
            dearDiary.addEntry("Time is money, and I don't have time neither money.");


            persistence.SaveToFile(dearDiary, path, false);

            Process.Start(path);
        }
        //
        public class Journal
        {
            private readonly List<string> entries = new List<string>();
            private static int count = 0;
            public int addEntry(string entry)
            {
                entries.Add($"{count++} - {entry}");
                return count;
            }

            public void removeEntry(int index)
            {
                entries.RemoveAt(index);
            }

            public override string ToString()
            {
                return string.Join(Environment.NewLine, entries);
            }
        }
        //separate concerns
        public class Persistence
        {
            public void SaveToFile(Journal j, string filename, bool overwrite = false)
            {
                if(overwrite || !File.Exists(filename))
                {
                    File.WriteAllText(filename, j.ToString());
                }
            }
        }
    }
}
