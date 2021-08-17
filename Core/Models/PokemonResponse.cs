using System.Collections.Generic;

namespace koloro.Core.Models
{
    public class Result
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class PokemonResponse
    {
        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<Result> results { get; set; }
    }
}
