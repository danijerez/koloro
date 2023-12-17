using System.Text.Json.Serialization;

namespace koloro.Core.Models
{
    public record PokemonSprites(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_female")] string BackFemale,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("back_shiny_female")] string BackShinyFemale,
        [property: JsonPropertyName("other")] Other Other,
        [property: JsonPropertyName("versions")] Versions Versions
    );

    public record Animated(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_female")] string BackFemale,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("back_shiny_female")] string BackShinyFemale
    );

    public record BlackWhite(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_female")] string BackFemale,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("back_shiny_female")] string BackShinyFemale,
        [property: JsonPropertyName("animated")] Animated Animated
    );

    public record Crystal(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("front_transparent")] string FrontTransparent,
        [property: JsonPropertyName("front_shiny_transparent")] string FrontShinyTransparent,
        [property: JsonPropertyName("back_transparent")] string BackTransparent,
        [property: JsonPropertyName("back_shiny_transparent")] string BackShinyTransparent
    );

    public record DiamondPearl(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_female")] string BackFemale,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("back_shiny_female")] string BackShinyFemale
    );

    public record DreamWorld(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale
    );

    public record Emerald(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_shiny")] string FrontShiny
    );

    public record FireredLeafgreen(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_shiny")] string BackShiny
    );

    public record GenerationI(
        [property: JsonPropertyName("red-blue")] RedBlue RedBlue,
        [property: JsonPropertyName("yellow")] Yellow Yellow
    );

    public record GenerationIi(
        [property: JsonPropertyName("crystal")] Crystal Crystal,
        [property: JsonPropertyName("gold")] Gold Gold,
        [property: JsonPropertyName("silver")] Silver Silver
    );

    public record GenerationIii(
        [property: JsonPropertyName("emerald")] Emerald Emerald,
        [property: JsonPropertyName("firered-leafgreen")] FireredLeafgreen FireredLeafgreen,
        [property: JsonPropertyName("ruby-sapphire")] RubySapphire RubySapphire
    );

    public record GenerationIv(
        [property: JsonPropertyName("diamond-pearl")] DiamondPearl DiamondPearl,
        [property: JsonPropertyName("heartgold-soulsilver")] HeartgoldSoulsilver HeartgoldSoulsilver,
        [property: JsonPropertyName("platinum")] Platinum Platinum
    );

    public record GenerationV(
        [property: JsonPropertyName("black-white")] BlackWhite BlackWhite
    );

    public record GenerationVi(
        [property: JsonPropertyName("omegaruby-alphasapphire")] OmegarubyAlphasapphire OmegarubyAlphasapphire,
        [property: JsonPropertyName("x-y")] XY XY
    );

    public record GenerationVii(
        [property: JsonPropertyName("ultra-sun-ultra-moon")] UltraSunUltraMoon UltraSunUltraMoon,
        [property: JsonPropertyName("icons")] PokeIcons Icons
    );

    public record GenerationViii(
        [property: JsonPropertyName("icons")] PokeIcons Icons
    );

    public record Gold(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("front_transparent")] string FrontTransparent
    );

    public record HeartgoldSoulsilver(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_female")] string BackFemale,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("back_shiny_female")] string BackShinyFemale
    );

    public record Home(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale
    );

    public record PokeIcons(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale
    );

    public record OfficialArtwork(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_shiny")] string FrontShiny
    );

    public record OmegarubyAlphasapphire(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] object FrontShinyFemale
    );

    public record Other(
        [property: JsonPropertyName("dream_world")] DreamWorld DreamWorld,
        [property: JsonPropertyName("home")] Home Home,
        [property: JsonPropertyName("official-artwork")] OfficialArtwork OfficialArtwork
    );

    public record Platinum(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_female")] string BackFemale,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("back_shiny_female")] string BackShinyFemale
    );

    public record RedBlue(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_gray")] string FrontGray,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_gray")] string BackGray,
        [property: JsonPropertyName("front_transparent")] string FrontTransparent,
        [property: JsonPropertyName("back_transparent")] string BackTransparent
    );

    public record RubySapphire(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_shiny")] string BackShiny
    );

    public record Silver(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_shiny")] string BackShiny,
        [property: JsonPropertyName("front_transparent")] string FrontTransparent
    );

    public record UltraSunUltraMoon(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] string FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale
    );

    public record Versions(
        [property: JsonPropertyName("generation-i")] GenerationI GenerationI,
        [property: JsonPropertyName("generation-ii")] GenerationIi GenerationIi,
        [property: JsonPropertyName("generation-iii")] GenerationIii GenerationIii,
        [property: JsonPropertyName("generation-iv")] GenerationIv GenerationIv,
        [property: JsonPropertyName("generation-v")] GenerationV GenerationV,
        [property: JsonPropertyName("generation-vi")] GenerationVi GenerationVi,
        [property: JsonPropertyName("generation-vii")] GenerationVii GenerationVii,
        [property: JsonPropertyName("generation-viii")] GenerationViii GenerationViii
    );

    public record XY(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_female")] object FrontFemale,
        [property: JsonPropertyName("front_shiny")] string FrontShiny,
        [property: JsonPropertyName("front_shiny_female")] string FrontShinyFemale
    );

    public record Yellow(
        [property: JsonPropertyName("front_default")] string FrontDefault,
        [property: JsonPropertyName("front_gray")] string FrontGray,
        [property: JsonPropertyName("back_default")] string BackDefault,
        [property: JsonPropertyName("back_gray")] string BackGray,
        [property: JsonPropertyName("front_transparent")] string FrontTransparent,
        [property: JsonPropertyName("back_transparent")] string BackTransparent
    );


}
