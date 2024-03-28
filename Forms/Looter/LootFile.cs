using SampleClasses;

namespace Looter
{
    internal class LootFile
    {
        public List<Loot> loots { get; set; }
        public string Path { get; set; }
        public bool Saved { get; set; }
        public bool NewFile { get; set; }

        public LootFile()
        {
            loots = new List<Loot>();
            Saved = false;
            Path = string.Empty;
            NewFile = true;
        }
    }
}
