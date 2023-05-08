using API_Platform_Library.Models.Tarot.Enums;

namespace API_Platform_Library.DTOs.Tarot
{
    public class CardDTO
    {
        public int Id { get; set; }
        public string CardName { get; set; }
        public Arcana Arcana { get; set; }
        public Value Value { get; set; }
        public Suit Suit { get; set; }
        public RWImage RWImage { get; set; }
        public bool Court { get; set; }
        public Element Element { get; set; }
        public Astrology Astrology { get; set; }
        public Sephirot Sephirot { get; set; }
        public Tetragrammaton Tetragrammaton { get; set; }
        public string HermeticTitle { get; set; }
        public string HermeticMeaningUp { get; set; }
        public string HermeticMeaningInv { get; set; }
        public string HermeticDescription { get; set; }
        public string? EkelenName { get; set; }
        public string? EkelenMeaningUp { get; set; }
        public string? EkelenMeaningInv { get; set; }
        public string? EkelenDescription { get; set; }
        public string? BiddyMeaningUp { get; set; }
        public string? BiddyMeaningInv { get; set; }
        public string? BiddyDescription { get; set; }

    }
}
