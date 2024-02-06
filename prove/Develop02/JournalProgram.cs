using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date},{entry.Prompt},{entry.Response}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (var line in lines)
        {
            string[] parts = line.Split(',');
            if (parts.Length == 3)
            {
                string dateStr = parts[0];
                string prompt = parts[1];
                string response = parts[2];
                if (DateTime.TryParse(dateStr, out DateTime date))
                {
                    entries.Add(new Entry(prompt, response) { Date = date });
                }
                else
                {
                    Console.WriteLine($"Invalid date format: {dateStr}");
                }
            }
            else
            {
                Console.WriteLine($"Invalid entry format: {line}");
            }
        }
    }
}
