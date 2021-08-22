using System.Collections.Generic;

namespace koloro.Core.Models
{
    public class PokemonDto
    {
        public int id { get; set; }
        public string name { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public Art art { get; set; }
        public List<TypePokemon> types { get; set; }
    }

    public class Art
    {
        public string official { get; set; }
        public string dreamworld { get; set; }
        public SpritesPokemon sprites { get; set; }
    }

    public class SpritesPokemon
    {
        public string back_default { get; set; }
        public string back_female { get; set; }
        public string back_shiny { get; set; }
        public string back_shiny_female { get; set; }
        public string front_default { get; set; }
        public string front_female { get; set; }
        public string front_shiny { get; set; }
        public string front_shiny_female { get; set; }
    }

    public class TypePokemon
    {
        public int slot { get; set; }
        public string name { get; set; }
    }

    public class AbilityPokemon
    {
        public string name { get; set; }
        public int slot { get; set; }
        public bool hidden { get; set; }
    }
}
