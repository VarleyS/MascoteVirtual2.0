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
        public PokemonSprites Sprites { get; set; }
    }

    public class PokemonResults
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("sprites")]
        public List<PokemonSprites> sprites { get; set; }
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

        [JsonProperty("sprites")]
        public List<PokemonSprites> Sprites { get; set; }
    }

    public class PokemonSprites
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

    public class PokemonSpritesOther
    {
        [JsonProperty("dream_world")]
        public DreamWorldImage dream_world { get; set; }

        public class DreamWorldImage
        {
            [JsonProperty("front_default")]
            public string front_default { get; set; }
        }

        [JsonProperty("showdown")]
        public ShowdownImage showdown { get; set; }

        public class ShowdownImage
        {
            [JsonProperty("front_default")]
            public string front_default { get; set; }

            [JsonProperty("front_shiny")]
            public string front_shiny { get; set; }
        }

    }
}