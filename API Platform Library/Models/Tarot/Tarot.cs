using System.Linq.Expressions;

namespace API_Platform_Library.Models.Tarot
{
    public class Tarot
    {
        public int ID { get; set; }
        public Arcana Arcana { get; set; }
        public Value Value { get; set; }
        public Suit? Suit { get; set; }
        public Element? Element { get; set; }
        public Astrology? Astrology { get; set; }
        public Sephirot? Sephirot { get; set; }
        public Tetragrammaton? Tetragrammaton { get; set; }
        public bool Court { get; set; }
        public string HermeticName { get; set; }
        public string HermeticTitle { get; set; }
        public string HermeticMeaningUp { get; set; }
        public string HermeticMeaningInv { get; set; }
        public string HermeticDescription { get; set; }
        public string? EkelenName { get; set; }
        public string? EkelenMeaningUp { get; set; }
        public string? EkelenMeaningInv { get; set; }
        public string? EkelenDescription { get; set; }


    }
}
