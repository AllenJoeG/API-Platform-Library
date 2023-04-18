namespace API_Platform_Library.Models.Tarot
{
    public class Tarot
    {
        public Arcana Arcana { get; set; }
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public string EkelenName { get; set; }
        public string EkelenMeaningUp { get; set; }
        public string EkelenMeaningInv { get; set; }
        public string EkelenDescription { get; set; }


    }
}
