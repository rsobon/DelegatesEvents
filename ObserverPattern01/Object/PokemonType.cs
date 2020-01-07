
using Newtonsoft.Json;

namespace ObserverPattern01.Object
{
    public class PokemonType
    {
        [JsonProperty("slot")]
        public int Slot { get; internal set; }

        [JsonProperty("type")]
        public PokemonTypeObject Type { get; internal set; }

    }
}