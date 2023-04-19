namespace API_Platform_Library.Models.Tarot
{
    public class Lsind18Schema
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string arcana { get; set; }
        public string suit { get; set; }
        public string img { get; set; }
        public List<string> fortune_telling { get; set; }
        public List<string> keywords { get; set; }
        public Dictionary<string, List<string>> meanings { get; set; }
        public string archetype { get; set; }
        public string hebrew_alphabet { get; set; }
        public string numerology { get; set; }
        public string elemental { get; set; }
        public string mythical_spiritual { get; set; }
        public List<string> questions { get; set; }

    }
}
