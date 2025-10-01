using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                using (var writer = new StreamWriter(filePath))
                {
                    foreach (var entry in entries)
                    {
                        writer.WriteLine($"{entry.Date:yyyy-MM-dd}|{entry.Text}");
                    }
                }
                Console.WriteLine("Diary entries saved successfully.");
                Console.WriteLine($"Entries saved to: {Path.GetFullPath(filePath)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving entries: {ex.Message}");
            }




        }

        public List<DiaryEntry> LoadEntries()
        {
            var loadedentries = new List<DiaryEntry>();
            try
            {
                if (!File.Exists(filePath))
                {
                    Console.WriteLine("No diary was created.");
                    return loadedentries;
                }

                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 2 && DateTime.TryParse(parts[0], out DateTime date))
                    {
                        loadedentries.Add(new DiaryEntry { Date = date, Text = parts[1] });
                    }
                    else
                    {
                        Console.WriteLine($"Invalid entry format: {line}");
                    }

                }
                Console.WriteLine("Diary notes succesfully loaded");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading entries: {ex.Message}");
            }
            return loadedentries;
        }
    }
}
