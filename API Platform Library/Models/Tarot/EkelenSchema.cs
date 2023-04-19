using Newtonsoft;

namespace API_Platform_Library.Models.Tarot
{
    public class EkelenSchema
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string name_short { get; set; }
        public string value { get; set; }
        public int value_int { get; set; }
        public string? suit { get; set; }
        public string type { get; set; }
        public string meaning_up { get; set; }
        public string meaning_rev { get; set; }
        public string desc { get; set; }
    }
}
