using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.SystemTextJson;
using koloro.Core.Models;
using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace koloro.Core.RestClients
{
    public static class PokeApiRestClient
    {
        private static readonly string host = "https://beta.pokeapi.co/graphql/v1beta";

        public static async Task<PokemonResponse> Pokemon()
        {
            var graphQLClient = new GraphQLHttpClient(host, new SystemTextJsonSerializer());
            var userJoinedRequest = new GraphQLRequest
            {
                Query = @"
                query pokeAPIquery {
                  pokemon_v2_pokemon {
                    id
                    name
                    height
                    weight
                    pokemon_v2_pokemonabilities {
                      pokemon_v2_ability {
                        id
                        name
                      }
                    }
                    pokemon_v2_pokemontypes {
                     pokemon_v2_type {
                      name
                     }
                    }
                    pokemon_v2_pokemonsprites {
                      sprites
                    }
                  }
                }
                ",
                OperationName = "pokeAPIquery"
            };

            var response = await graphQLClient.SendQueryAsync<PokemonResponse>(userJoinedRequest);
            return response.Data;
        }

        public static async Task<string> UrlToBase64(HttpClient http, string url)
        {
            var format = "data:image/png;base64,";

            try
            {
                var bytes = await http.GetByteArrayAsync(url);
                if (url.Contains(".svg"))
                    format = "data:image/svg+xml;base64,";

                return format + Convert.ToBase64String(bytes);
            }
            catch (Exception)
            {
                return string.Empty;
            }

        }

        public static PokemonSprites SpritesUrl(string sprites)
        {
            return JsonSerializer.Deserialize<PokemonSprites>(sprites);
        }

    }
}
