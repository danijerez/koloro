using System.Text.Json.Serialization;

namespace koloro.Core.Models
{
    public class DreamWorld
    {
        public string front_default { get; set; }
        public object front_female { get; set; }
    }

    public class OfficialArtwork
    {
        public string front_default { get; set; }
    }

    public class Other
    {
        public DreamWorld dream_world { get; set; }

        [JsonPropertyName("official-artwork")]
        public OfficialArtwork OfficialArtwork { get; set; }
    }


    public class Sprites
    {
        public Other other { get; set; }
    }


    public class PokemonData
    {
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public Sprites sprites { get; set; }
    }
}
