using koloro.Core.Models;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace koloro.Core.RestClients
{
    public static class PokeApiRestClient
    {
        private static readonly string host = "https://pokeapi.co/api/v2";


        public static async Task<PokemonResponse> Pokemon(HttpClient http, int offset, int limit)
        {
            http.DefaultRequestHeaders.Add("Accept", "application/json");
            var query = new Dictionary<string, string>
            {
                ["offset"] = offset.ToString(),
                ["limit"] = limit.ToString(),
            };

            var httpResponse = await http.GetAsync(QueryHelpers.AddQueryString(string.Format("{0}/pokemon", host), query));
            var response = await httpResponse.Content.ReadFromJsonAsync<PokemonResponse>();
            return response;
        }

        public static async Task<PokemonData> PokemonDataByName(HttpClient http, string name)
        {
            var httpResponse = await http.GetAsync(string.Format("{0}/pokemon/{1}", host, name));
            var response = await httpResponse.Content.ReadFromJsonAsync<PokemonData>();
            return response;
        }

        public static async Task<string> UrlToBase64(HttpClient http, string url)
        {
            http.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            var format = "data:image/png;base64,";
            var bytes = await http.GetByteArrayAsync(url);
            if (url.Contains(".svg"))
                format = "data:image/svg+xml;base64,";

            return format + Convert.ToBase64String(bytes);
        }



    }
}
