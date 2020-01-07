
using Newtonsoft.Json;

namespace ObserverPattern01.Object
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }

        [JsonProperty("types")]
        public PokemonType[] Types { get; internal set; }
    }
}