class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>
    {
        new Scripture("John 3:16", "For God so loved the world that he sent His only begotten Son, and whosoever believe in Him shall not perish but have everlasting life"),
        new Scripture("2Nephi 26:31", "But the laborer in Zion shall labor for Zion; for if they labor for money they shall perish"),
        new Scripture("Jacob 6:12", "O be wise; what can I say more?"),
        new Scripture("2Nephi 2:25","Adam fell that men might be; and men care, that they might have joy"),
        new Scripture($"Alma 7:11", "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.")
    
    };

    public Scripture GetRandomScripture()
    {
        var random = new Random();
        return scriptures[random.Next(scriptures.Count)];
    }
}