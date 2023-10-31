class ScriptureLibrary
{
    private List<Scripture> scriptures = new List<Scripture>
    {
        new Scripture(new Reference("John", 3, 16, 17), "For God so loved the world that he sent His only begotten Son, and whosoever believe in Him shall not perish but have everlasting life. For God did not send his Son into the world to condemn the world, but to save the world through him."),
        new Scripture(new Reference("2Nephi", 26, 31, 0), "But the laborer in Zion shall labor for Zion; for if they labor for money they shall perish"),
        new Scripture(new Reference("Jacob", 6, 12,0), "O be wise; what can I say more?"),
        new Scripture(new Reference("2Nephi", 2, 25,0), "Adam fell that men might be; and men care, that they might have joy"),
        new Scripture(new Reference("Alma", 7, 11,0), "And he shall go forth, suffering pains and afflictions and temptations of every kind; and this that the word might be fulfilled which saith he will take upon him the pains and the sicknesses of his people.")
    };

    public Scripture GetRandomScripture()
    {
        var random = new Random();
        return scriptures[random.Next(scriptures.Count)];
    }
}