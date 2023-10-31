class Scripture
{
    public Reference Reference { get; }
    public string Text { get; }

    private List<Word> words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
        words = Text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public bool AllWordsHidden()
    {
        return words.All(w => w.IsHidden);
    }

    public void HideRandomWord()
    {
        var random = new Random();
        var hiddenWords = words.Where(w => w.IsHidden).ToList();
        if (hiddenWords.Count < words.Count)
        {
            var wordToHide = words[random.Next(words.Count)];
            while (wordToHide.IsHidden)
            {
                wordToHide = words[random.Next(words.Count)];
            }
            wordToHide.IsHidden = true;
        }
    }

    public string GetCurrentOutput()
    {
        return $"{Reference}\n\n{string.Join(" ", words)}";
    }
}