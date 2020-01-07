﻿
using Newtonsoft.Json;

namespace DelegatesEventsContainerTest03.Object
{
    public class Pokemon
    {
        [JsonProperty("id")]
        public int Id { get; internal set; }

        [JsonProperty("name")]
        public string Name { get; internal set; }
    }
}