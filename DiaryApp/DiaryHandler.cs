using DiaryApp;
using System;
using System.Collections.Generic;

public class DiaryHandler
{
    private List<DiaryEntry> entries = new List<DiaryEntry>();

    public void AddEntry()
    {
       
    }

    public void ListEntries()
    {
        
    }

    public void SearchEntry()
    {
        
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
