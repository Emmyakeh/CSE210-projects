class Word
{
    public string Text { get; private set; }
    public bool IsHidden { get; set; }

    public Word(string text)
    {
        Text = text;
        IsHidden = false;
    }

    public override string ToString()
    {
        if (IsHidden)
            return new string('_', Text.Length);
        else
            return Text;
    }
}