using DiaryApp;
using System;
using System.Collections.Generic;

public class DiaryHandler
{
    private List<DiaryEntry> entries = new List<DiaryEntry>();

    public void AddEntry()
    {
        Console.WriteLine("Type your diary note");
        string? DiaryNote = Console.ReadLine();
        
        if (string.IsNullOrWhiteSpace(DiaryNote))
        {
            Console.WriteLine("Diary note cannot be empty.");
            return;
        }

        string notNullDiaryNote = DiaryNote;
        
        DiaryEntry entry = new DiaryEntry
        {
            Date = DateTime.Now,
            Text = notNullDiaryNote
        };

        entries.Add(entry);

        Console.WriteLine("Your Diary have now been saved");

        {
            
        }
    }

    public void ListEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No diary entries found.");
            return;
        }
            Console.WriteLine("your diary notes is: ");
            foreach (var entry in entries)
            {
            Console.WriteLine($"{entry.Date:yyyy-MM-dd}: {entry.Text}");
        }

    }

    public void SearchEntry()
    {
        Console.WriteLine("To see a specific diary note, enter the date you created it");
        Console.WriteLine("Please use the following format (yyyy-MM-dd): ");
        string? inputDate = Console.ReadLine();

        if (DateTime.TryParse(inputDate, out DateTime searchDate))
        {
            var foundEntries = entries.FindAll(e => e.Date.Date == searchDate.Date);
            if (foundEntries.Count > 0)
            {
                foreach (var entry in foundEntries)
                {
                    Console.WriteLine($"{entry.Date:yyyy-MM-dd}: {entry.Text}");
                }
            }
            else
            {
                Console.WriteLine("No diary notes found for the specified date.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use (yyyy-MM-dd).");
        }
    }

    public List<DiaryEntry> GetAllEntries()
    {
        return entries; 
    }

    public void SetEntries(List<DiaryEntry> loadedEntries)
    {
        entries = loadedEntries ?? new List<DiaryEntry>();
    }
}
