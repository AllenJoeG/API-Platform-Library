using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using API_Platform_Library.Models.Tarot.Enums;

namespace API_Platform_Library.Models.Tarot
{
    public class Tarot
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Arcana")]
        public Arcana Arcana { get; set; }

        [Required]
        [Display(Name = "Numerical Value")]
        public Value Value { get; set; }

        [Required]
        [Display(Name = "Suit")]
        public Suit Suit { get; set; }

        [Display(Name = "Elemental Signature")]
        public Element? Element { get; set; }

        [Display(Name = "Astrological Correlates")]
        public Astrology? Astrology { get; set; }

        [Display(Name = "Tree of Life")]
        public Sephirot? Sephirot { get; set; }

        [Display(Name = "Association Chain")]
        public Tetragrammaton? Tetragrammaton { get; set; }

        [Required]
        [Display(Name = "Is Court?")]
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
        public string? BiddyMeaningUp { get; set; }
        public string? BiddyMeaningInv { get; set; }
        public string? BiddyDescription { get; set; }

    }
}
