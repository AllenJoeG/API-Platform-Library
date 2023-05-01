namespace API_Platform_Library.Models.Tarot.Enums
{
    [Flags]
    public enum Astrology
    {
        Sun = 1,
        Moon = 2,
        Mercury = 4,
        Venus = 8,
        Mars = 16,
        Jupiter = 32,
        Saturn = 64,
        Pluto = 128,
        Neptune = 256,
        Uranus = 512,
        Aries = 1024,
        Taurus = 2048,
        Gemini = 4096,
        Cancer = 8192,
        Leo = 16384,
        Virgo = 32768,
        Libra = 65536,
        Scorpio = 131072,
        Sagittarius = 262144,
        Capricorn = 524288,
        Aquarius = 1048576,
        Pisces = 2097152
    }
}
