using System;
using System.Collections.Generic;

namespace DiaryApp   
{
    public class DiaryFileHandler
    {
        private readonly string filePath;

        public DiaryFileHandler(string filePath)
        {
            this.filePath = filePath;
        }

        public void SaveEntries(List<DiaryEntry> entries)
        {
            
        }

        public List<DiaryEntry> LoadEntries()
        {
            
            return new List<DiaryEntry>();
        }
    }
}
