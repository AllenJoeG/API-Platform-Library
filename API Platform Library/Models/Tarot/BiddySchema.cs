namespace API_Platform_Library.Models.Tarot
{
    public class BiddySchema
    {
        public string name { get; set; }
        public string value { get; set; }
        public int value_int { get; set; }
        public string? suit { get; set; }
        public string arcana { get; set; }
        public string keywords_up { get; set; }
        public string keywords_inv { get; set; }
        public string description { get; set; }
        public Dictionary<int, string> quotes { get; set; }
        public Dictionary<string, string> meaning_up { get; set; }
        public Dictionary<string, string> combos_up { get; set; }
        public string meaning_inv { get; set; }
        public Dictionary<string, string> combos_inv { get; set; }

    }
}
