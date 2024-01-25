using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace koloro.Core.Models
{
    public record PokemonResponse(
        [property: JsonPropertyName("pokemon_v2_pokemon")] IReadOnlyList<PokemonV2Pokemon> Pokemon
    );

    public record PokemonV2Ability(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name
    );

    public record PokemonV2Pokemontype(
        [property: JsonPropertyName("pokemon_v2_type")] PokemonV2Type Type
    );

    public record PokemonV2Type(
        [property: JsonPropertyName("name")] string name
    );

    public record PokemonV2Pokemon(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("height")] int Height,
        [property: JsonPropertyName("weight")] int Weight,
        [property: JsonPropertyName("pokemon_v2_pokemonabilities")] IReadOnlyList<PokemonV2Pokemonability> Abilities,
        [property: JsonPropertyName("pokemon_v2_pokemontypes")] IReadOnlyList<PokemonV2Pokemontype> Types,
        [property: JsonPropertyName("pokemon_v2_pokemonsprites")] IReadOnlyList<PokemonV2Pokemonsprite> Sprites
    );

    public record PokemonV2Pokemonability(
        [property: JsonPropertyName("pokemon_v2_ability")] PokemonV2Ability Ability
    );

    public record PokemonV2Pokemonsprite(
        [property: JsonPropertyName("sprites")] PokemonSprites Sprites
    );

}
