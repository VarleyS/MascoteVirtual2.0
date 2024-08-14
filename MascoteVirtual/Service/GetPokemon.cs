using MascoteVirtual.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MascoteVirtual.Service
{
    public class GetPokemon
    {
        public async Task<List<PokemonResults>> GetPokemonRepository()
        {
            string apiUrl = "https://pokeapi.co/api/v2/pokemon/?offset=0&limit=20";

            List<PokemonResults> pokemons = await FetchPokemonData(apiUrl);

            return pokemons;
            
        }

        public static async Task<List<PokemonResults>> FetchPokemonData(string apiUrl)
        {
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();
                PokemonApiResponse apiResponse = JsonConvert.DeserializeObject<PokemonApiResponse>(responseBody);

                return apiResponse.Results;
            }
        }

        public async Task<PokemonSprites> GetSprites(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                string json = await client.GetStringAsync(url);
                PokemonModel pokemon = JsonConvert.DeserializeObject<PokemonModel>(json);

                if (pokemon?.Sprites?.front_default != null) 
                {
                    Console.WriteLine($"Front Default Sprite URL: {pokemon.Sprites.front_default}");
                }
                else
                {
                    Console.WriteLine("Sprites not found");
                }
                return pokemon.Sprites;
            }
        }

    }

}
