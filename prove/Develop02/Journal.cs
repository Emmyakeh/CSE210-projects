using System;
 

// Journal class to manage entries
 public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter sw = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                sw.Write(entry);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            entries.Clear(); // Clear existing entries

            using (StreamReader sr = new StreamReader(filename))
            {
                string line;
                string currentPrompt = "";
                string currentResponse = "";

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.EndsWith(": ")) // New entry prompt
                    {
                        currentPrompt = line.TrimEnd(':');
                    }
                    else
                    {
                        currentResponse = line;
                        AddEntry(currentPrompt, currentResponse);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}