
using Newtonsoft.Json;

namespace ObserverPattern01.Object
{
    public class PokemonTypeObject
    {
        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}