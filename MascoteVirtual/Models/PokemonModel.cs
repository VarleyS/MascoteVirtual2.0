using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MascoteVirtual.Models
{
    public class PokemonModel
    {
        public Guid Id { get; protected set; }
        public string Nome { get; set; }
        public int Altura { get; set; }
        public int Peso { get; set; }
        public List<AbilityModel> Abilidades { get; set; }
    }

    public class PokemonResults
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class PokemonApiResponse
    {
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
        [JsonProperty("previous")]
        public string Previous { get; set; }
        [JsonProperty("results")]
        public List<PokemonResults> Results { get; set; }
    }
}
